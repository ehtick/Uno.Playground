# Uno Playground

A browser-based sandbox for trying Uno Platform controls and layouts. Edit XAML markup and data context, then see the result rendered instantly via WebAssembly.
Try it at <https://playground.platform.uno>.

## Solution structure

| Project | Description |
|---------|-------------|
| `src/Uno.Playground` | Main Playground app (Uno.Sdk single-project, WebAssembly) |
| `src/Uno.Playground.Api` | Azure Functions v1 backend (`net461`) |

## Prerequisites

- .NET 10.0 SDK (or the version pinned in `global.json`)
- Uno.Sdk (resolved automatically via `global.json`)

## Building

```bash
dotnet restore src/Uno.Playground.slnx
dotnet build src/Uno.Playground.slnx
```

## Running locally (WebAssembly)

```bash
dotnet run --project src/Uno.Playground/Uno.Playground.csproj
```

## Publishing

```bash
dotnet publish src/Uno.Playground/Uno.Playground.csproj -c Release
```

The published output is a static WebAssembly site deployed via Azure Static Web Apps.