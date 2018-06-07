using Cafeteria.COMMON.Entidades;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria.COMMON.Interfaces
{
   public interface IProducto : IGeneric<Productos>
    {
        List<Productos> ProductosExistentes(ObjectId idUsuario);
    }
}
