using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VentaVehiculos.DataModel.Entities
{
    public class Vehiculo: BaseEntity
    {
        [Required]
        public string TipoTransmisionId { get; set; }
        [Required]
        public TipoTransmision TipoTransmision { get; set; }
        [Required]
        public string TipoCombustibleId { get; set; }
        [Required]
        public TipoCombustible TipoCombustible { get; set; }
        [Required]
        public string Placa { get; set; }
        [Required]
        public string Chasis { get; set; }
        [Required]
        public int Anio { get; set; }
        [Required]
        public int Color { get; set; }
        [Required]
        public int Cilindraje { get; set; }
        [Required]
        public int KilometrosTablero { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        public int ModeloId { get; set; }
        public Modelo Modelo { get; set; }
        [Required]
        public string Kilometraje { get; set; }
        [Required]
        public int CantidadPuertas { get; set; }


    }
}
