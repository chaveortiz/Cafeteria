using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria.COMMON.Entidades
{
    public class Usuario : BaseDTO
    {
        public string Nombre { get; set; }
        public string Password { get; set; }
    }
}
