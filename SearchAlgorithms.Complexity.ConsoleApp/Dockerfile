FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SearchAlgorithms.Complexity.ConsoleApp/SearchAlgorithms.Complexity.ConsoleApp.csproj", "SearchAlgorithms.Complexity.ConsoleApp/"]
RUN dotnet restore "SearchAlgorithms.Complexity.ConsoleApp/SearchAlgorithms.Complexity.ConsoleApp.csproj"
COPY . .
WORKDIR "/src/SearchAlgorithms.Complexity.ConsoleApp"
RUN dotnet build "SearchAlgorithms.Complexity.ConsoleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SearchAlgorithms.Complexity.ConsoleApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SearchAlgorithms.Complexity.ConsoleApp.dll"]
