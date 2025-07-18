// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;
using System.Text;

namespace Nethermind.GmpBindings.Tests;

public class IntAssignmentTests
{
    [Fact]
    public void Should_set_from_mpz_t()
    {
        using var x = mpz_t.Create(1024);
        using mpz_t y = default;

        Gmp.mpz_set(y, x);

        Assert.Equal(0, Gmp.mpz_cmp(x, y));
    }

    [Fact]
    public void Should_set_from_nuint()
    {
        var value = 1024U;
        using mpz_t x = default;

        Gmp.mpz_set_ui(x, value);

        Assert.Equal(0, Gmp.mpz_cmp_ui(x, value));
    }

    [Fact]
    public void Should_set_from_nint()
    {
        var value = 1024;
        using mpz_t x = default;

        Gmp.mpz_set_si(x, value);

        Assert.Equal(0, Gmp.mpz_cmp_si(x, value));
    }

    [Fact]
    public void Should_set_from_double()
    {
        var value = 1024D;
        using mpz_t x = default;

        Gmp.mpz_set_d(x, value);

        Assert.Equal(0, Gmp.mpz_cmp_d(x, value));
    }

    [Fact]
    public unsafe void Should_set_from_string()
    {
        var value = "0x1000";
        using mpz_t x = default;

        fixed (byte* str = &MemoryMarshal.GetArrayDataReference(Encoding.UTF8.GetBytes(value)))
        {
            var status = Gmp.mpz_set_str(x, (nint)str, 0);
            Assert.Equal(0, status);
        }

        Assert.Equal(0, Gmp.mpz_cmp_si(x, Convert.ToInt32(value, 16)));
    }

    [Fact]
    public unsafe void Should_swap()
    {
        using var x = mpz_t.Create(1024);
        using var y = mpz_t.Create(-1024);

        Gmp.mpz_swap(x, y);

        Assert.Equal(0, Gmp.mpz_cmp_si(x, -1024));
        Assert.Equal(0, Gmp.mpz_cmp_si(y, 1024));
    }
}
