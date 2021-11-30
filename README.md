# OptiTemplates

The templates provided by Optimizely were lacking some important files that prevented it from running unless it was launched from Visual Studio.

This project aims to create sound starter files following conventions laid out by the Alloy and Foundation projects.

The **OptiTemplates** project templates save you some time by providing minimal Optimizely CMS (EPiServer) templates (dotnet CLI and Visual Studio).

**OptiTemplates** by default generates projects that target the latest .NET version supported by Optimizely.

## Getting Started

1. Make sure you have the latest version of the [.NET SDK](https://dotnet.microsoft.com/download/dotnet/) installed.
2. Open a terminal (e.g. powershell or bash) in any directory.
3. Install the dotnet templates.

```
dotnet new --install DuyHoang.DotNet.Templates.OptiTemplates --nuget-source ???
```

4. Install the CLI tool

```
dotnet tool install EPiServer.Net.Cli --global --add-source https://nuget.optimizely.com/feed/packages.svc/
```

## Create a project (CLI)

Open a terminal in any directory and run the `dotnet new` command.
Example:

```
dotnet new emptyopticms --output c:/source/MyEmptyOptimizelyCMS
```

```
cd MyEmptyOptimizelyCMS
```

Wire up a database

```
dotnet-episerver create-cms-database MyEmptyOptimizelyCMS.csproj -S .\SQLEXPRESS -U sa -P "password"
```

Launch

```
dotnet run
```
