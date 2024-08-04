namespace SIEleccionReina.Control
{
    /// <summary>
    /// The Exception that is thown when a given value is not valid, due to it does not fit the requirements 
    /// or the format of its destiny member.
    /// La Excepción que es lanzada cuando un valor dado no es válido, debido a que no cumple los requerimientos 
    /// o el formato de su miembro de destino.
    /// </summary>
    internal class InvalidValueException : SIEleccionReinaException
    {
        /// <summary>
        /// Initializes a new instance of the Exception with no arguments.
        /// Inicializa una nueva instancia de la Excepción sin parámetros.
        /// </summary>
        public InvalidValueException() { }

        /// <summary>
        /// Initializes a new instance of the Exception with a specified error message.
        /// Inicializa una nueva instancia de la Excepción con un mensaje de error especificado.
        /// </summary>
        /// <param name="exceptionMessage">The Message of that describes the error. El mensaje que describe el error.</param>
        public InvalidValueException( string exceptionMessage ) : base( errorMessage: exceptionMessage ) { }

        /// <summary>
        /// Initializes a new instance of the Exception with a specified error message and the <see langword="System.Windows.Forms.Control"/> component reference that caused the error, useful to set an <see langword="System.Windows.Forms.ErrorProvider"/> control on.
        /// Inicializa una nueva instancia de la Excepción con un mensaje de error especificado y la referencia del componente <see langword="System.Windows.Forms.Control"/> que causó el error, útil para establecer un control <see langword="System.Windows.Forms.ErrorProvider"/> sobre él.
        /// </summary>
        /// <param name="exceptionMessage">The Message of that describes the error. El mensaje que describe el error.</param>
        /// <param name="errorOnControl">The <see langword="System.Windows.Forms.Control"/> element that contains the value which caused the error. El elemento <see langword="System.Windows.Forms.Control"/> que contiene el valor que causó el error.</param>
        public InvalidValueException( string exceptionMessage, System.Windows.Forms.Control errorOnControl ) : base( errorMessage: exceptionMessage, errorSourceControl: errorOnControl ) { }
    }
}
