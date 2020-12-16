# How to build

`dotnet publish -r win-x86 -c Release --self-contained true /p:PublishTrimmed=true`

The above command publishes an x86 release which is self contained - framework independent, trimmed from unused assemblies.