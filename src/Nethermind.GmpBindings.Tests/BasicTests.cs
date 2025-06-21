// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

namespace Nethermind.GmpBindings.Tests;

public class BasicTests
{
    [Fact]
    public void Should_match_version() => Assert.Equal("6.3.0", Gmp.version);

    [Fact]
    public void Should_initialize()
    {
        Exception? ex = Record.Exception(static () =>
        {
            using var x = mpz_t.Create();
        });

        Assert.Null(ex);
    }

    [Fact]
    public void Should_initialize_from_mpz_t()
    {
        using var x = mpz_t.Create("1024");
        using var y = mpz_t.Create(x);

        Assert.Equal(0, Gmp.mpz_cmp(x, y));
    }

    [Fact]
    public void Should_initialize_from_nuint()
    {
        var value = 1024U;
        using var x = mpz_t.Create(value);

        Assert.Equal(0, Gmp.mpz_cmp_ui(x, value));
    }

    [Fact]
    public void Should_initialize_from_nint()
    {
        var value = 1024;
        using var x = mpz_t.Create(value);

        Assert.Equal(0, Gmp.mpz_cmp_si(x, value));
    }

    [Fact]
    public void Should_initialize_from_double()
    {
        using var x = mpz_t.Create(double.MaxValue);

        Assert.Equal(0, Gmp.mpz_cmp_d(x, double.MaxValue));
    }

    [Theory]
    [InlineData("0b01010101010101010101010101010101", 0)]
    [InlineData("1111222233334444555566667777888899990000", 0)]
    [InlineData("0x11223344556677889900aabbccddeeff", 0)]
    [InlineData("1100110011001100", 2)]
    [InlineData("-210120210", 3)]
    [InlineData("010203040506070809000a0b0c0d0e0f", 16)]
    public void Should_initialize_from_string(string value, int @base)
    {
        Exception? ex = Record.Exception(() =>
        {
            using var x = mpz_t.Create(value, @base);
        });

        Assert.Null(ex);
    }

    [Fact]
    public void Should_fail_on_init_if_null_value()
    {
        Assert.Throws<ArgumentNullException>(static () =>
        {
            using var _ = mpz_t.Create(null!);
        });
    }

    [Theory]
    [InlineData("", 0)]
    [InlineData("1234567890", 1)]
    [InlineData("1234567890", 63)]
    [InlineData("1234567890x", 16)]
    public void Should_fail_on_init_if_invalid_value(string value, int @base)
    {
        Assert.Throws<ArgumentException>("value", () =>
        {
            using var _ = mpz_t.Create(value, @base);
        });
    }
}
