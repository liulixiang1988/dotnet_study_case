FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["aspnet-demo/aspnet-demo.csproj", "aspnet-demo/"]
RUN dotnet restore "aspnet-demo/aspnet-demo.csproj"
COPY . .
WORKDIR "/src/aspnet-demo"
RUN dotnet build "aspnet-demo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "aspnet-demo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "aspnet-demo.dll"]
