FROM mcr.microsoft.com/dotnet/core/runtime

WORKDIR /app
COPY /publish .

ENTRYPOINT ["dotnet", "CatFacts365.dll"]
