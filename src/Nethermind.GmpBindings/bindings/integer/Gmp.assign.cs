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
    /// <see href="https://gmplib.org/manual/Assigning-Integers#index-mpz_005fset">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_set")]
    public static partial void mpz_set(in mpz_t rop, in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Assigning-Integers#index-mpz_005fset_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_set_ui")]
    public static partial void mpz_set_ui(in mpz_t rop, nuint op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Assigning-Integers#index-mpz_005fset_005fsi">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_set_si")]
    public static partial void mpz_set_si(in mpz_t rop, nint op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Assigning-Integers#index-mpz_005fset_005fd">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_set_d")]
    public static partial void mpz_set_d(in mpz_t rop, double op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Assigning-Integers#index-mpz_005fset_005fstr">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_set_str")]
    public static partial int mpz_set_str(in mpz_t rop, nint str, int @base);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Assigning-Integers#index-mpz_005fswap">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_swap")]
    public static partial void mpz_swap(in mpz_t rop1, in mpz_t rop2);
}
