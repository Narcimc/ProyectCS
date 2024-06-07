using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Entidades
{
    internal class clsAlbum
    {
        #region "Atributos Privados"

        private int _id_album = 0;
        private int _id_candidata = 0;
        private string _titulo = "";

        #endregion

        #region "Propiedades Públicas"

        public int Id_album { get => _id_album; set => _id_album = value; }
        public int Id_candidata { get => _id_candidata; set => _id_candidata = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }

        #endregion

        #region Constructor by Default

        public clsAlbum() {}

        #endregion
    }
}
