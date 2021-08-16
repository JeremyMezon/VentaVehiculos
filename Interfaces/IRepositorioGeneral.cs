using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaVehiculos.Interfaces
{
    interface IRepositorioGeneral<T>
    {
        T Crear(T cliente);
        List<T> GetAll();
        T FIndById(int ID);
        ResultadoOperacion Modificar(T cliente);
        ResultadoOperacion Eliminar(T cliente);
    }
}
