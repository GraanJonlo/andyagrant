namespace Blog

module Main =
    open Microsoft.AspNetCore
    open Microsoft.AspNetCore.Builder
    open Microsoft.AspNetCore.Hosting
    open Microsoft.Extensions.DependencyInjection
    open Suave.AspNetCore

    type Startup() =
        member this.ConfigureServices(services: IServiceCollection) =
            ()

        member this.Configure(app: IApplicationBuilder, env: IHostingEnvironment) =
            if env.IsDevelopment() then app.UseDeveloperExceptionPage() |> ignore
            app.UseStaticFiles() |> ignore
            app.UseSuave(App.webPart) |> ignore
            ()

    let BuildWebHost args =
        WebHost
            .CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build()

    [<EntryPoint>]
    let main args =
        BuildWebHost(args).Run()
        0
