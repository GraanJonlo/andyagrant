FROM microsoft/aspnetcore-build:2.0.8-2.1.200 AS build-env
COPY src /app
WORKDIR /app
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM microsoft/aspnetcore:2.0.8
WORKDIR /app
COPY --from=build-env /app/Blog/out .
EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000
ENTRYPOINT ["dotnet", "Blog.dll"]
