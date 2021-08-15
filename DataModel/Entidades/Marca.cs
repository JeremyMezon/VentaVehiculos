using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VentaVehiculos.DataModel.Entities
{
    public class Marca: BaseEntity
    {
        [Required]
        public string Nombre { get; set; }

        public List<Modelo> Modelos { get; set; }
    }
}
