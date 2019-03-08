# CoverletCheck
Testing that coverlet.msbuild works with xUnit and .NET Core 2.0.

dotnet test --test-adapter-path:. --logger "xunit;LogFileName=TestResult.xml" /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput='./TestResults/Coverage/'
