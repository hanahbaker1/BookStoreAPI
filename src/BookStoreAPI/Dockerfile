# Use the official .NET SDK image for building the application
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy the csproj file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the entire source code and build the application
COPY . .
RUN dotnet publish -c Release -o out

# Use the official ASP.NET Core runtime image for running the application
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY --from=build /app/out .

# Set environment variables
ENV ASPNETCORE_URLS=http://+:5000
EXPOSE 5000

# Run the application
ENTRYPOINT ["dotnet", "BookStoreAPI.dll"]
