FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine as build
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine as runtime
COPY --from=build /app/publish /app/publish
WORKDIR /app/publish
CMD ASPNETCORE_URLS=http://*:$PORT dotnet PersonalWebApi.dll