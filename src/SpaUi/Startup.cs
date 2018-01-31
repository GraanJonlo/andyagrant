using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.SpaServices.Webpack;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SpaUi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.Configure<GzipCompressionProviderOptions>(
                options => options.Level = System.IO.Compression.CompressionLevel.Optimal);
            services.AddResponseCompression(options =>
                                            {
                                                options.MimeTypes = new[]
                                                                    {
                                                                        // Default
                                                                        "text/plain",
                                                                        "text/css",
                                                                        "application/javascript",
                                                                        "text/html",
                                                                        "application/xml",
                                                                        "text/xml",
                                                                        "application/json",
                                                                        "text/json",
                                                                        // Custom
                                                                        "image/svg+xml"
                                                                    };
                                            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseWebpackDevMiddleware(new WebpackDevMiddlewareOptions
                                            {
                                                HotModuleReplacement = true,
                                                ReactHotModuleReplacement = true
                                            });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles(new StaticFileOptions
                               {
                                   OnPrepareResponse = ctx =>
                                                       {
                                                           // Requires the following import:
                                                           // using Microsoft.AspNetCore.Http;
                                                           ctx.Context.Response.Headers.Append("Cache-Control",
                                                               "public,max-age=600");
                                                       }
                               });

            app.UseMvc(routes =>
                       {
                           routes.MapRoute(
                               name: "default",
                               template: "{controller=Home}/{action=Index}/{id?}");

                           routes.MapSpaFallbackRoute(
                               name: "spa-fallback",
                               defaults: new {controller = "Home", action = "Index"});
                       });
        }
    }
}