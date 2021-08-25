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
        public int? TipoTransmisionId { get; set; }
        public virtual TipoTransmision TipoTransmision { get; set; }
        public int? TipoCombustibleId { get; set; }
        public virtual TipoCombustible TipoCombustible { get; set; }
        public string Placa { get; set; }
        public string Chasis { get; set; }
        public string Anio { get; set; }
        public string Color { get; set; }
        public string Cilindraje { get; set; }
        public string KilometrosTablero { get; set; }
        public int Precio { get; set; }
        public int? ModeloId { get; set; }
        public virtual Modelo Modelo { get; set; }
        public string Kilometraje { get; set; }
        public int CantidadPuertas { get; set; }


    }
}
