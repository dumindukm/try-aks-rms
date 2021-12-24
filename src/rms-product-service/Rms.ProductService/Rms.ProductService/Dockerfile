#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Rms.ProductService/Rms.ProductService.csproj", "Rms.ProductService/"]
RUN dotnet restore "Rms.ProductService/Rms.ProductService.csproj"
COPY . .
WORKDIR "/src/Rms.ProductService"
RUN dotnet build "Rms.ProductService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Rms.ProductService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Rms.ProductService.dll"]