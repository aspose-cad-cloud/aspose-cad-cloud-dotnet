# Aspose.CAD Cloud SDK Examples
This project provides examples of using Aspose.CAD Cloud SDK for .NET.

### Prerequisites
.NET Framework v4.5.2 is required.

### Running the examples
 ```
nuget restore
msbuild.exe Aspose.CAD.Cloud.SDK.Examples.sln /p:Configuration=Release /t:Clean,Build
cd .\Aspose.CAD.Cloud.Sdk.Examples\bin\Release\
Aspose.CAD.Cloud.Sdk.Examples.exe --appKey=... --appSid=... --baseUrl=...
 ```
`--appKey` and `--appSid` are required parameters to connect to Aspose.CAD Cloud API. They can be obtained at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) (free registration in Aspose Cloud is required for this).

`--baseUrl` is an optional parameter that allows running examples with custom hosted Aspose.CAD Cloud API instance.
