// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

namespace Nethermind.GmpBindings.Tests;

[DependsOn<AllocationTests>]
public class MiscTests
{
    [Test]
    [Arguments("1024", 4)]
    [Arguments("0x010203040506070809000a0b0c0d0e0f", 37)]
    public async Task Should_return_size_in_base(string value, int size)
    {
        int result;

        {
            using var x = mpz_t.Create(value);

            result = (int)Gmp.mpz_sizeinbase(x, 10);
        }

        await Assert.That(result).IsEqualTo(size);
    }

    // TODO: More tests
}
