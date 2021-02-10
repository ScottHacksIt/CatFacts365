FROM mcr.microsoft.com/dotnet/runtime

WORKDIR /app
COPY /publish .

ENTRYPOINT ["dotnet", "CatFacts365.dll"]
