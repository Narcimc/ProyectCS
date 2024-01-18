using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Entidades
{
    internal class ClsEstudiante
    {
        #region  "Atributos Privados"

        private int _id_estudiante;
        private int _id_semestre;
        private int _id_carrera;
        private string _cedula;
        private string _contrasenia;
        private string _rol_usuario;



        #endregion


        #region "Propiedades Públicas"

        public int Id_estudiante { get => _id_estudiante; set => _id_estudiante = value; }
        public int Id_semestre { get => _id_semestre; set => _id_semestre = value; }
        public int Id_carrera { get => _id_carrera; set => _id_carrera = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public string Rol_usuario { get => _rol_usuario; set => _rol_usuario = value; }


        #endregion
    }
}
