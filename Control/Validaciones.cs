using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Control
{
    internal static class Validaciones
    {
        internal static bool IsNullOrEmptyOrWhitespace( string str ) => String.IsNullOrEmpty( str ) || String.IsNullOrWhiteSpace( str );
    }
}
