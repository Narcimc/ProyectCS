using System;

namespace SIEleccionReina.Control
{
    /// <summary>
    /// General SIEleccionReina Exception that implements a required attribute and property for specialized exceptions which inherit from this one.
    /// Excepción General de SIEleccionReina que implementa un atributo y propiedad requerida para excepciones especializadas que hereden de esta.
    /// </summary>
    internal abstract class SIEleccionReinaException : Exception
    {
        private System.Windows.Forms.Control errorSourceControl = null;

        /// <summary>
        /// Gets the <c "System.Windows.Forms.Control"/> that caused the error.
        /// Devuelve el <c "System.Windows.Forms.Control"/> que causó el error.
        /// </summary>
        internal System.Windows.Forms.Control ErrorSourceControl => errorSourceControl;

        /// <summary>
        /// Initializes a new instance of the Exception with no arguments.
        /// Inicializa una nueva instancia de la Excepción sin parámetros.
        /// </summary>
        protected SIEleccionReinaException() {}

        /// <summary>
        /// Initializes a new instance of the Exception with a specified error message.
        /// Inicializa una nueva instancia de la Excepción con un mensaje de error especificado.
        /// </summary>
        /// <param name="exceptionMessage">The Message of that describes the error. El mensaje que describe el error.</param>
        protected SIEleccionReinaException( string errorMessage ) : base( message: errorMessage ) { }

        /// <summary>
        /// Initializes a new instance of the Exception with a specified error message and the <see langword="System.Windows.Forms.Control"/> component reference that caused the error, useful to set an <see langword="System.Windows.Forms.ErrorProvider"/> control on.
        /// Inicializa una nueva instancia de la Excepción con un mensaje de error especificado y la referencia del componente <see langword="System.Windows.Forms.Control"/> que causó el error, útil para establecer un control <see langword="System.Windows.Forms.ErrorProvider"/> sobre él.
        /// </summary>
        /// <param name="exceptionMessage">The Message of that describes the error. El mensaje que describe el error.</param>
        /// <param name="guiltyControl">The <see langword="System.Windows.Forms.Control"/> element that contains the value which caused the error. El elemento <see langword="System.Windows.Forms.Control"/> que contiene el valor que causó el error.</param>
        protected SIEleccionReinaException( string errorMessage, System.Windows.Forms.Control errorSourceControl ) : base( message: errorMessage ) 
            => this.errorSourceControl = errorSourceControl;
    }
}
