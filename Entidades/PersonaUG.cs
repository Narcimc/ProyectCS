using SIEleccionReina.Control;

namespace SIEleccionReina.Modelos
{
    internal abstract class PersonaUG
    {
        #region Atributos Privados

        private int id = 0;
        private int carreraId = 0;
        private string cedula = "";
        private string nombres = "";
        private string apellidos = "";
        private int semestre = 0;
        private string primerNombre = "";
        private string segundoNombre = "";

        #endregion

        #region Propiedades Públicas

        internal int Id { get => id; set => id = value; }
        internal int CarreraId { get => carreraId; set => carreraId = value; }
        internal string Cedula { get => cedula; set => cedula = value; }
        internal string Nombres 
        { 
            get => nombres; 
            set
            {
                nombres = value;
                SepararNombres( nombres: value );
            } 
        }
        internal string Apellidos { get => apellidos; set => apellidos = value; }
        internal int Semestre { get => semestre; set => semestre = value; }
        internal string PrimerNombre { get => primerNombre; }
        internal string SegundoNombre { get => segundoNombre; }

        #endregion

        // * Constructor por Defecto
        protected PersonaUG() { }

        // * Constructores Parametrizados
        protected PersonaUG( int id, int carreraId, string cedula, string nombres, string apellidos, int semestre )
        {
            this.id = id;
            this.carreraId = carreraId;
            this.cedula = cedula;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.semestre = semestre;
            SepararNombres( nombres );
        }

        protected PersonaUG( string cedula ) => this.cedula = cedula;

        // *** Métodos de la clase abstracta

        private void SepararNombres( string nombres )
        {
            string[] nombresObtenidos = nombres.Split( new char[] { ' ' }, System.StringSplitOptions.RemoveEmptyEntries );
            
            if ( nombresObtenidos.Length > 0 )
                primerNombre = nombresObtenidos[ 0 ];

            if( nombresObtenidos.Length > 1 )
                segundoNombre = nombresObtenidos[ 1 ];
        }

        internal void LimpiarPrimerSegundoNombre() 
        {
            primerNombre = "";
            segundoNombre = "";
        }
    }
}
