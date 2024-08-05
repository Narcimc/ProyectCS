using SIEleccionReina.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.Control
{
    internal static class Validaciones
    {
        internal static bool IsNullOrEmptyOrWhitespace( string str ) => String.IsNullOrEmpty( str ) || String.IsNullOrWhiteSpace( str );

        /// <summary>
        /// Evaluates if the specified id <c>userCedula</c>, which corresponds to the username, is or not valid.
        /// Evalúa si la cédula especificada <c>userCedula</c>, la cual corresponde al nombre de usuario, es o no válida.
        /// </summary>
        /// <param name="userCedula">User's username id. Cédula nombre de usuario del Usuario.</param>
        /// <param name="exControl">Component <c>System.Windows.Forms.Control</c> which caused the error. Componente <c>System.Windows.Forms.Control</c> que causó el error.</param>
        /// <exception cref="InvalidValueException">
        /// Thrown when the specified parameter <paramref name="userCedula"/> does not have 10 digits.
        /// Lanzada cuando el parametro especificado <paramref name="userCedula"/> no tiene 10 dígitos.
        /// </exception>
        /// <returns>
        /// A <see cref="bool"/> value indicating if the specified parameter <c>userCedula</c> is or not valid, true if valid, false otherwise.
        /// Un valor <see cref="bool"/> indicando si el parámetro especificado <c>userCedula</c> es o no válido, true si es válido, false de no serlo.
        /// </returns>
        internal static bool IsUserCedulaValid( string userCedula, System.Windows.Forms.Control exControl ) 
        { 
            if ( userCedula.Length != 10 || userCedula.Any( char.IsWhiteSpace ) )
                throw new InvalidValueException( exceptionMessage: "El campo de usuario, que corresponde a su número de Cédula de Identidad, debe contener exactamente 10 dígitos numéricos sin espacios, verifique nuevamente por favor.", errorOnControl: exControl );

            return true;
        }

        internal static bool IsPasswordValid( string password, System.Windows.Forms.Control exControl )
        {
            if ( IsNullOrEmptyOrWhitespace( password ) )
                throw new InvalidValueException( exceptionMessage: "Su Contraseña " + CommonUtils.Messages.NULL_EMPTY_MSJ_FEM, errorOnControl: exControl );

            return true;
        }

        internal static bool IsPasswordConfirmationValid( string password,  string passwordConfirmation, System.Windows.Forms.Control exControl )
        {
            if ( !String.Equals( password, passwordConfirmation ) )
                throw new InvalidValueException( exceptionMessage: "Las contraseñas no coinciden, por favor verifique nuevamente.", errorOnControl: exControl );

            return true;
        }

        internal static bool IsNameLastNameValid( string nameLastName, System.Windows.Forms.Control exControl ) 
        {
            if ( IsNullOrEmptyOrWhitespace( nameLastName ) )
                throw new InvalidValueException( exceptionMessage: "El campo de nombres y apellidos " + CommonUtils.Messages.NULL_EMPTY_MSJ_FEM, errorOnControl: exControl );

            if( !nameLastName.All<char>( c => char.IsLetter( c ) || char.IsWhiteSpace( c ) ) )
                throw new InvalidValueException( exceptionMessage: "El campo de nombres y apellidos solo puede contener letras, verifique nuevamente por favor.", errorOnControl: exControl );

            return true;
        }

        internal static bool IsInteresesAspiracionesHabilidadesValid( string interAspHab, System.Windows.Forms.Control exControl )
        {
            if ( IsNullOrEmptyOrWhitespace( interAspHab ) )
                throw new InvalidValueException( exceptionMessage: "Los campos de intereses, aspiraciones y habilidades " + CommonUtils.Messages.NULL_EMPTY_MSJ_FEM, errorOnControl: exControl );

            if ( !interAspHab.All<char>( c => char.IsLetter( c ) || char.IsWhiteSpace( c ) ) )
                throw new InvalidValueException( exceptionMessage: "Los campos de intereses, aspiraciones y habilidades, solo puede contener letras, verifique nuevamente por favor.", errorOnControl: exControl );

            return true;
        }

        internal static bool IsCarreraValid( string carrera, System.Windows.Forms.Control exControl )
        {
            if ( IsNullOrEmptyOrWhitespace( carrera ) )
                throw new InvalidValueException( exceptionMessage: "La Carrera debe tener un nombre, " + CommonUtils.Messages.NULL_EMPTY_MSJ_FEM, errorOnControl: exControl );

            if ( carrera.StartsWith( "Selecciona" ) )
                throw new InvalidValueException( exceptionMessage: "Seleccione una carrera valida de la lista, verifique nuevamente por favor.", errorOnControl: exControl );

            return true;
        }



    }
}
