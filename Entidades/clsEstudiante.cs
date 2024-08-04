using SIEleccionReina.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Entidades
{
    internal class ClsEstudiante : PersonaUG
    {
        #region  "Atributos Privados"
        // Aclaracion: Los atributos y propiedades que aparentemente faltan aqui, en realidad si estan, pero ocultas por el polimorfismo, dado que ahora se hereda de la clase abstracta PersonaUG, la cual posee estros atributos y propiedades
        private string _contrasenia;
        private decimal _idRolUsuario;

        #endregion

        #region "Propiedades Públicas"

        public string Contrasenia { get => _contrasenia; set => _contrasenia = value; }
        public decimal IdRolUsuario { get => _idRolUsuario; set => _idRolUsuario = value; }

        #endregion

        #region Constructor by Default

        public ClsEstudiante() {}

        #endregion

        #region Parameterized Constructors

        public ClsEstudiante( int idEstudiante, int idCarrera, string cedula, int semestre, string contrasenia, decimal id_rol_usuario, string nombres, string apellidos ) : base( id: idEstudiante, carreraId: idCarrera, cedula: cedula, nombres: nombres, apellidos: apellidos, semestre: semestre )
        {
            _contrasenia = contrasenia;
            _idRolUsuario = id_rol_usuario;
        }

        public ClsEstudiante( string cedula, string contrasenia, decimal id_rol_usuario ) : base ( cedula: cedula )
        {
            _contrasenia = contrasenia;
            _idRolUsuario = id_rol_usuario;
        }

        #endregion
    }
}
