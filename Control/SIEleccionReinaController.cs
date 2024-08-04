using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Entidades;
using SIEleccionReina.Formularios;
using SIEleccionReina.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SIEleccionReina.Control
{
    internal sealed class SIEleccionReinaController
    {
        //***** Objetos de Instancia de otras clases
        private ClsEstudiante_DB estudiante_DB;
        private ClsVoto_DB voto_DB;
        private ClsCandidata_DB candidata_DB;
        private ClsCarrera_DB carrera_DB;

        //***** Objeto de Sesión del Usuario logueado
        private ClsEstudiante _estudianteLogueado;
        internal ClsEstudiante EstudianteLogueado { get => _estudianteLogueado; }

        //***** Atributos y Propiedades generales
        private bool _estudianteVotoReinaYaRegistrado = false;
        private bool _estudianteVotoFotogeniaYaRegistrado = false;

        public bool EstudianteVotoReinaYaRegistrado { get => _estudianteVotoReinaYaRegistrado; set => _estudianteVotoReinaYaRegistrado = value; }
        public bool EstudianteVotoFotogeniaYaRegistrado { get => _estudianteVotoFotogeniaYaRegistrado; set => _estudianteVotoFotogeniaYaRegistrado = value; }

        private List<ClsCandidata> _listaCandidatas;
        public List<ClsCandidata> ListaCandidatas { get => _listaCandidatas; }

        private Dictionary<int, string> _carrerasDisponibles;
        public Dictionary<int, string> CarrerasDisponibles { get => _carrerasDisponibles; }


        //***** Singleton Pattern using a Lazy approach
        private static readonly Lazy<SIEleccionReinaController> lazy = new Lazy<SIEleccionReinaController>( () => new SIEleccionReinaController() );
        public static SIEleccionReinaController Instance { get { return lazy.Value; } }
        private SIEleccionReinaController() // Private Constructor
        { 
            estudiante_DB = new ClsEstudiante_DB();
            voto_DB = new ClsVoto_DB();
            candidata_DB = new ClsCandidata_DB();
            carrera_DB = new ClsCarrera_DB();
            _listaCandidatas = new List<ClsCandidata>();
            _carrerasDisponibles = new Dictionary<int, string>();
        }

        //***** Métodos

        // * Métodos más Generales

        internal void ObtenerCarreras() 
        {
            DataTable carrerasDt = new DataTable();
            carrerasDt = carrera_DB.Obtener_Carreras( tipoCrud: CarreraTipoCrud.ConsultaTodasCarreras );

            foreach ( DataRow row in carrerasDt.Rows )
            {
                _carrerasDisponibles.Add( ( int ) row[ "id_carrera" ], ( string ) row[ "nombre_carrera" ] );
            }
        }

        // * Métodos relacionados con la Sesión y Registro de Estudiante y Candidata

        internal bool ValidarLogin( string usuario, string pwd, decimal userType, System.Windows.Forms.Control exControl ) 
        {
            ClsEstudiante estudianteObj = new ClsEstudiante( cedula: usuario, contrasenia: pwd, id_rol_usuario: userType );
            System.Data.DataTable tablaDatosValidacionUsuario = new System.Data.DataTable();
            tablaDatosValidacionUsuario = estudiante_DB.ValidarLogin( estudianteObj, EstudianteTipoCRUD.ValidarLoginUsuario ); // Validar Usuario y Contraseña

            if ( tablaDatosValidacionUsuario != null && tablaDatosValidacionUsuario.Rows.Count > 0 )
            {
                RegistrarEstudianteLogueado( datosEstudiante: tablaDatosValidacionUsuario );
                VerificarVotosRegistradosEstudiante();
                ObtenerCandidatas();
                return true;
            }
            else
                throw new LoginUnsuccessfulException( exceptionMessage: "Usuario, contraseña y/o Tipo de Usuario no válidos, los tres datos deben ser correctos, verifique nuevamente por favor.", errorOnControl: exControl );
        }

        internal void RegistrarEstudianteLogueado( DataTable datosEstudiante )
        {
            _estudianteLogueado = new ClsEstudiante()
            {
                Id = ( int ) datosEstudiante.Rows[ 0 ][ "id_estudiante" ],
                CarreraId = ( int ) datosEstudiante.Rows[ 0 ][ "id_carrera" ],
                Cedula = datosEstudiante.Rows[ 0 ][ "cedula" ].ToString(),
                Semestre = ( int ) datosEstudiante.Rows[ 0 ][ "semestre" ],
                Contrasenia = datosEstudiante.Rows[ 0 ][ "contrasenia" ].ToString(),
                IdRolUsuario = ( decimal ) datosEstudiante.Rows[ 0 ][ "id_rol_usuario" ]
            };
        }

        internal void LimpiarDatosCierreSesion()
        {
            _estudianteLogueado.Id = 0;
            _estudianteLogueado.CarreraId = 0;
            _estudianteLogueado.Semestre = 0;
            _estudianteLogueado.Cedula = "";
            _estudianteLogueado.Contrasenia = "";
            _estudianteLogueado.IdRolUsuario = 0;
        }

        internal void MostrarOcultarContrasenia( TextBox txtContrasenia, PictureBox pbShowingIcon ) 
        {   // Cambiar la visibilidad de la contraseña
            if ( txtContrasenia.PasswordChar == '*' )
            {
                txtContrasenia.PasswordChar = '\0'; // Se Muestra la Contraseña
                pbShowingIcon.Image = Resources.noVer;
            }
            else
            {
                txtContrasenia.PasswordChar = '*'; // Se Oculta la Contraseña
                pbShowingIcon.Image = Resources.ver;
            }
        }

        // * Métodos relacionados con los Votos

        internal void VerificarVotosRegistradosEstudiante()
        {
            ClsVoto votoObj = new ClsVoto() { Id_estudiante = _estudianteLogueado.Id, Tipo_voto = TipoVoto.Reina.ToString().ToUpper() };

            _estudianteVotoReinaYaRegistrado = voto_DB.VerificarVotoRegistrado( obj_Info: votoObj, tipoCrud: VotoTipoCRUD.ConsultaIndividualEstudiante );
            
            votoObj.Tipo_voto = TipoVoto.Fotogenia.ToString().ToUpper();
            _estudianteVotoFotogeniaYaRegistrado = voto_DB.VerificarVotoRegistrado( obj_Info: votoObj, tipoCrud: VotoTipoCRUD.ConsultaIndividualEstudiante );
        }

        internal int Votar( int idCandidata, TipoVoto tipoVoto )
        {
            ClsVoto voto = new ClsVoto()
            {
                Id_estudiante = _estudianteLogueado.Id,
                Id_candidata = idCandidata,
                Tipo_voto = tipoVoto.ToString().ToUpper()
            };
            
            return voto_DB.Ingresar_Voto( obj_Info: voto, tipoCrud: VotoTipoCRUD.InsertarVoto );
        }

        internal void VotoYaRegistradoButtonPreparer( Button botonVotar )
        {
            botonVotar.Enabled = false;
            ErrorProvider votoYaRegistradoErrorProvider = new ErrorProvider();
            votoYaRegistradoErrorProvider.Icon = new Icon( SystemIcons.Information, 8, 8 );
            votoYaRegistradoErrorProvider.SetIconPadding( botonVotar, 10    );
            votoYaRegistradoErrorProvider.SetError( botonVotar, CommonUtils.Messages.VOTO_YA_REGISTRADO_MSJ );
        }

        // * Métodos relacionados con las Candidatas

        internal void ObtenerCandidatas() 
        { 
            DataTable candidatasDt = new DataTable();
            candidatasDt = candidata_DB.ConsultarCandidatas( candidataObjInfo: new ClsCandidata(), tipoCrud: CandidataTipoCrud.ConsultaTodasCandidatas );

            foreach ( DataRow row in candidatasDt.Rows )
            {
                _listaCandidatas.Add
                ( 
                    new ClsCandidata()
                    {
                        Id = ( int ) row[ "id_candidata" ],
                        CarreraId = ( int ) row[ "id_carrera" ],
                        Semestre = ( int ) row[ "id_semestre" ],
                        Cedula = ( string ) row[ "cedula" ],
                        Nombres = ( string ) row[ "nombre" ],
                        Apellidos = ( string ) row[ "apellido" ],
                        Foto = ( string ) row[ "foto" ],
                        Fecha_nacimiento = ( DateTime ) row[ "fecha_nacimiento" ],
                        Edad = ( int ) row[ "edad" ],
                        Aspiraciones = ( string ) row[ "aspiraciones" ],
                        Intereses = ( string ) row[ "intereses" ],
                        Habilidades = ( string ) row[ "habilidades" ]
                    }
                );
            }
        }

        public void MostrarInfoCandidata( Label nombreCandidata, PictureBox imagenCandidata, int indexCandidata )
        {
            nombreCandidata.Text = _listaCandidatas[indexCandidata].Nombres + " " + _listaCandidatas[ indexCandidata ].Apellidos;
            imagenCandidata.Image = Base64ToImage( _listaCandidatas[ indexCandidata ].Foto );
        }

        // * Métodos relacionados con Apertura y Guardado de Imagenes desde y hacia la Base de Datos - Conversión y codificación de imagenes - Serialización

        public string ImageToBase64( Image image, System.Drawing.Imaging.ImageFormat format )
        {
            using ( MemoryStream ms = new MemoryStream() )
            {
                // Convert Image to byte[]
                image.Save( ms, format );
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String( imageBytes );
                return base64String;
            }
        }

        public Image Base64ToImage( string base64String )
        {
            // Convert Base64 String to byte[]
            Image image;
            byte[] imageBytes = Convert.FromBase64String( base64String );
            
            using ( MemoryStream ms = new MemoryStream( imageBytes, 0, imageBytes.Length ) )
            {
                // Convert byte[] to Image
                ms.Write( imageBytes, 0, imageBytes.Length );
                image = Image.FromStream( ms, true );
            }

            return image;
        }

    }
}
