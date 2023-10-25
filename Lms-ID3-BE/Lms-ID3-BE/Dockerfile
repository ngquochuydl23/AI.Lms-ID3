#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Lms-ID3-BE/Lms-ID3-BE.csproj", "Lms-ID3-BE/"]
RUN dotnet restore "Lms-ID3-BE/Lms-ID3-BE.csproj"
COPY . .
WORKDIR "/src/Lms-ID3-BE"
RUN dotnet build "Lms-ID3-BE.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Lms-ID3-BE.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Lms-ID3-BE.dll"]