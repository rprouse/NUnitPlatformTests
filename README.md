# NUnit Platform Tests

NUnit tests targetting various platforms like .NET Core. I am using this to test the NUnit Visual Studio Adapter updates.

### Projects

- **src\NetStandard13Library** - A .NET Standard 1.3 project to be referenced by a test project.
- **src\NetStandard16Library** - A .NET Standard 1.6 project to be referenced by a test project. Contains async methods for testing.
- **test\NetCore10Tests** - A .NET Core 1.0 test project referencing the .NET Standard 1.3 Library.
- **test\NetCore11Tests** - A .NET Core 1.1 test project referencing the .NET Standard 1.6 Library.
- **test\NetClrNewStyleTests** - A .NET 4.5.2 test project using the new CSPROJ format.
- **test\NetClrTests** - A .NET 4.5 test project using the old CSPROJ format.

### Dependencies

Any tests using the new style CSPROJ format, either .NET Core or .NET 4.x, need to add a `PackageReference` to the NuGet package `Microsoft.NET.Test.Sdk`.

```xml
<ItemGroup>
  <PackageReference Include="Microsoft.NET.Test.Sdk" Version="15.0.0" />
  <PackageReference Include="NUnit" Version="3.6.1" />
  <PackageReference Include="NUnit3TestAdapter" Version="4.0.0-ci-00452-pr-313" />
</ItemGroup>
```

### Running Tests

These tests will run in Visual Studio, and the .NET Core test can be run on the command line with `dotnet test`, for example,

```cmd
> dotnet test .\test\NetCore10Tests\NetCore10Tests.csproj
Build started, please wait...
Build completed.

Test run for D:\src\NUnit\NUnitPlatformTests\test\NetCore10Tests\bin\Debug\netcoreapp1.0\NetCore10Tests.dll(.NETCoreApp,Version=v1.0)
Microsoft (R) Test Execution Command Line Tool Version 15.0.0.0
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
NUnit Adapter 4.0.0.0: Test execution started
Running all tests in D:\src\NUnit\NUnitPlatformTests\test\NetCore10Tests\bin\Debug\netcoreapp1.0\NetCore10Tests.dll
NUnit3TestExecutor converted 14 of 14 NUnit test cases
NUnit Adapter 4.0.0.0: Test execution complete

Total tests: 14. Passed: 14. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 5.4507 Seconds
```

The .NET 4.5 tests can also be run with `vstest.console.exe`. The .NET Core tests are not running because they are not finding the dependent assemblies (`nunit.framework.dll`) which are not copied into the bin directory on build. I am not sure if this is expected behaviour. I would think most people would use `dotnet test`, but it needs looking into.

```cmd
> vstest.console.exe .\test\NUnitClrTests\bin\Debug\NUnitClrTests.dll /TestAdapterPath:packages
Microsoft (R) Test Execution Command Line Tool Version 14.0.25420.1
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
Information: NUnit Adapter 4.0.0.0: Test execution started

Information: Running all tests in D:\src\NUnit\NUnitPlatformTests\.\test\NUnitClrTests\bin\Debug\NUnitClrTests.dll

Information: NUnit3TestExecutor converted 1 of 1 NUnit test cases

Information: NUnit Adapter 4.0.0.0: Test execution complete

Passed   TestMethod

Total tests: 1. Passed: 1. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 0.4058 Seconds
```
