FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["dotnet-7-playground.csproj", "./"]
RUN dotnet restore "dotnet-7-playground.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "dotnet-7-playground.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dotnet-7-playground.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dotnet-7-playground.dll"]
