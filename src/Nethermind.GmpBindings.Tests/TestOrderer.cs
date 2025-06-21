// SPDX-FileCopyrightText: 2025 Demerzel Solutions Limited
// SPDX-License-Identifier: MIT

using Nethermind.GmpBindings.Tests;
using Xunit.Internal;
using Xunit.Sdk;
using Xunit.v3;

[assembly: TestCollectionOrderer(typeof(TestOrderer))]

namespace Nethermind.GmpBindings.Tests;

public class TestOrderer : ITestCollectionOrderer
{
    public IReadOnlyCollection<TTestCollection> OrderTestCollections<TTestCollection>(
        IReadOnlyCollection<TTestCollection> testCollections) where TTestCollection : ITestCollection
    {
        // Order test collections to run the AllocationTests first, as it sets up memory functions
        return testCollections
            .OrderBy(c => c.TestCollectionDisplayName?.Equals(nameof(AllocationTests), StringComparison.Ordinal) == true ? 0 : 1)
            .CastOrToReadOnlyCollection();
    }
}
