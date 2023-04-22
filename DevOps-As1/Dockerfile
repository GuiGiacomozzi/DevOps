FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 5026

ENV ASPNETCORE_URLS=http://+:5026

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["DevOps-As1/DevOps-As1.csproj", "DevOps-As1/"]
RUN dotnet restore "DevOps-As1\DevOps-As1.csproj"
COPY . .
WORKDIR "/src/DevOps-As1"
RUN dotnet build "DevOps-As1.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DevOps-As1.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DevOps-As1.dll"]
