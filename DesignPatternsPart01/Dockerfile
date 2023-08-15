FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DesignPatternsParte01/DesignPatternsParte01.csproj", "DesignPatternsParte01/"]
RUN dotnet restore "DesignPatternsParte01/DesignPatternsParte01.csproj"
COPY . .
WORKDIR "/src/DesignPatternsParte01"
RUN dotnet build "DesignPatternsParte01.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DesignPatternsParte01.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DesignPatternsParte01.dll"]
