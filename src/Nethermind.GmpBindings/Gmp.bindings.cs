// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

#pragma warning disable IDE1006 // Naming rules

using System.Runtime.InteropServices;

namespace Nethermind.GmpBindings;

/// <summary>
/// Represents the functions of the GMP library.
/// </summary>
public static unsafe partial class Gmp
{
    #region Macros and Constants

    /// <summary>
    /// <see href="https://gmplib.org/manual/Useful-Macros-and-Constants#index-gmp_005fversion">See the GMP manual</see>
    /// </summary>
    public static readonly string version;

    #endregion

    #region Integer Functions

    #region Initialization Functions

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

    #endregion

    #region Assignment Functions

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

    #endregion

    #region Combined Initialization and Assignment Functions

    /// <summary>
    /// <see href="https://gmplib.org/manual/Simultaneous-Integer-Init-_0026-Assign#index-mpz_005finit_005fset">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_init_set")]
    public static partial void mpz_init_set(in mpz_t rop, in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Simultaneous-Integer-Init-_0026-Assign#index-mpz_005finit_005fset_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_init_set_ui")]
    public static partial void mpz_init_set_ui(in mpz_t rop, nuint op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Simultaneous-Integer-Init-_0026-Assign#index-mpz_005finit_005fset_005fsi">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_init_set_si")]
    public static partial void mpz_init_set_si(in mpz_t rop, nint op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Simultaneous-Integer-Init-_0026-Assign#index-mpz_005finit_005fset_005fd">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_init_set_d")]
    public static partial void mpz_init_set_d(in mpz_t rop, double op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Simultaneous-Integer-Init-_0026-Assign#index-mpz_005finit_005fset_005fstr">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_init_set_str")]
    public static partial int mpz_init_set_str(in mpz_t rop, nint str, int @base);

    #endregion

    #region Conversion Functions

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

    #endregion

    #region Arithmetic Functions

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

    #endregion

    #region Division Functions

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcdiv_005fq">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cdiv_q")]
    public static partial void mpz_cdiv_q(in mpz_t q, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcdiv_005fr">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cdiv_r")]
    public static partial void mpz_cdiv_r(in mpz_t q, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcdiv_005fqr">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cdiv_qr")]
    public static partial void mpz_cdiv_qr(in mpz_t q, in mpz_t r, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcdiv_005fq_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cdiv_q_ui")]
    public static partial nuint mpz_cdiv_q_ui(in mpz_t q, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcdiv_005fr_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cdiv_r_ui")]
    public static partial nuint mpz_cdiv_r_ui(in mpz_t q, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcdiv_005fqr_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cdiv_qr_ui")]
    public static partial nuint mpz_cdiv_qr_ui(in mpz_t q, in mpz_t r, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcdiv_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cdiv_ui")]
    public static partial nuint mpz_cdiv_ui(in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcdiv_005fq_005f2exp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cdiv_q_2exp")]
    public static partial void mpz_cdiv_q_2exp(in mpz_t q, in mpz_t n, nuint b);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcdiv_005fr_005f2exp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cdiv_r_2exp")]
    public static partial void mpz_cdiv_r_2exp(in mpz_t r, in mpz_t n, nuint b);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ffdiv_005fq">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fdiv_q")]
    public static partial void mpz_fdiv_q(in mpz_t q, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ffdiv_005fr">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fdiv_r")]
    public static partial void mpz_fdiv_r(in mpz_t q, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ffdiv_005fqr">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fdiv_qr")]
    public static partial void mpz_fdiv_qr(in mpz_t q, in mpz_t r, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ffdiv_005fq_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fdiv_q_ui")]
    public static partial nuint mpz_fdiv_q_ui(in mpz_t q, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ffdiv_005fr_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fdiv_r_ui")]
    public static partial nuint mpz_fdiv_r_ui(in mpz_t q, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ffdiv_005fqr_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fdiv_qr_ui")]
    public static partial nuint mpz_fdiv_qr_ui(in mpz_t q, in mpz_t r, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ffdiv_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fdiv_ui")]
    public static partial nuint mpz_fdiv_ui(in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ffdiv_005fq_005f2exp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fdiv_q_2exp")]
    public static partial void mpz_fdiv_q_2exp(in mpz_t q, in mpz_t n, nuint b);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ffdiv_005fr_005f2exp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_fdiv_r_2exp")]
    public static partial void mpz_fdiv_r_2exp(in mpz_t r, in mpz_t n, nuint b);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ftdiv_005fq">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_tdiv_q")]
    public static partial void mpz_tdiv_q(in mpz_t q, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ftdiv_005fr">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_tdiv_r")]
    public static partial void mpz_tdiv_r(in mpz_t q, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ftdiv_005fqr">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_tdiv_qr")]
    public static partial void mpz_tdiv_qr(in mpz_t q, in mpz_t r, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ftdiv_005fq_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_tdiv_q_ui")]
    public static partial nuint mpz_tdiv_q_ui(in mpz_t q, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ftdiv_005fr_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_tdiv_r_ui")]
    public static partial nuint mpz_tdiv_r_ui(in mpz_t q, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ftdiv_005fqr_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_tdiv_qr_ui")]
    public static partial nuint mpz_tdiv_qr_ui(in mpz_t q, in mpz_t r, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ftdiv_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_tdiv_ui")]
    public static partial nuint mpz_tdiv_ui(in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ftdiv_005fq_005f2exp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_tdiv_q_2exp")]
    public static partial void mpz_tdiv_q_2exp(in mpz_t q, in mpz_t n, nuint b);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005ftdiv_005fr_005f2exp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_tdiv_r_2exp")]
    public static partial void mpz_tdiv_r_2exp(in mpz_t r, in mpz_t n, nuint b);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fmod">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_mod")]
    public static partial void mpz_mod(in mpz_t r, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fmod_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_mod_ui")]
    public static partial void mpz_mod_ui(in mpz_t r, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fdivexact">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_divexact")]
    public static partial void mpz_divexact(in mpz_t q, in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fdivexact_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_divexact_ui")]
    public static partial void mpz_divexact_ui(in mpz_t q, in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fdivisible_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_divisible_p")]
    public static partial int mpz_divisible_p(in mpz_t n, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fdivisible_005fui_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_divisible_ui_p")]
    public static partial int mpz_divisible_ui_p(in mpz_t n, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fdivisible_005f2exp_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_divisible_2exp_p")]
    public static partial int mpz_divisible_2exp_p(in mpz_t n, nuint b);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcongruent_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_congruent_p")]
    public static partial int mpz_congruent_p(in mpz_t n, in mpz_t c, in mpz_t d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcongruent_005fui_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_congruent_ui_p")]
    public static partial int mpz_congruent_ui_p(in mpz_t n, nuint c, nuint d);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fcongruent_005f2exp_005fp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_congruent_2exp_p")]
    public static partial int mpz_congruent_2exp_p(in mpz_t n, in mpz_t c, nuint b);

    #endregion

    #region Exponentiation Functions

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

    #endregion

    #region Import/Export Functions

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Import-and-Export#index-mpz_005fimport">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_import")]
    public static partial void mpz_import(in mpz_t rop, nuint count, int order, nuint size, int endian, nuint nails, nint op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Import-and-Export#index-mpz_005fexport">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_export")]
    public static partial nint mpz_export(nint rop, out nuint countp, int order, nuint size, int endian, nuint nails, in mpz_t op);

    #endregion

    #region Comparison Functions

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

    #endregion

    #region Logical and Bit Manipulation Functions

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

    #endregion

    #region Miscellaneous Functions

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

    #endregion

    #endregion

    #region Custom Allocation

    private static delegate* unmanaged[Cdecl]<nuint, nint> _alloc;
    private static delegate* unmanaged[Cdecl]<nint, nuint, nuint, nint> _realloc;
    private static delegate* unmanaged[Cdecl]<nint, nuint, void> _free;

    /// <summary>
    /// <see href="https://gmplib.org/manual/Custom-Allocation#index-allocate_005ffunction">See the GMP manual</see>
    /// </summary>
    public static nint alloc(nuint alloc_size) => _alloc(alloc_size);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Custom-Allocation#index-reallocate_005ffunction">See the GMP manual</see>
    /// </summary>
    public static nint realloc(nint ptr, nuint old_size, nuint new_size) => _realloc(ptr, old_size, new_size);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Custom-Allocation#index-free_005ffunction">See the GMP manual</see>
    /// </summary>
    public static void free(nint ptr, nuint size) => _free(ptr, size);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Custom-Allocation#index-mp_005fset_005fmemory_005ffunctions">See the GMP manual</see>
    /// </summary>
    public static void mp_set_memory_functions(
        delegate* unmanaged[Cdecl]<nuint, nint> alloc,
        delegate* unmanaged[Cdecl]<nint, nuint, nuint, nint> realloc,
        delegate* unmanaged[Cdecl]<nint, nuint, void> free)
    {
        __gmp_set_memory_functions(alloc, realloc, free);
        mp_get_memory_functions(out _alloc, out _realloc, out _free);
    }

    [LibraryImport(LibraryName)]
    private static partial void __gmp_set_memory_functions(
        delegate* unmanaged[Cdecl]<nuint, nint> alloc,
        delegate* unmanaged[Cdecl]<nint, nuint, nuint, nint> realloc,
        delegate* unmanaged[Cdecl]<nint, nuint, void> free);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Custom-Allocation#index-mp_005fget_005fmemory_005ffunctions">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmp_get_memory_functions")]
    public static partial void mp_get_memory_functions(
        out delegate* unmanaged[Cdecl]<nuint, nint> alloc,
        out delegate* unmanaged[Cdecl]<nint, nuint, nuint, nint> realloc,
        out delegate* unmanaged[Cdecl]<nint, nuint, void> free);

    #endregion
}
