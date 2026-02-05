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
    /// <see href="https://gmplib.org/manual/Miscellaneous-Integer-Functions#index-mpz_005ffits_005fulong_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fits_ulong_p")]
    public static partial int mpz_fits_ulong_p(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Miscellaneous-Integer-Functions#index-mpz_005ffits_005fslong_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fits_slong_p")]
    public static partial int mpz_fits_slong_p(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Miscellaneous-Integer-Functions#index-mpz_005ffits_005fuint_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fits_uint_p")]
    public static partial int mpz_fits_uint_p(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Miscellaneous-Integer-Functions#index-mpz_005ffits_005fsint_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fits_sint_p")]
    public static partial int mpz_fits_sint_p(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Miscellaneous-Integer-Functions#index-mpz_005ffits_005fushort_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fits_ushort_p")]
    public static partial int mpz_fits_ushort_p(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Miscellaneous-Integer-Functions#index-mpz_005ffits_005fsshort_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fits_sshort_p")]
    public static partial int mpz_fits_sshort_p(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Miscellaneous-Integer-Functions#index-mpz_005fodd_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_odd_p")]
    public static partial int mpz_odd_p(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Miscellaneous-Integer-Functions#index-mpz_005feven_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_even_p")]
    public static partial int mpz_even_p(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Miscellaneous-Integer-Functions#index-mpz_005fsizeinbase">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_sizeinbase")]
    public static partial nuint mpz_sizeinbase(in mpz_t op, int @base);
}
