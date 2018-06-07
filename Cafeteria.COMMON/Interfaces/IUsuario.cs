using Cafeteria.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cafeteria.COMMON.Interfaces
{
   public interface IUsuario : IGeneric<Usuario>
    {
        Usuario Login(string usuario, string pass);
        Usuario CrearCuenta(string usuario, string pass);
    }
}
