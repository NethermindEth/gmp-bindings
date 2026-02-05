// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

#pragma warning disable IDE1006 // Naming Styles

using System.Runtime.InteropServices;

namespace Nethermind.GmpBindings;

/// <summary>
/// Represents the functions of the GMP library.
/// </summary>
public static unsafe partial class Gmp
{
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
}
