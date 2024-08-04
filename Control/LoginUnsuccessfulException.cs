namespace SIEleccionReina.Control
{
    /// <summary>
    /// The Exception that is thown when the login on the application was unsuccessful, this because the user or 
    /// the password, or the user type role, at least one of these, does not exist in the Database, is incorrect or it is not valid.
    /// La Excepción que es lanzada cuando el inicio de sesión en la aplicación no fue exitoso, esto es porque el usuario o 
    /// la contraseña, o el rol del tipo de usuario, al menos uno de estos, no existe en la Base de Datos, es incorrecto o no es válido.
    /// </summary>
    internal class LoginUnsuccessfulException : SIEleccionReinaException
    {
        /// <summary>
        /// Initializes a new instance of the Exception with no arguments.
        /// Inicializa una nueva instancia de la Excepción sin parámetros.
        /// </summary>
        public LoginUnsuccessfulException() { }

        /// <summary>
        /// Initializes a new instance of the Exception with a specified error message.
        /// Inicializa una nueva instancia de la Excepción con un mensaje de error especificado.
        /// </summary>
        /// <param name="exceptionMessage">The Message of that describes the error. El mensaje que describe el error.</param>
        public LoginUnsuccessfulException( string exceptionMessage ) : base( errorMessage: exceptionMessage ) { }

        /// <summary>
        /// Initializes a new instance of the Exception with a specified error message and the <see langword="System.Windows.Forms.Control"/> component reference that caused the error, useful to set an <see langword="System.Windows.Forms.ErrorProvider"/> control on.
        /// Inicializa una nueva instancia de la Excepción con un mensaje de error especificado y la referencia del componente <see langword="System.Windows.Forms.Control"/> que causó el error, útil para establecer un control <see langword="System.Windows.Forms.ErrorProvider"/> sobre él.
        /// </summary>
        /// <param name="exceptionMessage">The Message of that describes the error. El mensaje que describe el error.</param>
        /// <param name="errorOnControl">The <see langword="System.Windows.Forms.Control"/> element that contains the value which caused the error. El elemento <see langword="System.Windows.Forms.Control"/> que contiene el valor que causó el error.</param>
        public LoginUnsuccessfulException( string exceptionMessage, System.Windows.Forms.Control errorOnControl ) : base( errorMessage: exceptionMessage, errorSourceControl: errorOnControl ) { }
    }
}
