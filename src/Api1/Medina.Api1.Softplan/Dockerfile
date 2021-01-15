FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build
WORKDIR /src
COPY src/Api1/Medina.Api1.Softplan/Api1.Softplan.csproj src/Api1/Medina.Api1.Softplan/
COPY src/Api1/Medina.Api1.Softplan.Application/Api1.Softplan.Application.csproj src/Api1/Medina.Api1.Softplan.Application/
COPY src/Api1/Medina.Api1.Softplan.Domain/Api1.Softplan.Domain.csproj src/Api1/Medina.Api1.Softplan.Domain/
RUN dotnet restore src/Api1/Medina.Api1.Softplan/Api1.Softplan.csproj
COPY . .

WORKDIR /src/src/Api1/Medina.Api1.Softplan.Application.Test
RUN dotnet test

# WORKDIR /src/src/Api1/Medina.Api1.Softplan.Integration.Test
# RUN dotnet test

WORKDIR /src/src/Api1/Medina.Api1.Softplan
RUN dotnet build Api1.Softplan.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish Api1.Softplan.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Api1.Softplan.dll"]
