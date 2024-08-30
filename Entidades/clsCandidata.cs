using SIEleccionReina.Modelos;
using System;
using System.Collections.Generic;

namespace SIEleccionReina.Entidades
{
    internal class ClsCandidata : PersonaUG
    {
        #region "Atributos Privados"

        // Aclaracion: Los atributos y propiedades que aparentemente faltan aqui, en realidad si estan, pero ocultas por el polimorfismo, dado que ahora se hereda de la clase abstracta PersonaUG, la cual posee estros atributos y propiedades
        private string _foto = "";
        private DateTime _fecha_nacimiento;
        private int _edad = 0;
        private string _aspiraciones = "";
        private string _intereses = "";
        private string _habilidades = "";

        #endregion

        #region "Propiedades Publicas"

        internal string Foto { get => _foto; set => _foto = value; }
        internal DateTime Fecha_nacimiento { get => _fecha_nacimiento; set => _fecha_nacimiento = value; }
        internal int Edad { get => _edad; set => _edad = value; }
        internal string Aspiraciones { get => _aspiraciones; set => _aspiraciones = value; }
        internal string Intereses { get => _intereses; set => _intereses = value; }
        internal string Habilidades { get => _habilidades; set => _habilidades = value; }

        #endregion

        #region Constructor by Default

        public ClsCandidata() {}
        // Se envia al superconstructor 'base' los parametros de la superclase o clase padre de la cual se hereda para setear los atributos generales que hereda esta clase de PersonaUG
        public ClsCandidata( int idCandidata, int idCarrera, string cedula, string nombres, string apellidos, int semestre, string foto, DateTime fecha_nacimiento, int edad, string aspiraciones, string intereses, string habilidades ) : base( id: idCandidata, carreraId: idCarrera, cedula: cedula, nombres: nombres, apellidos: apellidos, semestre: semestre )
        {
            _foto = foto;
            _fecha_nacimiento = fecha_nacimiento;
            _edad = edad;
            _aspiraciones = aspiraciones;
            _intereses = intereses;
            _habilidades = habilidades;
        }

        #endregion
    }
}
