FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["ProjectEuler.Solutions/ProjectEuler.Solutions.csproj", "ProjectEuler.Solutions/"]
RUN dotnet restore "ProjectEuler.Solutions/ProjectEuler.Solutions.csproj"
COPY . .
WORKDIR "/src/ProjectEuler.Solutions"
RUN dotnet build "ProjectEuler.Solutions.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ProjectEuler.Solutions.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ProjectEuler.Solutions.dll"]
