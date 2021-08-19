﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace VentaVehiculos.DataModel.Entities
{
   public class Cliente: BaseEntity
    {
        public string Nombre { get; set; }
        
        public string Apellido { get; set; }
        
        public string Telefono { get; set; }
        
        public string Direccion { get; set; }
        
        public string Correo { get; set; }
        
        public string Cedula { get; set; }





    }
}
