using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria.COMMON.Entidades
{
   public class Productos : BaseDTO
    {
        public string Nombre { get; set; }
        public int precio { get; set; }
        public ObjectId IdUsuario { get; set; }
        public override string ToString()
        {
            return Nombre + ": " + precio;
        }
    }
}

