// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

#pragma warning disable IDE1006 // Naming rules

using System.Runtime.InteropServices;
using System.Text;

namespace Nethermind.GmpBindings;

/// <summary>
/// Represents a multiple precision integer type.
/// <see href="https://gmplib.org/manual/Nomenclature-and-Types.html#index-mpz_005ft">See the GMP manual</see>.
/// </summary>
[StructLayout(LayoutKind.Sequential)]
public readonly ref struct mpz_t
{
    internal readonly int _mp_alloc;
    internal readonly int _mp_size;
    internal readonly nint _mp_d;

    /// <summary>
    /// Initializes a new instance of the <see cref="mpz_t"/> struct with the value of 0
    /// using the <see cref="Gmp.mpz_init"/> method.
    /// </summary>
    public mpz_t() => Gmp.mpz_init(this);

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
    /// <exception cref="ArgumentException">
    /// <c>value</c> is <c>null</c> or an empty string, or <c>base</c> is invalid.
    /// </exception>
    public unsafe mpz_t(string value, int @base = 0)
    {
        ArgumentException.ThrowIfNullOrEmpty(value);

        fixed (byte* ptr = Encoding.UTF8.GetBytes(value))
        {
            if (Gmp.mpz_init_set_str(this, (nint)ptr, @base) != 0)
                throw new ArgumentException($"{nameof(Gmp.mpz_init_set_str)} failed");
        }
    }

    /// <summary>
    /// Frees the memory occupied by this instance using the <see cref="Gmp.mpz_clear"/> method.
    /// </summary>
    public readonly void Dispose() => Gmp.mpz_clear(this);
}
