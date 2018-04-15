namespace Blog

open System
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.AspNetCore.Http
open Microsoft.Extensions.DependencyInjection
open Suave
open Suave.AspNetCore
open Suave.Operators
open Suave.Successful

type Startup() =

    member this.ConfigureServices(services: IServiceCollection) =
        ()

    member this.Configure(app: IApplicationBuilder, env: IHostingEnvironment) =
        if env.IsDevelopment() then app.UseDeveloperExceptionPage() |> ignore

        app.UseSuave(App.helloWorld) |> ignore

        ()