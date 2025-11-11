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
    /// <see href="https://gmplib.org/manual/Converting-Integers#index-mpz_005fget_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_get_ui")]
    public static partial nuint mpz_get_ui(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Converting-Integers#index-mpz_005fget_005fsi">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_get_si")]
    public static partial nint mpz_get_si(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Converting-Integers#index-mpz_005fget_005fd">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_get_d")]
    public static partial double mpz_get_d(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Converting-Integers#index-mpz_005fget_005fd_005f2exp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_get_d_2exp")]
    public static partial double mpz_get_d_2exp(out nint exp, in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Converting-Integers#index-mpz_005fget_005fstr">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_get_str")]
    public static partial nint mpz_get_str(nint str, int @base, in mpz_t op);
}
