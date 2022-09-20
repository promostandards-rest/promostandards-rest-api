# create the build instance 
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src                                                                    
COPY ./src ./

# restore solution
RUN dotnet restore PromoStandards.REST/PromoStandards.REST.sln -s https://api.nuget.org/v3/index.json

WORKDIR /src/PromoStandards.REST/PromoStandards.REST.API

# build project   
RUN dotnet build PromoStandards.REST.API.csproj -c Release

# publish project
WORKDIR /src/PromoStandards.REST/PromoStandards.REST.API
RUN dotnet publish PromoStandards.REST.API.csproj -c Release -o /app/published

# create the runtime instance 
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS runtime 

# add globalization support
ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false

WORKDIR /app        
RUN mkdir bin
RUN mkdir logs  
                                                            
COPY --from=build /app/published .
     
ARG ASPNETCORE_ENVIRONMENT=Development
ENV ASPNETCORE_ENVIRONMENT=$ASPNETCORE_ENVIRONMENT

ARG MongoDB__Url=Development
ENV MongoDB__Url=$MongoDB__Url
                
ENTRYPOINT ["dotnet", "PromoStandards.REST.API.dll"]