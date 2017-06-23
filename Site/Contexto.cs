using Site.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Contexto : DbContext
    {
        public Contexto()
            :base(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Daniel Costa\Documents\visual studio 2015\Projects\Site\Site\App_Data\Banco.mdf; Integrated Security = True")
        {

        }

        public DbSet <Restaurante> restaurantes { get; set;}
        public DbSet<Prato> pratos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Restaurante>().Property(x => x.idR).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Restaurante>().Property(x => x.nome).IsRequired().HasColumnType("varchar").HasMaxLength(50);

            modelBuilder.Entity<Prato>().Property(x => x.idP).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Prato>().Property(x => x.idR).IsRequired().HasColumnType("int");
            modelBuilder.Entity<Prato>().Property(x => x.prato).IsRequired().HasColumnType("varchar").HasMaxLength(50);
            modelBuilder.Entity<Prato>().Property(x => x.preco).IsRequired().HasColumnType("float");

        }
    }
}
