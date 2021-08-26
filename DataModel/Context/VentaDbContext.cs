using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using VentaVehiculos.DataModel.Entities;

namespace VentaVehiculos.DataModel.Context
{
    class VentaDbContext:DbContext
    {
        public VentaDbContext()
            :base("name=conexionBD")
        {

        }

        public DbSet<Cliente> Clientes { set; get; }
        public DbSet<Vehiculo> Vehiculos { set; get; }
        public DbSet<Modelo> Modelos { set; get; }
        public DbSet<Marca> Marcas { set; get; }
        public DbSet<Venta> Ventas { set; get; }
        public DbSet<TipoTransmision> TipoTransmisions { set; get; }
        public DbSet<TipoCombustible> TipoCombustibles { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Vehiculos

            modelBuilder.Entity<Vehiculo>()
                .ToTable("Vehiculo")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Vehiculo>()
                .Property(p => p.Id)
                .HasColumnName("VehiculoID");

            modelBuilder.Entity<Vehiculo>()
                .Property(p => p.Placa)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("varchar");

            modelBuilder.Entity<Vehiculo>()
                .Property(p => p.Anio)
                .HasMaxLength(4)
                .IsRequired()
                .HasColumnType("varchar");

            modelBuilder.Entity<Vehiculo>()
                .Property(p => p.CantidadPuertas)
                .IsRequired()
                .HasColumnType("int");

            modelBuilder.Entity<Vehiculo>()
                .Property(p => p.Color)
                .HasMaxLength(20)
                .IsRequired()
                .HasColumnType("varchar");

            modelBuilder.Entity<Vehiculo>()
                .Property(p => p.Chasis)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnType("varchar");

            #endregion

            #region Marca

            modelBuilder.Entity<Marca>()
                .ToTable("Marca")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Marca>()
                .Property(p => p.Id)
                .HasColumnName("MarcaID");

            modelBuilder.Entity<Marca>()
                .Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            #endregion

            #region Modelo

            modelBuilder.Entity<Modelo>()
                .ToTable("Modelo")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Modelo>()
                .Property(p => p.Id)
                .HasColumnName("ModeloID");

            modelBuilder.Entity<Modelo>()
                .Property(p => p.NombreModelo)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            #endregion

            #region Cliente

            modelBuilder.Entity<Cliente>()
                .ToTable("Cliente")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Cliente>()
                .Property(p => p.Id)
                .HasColumnName("ClienteID");

            modelBuilder.Entity<Cliente>()
                .Property(p => p.Nombre)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            modelBuilder.Entity<Cliente>()
                .Property(p => p.Telefono)
                .HasMaxLength(30)
                .HasColumnType("varchar")
                .IsOptional();
            

            modelBuilder.Entity<Cliente>()
                .Property(p => p.Direccion)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnType("varchar");

            #endregion


            #region TipoCombustible

            modelBuilder.Entity<TipoCombustible>()
                .ToTable("TipoCombustible")
                .HasKey(k => k.Id);

            modelBuilder.Entity<TipoCombustible>()
                .Property(p => p.Id)
                .HasColumnName("TipoCombustibleID");

            modelBuilder.Entity<TipoCombustible>()
                .Property(p => p.NombreCombustible)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            #endregion

            #region TipoTransmision

            modelBuilder.Entity<TipoTransmision>()
                .ToTable("TipoTransmision")
                .HasKey(k => k.Id);

            modelBuilder.Entity<TipoTransmision>()
                .Property(p => p.Id)
                .HasColumnName("TipoTransmisionID");

            modelBuilder.Entity<TipoTransmision>()
                .Property(p => p.NombreTransmision)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");

            #endregion

            modelBuilder.Entity<Venta>()
                .ToTable("Venta")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Venta>()
                .Property(p => p.MetodoPago)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar");
        }

    }
}
