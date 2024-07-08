# Fina

[![Maintainability](https://api.codeclimate.com/v1/badges/adb0306a7e20e79b8a11/maintainability)](https://codeclimate.com/github/codinginbrazil/Fina/maintainability)

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
```