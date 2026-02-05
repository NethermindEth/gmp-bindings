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
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fadd">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_add")]
    public static partial void mpz_add(in mpz_t rop, in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fadd_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_add_ui")]
    public static partial void mpz_add_ui(in mpz_t rop, in mpz_t op1, nuint op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fsub">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_sub")]
    public static partial void mpz_sub(in mpz_t rop, in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fsub_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_sub")]
    public static partial void mpz_sub_ui(in mpz_t rop, in mpz_t op1, nuint op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fui_005fsub">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_sub")]
    public static partial void mpz_ui_sub(in mpz_t rop, nuint op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fmul">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_mul")]
    public static partial void mpz_mul(in mpz_t rop, in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fmul_005fsi">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_mul_si")]
    public static partial void mpz_mul_si(in mpz_t rop, in mpz_t op1, nint op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fmul_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_mul_ui")]
    public static partial void mpz_mul_ui(in mpz_t rop, in mpz_t op1, nuint op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005faddmul">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_addmul")]
    public static partial void mpz_addmul(in mpz_t rop, in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005faddmul_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_addmul_ui")]
    public static partial void mpz_addmul_ui(in mpz_t rop, in mpz_t op1, nuint op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fsubmul">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_submul")]
    public static partial void mpz_submul(in mpz_t rop, in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fsubmul_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_submul_ui")]
    public static partial void mpz_submul_ui(in mpz_t rop, in mpz_t op1, nuint op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fmul_005f2exp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_mul_2exp")]
    public static partial void mpz_mul_2exp(in mpz_t rop, in mpz_t op1, nuint op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fneg">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_neg")]
    public static partial void mpz_neg(in mpz_t rop, in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fabs">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_abs")]
    public static partial void mpz_abs(in mpz_t rop, in mpz_t op);
}
