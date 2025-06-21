// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nethermind.GmpBindings.Tests;

public class AllocationTests : IDisposable
{
    private static int _counter;

    [Fact]
    public unsafe void Should_set_memory_functions()
    {
        Gmp.mp_set_memory_functions(&TestAlloc, &TestReAlloc, &TestFree);

        nint ptr = Gmp.allocate(128);
        Assert.Equal(1, _counter);

        ptr = Gmp.reallocate(ptr, 128, 256);
        Assert.Equal(2, _counter);

        Gmp.free(ptr, 256);
        Assert.Equal(3, _counter);

        // Restore defaults
        Gmp.mp_set_memory_functions(null, null, null);
    }

    [Fact]
    public unsafe void Should_get_memory_functions()
    {
        Gmp.mp_get_memory_functions(
            out delegate* unmanaged[Cdecl]<nuint, nint> alloc,
            out delegate* unmanaged[Cdecl]<nint, nuint, nuint, nint> realloc,
            out delegate* unmanaged[Cdecl]<nint, nuint, void> free);

        Assert.True(alloc is not null);
        Assert.True(realloc is not null);
        Assert.True(free is not null);

        nint ptr = Gmp.allocate(128);
        Assert.NotEqual(nint.Zero, ptr);

        ptr = Gmp.reallocate(ptr, 128, 256);
        Assert.NotEqual(nint.Zero, ptr);

        Gmp.free(ptr, 256);
    }

    public void Dispose() => _counter = default;

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static nint TestAlloc(nuint size)
    {
        _counter++;

        return Marshal.AllocHGlobal((nint)size);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static nint TestReAlloc(nint ptr, nuint _, nuint newSize)
    {
        _counter++;

        return Marshal.ReAllocHGlobal(ptr, (nint)newSize);
    }

    [UnmanagedCallersOnly(CallConvs = [typeof(CallConvCdecl)])]
    private static void TestFree(nint ptr, nuint _)
    {
        _counter++;

        Marshal.FreeHGlobal(ptr);
    }
}
