# VaderConsulting.CommandLine

C# .NET 3.5 class library: command-line argument parser and WinForms TraceListener that logs to a progress form. `Arguments` accepts `-param`, `/param`, and `--param` with values after `=`, `:`, or a space, and treats a flag with no value as `true`. `TextTraceListener` copies `System.Diagnostics.Trace` into a `TextBox`, `StatusStrip`, or `ToolStripStatusLabel` and mirrors the same lines in `frmProgress`, a read-only window that minimises instead of closing.

**Source last updated:** 2015-02-26 · **Language:** C# · **Target:** .NET Framework 3.5 · **Output:** class library (WinForms helpers)

## Solution structure

| Project | Language | Type | Purpose |
|---------|----------|------|---------|
| `VaderConsulting.CommandLine` | C# | class library (`net35`) | `Arguments` parser (`CommandLine` namespace); `TextTraceListener` and `frmProgress` for WinForms trace output. |

## How to open

Open `VaderConsulting.CommandLine.csproj` in Visual Studio 2013 or later (ToolsVersion 12.0). There is no `.sln` in this folder.

## Requirements

- Visual Studio 2013 or later, .NET Framework 3.5

## Attribution and provenance

Working copy from Dave Robinson's OneDrive Historical Dev folder `VaderConsulting.CommandLine`. Assembly title/product `VaderConsulting.CommandLine`; the template still has company/copyright Microsoft 2015. Namespaces `VaderConsulting.CommandLine` and `CommandLine`. `packages.config` lists AsyncBridge 0.1.1; `App.config` has leftover Entity Framework 6 LocalDB section. Neither is referenced by the `.csproj`.

## License

MIT © 2026 VaderConsulting. See `LICENSE`.
