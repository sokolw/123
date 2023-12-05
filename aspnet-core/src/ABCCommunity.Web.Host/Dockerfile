FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/ABCCommunity.Web.Host/ABCCommunity.Web.Host.csproj", "src/ABCCommunity.Web.Host/"]
COPY ["src/ABCCommunity.Web.Core/ABCCommunity.Web.Core.csproj", "src/ABCCommunity.Web.Core/"]
COPY ["src/ABCCommunity.Application/ABCCommunity.Application.csproj", "src/ABCCommunity.Application/"]
COPY ["src/ABCCommunity.Core/ABCCommunity.Core.csproj", "src/ABCCommunity.Core/"]
COPY ["src/ABCCommunity.EntityFrameworkCore/ABCCommunity.EntityFrameworkCore.csproj", "src/ABCCommunity.EntityFrameworkCore/"]
WORKDIR "/src/src/ABCCommunity.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/ABCCommunity.Web.Host", "src/ABCCommunity.Web.Host"]
COPY ["src/ABCCommunity.Web.Core", "src/ABCCommunity.Web.Core"]
COPY ["src/ABCCommunity.Application", "src/ABCCommunity.Application"]
COPY ["src/ABCCommunity.Core", "src/ABCCommunity.Core"]
COPY ["src/ABCCommunity.EntityFrameworkCore", "src/ABCCommunity.EntityFrameworkCore"]
WORKDIR "/src/src/ABCCommunity.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "ABCCommunity.Web.Host.dll"]
