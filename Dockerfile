FROM mcr.microsoft.com/dotnet/sdk:10 AS build
WORKDIR /src
COPY src/CSharpAu.Api/CSharpAu.Api.csproj src/CSharpAu.Api/
RUN dotnet restore src/CSharpAu.Api/CSharpAu.Api.csproj
COPY . .
WORKDIR /src/src/CSharpAu.Api
RUN dotnet build CSharpAu.Api.csproj -c Release -o /app/build
FROM build AS publish
RUN dotnet publish CSharpAu.Api.csproj -c Release -o /app/publish
FROM mcr.microsoft.com/dotnet/aspnet:10
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CSharpAu.Api.dll"]