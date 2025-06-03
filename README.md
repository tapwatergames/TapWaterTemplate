# Tap Water Godot Template v4.4.1.0
This is a template used to create new godot projects for Godot 4.4.1

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