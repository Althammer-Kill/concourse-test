FROM mcr.microsoft.com/dotnet/runtime:7.0
COPY HelloWorld/bin/Debug/net7.0/* .
ENTRYPOINT [ "dotnet", "HelloWorld.dll" ]
