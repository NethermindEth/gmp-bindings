// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

namespace Nethermind.GmpBindings.Tests;

public class BasicTests
{
    [Test]
    public async Task Should_match_version() => await Assert.That(Gmp.version).IsEqualTo("6.3.0");

    [Test]
    public async Task Should_initialize()
    {
        await Assert.That(static () =>
        {
            using var x = mpz_t.Create();
        }).ThrowsNothing();
    }

    [Test]
    public async Task Should_initialize_from_mpz_t()
    {
        int result;

        {
            using var x = mpz_t.Create("1024");
            using var y = mpz_t.Create(x);
            result = Gmp.mpz_cmp(x, y);
        }

        await Assert.That(result).IsEqualTo(0);
    }

    [Test]
    public async Task Should_initialize_from_nuint()
    {
        int result;

        {
            var value = 1024U;
            using var x = mpz_t.Create(value);
            result = Gmp.mpz_cmp_ui(x, value);
        }

        await Assert.That(result).IsEqualTo(0);
    }

    [Test]
    public async Task Should_initialize_from_nint()
    {
        int result;

        {
            var value = 1024;
            using var x = mpz_t.Create(value);
            result = Gmp.mpz_cmp_si(x, value);
        }

        await Assert.That(result).IsEqualTo(0);
    }

    [Test]
    public async Task Should_initialize_from_double()
    {
        int result;

        {
            using var x = mpz_t.Create(double.MaxValue);
            result = Gmp.mpz_cmp_d(x, double.MaxValue);
        }

        await Assert.That(result).IsEqualTo(0);
    }

    [Test]
    [Arguments("0b01010101010101010101010101010101", 0)]
    [Arguments("1111222233334444555566667777888899990000", 0)]
    [Arguments("0x11223344556677889900aabbccddeeff", 0)]
    [Arguments("1100110011001100", 2)]
    [Arguments("-210120210", 3)]
    [Arguments("010203040506070809000a0b0c0d0e0f", 16)]
    public async Task Should_initialize_from_string(string value, int @base)
    {
        await Assert.That(() =>
        {
            using var x = mpz_t.Create(value, @base);
        }).ThrowsNothing();
    }

    [Test]
    public async Task Should_fail_on_init_if_null_value()
    {
        await Assert.That(static () =>
        {
            using var _ = mpz_t.Create(null!);
        }).Throws<ArgumentNullException>();
    }

    [Test]
    [Arguments("", 0)]
    [Arguments("1234567890", 1)]
    [Arguments("1234567890", 63)]
    [Arguments("1234567890x", 16)]
    public async Task Should_fail_on_init_if_invalid_value(string value, int @base)
    {
        await Assert
            .That(() =>
            {
                using var _ = mpz_t.Create(value, @base);
            })
            .Throws<ArgumentException>()
            .WithParameterName("value");
    }
}
