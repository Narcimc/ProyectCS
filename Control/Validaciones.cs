using System;
using System.Linq;

namespace SIEleccionReina.Control
{
    internal static class Validaciones
    {
        private static bool IsNullOrEmptyOrWhitespace( string str ) => String.IsNullOrEmpty( str ) || String.IsNullOrWhiteSpace( str );
        private static bool IsLetterOrWhitespace( string str ) => str.All<char>( c => char.IsLetter( c ) || char.IsWhiteSpace( c ) );
        private static bool IsLetterOrWhitespaceOrPunctuation( string str ) => str.All<char>( c => char.IsLetter( c ) || char.IsWhiteSpace( c ) || char.IsPunctuation( c ) );

        /// <summary>
        /// Evaluates if the specified id <c>userCedula</c>, which corresponds to the username, is or not valid.
        /// Evalúa si la cédula especificada <c>userCedula</c>, la cual corresponde al nombre de usuario, es o no válida.
        /// </summary>
        /// <param name="userCedula">User's username id. Cédula nombre de usuario del Usuario.</param>
        /// <param name="cedulaControl"><c>System.Windows.Forms.Control</c> Component which caused the error. Componente <c>System.Windows.Forms.Control</c> que causó el error.</param>
        /// <exception cref="InvalidValueException">
        /// Thrown when the specified parameter <paramref name="userCedula"/> does not have 10 digits.
        /// Lanzada cuando el parametro especificado <paramref name="userCedula"/> no tiene 10 dígitos.
        /// </exception>
        /// <returns>
        /// True if valid, False otherwise.
        /// True si es válida, False de no serlo.
        /// </returns>
        internal static bool IsUserCedulaValid( System.Windows.Forms.Control cedulaControl ) 
        { 
            if ( cedulaControl.Text.Length != 10 || cedulaControl.Text.Any( char.IsWhiteSpace ) )
                throw new InvalidValueException( exceptionMessage: "El campo de usuario, que corresponde a su número de Cédula de Identidad, debe contener exactamente 10 dígitos numéricos sin espacios, verifique nuevamente por favor.", errorOnControl: cedulaControl );

            return true;
        }

        internal static bool IsPasswordValid( System.Windows.Forms.Control passwordControl )
        {
            if ( IsNullOrEmptyOrWhitespace( passwordControl.Text ) )
                throw new InvalidValueException( exceptionMessage: "Su Contraseña " + CommonUtils.Messages.NULL_EMPTY_MSJ_FEM, errorOnControl: passwordControl );

            return true;
        }

        internal static bool IsPasswordConfirmationValid( string password, System.Windows.Forms.Control passwordConfirmationControl )
        {
            if ( !String.Equals( password, passwordConfirmationControl.Text ) )
                throw new InvalidValueException( exceptionMessage: "Las contraseñas no coinciden, por favor verifique nuevamente.", errorOnControl: passwordConfirmationControl );

            return true;
        }

        internal static bool IsNameLastNameValid( System.Windows.Forms.Control nameLastNameControl ) 
        {
            if ( IsNullOrEmptyOrWhitespace( nameLastNameControl.Text.Trim() ) )
                throw new InvalidValueException( exceptionMessage: "El campo de nombres y apellidos " + CommonUtils.Messages.NULL_EMPTY_MSJ_FEM, errorOnControl: nameLastNameControl );

            if( !IsLetterOrWhitespace( nameLastNameControl.Text.Trim() ) )
                throw new InvalidValueException( exceptionMessage: "El campo de nombres y apellidos solo puede contener letras, verifique nuevamente por favor.", errorOnControl: nameLastNameControl );

            return true;
        }

        internal static bool IsInteresesAspiracionesHabilidadesValid( System.Windows.Forms.Control interAspHabControl )
        {
            if ( IsNullOrEmptyOrWhitespace( interAspHabControl.Text.Trim() ) )
                throw new InvalidValueException( exceptionMessage: "Los campos de intereses, aspiraciones y habilidades " + CommonUtils.Messages.NULL_EMPTY_MSJ_FEM, errorOnControl: interAspHabControl );

            if ( !IsLetterOrWhitespaceOrPunctuation( interAspHabControl.Text.Trim() ) )
                throw new InvalidValueException( exceptionMessage: "Los campos de intereses, aspiraciones y habilidades, solo puede contener letras, verifique nuevamente por favor.", errorOnControl: interAspHabControl );

            return true;
        }

        internal static bool IsCarreraValid( System.Windows.Forms.Control carreraControl )
        {
            if ( IsNullOrEmptyOrWhitespace( carreraControl.Text ) )
                throw new InvalidValueException( exceptionMessage: "La Carrera debe tener un nombre, " + CommonUtils.Messages.NULL_EMPTY_MSJ_FEM, errorOnControl: carreraControl );

            if ( carreraControl.Text.Trim().StartsWith( "Seleccion" ) )
                throw new InvalidValueException( exceptionMessage: "Seleccione una carrera valida de la lista, verifique nuevamente por favor.", errorOnControl: carreraControl );

            if ( !IsLetterOrWhitespace( carreraControl.Text.Trim() ) )
                throw new InvalidValueException( exceptionMessage: "La Carrera solo puede contener letras, sin signos de puntuación ni símbolos, verifique nuevamente por favor.", errorOnControl: carreraControl );

            return true;
        }

        internal static bool IsFotoDataValid( System.Windows.Forms.Control fotoControl ) 
        {
            if ( IsNullOrEmptyOrWhitespace( fotoControl.Text ) )
                throw new InvalidValueException( exceptionMessage: "El Título o la Descripción de la Foto " + CommonUtils.Messages.NULL_EMPTY_MSJ_FEM, errorOnControl: fotoControl );

            if( fotoControl.Name.Contains( "Titulo" ) )
            {
                if ( !IsLetterOrWhitespace( fotoControl.Text.Trim() ) )
                    throw new InvalidValueException( exceptionMessage: "El Título de la Foto solo puede contener letras, sin signos de puntuación ni símbolos, verifique nuevamente por favor.", errorOnControl: fotoControl );
            }
            else
                if ( !IsLetterOrWhitespaceOrPunctuation( fotoControl.Text.Trim() ) )
                throw new InvalidValueException( exceptionMessage: "La Descripción de la Foto solo pueden contener letras y signos de puntuación, verifique nuevamente por favor.", errorOnControl: fotoControl );

            return true;
        }
    }
}
