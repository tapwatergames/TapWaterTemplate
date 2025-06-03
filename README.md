# Tap Water Godot Template v4.4.1.0
This is a template used to create new godot projects for Godot 4.4.1 it is intended for use with Windows 10/11 and VSCode.

## Installation
1. Clone this repo
2. Navigate to the cloned repo with PowerShell.
3. run command ```dotnet new install .``` to install the template.

## Creating a project
After the template is installed on your system, use these instructions to create a new project.

1. navigate to the desired directory with powershell.
2. run ```dotnet new TWGodot -o <ProjectName>```
3. Navigate to the newly created folder, and run newprojectsetup.bat to clean some files up.

## Required Dependencies
There are a few things that you need configured before you can use this template. It is intended to be used on Windows with VSCode as a Text Editor.

1. Windows
2. .NET 9
3. Godot 4.4.1 .NET should be configured in your PATH. I recomend doing this using godotenv, but however you get it there is fine.

### Optional Enhancements
Because this template is intended for use with VSCode, there are a few extensions that will make your life easier.

1. C# Dev kit - This is a plugin that adds Roslyn (C# lsp) and other nicities to VSCode.

## Included NuGet Packages

### Chickensoft Tools

#### [GoDotTest](https://github.com/chickensoft-games/GoDotTest)
A simple godot unit testing framework.

#### [GodotTestDriver](https://github.com/chickensoft-games/GodotTestDriver)
A tool to create integration tests with godot.

#### [Godot Node Interfaces](https://github.com/chickensoft-games/GodotNodeInterfaces)
Allows for abstracting godot nodes during integration/unit tests.

#### [AutoInject](https://github.com/chickensoft-games/AutoInject)
Runtime dependency injection of Godot nodes.


### Other NuGet tools

#### [Shoudly](https://github.com/shouldly)
C# Assertion Framework

#### [GodotSharp.SourceGenerators](https://github.com/Cat-Lips/GodotSharp.SourceGenerators)
C# Source Generation for Type Safe C# programming with Godot.

## Included SubModules
#### [Tap Water Standard Library](https://github.com/tapwatergames/TapWaterSL)
A small library of useful tools for game development with Godot and C#

## Included Godot Addons
#### [Debug Draw 3D](https://github.com/DmitriySalnikov/godot_debug_draw_3d)
A tool for Drawing Debug shapes in Godot 3D

#### Run Chickensoft Test
Proprietary addon to run chickensoft tests from within the godot editor.