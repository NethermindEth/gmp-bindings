# GMP bindings

[![Tests](https://github.com/nethermindeth/gmp-bindings/actions/workflows/test-publish.yml/badge.svg)](https://github.com/nethermindeth/gmp-bindings/actions/workflows/test-publish.yml)
[![Nethermind.GmpBindings](https://img.shields.io/nuget/v/Nethermind.GmpBindings)](https://www.nuget.org/packages/Nethermind.GmpBindings)

C# bindings for the [GNU Multiple Precision](https://gmplib.org) (GMP) arithmetic library.

#### Note

- Not all GMP functions are currently bound — only a subset of integer functions. If you need a specific function, please open an issue.
- To build the GMP, an unofficial GMP repository mirror is used, as the official repository is inaccessible from GitHub.

## License

This project is licensed under the [MIT](./LICENSE) license and contains dynamically linked GMP binaries licensed under the [LGPL-3.0](https://www.gnu.org/licenses/lgpl-3.0.html) and [GPL-2.0](https://www.gnu.org/licenses/gpl-2.0.html) dual licenses.
