// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

namespace Nethermind.GmpBindings.Tests;

public class MiscTests
{
    [Theory]
    [InlineData("1024", 4)]
    [InlineData("0x010203040506070809000a0b0c0d0e0f", 37)]
    public void Should_return_size_in_base(string value, int size)
    {
        using var x = mpz_t.Create(value);

        Assert.Equal(size, (int)Gmp.mpz_sizeinbase(x, 10));
    }

    // TODO: More tests
}
