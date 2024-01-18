using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Entidades
{
    internal class clsCarrera
    {
        #region "Atributos Privados"

        private int _id_carrera;
        private string _nombre_carrera;

        #endregion



        #region "Propiedades Públicas"

        public int Id_carrera { get => _id_carrera; set => _id_carrera = value; }
        public string Nombre_carrera { get => _nombre_carrera; set => _nombre_carrera = value; }

        #endregion
    }
}
