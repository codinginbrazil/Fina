# Fina

[![Maintainability](https://api.codeclimate.com/v1/badges/adb0306a7e20e79b8a11/maintainability)](https://codeclimate.com/github/codinginbrazil/Fina/maintainability)

To do:
[health checks](https://renatogroffe.medium.com/net-5-health-checks-exemplos-de-implementa%C3%A7%C3%A3o-em-projetos-asp-net-core-3488cc807608)

Doing: 
- Dapper
- Minimal API

```shell
#Create a Solution File: To create a solution file, use the following command:
dotnet new sln -n Fina 

# Create API Project
dotnet new web -o Api

#Create Blazor WebAssembly (PWA) project:
dotnet new blazorwasm -o Web --pwa 

#Create class library (Core) project:
dotnet new classlib -o Core 

#Add Projects to Solution: Finally, add your projects to the solution: 
dotnet sln add Api/
dotnet sln add Core/
dotnet sln add Web

cd /Web/
dotnet add package MudBlazor
```