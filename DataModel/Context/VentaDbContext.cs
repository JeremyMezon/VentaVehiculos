using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

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
        public DbSet<TipoTransimision> TipoTransimisions { set; get; }
        public DbSet<TipoCombustible> TipoCombustibles { set; get; }
    }
}
