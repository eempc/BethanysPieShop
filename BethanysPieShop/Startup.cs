using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using BethanysPieShop.Models;

namespace BethanysPieShop {
    public class Startup {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services) {
            services.AddSingleton<IPieRepository, MockPieRepository>(); // To use the in-memory "database", why can't we jump straight to EF
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            //if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            //app.Run(async (context) => { await context.Response.WriteAsync("Hello World!"); });

            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages(); // E.g. status 404
            app.UseStaticFiles(); // wwwroot contents
            app.UseMvcWithDefaultRoute();
        }
    }
}
