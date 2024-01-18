using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Entidades
{
    internal class clsFoto
    {
        #region "Atributos Privados"

        private int _id_foto;
        private string foto_Album;
        private int _id_album;
        private string _titulo_foto;
        private string _descripcion;
        private string _comentario;

        #endregion

        #region "Propiedades Públicas"

        public int Id_foto { get => _id_foto; set => _id_foto = value; }
        public int Id_album { get => _id_album; set => _id_album = value; }
        public string Titulo_foto { get => _titulo_foto; set => _titulo_foto = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public string Foto_Album { get => foto_Album; set => foto_Album = value; }
        public string Comentario { get => _comentario; set => _comentario = value; }

        #endregion

    }
}
