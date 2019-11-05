using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ModuloAdministrador.Infra.Data.Context;

namespace ModuloAdministrador.API {
    public class Startup {

        IConfiguration Configuration { get; set; }
        public Startup() {
            var builder = new ConfigurationBuilder().AddJsonFile("config.json");
            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services) {
            var conn = Configuration.GetConnectionString("ModuloAdministradorDB");
            services.AddDbContext<ModuloAdministradorContext>(option => option.UseLazyLoadingProxies()
                                                            .UseMySql(conn, m => m.MigrationsAssembly("ModuloAdministrador.Infra.Data")));

            services.AddMvcCore();
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
