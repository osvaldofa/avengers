FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["Avengers.Hero.Api/Avengers.Hero.Api.csproj", "Avengers.Hero.Api/"]
RUN dotnet restore "Avengers.Hero.Api/Avengers.Hero.Api.csproj"
COPY . .
WORKDIR "/src/Avengers.Hero.Api"
RUN dotnet build "Avengers.Hero.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Avengers.Hero.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Avengers.Hero.Api.dll"]