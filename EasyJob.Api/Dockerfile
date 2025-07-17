# Use .NET 8 SDK image for build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet publish EasyJob.Api/EasyJob.Api.csproj -c Release -o /app/out

# Use .NET 8 ASP.NET runtime for run
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/out ./
ENTRYPOINT ["dotnet", "EasyJob.Api.dll"]
