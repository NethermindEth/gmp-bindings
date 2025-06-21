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
    /// <see href="https://gmplib.org/manual/Initializing-Integers#index-mpz_005fclear">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_clear")]
    public static partial void mpz_clear(in mpz_t x);

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
    public static partial void mpz_set_ui(in mpz_t rop, ulong op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Assigning-Integers#index-mpz_005fset_005fsi">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_set_si")]
    public static partial void mpz_set_si(in mpz_t rop, long op);

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
    public static partial void mpz_init_set_ui(in mpz_t rop, ulong op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Simultaneous-Integer-Init-_0026-Assign#index-mpz_005finit_005fset_005fsi">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_init_set_si")]
    public static partial void mpz_init_set_si(in mpz_t rop, long op);

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
    public static partial ulong mpz_get_ui(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Converting-Integers#index-mpz_005fget_005fsi">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_get_si")]
    public static partial long mpz_get_si(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Converting-Integers#index-mpz_005fget_005fd">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_get_d")]
    public static partial double mpz_get_d(in mpz_t op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Converting-Integers#index-mpz_005fget_005fd_005f2exp">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_get_d_2exp")]
    public static partial double mpz_get_d_2exp(out long exp, in mpz_t op);

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
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fmul">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_mul")]
    public static partial void mpz_mul(in mpz_t rop, in mpz_t op1, in mpz_t op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Arithmetic#index-mpz_005fabs">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_abs")]
    public static partial void mpz_abs(in mpz_t rop, in mpz_t op);

    #endregion

    #region Division Functions

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Division#index-mpz_005fmod">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_mod")]
    public static partial void mpz_mod(in mpz_t r, in mpz_t n, in mpz_t d);

    #endregion

    #region Exponentiation Functions

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Exponentiation#index-mpz_005fpowm">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_powm")]
    public static partial void mpz_powm(in mpz_t rop, in mpz_t @base, in mpz_t exp, in mpz_t mod);

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
    public static partial int mpz_cmp_si(in mpz_t op1, long op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Comparisons#index-mpz_005fcmp_005fui">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_cmp_ui")]
    public static partial int mpz_cmp_ui(in mpz_t op1, ulong op2);

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
    public static partial int mpz_cmpabs_ui(in mpz_t op1, ulong op2);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Comparisons#index-mpz_005fsgn">See the GMP manual</see>
    /// </summary>
    public static int mpz_sgn(in mpz_t op) => op._mp_size < 0 ? -1 : op._mp_size > 0 ? 1 : 0;

    #endregion

    #region Miscellaneous Functions

    /// <summary>
    /// <see href="https://gmplib.org/manual/Miscellaneous-Integer-Functions#index-mpz_005fsizeinbase">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_sizeinbase")]
    public static partial nuint mpz_sizeinbase(in mpz_t op, int @base);

    #endregion

    #endregion

    #region Custom Allocation

    private static delegate* unmanaged[Cdecl]<nuint, nint> _allocate;
    private static delegate* unmanaged[Cdecl]<nint, nuint, nuint, nint> _reallocate;
    private static delegate* unmanaged[Cdecl]<nint, nuint, void> _free;

    /// <summary>
    /// <see href="https://gmplib.org/manual/Custom-Allocation#index-allocate_005ffunction">See the GMP manual</see>
    /// </summary>
    public static nint allocate(nuint alloc_size) => _allocate(alloc_size);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Custom-Allocation#index-reallocate_005ffunction">See the GMP manual</see>
    /// </summary>
    public static nint reallocate(nint ptr, nuint old_size, nuint new_size) => _reallocate(ptr, old_size, new_size);

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
        mp_get_memory_functions(out _allocate, out _reallocate, out _free);
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
