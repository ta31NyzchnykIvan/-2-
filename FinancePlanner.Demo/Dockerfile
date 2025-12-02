FROM mcr.microsoft.com/dotnet/runtime:8.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

COPY ["FinancePlanner.Demo/FinancePlanner.Demo.csproj", "FinancePlanner.Demo/"]
COPY ["FinancePlanner/FinancePlanner.csproj", "FinancePlanner/"]

RUN dotnet restore "FinancePlanner.Demo/FinancePlanner.Demo.csproj"

COPY . .

WORKDIR "/src/FinancePlanner.Demo"
RUN dotnet build "FinancePlanner.Demo.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "FinancePlanner.Demo.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FinancePlanner.Demo.dll"]
