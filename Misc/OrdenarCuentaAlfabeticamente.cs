using System;
using System.Collections.Generic;

namespace Misc
{
    /// <summary>
    /// Metodo de ordenamiento alfabetico por nombre de usuario, 
    /// </summary>
    public class OrdenarCuentaAlfabeticamente : IComparer<CuentaDTO>
    {
        public int Compare (CuentaDTOx, CuentaDTO y)
        {
            return (x.Usuario.CompareTo(y.Usuario));
        }
    }
}