FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY src/Api2/Medina.Api2.Softplan/Api2.Softplan.csproj src/Api2/Medina.Api2.Softplan/
COPY src/Api2/Medina.Api2.Softplan.Domain/Api2.Softplan.Domain.csproj src/Api2/Medina.Api2.Softplan.Domain/
COPY src/Api2/Medina.Api2.Softplan.Infrastructure/Api2.Softplan.Infrastructure.csproj src/Api2/Medina.Api2.Softplan.Infrastructure/
RUN dotnet restore src/Api2/Medina.Api2.Softplan/Api2.Softplan.csproj
COPY . .

WORKDIR /src/src/Api2/Medina.Api2.Softplan.Application.Test
RUN dotnet test

# WORKDIR /src/src/Api2/Medina.Api2.Softplan.Integration.Test
# RUN dotnet test

WORKDIR /src/src/Api2/Medina.Api2.Softplan
RUN dotnet build Api2.Softplan.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Api2.Softplan.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Api2.Softplan.dll"]
