using Database.BD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database.BD.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> data) : base(data) { }

        public DbSet<AlturaPiso> AlturasPisos { get; set; }
        public DbSet<AlturaPisoMaterialPiso> AlturasPisosMaterialesPisos { get; set; }
        public DbSet<AlturaTapa> AlturasTapas { get; set; }
        public DbSet<AlturaTapaMaterialTapa> AlturasTapasMaterialesTapas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ClienteFormaPago> ClientesFormasPago { get; set; }
        public DbSet<ColorCerco> ColoresCercos { get; set; }
        public DbSet<ColorCercoMaterialCerco> ColoresCercoMaterialesCerco { get; set; }
        public DbSet<ColorPiso> ColoresPisos { get; set; }
        public DbSet<ColorPisoMaterialPiso> ColoresPisosMaterialesPisos { get; set; }
        public DbSet<ColorTapa> ColoresTapas { get; set; }
        public DbSet<ColorTapaMaterialTapa> ColoresTapasMaterialesTapas { get; set; }
        public DbSet<ColorTintado> ColoresTintados { get; set; }
        public DbSet<Escandallo> Escandallos { get; set; }
        public DbSet<EscandalloPedido> EscandallosPedidos { get; set; }
        public DbSet<FormaPago> FormasPago { get; set; }
        public DbSet<Horma> Hormas { get; set; }
        public DbSet<HormaTroquelPiso> HormasTroquelesPisos { get; set; }
        public DbSet<HormaTroquelTapa> HormasTroquelesTapas { get; set; }
        public DbSet<LineaSerie> LineasSerie { get; set; }
        public DbSet<LineaSerieEscandallo> LineasSerieEscandallos { get; set; }
        public DbSet<LineaSeriePedido> LineasSeriePedidos { get; set; }
        public DbSet<LineaSerieSerie> LineasSerieSerie { get; set; }
        public DbSet<MaterialCerco> MaterialesCercos { get; set; }
        public DbSet<MaterialPiso> MaterialesPisos { get; set; }
        public DbSet<MaterialTapa> MaterialesTapas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Trabajo> Trabajos { get; set; }
        public DbSet<TroquelPiso> TroquelesPisos { get; set; }
        public DbSet<TroquelTapa> TroquelesTapas { get; set; }              
        public DbSet<Cobro> Cobros { get; set; }
        public DbSet<Remesa> Remesas { get; set; }
        public DbSet<Albaran> Albaranes { get; set; }
        public DbSet<Factura> Facturas { get; set; }        


        //relaciones muchos a muchos
        #region relaciones muchos a muchos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.Entity<AlturaPisoMaterialPiso>()
                .HasKey(c => new { c.AlturaPisoId, c.MaterialPisoId });

            modelBuilder.Entity<AlturaTapaMaterialTapa>()
                .HasKey(c => new { c.AlturaTapaId, c.MaterialTapaId });
            
            modelBuilder.Entity<ClienteFormaPago>()
                .HasKey(c => new { c.ClienteId, c.FormaPagoId });

            modelBuilder.Entity<ColorCercoMaterialCerco>()
                .HasKey(c => new { c.ColorCercoId, c.MaterialCercoId });

            modelBuilder.Entity<ColorPisoMaterialPiso>()
                .HasKey(c => new { c.ColorPisoId, c.MaterialPisoId });

            modelBuilder.Entity<ColorTapaMaterialTapa>()
                .HasKey(c => new { c.ColorTapaId, c.MaterialTapaId });

            modelBuilder.Entity<EscandalloPedido>()
                .HasKey(c => new { c.EscandalloId, c.PedidoId });

            modelBuilder.Entity<HormaTroquelPiso>()
                .HasKey(c => new { c.HormaId, c.TroquelPisoId });

            modelBuilder.Entity<HormaTroquelTapa>()
                .HasKey(c => new { c.HormaId, c.TroquelTapaId });

            modelBuilder.Entity<LineaSerieEscandallo>()
                .HasKey(c => new { c.LineaSerieId, c.EscandalloId });

            modelBuilder.Entity<LineaSeriePedido>()
                .HasKey(c => new { c.LineaSerieId, c.PedidoId });

            modelBuilder.Entity<LineaSerieSerie>()
                .HasKey(c => new { c.LineaSerieId, c.SerieId });

            modelBuilder.Entity<RemesaCliente>()
                .HasKey(c => new { c.RemesaId, c.ClienteId });

            //PEDIDO - ALBARAN
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Albaran).WithOne(a => a.Pedido)
                .HasForeignKey<Albaran>(a => a.IdPedido);
            modelBuilder.Entity<Pedido>().ToTable("Pedidos");
            modelBuilder.Entity<Albaran>().ToTable("Albaranes");

            //PEDIDO - FACTURA
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Factura).WithOne(f => f.Pedido)
                .HasForeignKey<Factura>(f => f.IdPedido);
            modelBuilder.Entity<Pedido>().ToTable("Pedidos");
            modelBuilder.Entity<Factura>().ToTable("Facturas");
        }        
        #endregion
    }
}