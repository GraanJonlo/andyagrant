FROM microsoft/dotnet:2.1.301-sdk AS build-env
COPY src /app
WORKDIR /app
RUN dotnet restore
RUN dotnet publish -c Release -o out

FROM microsoft/dotnet:2.1.1-aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/Blog/out .
EXPOSE 5000/tcp
ENV ASPNETCORE_URLS http://*:5000
ENTRYPOINT ["dotnet", "Blog.dll"]
