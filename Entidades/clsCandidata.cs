using System;
using System.Collections.Generic;

namespace SIEleccionReina.Entidades
{
    internal class clsCandidata
    {
        #region "Atributos Privados"

        private int _id_candidata = 0;
        private KeyValuePair<int, string> _carrera;
        private KeyValuePair<int, int> _semestre;
        private string _cedula = "";
        private string _nombre = "";
        private string _apellido = "";
        private string foto = "";
        private DateTime fecha_nacimiento;
        private int edad = 0;
        private string aspiraciones = "";
        private string intereses = "";
        private string habilidades = "";

        #endregion

        #region "Propiedades Publicas"

        public int Id_candidata { get => _id_candidata; set => _id_candidata = value; }
        public KeyValuePair<int, string> Carrera { get => _carrera; set => _carrera = value; }
        public KeyValuePair<int, int> Semestre { get => _semestre; set => _semestre = value; }
        public string Cedula { get => _cedula; set => _cedula = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Foto { get => foto; set => foto = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Aspiraciones { get => aspiraciones; set => aspiraciones = value; }
        public string Intereses { get => intereses; set => intereses = value; }
        public string Habilidades { get => habilidades; set => habilidades = value; }

        #endregion

        #region Constructor by Default

        public clsCandidata() {}

        #endregion
    }
}
