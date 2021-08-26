FROM mcr.microsoft.com/dotnet/runtime:3.1

WORKDIR /app
COPY /publish .

ENTRYPOINT ["dotnet", "CatFacts365.dll"]
