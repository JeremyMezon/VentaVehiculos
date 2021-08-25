using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VentaVehiculos.DataModel.Entities
{
    public class Modelo: BaseEntity
    {
        public string Nombre { get; set; }
        public int MarcaId { get; set; }
        public virtual Marca Marca { get; set; }
        
        public virtual List<Vehiculo> Vehiculos { get; set; }
    }
}
