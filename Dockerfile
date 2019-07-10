# temporary image for building
FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build

# copy the source code
COPY . /src
WORKDIR /src/BotTemplate
# restore dependencies
RUN dotnet restore

# build the application into the app dir
RUN dotnet publish BotTemplate.csproj -c Release -o out

# runtime image
FROM mcr.microsoft.com/dotnet/core/runtime:2.2 AS runtime
WORKDIR /app
# copy build artifacts
COPY --from=build /src/BotTemplate/out ./ 
ENTRYPOINT ["dotnet", "BotTemplate.dll"]