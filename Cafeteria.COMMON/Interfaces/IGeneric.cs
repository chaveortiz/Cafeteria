using Cafeteria.COMMON.Entidades;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria.COMMON.Interfaces
{
   public interface IGeneric<T> where T : BaseDTO
    {
        T Agregar(T entidad);
        T Modificar(T entidad);
        bool Eliminar(ObjectId id);
        List<T> ListarElementos { get; set; }
        T ObtenerElementoPorId(ObjectId id);
    
    }
}
