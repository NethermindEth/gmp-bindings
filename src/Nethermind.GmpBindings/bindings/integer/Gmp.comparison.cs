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
    /// <see href="https://gmplib.org/manual/Integer-Comparisons#index-mpz_005fcmp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cmp")]
    public static partial int mpz_cmp(in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Comparisons#index-mpz_005fcmp_005fd">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cmp_d")]
    public static partial int mpz_cmp_d(in mpz_t op1, double op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Comparisons#index-mpz_005fcmp_005fsi">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cmp_si")]
    public static partial int mpz_cmp_si(in mpz_t op1, nint op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Comparisons#index-mpz_005fcmp_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cmp_ui")]
    public static partial int mpz_cmp_ui(in mpz_t op1, nuint op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Comparisons#index-mpz_005fcmpabs">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cmpabs")]
    public static partial int mpz_cmpabs(in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Comparisons#index-mpz_005fcmpabs_005fd">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cmpabs_d")]
    public static partial int mpz_cmpabs_d(in mpz_t op1, double op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Comparisons#index-mpz_005fcmp_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cmpabs_ui")]
    public static partial int mpz_cmpabs_ui(in mpz_t op1, nuint op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Comparisons#index-mpz_005fsgn">See the GMP manual</see>
    /// </summary>
    public static int mpz_sgn(in mpz_t op) => op._mp_size < 0 ? -1 : op._mp_size > 0 ? 1 : 0;
}
