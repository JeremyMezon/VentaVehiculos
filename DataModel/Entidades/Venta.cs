using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VentaVehiculos.DataModel.Entities
{
    [Table("Venta")]
    public class Venta: BaseEntity
    {
        public int ClienteId { get; set; }
        
        public virtual Cliente Cliente { get; set; }
        
        public int VehiculoId { get; set; }
        
        public virtual Vehiculo Vehiculo { get; set; }
        public string MetodoPago { get; set; }
        public int Precio { get; set; }
    }
}
