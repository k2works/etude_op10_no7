FROM microsoft/dotnet:runtime
WORKDIR /dotnetapp
COPY out .
ENTRYPOINTk ["dotnet", "dotnetapp.dll"]