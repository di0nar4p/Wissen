using Entidades.Map;
using Entidades.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        /*
        *   Ao se criar uma classe do tipo Map,  
        *   faz-se necessário a criação a inserção de 
        *   um instância dentro deste método;
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new MapNoticia(modelBuilder.Entity<Noticia>());
            new MapUsuario(modelBuilder.Entity<Usuario>());
            
        }
    }
}
