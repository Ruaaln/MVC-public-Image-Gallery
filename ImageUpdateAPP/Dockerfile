FROM mcr.microsoft.com/dotnet/sdk:8.0 AS base
WORKDIR /app
COPY *.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish ImageUpdateAPP.csproj -c Release -o out 

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=base /app/out . 
ENV ASPNETCORE_URLS="http://*:4500"
ENTRYPOINT ["dotnet", "ImageUpdateAPP.dll"]