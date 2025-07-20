// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

namespace Nethermind.GmpBindings.Tests;

public class ExponentiationTests
{
    [Theory]
    [InlineData(2, 256, 997, 668)]
    [InlineData(7, 47, 1023, 886)]
    public void Should_do_powm(int @base, int exp, int mod, int result)
    {
        using var b = mpz_t.Create(@base);
        using var e = mpz_t.Create(exp);
        using var m = mpz_t.Create(mod);
        using var r = mpz_t.Create();

        Gmp.mpz_powm(r, b, e, m);

        Assert.Equal(result, Gmp.mpz_get_si(r));
    }

    // TODO: More tests
}
