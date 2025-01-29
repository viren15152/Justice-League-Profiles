# Use the official .NET runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
WORKDIR /app
EXPOSE 8080

# Use the .NET SDK to build the project
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["Justice-League-Profiles.csproj", "./"]
RUN dotnet restore "./Justice-League-Profiles.csproj"
COPY . .
RUN dotnet publish -c Release -o /app/publish

# Final stage: Run the app
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
CMD ["dotnet", "Justice-League-Profiles.dll"]

