// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace Nethermind.GmpBindings;

public static unsafe partial class Gmp
{
    private const string LibraryName = "gmp";

    static Gmp()
    {
        AssemblyLoadContext.Default.ResolvingUnmanagedDll += OnResolvingUnmanagedDll;

        var handle = NativeLibrary.Load(LibraryName, typeof(Gmp).Assembly, default);

        version = Marshal.PtrToStringUTF8(
            Marshal.ReadIntPtr(NativeLibrary.GetExport(handle, "__gmp_version"))
            ) ?? string.Empty;

        NativeLibrary.Free(handle);

        mp_get_memory_functions(out _allocate, out _reallocate, out _free);
    }

    private static nint OnResolvingUnmanagedDll(Assembly context, string name)
    {
        if (context != typeof(Gmp).Assembly || !LibraryName.Equals(name, StringComparison.Ordinal))
            return nint.Zero;

        string platform;

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            name = $"lib{name}.so";
            platform = "linux";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            name = $"lib{name}.dylib";
            platform = "osx";
        }
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            name = $"{name}.dll";
            platform = "win";
        }
        else
            throw new PlatformNotSupportedException();

        var arch = RuntimeInformation.ProcessArchitecture.ToString().ToLowerInvariant();

        return NativeLibrary.Load($"runtimes/{platform}-{arch}/native/{name}", context, DllImportSearchPath.AssemblyDirectory);
    }
}
