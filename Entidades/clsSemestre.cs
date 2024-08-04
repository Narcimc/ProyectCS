using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Entidades
{
    [Obsolete( "DEPRECATED: Esta clase está actualmente Obsoleta y ha sido marcada para ser eliminada en una próxima iteración, " +
        "por favor evite su uso, y el de cualquiera de sus métodos, dado que actualmente carece de propósito y ya no existen los " +
        "medios en la Base de Datos para poder usarla, por lo tanto su intento de uso dará como resultado un error.", true )]
    internal class ClsSemestre
    {
        #region "Atributos Privados"

        private int _id_semestre;
        private string _numero_semestre;

        #endregion
        #region "Propiedades Públicas"

        public int Id_semestre { get => _id_semestre; set => _id_semestre = value; }
        public string Numero_semestre { get => _numero_semestre; set => _numero_semestre = value; }

        #endregion
    }
}
