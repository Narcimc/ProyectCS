﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Entidades
{
    internal class clsVoto
    {
        #region "Atributos Privados"

        private int _id_voto;
        private int _id_estudiante;
        private int _id_candidata;
        private string _tipo_voto;

        #endregion

        #region "Propiedades Públicas"

        public int Id_voto { get => _id_voto; set => _id_voto = value; }
        public int Id_estudiante { get => _id_estudiante; set => _id_estudiante = value; }
        public int Id_candidata { get => _id_candidata; set => _id_candidata = value; }
        public string Tipo_voto { get => _tipo_voto; set => _tipo_voto = value; }

        #endregion
    }
}
