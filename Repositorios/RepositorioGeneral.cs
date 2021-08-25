using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaVehiculos.DataModel.Context;
using VentaVehiculos.DataModel.Entities;
using VentaVehiculos.Interfaces;

namespace VentaVehiculos.Repositorios
{
    class RepositorioGeneral<T>:IRepositorioGeneral<T> where T: BaseEntity
    {
        private VentaDbContext dbContext;
        private DbSet<T> _set;

        public RepositorioGeneral()
        {
            //Configuracion para utilizar el 3er metodo
            dbContext = new VentaDbContext();
            _set = dbContext.Set<T>();
        }

        public ResultadoOperacion Crear(T entidad)
        {
            _set.Add(entidad);
            dbContext.SaveChanges();
            return new ResultadoOperacion()
            {
                Success = true,
                Message = "Datos Guardados Correctamente"
            };
        }
        public List<T> GetAll()
        {

            if (_set.Any())
            {
                return _set.Where(x => x.Borrado == false && x.Estatus != "IN").ToList();
            }

            return null;
        }
        public T FIndById(int ID)
        {
            return _set.FirstOrDefault(x => x.Id == ID);
        }
        public ResultadoOperacion Modificar(T entidad)
        {
            dbContext.Entry(entidad).State = EntityState.Modified;
            dbContext.SaveChanges();
            return new ResultadoOperacion()
            {
                Success = true
            };
        }
        public ResultadoOperacion Eliminar(T entidad)
        {
            entidad.Borrado = true;

            dbContext.Entry(entidad).State = EntityState.Modified;
            dbContext.SaveChanges();

            return new ResultadoOperacion()
            {
                Success = true,
                Message = "Datos Eliminados Correctamente"
            };
        }
    }
}
