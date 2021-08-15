using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VentaVehiculos.DataModel.Entities
{
    public class Venta: BaseEntity
    {
        [Required]
        public int ClienteId { get; set; }
        [Required]
        public Cliente Cliente { get; set; }
        [Required]
        public int VehiculoId { get; set; }
        [Required]
        public Vehiculo Vehiculo { get; set; }
        [Required]
        public Vehiculo MetodoPago { get; set; }
        [Required]
        public int Precio { get; set; }
    }
}
