// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

#pragma warning disable IDE1006 // Naming Styles

using System.Runtime.InteropServices;

namespace Nethermind.GmpBindings;

/// <summary>
/// Represents the functions of the GMP library.
/// </summary>
public static partial class Gmp
{
    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Exponentiation#index-mpz_005fpowm">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_powm")]
    public static partial void mpz_powm(in mpz_t rop, in mpz_t @base, in mpz_t exp, in mpz_t mod);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Exponentiation#index-mpz_005fpowm_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_powm_ui")]
    public static partial void mpz_powm_ui(in mpz_t rop, in mpz_t @base, nuint exp, in mpz_t mod);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Exponentiation#index-mpz_005fpowm_005fsec">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_powm_sec")]
    public static partial void mpz_powm_sec(in mpz_t rop, in mpz_t @base, in mpz_t exp, in mpz_t mod);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Exponentiation#index-mpz_005fpow_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_pow_ui")]
    public static partial void mpz_pow_ui(in mpz_t rop, in mpz_t @base, nuint exp);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Exponentiation#index-mpz_005fui_005fpow_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_ui_pow_ui")]
    public static partial void mpz_ui_pow_ui(in mpz_t rop, nuint @base, nuint exp);
}
