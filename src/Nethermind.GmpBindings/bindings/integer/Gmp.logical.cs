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
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fand">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_and")]
    public static partial void mpz_and(in mpz_t rop, in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fior">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_ior")]
    public static partial void mpz_ior(in mpz_t rop, in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fxor">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_xor")]
    public static partial void mpz_xor(in mpz_t rop, in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fcom">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_com")]
    public static partial void mpz_com(in mpz_t rop, in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fpopcount">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_popcount")]
    public static partial nuint mpz_popcount(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fhamdist">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_hamdist")]
    public static partial nuint mpz_hamdist(in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fscan0">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_scan0")]
    public static partial nuint mpz_scan0(in mpz_t op, nuint starting_bit);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fscan1">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_scan1")]
    public static partial nuint mpz_scan1(in mpz_t op, nuint starting_bit);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fsetbit">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_setbit")]
    public static partial void mpz_setbit(in mpz_t rop, nuint bit_index);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fclrbit">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_clrbit")]
    public static partial void mpz_clrbit(in mpz_t rop, nuint bit_index);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005fcombit">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_combit")]
    public static partial void mpz_combit(in mpz_t rop, nuint bit_index);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Logic-and-Bit-Fiddling#index-mpz_005ftstbit">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_tstbit")]
    public static partial int mpz_tstbit(in mpz_t op, nuint bit_index);
}
