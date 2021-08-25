using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VentaVehiculos.DataModel.Entities
{
   public  class TipoCombustible: BaseEntity
    {
        public string NombreCombustible { get; set; }

        public virtual List<Vehiculo> Vehiculos { get; set; }

    }
}
