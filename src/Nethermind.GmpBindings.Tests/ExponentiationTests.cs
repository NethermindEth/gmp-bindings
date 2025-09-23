// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

namespace Nethermind.GmpBindings.Tests;

[DependsOn<AllocationTests>]
public class ExponentiationTests
{
    [Test]
    [Arguments(2, 256, 997, 668)]
    [Arguments(7, 47, 1023, 886)]
    public async Task Should_do_powm(int @base, int exp, int mod, int result)
    {
        nint outcome;

        {
            using var b = mpz_t.Create(@base);
            using var e = mpz_t.Create(exp);
            using var m = mpz_t.Create(mod);
            using var r = mpz_t.Create();

            Gmp.mpz_powm(r, b, e, m);
            outcome = Gmp.mpz_get_si(r);
        }

        await Assert.That(outcome).IsEqualTo(result);
    }

    // TODO: More tests
}
