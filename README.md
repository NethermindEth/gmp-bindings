# GMP bindings

[![Tests](https://github.com/nethermindeth/gmp-bindings/actions/workflows/test-publish.yml/badge.svg)](https://github.com/nethermindeth/gmp-bindings/actions/workflows/test-publish.yml)
[![Nethermind.GmpBindings](https://img.shields.io/nuget/v/Nethermind.GmpBindings)](https://www.nuget.org/packages/Nethermind.GmpBindings)

C# bindings for the [GNU Multiple Precision](https://gmplib.org) (GMP) arithmetic library.

## Notes

Not all GMP functions are currently bound, only a subset of integer functions. If you need a specific function, please open an issue.

The binaries are built from an unofficial GMP repository mirror, as the official repository is inaccessible from GitHub.

## License

This project is licensed under the [MIT](https://github.com/nethermindeth/gmp-bindings/blob/main/LICENSE) license.

The package also ships prebuilt GMP binaries, used under the [LGPL-3.0](https://www.gnu.org/licenses/lgpl-3.0.html) option of GMP's dual LGPL-3.0/[GPL-2.0](https://www.gnu.org/licenses/gpl-2.0.html) license. Those binaries are linked dynamically and link no dependencies of their own. See [THIRD-PARTY-NOTICES](https://github.com/nethermindeth/gmp-bindings/blob/main/THIRD-PARTY-NOTICES) for the third-party license texts.
