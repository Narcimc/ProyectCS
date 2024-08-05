namespace SIEleccionReina.Modelos
{
    internal abstract class PersonaUG
    {
        #region Atributos Privados

        private int id;
        private int carreraId;
        private string cedula;
        private string nombres;
        private string apellidos;
        private int semestre;
        private string primerNombre;
        private string segundoNombre;

        #endregion

        #region Propiedades Públicas

        public int Id { get => id; set => id = value; }
        public int CarreraId { get => carreraId; set => carreraId = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombres 
        { 
            get => nombres; 
            set
            { 
                nombres = value;
                SepararNombres( nombres: value );
            } 
        }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Semestre { get => semestre; set => semestre = value; }
        public string PrimerNombre { get => primerNombre; }
        public string SegundoNombre { get => segundoNombre; }

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
            primerNombre = nombresObtenidos[ 0 ];

            if( nombresObtenidos.Length > 1 )
                segundoNombre = nombresObtenidos[ 1 ];
        }
    }
}
