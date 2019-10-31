using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModuloAdministrador.Infra.Data.Context;

namespace ModuloAdministrador.API {
    public class Startup {

        IConfiguration Configuration { get; set; }
        public Startup() {
            var builder = new ConfigurationBuilder().AddJsonFile("config.json");
        }

        public void ConfigureServices(IServiceCollection services) {
            var conn = Configuration.GetConnectionString("ModuloAdministradorDB");
            services.AddDbContext<ModuloAdministradorContext>(option => option.UseLazyLoadingProxies());
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
