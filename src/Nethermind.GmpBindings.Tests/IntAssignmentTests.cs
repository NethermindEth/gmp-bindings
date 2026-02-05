// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;
using System.Text;

namespace Nethermind.GmpBindings.Tests;

public class IntAssignmentTests
{
    [Test]
    public async Task Should_set_from_mpz_t()
    {
        int result;
        {
            using var x = mpz_t.Create(1024);
            using mpz_t y = default;

            Gmp.mpz_set(y, x);

            result = Gmp.mpz_cmp(x, y);
        }

        await Assert.That(result).IsEqualTo(0);
    }

    [Test]
    public async Task Should_set_from_nuint()
    {
        int result;

        {
            var value = 1024U;
            using mpz_t x = default;

            Gmp.mpz_set_ui(x, value);

            result = Gmp.mpz_cmp_ui(x, value);
        }

        await Assert.That(result).IsEqualTo(0);
    }

    [Test]
    public async Task Should_set_from_nint()
    {
        int result;

        {
            var value = 1024;
            using mpz_t x = default;

            Gmp.mpz_set_si(x, value);

            result = Gmp.mpz_cmp_si(x, value);
        }

        await Assert.That(result).IsEqualTo(0);
    }

    [Test]
    public async Task Should_set_from_double()
    {
        int result;

        {
            var value = 1024D;
            using mpz_t x = default;

            Gmp.mpz_set_d(x, value);

            result = Gmp.mpz_cmp_d(x, value);
        }
        
        await Assert.That(result).IsEqualTo(0);
    }

    [Test]
    public async Task Should_set_from_string()
    {
        int status;
        int result;

        unsafe
        {
            var value = "0x1000";
            using mpz_t x = default;

            fixed (byte* str = &MemoryMarshal.GetArrayDataReference(Encoding.UTF8.GetBytes(value)))
                status = Gmp.mpz_set_str(x, (nint)str, 0);

            result = Gmp.mpz_cmp_si(x, Convert.ToInt32(value, 16));
        }

        await Assert.That(status).IsEqualTo(0);
        await Assert.That(result).IsEqualTo(0);
    }

    [Test]
    public async Task Should_swap()
    {
        int resultX;
        int resultY;

        {
            using var x = mpz_t.Create(1024);
            using var y = mpz_t.Create(-1024);

            Gmp.mpz_swap(x, y);

            resultX = Gmp.mpz_cmp_si(x, -1024);
            resultY = Gmp.mpz_cmp_si(y, 1024);
        }

        await Assert.That(resultX).IsEqualTo(0);
        await Assert.That(resultY).IsEqualTo(0);
    }
}
