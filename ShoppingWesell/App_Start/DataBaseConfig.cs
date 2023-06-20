using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Shopping.Dominio.Entidades;

namespace ShoppingWesell.App_Start
{
    public class DataBaseConfig : DbContext
    {
        public DbSet<TipoFrete> TipoFrete { get; set; }
        public DbSet<Marca> Marca { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}