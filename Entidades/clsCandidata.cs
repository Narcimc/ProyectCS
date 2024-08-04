using SIEleccionReina.Modelos;
using System;
using System.Collections.Generic;

namespace SIEleccionReina.Entidades
{
    internal class ClsCandidata : PersonaUG
    {
        #region "Atributos Privados"
        // Aclaracion: Los atributos y propiedades que aparentemente faltan aqui, en realidad si estan, pero ocultas por el polimorfismo, dado que ahora se hereda de la clase abstracta PersonaUG, la cual posee estros atributos y propiedades
        private string foto = "";
        private DateTime fecha_nacimiento;
        private int edad = 0;
        private string aspiraciones = "";
        private string intereses = "";
        private string habilidades = "";

        #endregion

        #region "Propiedades Publicas"

        public string Foto { get => foto; set => foto = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Aspiraciones { get => aspiraciones; set => aspiraciones = value; }
        public string Intereses { get => intereses; set => intereses = value; }
        public string Habilidades { get => habilidades; set => habilidades = value; }

        #endregion

        #region Constructor by Default

        public ClsCandidata() {}

        public ClsCandidata( int _idEstudiante, int _idCarrera, string _cedula, string _nombres, string _apellidos, int _semestre, string foto, DateTime fecha_nacimiento, int edad, string aspiraciones, string intereses, string habilidades ) : base( id: _idEstudiante, carreraId: _idCarrera, cedula: _cedula, nombres: _nombres, apellidos: _apellidos, semestre: _semestre )
        {
            this.foto = foto;
            this.fecha_nacimiento = fecha_nacimiento;
            this.edad = edad;
            this.aspiraciones = aspiraciones;
            this.intereses = intereses;
            this.habilidades = habilidades;
        }

        #endregion
    }
}
