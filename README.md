# OptiTemplates

This project aims to create sound starter files following conventions laid out by the Alloy and Foundation projects. Also borrowing some files...

The **OptiTemplates** project templates save you some time by providing minimal Optimizely CMS (EPiServer) templates (dotnet CLI and Visual Studio).

**OptiTemplates** by default generates projects that target the latest .NET version supported by Optimizely.

## Getting Started

1. Make sure you have the latest version of the [.NET SDK](https://dotnet.microsoft.com/download/dotnet/) installed.
3. Open a terminal (e.g. powershell or bash) in any directory.
4. Authenticate with [github](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry#authenticating-with-a-personal-access-token)
5. Install the dotnet templates.

```
dotnet new --install Opti.Templates --nuget-source https://nuget.pkg.github.com/dqhoang/index.json
```

6. Install the CLI tool

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

## Dev

To get started clone the repository

Then install the template

```
cd OptiTemplates/templates/StarterOptiCms
```

Mac/Linux

```
dotnet new --install ./
```

Windows

```
dotnet new --install .\
```
