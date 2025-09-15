@echo off
echo Building and running C# program...

echo ^<Project Sdk="Microsoft.NET.Sdk"^> > temp.csproj
echo   ^<PropertyGroup^> >> temp.csproj
echo     ^<OutputType^>Exe^</OutputType^> >> temp.csproj
echo     ^<TargetFramework^>net9.0^</TargetFramework^> >> temp.csproj
echo     ^<RootNamespace^>Program^</RootNamespace^> >> temp.csproj
echo     ^<AssemblyName^>Program^</AssemblyName^> >> temp.csproj
echo     ^<ImplicitUsings^>enable^</ImplicitUsings^> >> temp.csproj
echo     ^<Nullable^>enable^</Nullable^> >> temp.csproj
echo   ^</PropertyGroup^> >> temp.csproj
echo ^</Project^> >> temp.csproj

dotnet build temp.csproj -o bin -nologo -v quiet

if %errorlevel% equ 0 (
    bin\Program.exe
)

del temp.csproj