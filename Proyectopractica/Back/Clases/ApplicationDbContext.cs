using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Clases
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Ingredientes> ingredientes { get; set; }
        public DbSet<Opcion> opciones { get; set; }    
        public DbSet<Pedido> pedidos { get; set; }

        public DbSet<Usuario> usuarios { get; set; }

        public DbSet<IngredienteOpcion> ingredientesOpciones { get; set; }  




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-DT711V1\\SQLEXPRESS;database=ProyectoPractica;trusted_connection=true;Encrypt=False");
        }

       


    }
}
