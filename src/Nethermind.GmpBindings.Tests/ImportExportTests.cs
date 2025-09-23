// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace Nethermind.GmpBindings.Tests;

[DependsOn<AllocationTests>]
public class ImportExportTests
{
    [Test]
    [Arguments("0400")]
    [Arguments("010203040506070809000a0b0c0d0e0f")]
    public async Task Should_export_from_mpz_t(string value)
    {
        nuint count;
        int dataLength = value.Length / 2;
        string dataHex;

        unsafe
        {
            using var x = mpz_t.Create(value, 16);
            Span<byte> data = stackalloc byte[value.Length / 2];

            fixed (byte* ptr = &MemoryMarshal.GetReference(data))
                Gmp.mpz_export((nint)ptr, out count, 1, 1, 1, nuint.Zero, x);

            dataHex = Convert.ToHexStringLower(data);
        }

        await Assert.That((int)count).IsEqualTo(dataLength);
        await Assert.That(value).IsEqualTo(dataHex);
    }

    [Test]
    [Arguments("0400")]
    [Arguments("010203040506070809000a0b0c0d0e0f")]
    public async Task Should_import_to_mpz_t(string value)
    {
        string? actualValue;

        unsafe
        {
            Span<byte> import = Convert.FromHexString(value);
            using var x = mpz_t.Create();

            fixed (byte* ptr = &MemoryMarshal.GetReference(import))
                Gmp.mpz_import(x, (nuint)import.Length, 1, 1, 1, nuint.Zero, (nint)ptr);

            using GmpHandle str = new(Gmp.mpz_get_str(nint.Zero, 16, x));

            actualValue = Marshal.PtrToStringUTF8(str.DangerousGetHandle());
        }

        await Assert.That(actualValue?.PadLeft(value.Length, '0')).IsEqualTo(value);
    }
}
