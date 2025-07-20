// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace Nethermind.GmpBindings.Tests;

public class ImportExportTests
{
    [Theory]
    [InlineData("0400")]
    [InlineData("010203040506070809000a0b0c0d0e0f")]
    public unsafe void Should_export_from_mpz_t(string value)
    {
        using var x = mpz_t.Create(value, 16);
        Span<byte> data = stackalloc byte[value.Length / 2];

        fixed (byte* ptr = &MemoryMarshal.GetReference(data))
        {
            Gmp.mpz_export((nint)ptr, out var count, 1, 1, 1, nuint.Zero, x);

            Assert.Equal(data.Length, (int)count);
        }

        Assert.Equal(value, Convert.ToHexStringLower(data));
    }

    [Theory]
    [InlineData("0400")]
    [InlineData("010203040506070809000a0b0c0d0e0f")]
    public unsafe void Should_import_to_mpz_t(string value)
    {
        Span<byte> import = Convert.FromHexString(value);
        using var x = mpz_t.Create();

        fixed (byte* ptr = &MemoryMarshal.GetReference(import))
            Gmp.mpz_import(x, (nuint)import.Length, 1, 1, 1, nuint.Zero, (nint)ptr);

        using GmpHandle str = new(Gmp.mpz_get_str(nint.Zero, 16, x));
        var actualValue = Marshal.PtrToStringUTF8(str.DangerousGetHandle());

        Assert.Equal(value, actualValue?.PadLeft(value.Length, '0'));
    }
}
