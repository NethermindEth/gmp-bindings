// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

using System.Runtime.InteropServices;

namespace Nethermind.GmpBindings;

/// <summary>
/// Provides a safe handle for GMP objects.
/// </summary>
/// <param name="handle">
/// An existing GMP pointer to use. Using <see cref="nint.Zero"/> invalidates the handle.
/// </param>
public class GmpHandle(nint handle) : SafeHandle(handle, true)
{
    /// <inheritdoc/>
    public override bool IsInvalid => handle == nint.Zero;

    /// <inheritdoc/>
    protected override bool ReleaseHandle()
    {
        if (IsInvalid)
            return false;

        Gmp.free(handle, nuint.Zero);

        return true;
    }
}
