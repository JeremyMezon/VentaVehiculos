using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VentaVehiculos.DataModel.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "BIT")]
        public bool Borrado { get; set; }
        [Required]
        [Column(TypeName = "Varchar")]
        [StringLength(2)]
        public string Estatus { get; set; }
        [Required]
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }
}
