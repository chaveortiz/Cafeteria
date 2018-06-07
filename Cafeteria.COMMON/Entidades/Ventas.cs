using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria.COMMON.Entidades
{
   public class Ventas: BaseDTO
    {
        public string Nombre { get; set; }
        public DateTime fecha { get; set; }
        public ObjectId IdProducto { get; set; }
        public override string ToString()
        {
            return Nombre + ": " + fecha;
        }
    }
  
        
    
}
   