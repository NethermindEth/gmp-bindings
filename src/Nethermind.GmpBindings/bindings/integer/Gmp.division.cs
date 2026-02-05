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
}
