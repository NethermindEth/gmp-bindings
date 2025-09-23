// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Nethermind.GmpBindings.Tests;

public class AllocationTests
{
    private static int _counter;

    [Test]
    public async Task Should_set_memory_functions()
    {
        unsafe { Gmp.mp_set_memory_functions(&TestAlloc, &TestReAlloc, &TestFree); }

        nint ptr = Gmp.alloc(128);
        await Assert.That(_counter).IsEqualTo(1);

        ptr = Gmp.realloc(ptr, 128, 256);
        await Assert.That(_counter).IsEqualTo(2);

        Gmp.free(ptr, 256);
        await Assert.That(_counter).IsEqualTo(3);

        // Restore defaults
        unsafe { Gmp.mp_set_memory_functions(null, null, null); }
    }

    [Test]
    public async Task Should_get_memory_functions()
    {
        bool hasAlloc;
        bool hasRealloc;
        bool hasFree;

        unsafe
        {
            Gmp.mp_get_memory_functions(
                out delegate* unmanaged[Cdecl]<nuint, nint> alloc,
                out delegate* unmanaged[Cdecl]<nint, nuint, nuint, nint> realloc,
                out delegate* unmanaged[Cdecl]<nint, nuint, void> free);

            hasAlloc = alloc is not null;
            hasRealloc = realloc is not null;
            hasFree = free is not null;
        }

        await Assert.That(hasAlloc).IsTrue();
        await Assert.That(hasRealloc).IsTrue();
        await Assert.That(hasFree).IsTrue();

        nint ptr = Gmp.alloc(128);
        await Assert.That(ptr).IsNotEqualTo(nint.Zero);

        ptr = Gmp.realloc(ptr, 128, 256);
        await Assert.That(ptr).IsNotEqualTo(nint.Zero);

        Gmp.free(ptr, 256);
    }

    [After(Class)]
    public static void Reset() => _counter = default;

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
