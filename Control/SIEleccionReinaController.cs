using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Entidades;
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
        private clsVoto_DB voto_DB;
        private clsCandidata_DB candidata_DB;

        //***** Objeto de Sesión del Usuario logueado
        private ClsEstudiante _estudianteLogueado;
        internal ClsEstudiante EstudianteLogueado { get => _estudianteLogueado; }

        //***** Atributos y Propiedades generales
        private bool _estudianteVotoReinaYaRegistrado = false;
        private bool _estudianteVotoFotogeniaYaRegistrado = false;

        public bool EstudianteVotoReinaYaRegistrado { get => _estudianteVotoReinaYaRegistrado; set => _estudianteVotoReinaYaRegistrado = value; }
        public bool EstudianteVotoFotogeniaYaRegistrado { get => _estudianteVotoFotogeniaYaRegistrado; set => _estudianteVotoFotogeniaYaRegistrado = value; }

        private List<clsCandidata> _listaCandidatas;
        public List<clsCandidata> ListaCandidatas { get => _listaCandidatas; }

        //***** Singleton Pattern using a Lazy approach
        private static readonly Lazy<SIEleccionReinaController> lazy = new Lazy<SIEleccionReinaController>( () => new SIEleccionReinaController() );
        public static SIEleccionReinaController Instance { get { return lazy.Value; } }
        private SIEleccionReinaController() // Private Constructor
        { 
            voto_DB = new clsVoto_DB();
            candidata_DB = new clsCandidata_DB();
            _listaCandidatas = new List<clsCandidata>();
        }

        //***** Métodos

        internal void RegistrarEstudianteLogueado( DataTable datosEstudiante )
        {
            _estudianteLogueado = new ClsEstudiante()
            {
                Id_estudiante = ( int ) datosEstudiante.Rows[ 0 ][ "id_estudiante" ],
                Id_semestre = ( int ) datosEstudiante.Rows[ 0 ][ "id_semestre" ],
                Id_carrera = ( int ) datosEstudiante.Rows[ 0 ][ "id_carrera" ],
                Cedula = datosEstudiante.Rows[ 0 ][ "cedula" ].ToString(),
                Contrasenia = datosEstudiante.Rows[ 0 ][ "contrasenia" ].ToString(),
                Rol_usuario = datosEstudiante.Rows[ 0 ][ "rol_usuario" ].ToString()
            };
        }

        // * Métodos relacionados con los Votos

        internal void VerificarVotosRegistradosEstudiante()
        {
            clsVoto votoObj = new clsVoto() { Id_estudiante = _estudianteLogueado.Id_estudiante, Tipo_voto = TipoVoto.Reina.ToString().ToUpper() };

            _estudianteVotoReinaYaRegistrado = voto_DB.VerificarVotoRegistrado( obj_Info: votoObj, tipoCrud: VotoTipoCRUD.ConsultaIndividualEstudiante );
            
            votoObj.Tipo_voto = TipoVoto.Fotogenia.ToString().ToUpper();
            _estudianteVotoFotogeniaYaRegistrado = voto_DB.VerificarVotoRegistrado( obj_Info: votoObj, tipoCrud: VotoTipoCRUD.ConsultaIndividualEstudiante );
        }

        internal int Votar( int idCandidata, TipoVoto tipoVoto )
        {
            clsVoto voto = new clsVoto()
            {
                Id_estudiante = _estudianteLogueado.Id_estudiante,
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
            votoYaRegistradoErrorProvider.SetError( botonVotar, CommonUtils.VOTO_YA_REGISTRADO_MSJ );
        }

        // * Métodos relacionados con las Candidatas

        internal void ObtenerCandidatas() 
        { 
            DataTable candidatasDt = new DataTable();
            candidatasDt = candidata_DB.ConsultarCandidatas( obj_Info: new clsCandidata(), tipoCrud: CandidataTipoCrud.ConsultaTodasCandidatas );

            foreach ( DataRow row in candidatasDt.Rows )
            {
                _listaCandidatas.Add
                ( 
                    new clsCandidata()
                    {
                        Id_candidata = ( int ) row[ "id_candidata" ],
                        Carrera = new KeyValuePair<int, string>( ( int ) row[ "id_carrera" ], ( string ) row[ "nombre_carrera" ] ),
                        Semestre = new KeyValuePair<int, int>( ( int ) row[ "id_semestre" ], ( int ) row[ "numero_semestre" ] ),
                        Cedula = ( string ) row[ "cedula" ],
                        Nombre = ( string ) row[ "nombre" ],
                        Apellido = ( string ) row[ "apellido" ],
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
            nombreCandidata.Text = _listaCandidatas[indexCandidata].Nombre + " " + _listaCandidatas[ indexCandidata ].Apellido;
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
