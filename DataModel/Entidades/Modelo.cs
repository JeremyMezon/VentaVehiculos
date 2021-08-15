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
        [Required]
        public string Nombre { get; set; }
        [Required]
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        

        public List<Vehiculo> Vehiculos { get; set; }
    }
}
