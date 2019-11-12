using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using ModuloAdministrador.Domain.Entities;
using ModuloAdministrador.Infra.CrossCutting.Logging;
using ModuloAdministrador.Infra.Data.Context;
using System;
using System.Linq;

namespace ModuloAdministradorApp {
    class Program {
        static void Main(string[] args) {
            Usuario usuario1;
            Usuario usuario2;

            Usuario CriarUsuario(String nome, String email, String cpf) {
                return new Usuario() {
                    Nome = nome,
                    Email = email,
                    Cpf = cpf
                };
            }

            usuario1 = CriarUsuario("Mais Usuario", "xyz@efg.com", "000400");
            usuario2 = CriarUsuario("Another Usuario", "xyz@efg.com", "020030");

            var optionsBuilder = new DbContextOptionsBuilder<ModuloAdministradorContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("Server=localhost; userid=root; password=admin; database=ModuloAdministradorDB;",
                                    m => m.MigrationsAssembly("ModuloAdministrador.Infra.Data"));
            try {
                using (var dbcontext = new ModuloAdministradorContext(optionsBuilder.Options)) {
                    dbcontext.GetService<ILoggerFactory>().AddProvider(new Logger());

                    //dbcontext.Usuarios.Add(usuario1);
                    //dbcontext.Usuarios.Add(usuario2);
                    //dbcontext.SaveChanges();

                    var resultado = dbcontext.Usuarios.Where(u => u.Id<3);

                    foreach(var us in resultado) {

                    }
                }
            }
            catch(Exception e) {
                Console.WriteLine("Erro: " + e.Message);
                Console.ReadKey();

            }
            Console.WriteLine("Ok...");
            Console.ReadKey();
        }
    }
}
