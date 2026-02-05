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
    /// <see href="https://gmplib.org/manual/Initializing-Integers#index-mpz_005finit">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_init")]
    public static partial void mpz_init(in mpz_t x);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Initializing-Integers#index-mpz_005finit2">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_init2")]
    public static partial void mpz_init2(in mpz_t x, nuint n);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Initializing-Integers#index-mpz_005fclear">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_clear")]
    public static partial void mpz_clear(in mpz_t x);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Initializing-Integers#index-mpz_005fclear">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_realloc2")]
    public static partial void mpz_realloc2(in mpz_t x, nuint n);
}
