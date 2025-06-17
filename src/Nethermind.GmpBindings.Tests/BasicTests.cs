// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

namespace Nethermind.GmpBindings.Tests;

public class BasicTests
{
    [Fact]
    public void Should_match_version() => Assert.Equal("6.3.0", Gmp.version);
}
