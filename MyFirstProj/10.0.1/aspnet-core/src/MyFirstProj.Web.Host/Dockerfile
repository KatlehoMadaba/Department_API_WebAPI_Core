FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/MyFirstProj.Web.Host/MyFirstProj.Web.Host.csproj", "src/MyFirstProj.Web.Host/"]
COPY ["src/MyFirstProj.Web.Core/MyFirstProj.Web.Core.csproj", "src/MyFirstProj.Web.Core/"]
COPY ["src/MyFirstProj.Application/MyFirstProj.Application.csproj", "src/MyFirstProj.Application/"]
COPY ["src/MyFirstProj.Core/MyFirstProj.Core.csproj", "src/MyFirstProj.Core/"]
COPY ["src/MyFirstProj.EntityFrameworkCore/MyFirstProj.EntityFrameworkCore.csproj", "src/MyFirstProj.EntityFrameworkCore/"]
WORKDIR "/src/src/MyFirstProj.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/MyFirstProj.Web.Host", "src/MyFirstProj.Web.Host"]
COPY ["src/MyFirstProj.Web.Core", "src/MyFirstProj.Web.Core"]
COPY ["src/MyFirstProj.Application", "src/MyFirstProj.Application"]
COPY ["src/MyFirstProj.Core", "src/MyFirstProj.Core"]
COPY ["src/MyFirstProj.EntityFrameworkCore", "src/MyFirstProj.EntityFrameworkCore"]
WORKDIR "/src/src/MyFirstProj.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "MyFirstProj.Web.Host.dll"]
