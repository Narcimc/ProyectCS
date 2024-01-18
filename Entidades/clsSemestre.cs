using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Entidades
{
    internal class clsSemestre
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
