# GMP bindings

[![Tests](https://github.com/nethermindeth/gmp-bindings/actions/workflows/test-publish.yml/badge.svg)](https://github.com/nethermindeth/gmp-bindings/actions/workflows/test-publish.yml)
[![Nethermind.GmpBindings](https://img.shields.io/nuget/v/Nethermind.GmpBindings)](https://www.nuget.org/packages/Nethermind.GmpBindings)

C# bindings for the [GNU Multiple Precision](https://gmplib.org) (GMP) arithmetic library.

#### Note

- Not all GMP functions are currently bound — only a few are used by the Nethermind. If you need a specific function, please open an issue.
- To build the GMP, an unofficial GMP repository mirror is used, as access to the original one is inaccessible from GitHub.
