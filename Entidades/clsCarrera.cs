using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Entidades
{
    internal class ClsCarrera
    {
        #region "Atributos Privados"

        private int _idCarrera;
        private string _nombreCarrera;

        #endregion

        #region "Propiedades Públicas"

        public int IdCarrera { get => _idCarrera; set => _idCarrera = value; }
        public string NombreCarrera { get => _nombreCarrera; set => _nombreCarrera = value; }

        #endregion

        #region Constructor Parametrizado
        
        public ClsCarrera( int idCarrera, string nombreCarrera )
        {
            _idCarrera = idCarrera;
            _nombreCarrera = nombreCarrera;
        }

        #endregion

    }
}
