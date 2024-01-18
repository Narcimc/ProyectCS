using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Entidades
{
    internal class clsCandidatas
    {
        #region "Atributos Privados"

        private int _id_candidata;
        private int _id_carrera;
        private int _id_semestre;
        private string _cedula;
        private string _nombre;
        private string _apellido;
        private string foto;
        private DateTime fecha_nacimiento;
        private int edad;
        private string aspiraciones;
        private string intereses;
        private string habilidades;



        #endregion
        #region "Propiedades Publicas"
        public int Id_candidata { get => _id_candidata; set => _id_candidata = value; }
        public int Id_carrera { get => _id_carrera; set => _id_carrera = value; }
        public int Id_semestre { get => _id_semestre; set => _id_semestre = value; }
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

    }
}
