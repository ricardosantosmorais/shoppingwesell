using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using Shopping.Dominio.Entidades;

namespace Shopping.InfraEstrutura
{
    public class ShoppingEntities : DbContext
    {
        public ShoppingEntities() : base("ShoppingWesell") { this.Configuration.LazyLoadingEnabled = false; this.Configuration.ProxyCreationEnabled = false; }

        public DbSet<TipoFrete> TipoFrete { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Estilo> Estilo { get; set; }
        public DbSet<ModeloProduto> ModeloProduto { get; set; }
        public DbSet<TipoBanner> TipoBanner { get; set; }
        public DbSet<TipoEndereco> TipoEndereco { get; set; }
        public DbSet<Fabricante> Fabricante { get; set; }
        public DbSet<AreaBanner> AreaBanner { get; set; }
        public DbSet<StatusPedido> StatusPedido { get; set; }
        public DbSet<FormaEntrega> FormaEntrega { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<SubCategoria> SubCategoria { get; set; }
        public DbSet<Loja> Loja { get; set; }
        //public DbSet<LojaUsuario> LojaUsuario { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Segmento> Segmento { get; set; }
        public DbSet<Banner> Banner { get; set; }
        public DbSet<Tema> Tema { get; set; }
        public DbSet<Pagina> Pagina { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasMany(s => s.SubCategoria).WithMany(p => p.Categoria).Map(m => m.MapLeftKey("CategoriaId").MapRightKey("SubCategoriaId").ToTable("CategoriaSubCategoria"));
            modelBuilder.Entity<Departamento>().HasMany(s => s.Categoria).WithMany(p => p.Departamento).Map(m => m.MapLeftKey("DepartamentoId").MapRightKey("CategoriaId").ToTable("DepartamentoCategoria"));
            modelBuilder.Entity<Cliente>().HasMany(s => s.Loja).WithMany(p => p.Cliente).Map(m => m.MapLeftKey("ClienteId").MapRightKey("LojaId").ToTable("ClienteLoja"));
            modelBuilder.Entity<Loja>().HasMany(s => s.FormaPagamento).WithMany(p => p.Loja).Map(m => m.MapLeftKey("LojaId").MapRightKey("FormaPagamentoId").ToTable("LojaFormaPagamento"));
            modelBuilder.Entity<Loja>().HasMany(s => s.FormaEntrega).WithMany(p => p.Loja).Map(m => m.MapLeftKey("LojaId").MapRightKey("FormaEntregaId").ToTable("LojaFormaEntrega"));
            modelBuilder.Entity<Loja>().HasMany(s => s.TipoFrete).WithMany(p => p.Loja).Map(m => m.MapLeftKey("LojaId").MapRightKey("TipoFreteId").ToTable("LojaTipoFrete"));
            modelBuilder.Entity<Loja>().HasMany(s => s.Segmento).WithMany(p => p.Loja).Map(m => m.MapLeftKey("LojaId").MapRightKey("SegmentoId").ToTable("LojaSegmento"));
            modelBuilder.Entity<Loja>().HasMany(s => s.Usuario).WithMany(p => p.Loja).Map(m => m.MapLeftKey("LojaId").MapRightKey("UsuarioId").ToTable("LojaUsuario"));
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
