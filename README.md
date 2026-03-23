# Irihi.Ursa.Themes.PipBoy

`Irihi.Ursa.Themes.PipBoy` is an Avalonia theme library that adapts **Ursa** controls to a **PipBoy-inspired** visual style.

This repository contains:

- a reusable theme library in `src/Irihi.Ursa.Themes.PipBoy`
- a desktop demo app in `demo/PipBoyTheme.Demo`

The demo combines the base `PipboyTheme` with `UrsaPipboyTheme` so Ursa controls render consistently inside the PipBoy-styled UI.

## Requirements

- .NET SDK 10 or newer
- Avalonia 11.3.12-compatible development environment

The projects in this repository currently target:

- `net10.0`

## Included dependencies

The theme library is built on top of:

- `Avalonia` 11.3.12
- `Irihi.Ursa` 1.15.0
- `Pipboy.Avalonia` 0.0.2-beta

The demo app additionally uses:

- `Avalonia.Desktop`
- `Avalonia.Fonts.Inter`
- `CommunityToolkit.Mvvm`

## Project structure

```text
src/
  Irihi.Ursa.Themes.PipBoy/
	Controls/            # Ursa control style overrides and resources
	Locale/              # Localized resource dictionaries
	UrsaPipboyTheme.axaml
	UrsaPipboyTheme.axaml.cs

demo/
  PipBoyTheme.Demo/
	App.axaml            # Registers PipboyTheme + UrsaPipboyTheme
	Views/MainWindow.axaml
	Pages/OverviewPage.axaml
	Pages/UrsaOverviewPage.axaml
```

## Using the theme in an Avalonia app

Add a reference to the theme library project, then register both the base PipBoy theme and the Ursa overlay theme in your application styles.

### Example `App.axaml`

```xml
<Application
	xmlns="https://github.com/avaloniaui"
	xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
	xmlns:pipboy="clr-namespace:Pipboy.Avalonia;assembly=Pipboy.Avalonia"
	xmlns:pipboyUrsa="clr-namespace:Irihi.Ursa.Themes.Pipboy;assembly=Irihi.Ursa.Themes.PipBoy">

	<Application.Styles>
		<pipboy:PipboyTheme />
		<pipboyUrsa:UrsaPipboyTheme />
	</Application.Styles>
</Application>
```

## Localization support

`UrsaPipboyTheme` merges localized resources and exposes helpers for overriding locale resources at runtime.

Currently discoverable locale dictionaries:

- `en-US`
- `zh-CN`
- `fr-FR`
- `ru-RU`

Relevant implementation:

- `src/Irihi.Ursa.Themes.PipBoy/UrsaPipboyTheme.axaml.cs`

## Demo app

The demo app shows:

- core PipBoy-styled layout and navigation
- an overview page for the base PipBoy look-and-feel
- an Ursa showcase page with themed controls such as `Banner`, `Marquee`, `Avatar`, `Badge`, `ButtonGroup`, `Rating`, `RangeSlider`, `MultiComboBox`, `TreeComboBox`, `TagInput`, `DateRangePicker`, `ToolBar`, and `Pagination`

### Run the demo

From the repository root:

```powershell
dotnet run --project .\demo\PipBoyTheme.Demo\PipBoyTheme.Demo.csproj
```

## Build

Library build:

```powershell
dotnet build .\src\Irihi.Ursa.Themes.PipBoy\Irihi.Ursa.Themes.PipBoy.csproj -nologo
```

Demo build:

```powershell
dotnet build .\demo\PipBoyTheme.Demo\PipBoyTheme.Demo.csproj -nologo
```

If the demo is already running, the default demo output folder can be locked by the active `.NET Host` process. In that case, build to an alternate output directory:

```powershell
dotnet build .\demo\PipBoyTheme.Demo\PipBoyTheme.Demo.csproj -nologo -p:OutDir=".\artifacts\verify-demo\"
```

## Control resource composition

`UrsaPipboyTheme.axaml` merges:

- `Controls/_index.axaml`
- `Locale/en-us.axaml`

`Controls/_index.axaml` then aggregates the themed resource dictionaries for the supported Ursa controls.

## Development notes

- Demo pages use `HeaderedContentControl` with `Classes="groupbox"` for section containers.
- The main library entry point is `UrsaPipboyTheme`.
- The demo registers both themes in `demo/PipBoyTheme.Demo/App.axaml`.

## Status

This repository is currently a source project with a demo application and no package publishing metadata documented in the project files yet.
