# AGENTS instructions

C# bindings for the GNU Multiple Precision (GMP) arithmetic library. See [global.json](./global.json) and [src](./src/) directory for the project requirements and configuration.

## Project structure

- [src](./src/): The main codebase. [bindings](./src/Nethermind.GmpBindings/bindings/) holds the hand-written `LibraryImport` declarations mirroring the GMP C API; the rest is the managed wrapper around it.
- [build-gmp.yml](./.github/workflows/build-gmp.yml): Builds GMP for the supported platforms and optionally opens a pull request with the updated binaries.
- [test-publish.yml](./.github/workflows/test-publish.yml): Runs the tests and optionally publishes on NuGet.

## Coding guidelines

- Follow [.editorconfig](./.editorconfig).
- Do not assume; measure, research, ask if unsure.
- Keep comments short and to the point.
- Add tests for new code and bug fixes.
- Use conventional commits; keep scoped and imperative.
- Keep the bindings faithful to the GMP C API: preserve the native names and signatures, and document each one with a link to the GMP manual.
- Keep `unsafe` on the narrowest scope: on the members that need it or in inner `unsafe { }` blocks, never on a type declaration, and note the caller obligations with a short `// SAFETY:` comment. See [Improving C# memory safety](https://devblogs.microsoft.com/dotnet/improving-csharp-memory-safety/).
- Do not build or edit the native binaries under `runtimes/` locally; they are tracked with Git LFS and produced by [build-gmp.yml](./.github/workflows/build-gmp.yml).
- Prefer the latest versions of GitHub Actions and runners.
- Update [THIRD-PARTY-NOTICES](./THIRD-PARTY-NOTICES) when introducing a dependency if needed.
- Keep [AGENTS.md](./AGENTS.md) in sync with the ongoing development.
