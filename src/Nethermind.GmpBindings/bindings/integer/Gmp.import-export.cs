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
    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Import-and-Export#index-mpz_005fimport">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_import")]
    public static partial void mpz_import(in mpz_t rop, nuint count, int order, nuint size, int endian, nuint nails, void* op);

    /// <summary>
    /// <see href="https://gmplib.org/manual/Integer-Import-and-Export#index-mpz_005fexport">See the GMP manual</see>
    /// </summary>
    [LibraryImport(LibraryName, EntryPoint = "__gmpz_export")]
    public static partial void* mpz_export(void* rop, out nuint countp, int order, nuint size, int endian, nuint nails, in mpz_t op);
}
