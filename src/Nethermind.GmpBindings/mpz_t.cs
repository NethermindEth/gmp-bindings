// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

#pragma warning disable IDE1006 // Naming rules

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Nethermind.GmpBindings;

/// <summary>
/// Represents a multiple precision integer type.
/// <see href="https://gmplib.org/manual/Nomenclature-and-Types#index-mpz_005ft">See the GMP manual</see>.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly ref struct mpz_t
{
    internal readonly int _mp_alloc;
    internal readonly int _mp_size;
    internal readonly nint _mp_d;

    #region Initialization

    /// <summary>
    /// Initializes a new instance of the <see cref="mpz_t"/> struct
    /// using the <see cref="Gmp.mpz_init"/> method.
    /// </summary>
    public static mpz_t Create()
    {
        Unsafe.SkipInit(out mpz_t x);
        Gmp.mpz_init(x);

        return x;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="mpz_t"/> struct with the specified value
    /// using the <see cref="Gmp.mpz_init_set"/> method.
    /// </summary>
    public static mpz_t Create(in mpz_t value)
    {
        Unsafe.SkipInit(out mpz_t x);
        Gmp.mpz_init_set(x, value);

        return x;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="mpz_t"/> struct with the specified value
    /// using the <see cref="Gmp.mpz_init_set_ui"/> method.
    /// </summary>
    public static mpz_t Create(nuint value)
    {
        Unsafe.SkipInit(out mpz_t x);
        Gmp.mpz_init_set_ui(x, value);

        return x;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="mpz_t"/> struct with the specified value
    /// using the <see cref="Gmp.mpz_init_set_si"/> method.
    /// </summary>
    public static mpz_t Create(nint value)
    {
        Unsafe.SkipInit(out mpz_t x);
        Gmp.mpz_init_set_si(x, value);

        return x;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="mpz_t"/> struct with the specified value
    /// using the <see cref="Gmp.mpz_init_set_d"/> method.
    /// </summary>
    public static mpz_t Create(double value)
    {
        Unsafe.SkipInit(out mpz_t x);
        Gmp.mpz_init_set_d(x, value);

        return x;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="mpz_t"/> struct with the specified value and base
    /// using the <see cref="Gmp.mpz_init_set_str"/> method.
    /// </summary>
    /// <param name="value">
    /// A string in base <c>base</c>.
    /// White space is allowed in the string, and is simply ignored.
    /// </param>
    /// <param name="base">
    /// The base may vary from 2 to 62, or if base is 0, then the leading characters are used:
    /// 0x and 0X for hexadecimal, 0b and 0B for binary, 0 for octal, or decimal otherwise.
    /// For bases up to 36, case is ignored; upper-case and lower-case letters have the same value.
    /// For bases 37 to 62, upper-case letters represent the usual 10..35 while lower-case letters represent 36..61.
    /// </param>
    /// <exception cref="ArgumentNullException">
    /// <c>value</c> is <c>null</c>.
    /// </exception>
    /// <exception cref="ArgumentException">
    /// <c>value</c> is an empty string or an incorrect base <c>base</c>.
    /// </exception>
    public static unsafe mpz_t Create(string value, int @base = 0)
    {
        ArgumentException.ThrowIfNullOrEmpty(value);

        fixed (byte* str = Encoding.UTF8.GetBytes(value))
        {
            Unsafe.SkipInit(out mpz_t x);

            if (Gmp.mpz_init_set_str(x, (nint)str, @base) == 0)
                return x;

            Gmp.mpz_clear(x);

            throw new ArgumentException("Value is an incorrect base.", nameof(value));
        }
    }

    #endregion

    #region Cleanup

    /// <summary>
    /// Frees the memory occupied by this instance using the <see cref="Gmp.mpz_clear"/> method.
    /// </summary>
    public readonly void Dispose() => Gmp.mpz_clear(this);

    #endregion
}
