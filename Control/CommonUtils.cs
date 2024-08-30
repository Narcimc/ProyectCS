using SIEleccionReina.Entidades;
using SIEleccionReina.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace SIEleccionReina.Control
{
    public enum TipoUsuario // Es público porque se usa como parametro de constructor en un Formulario y el modificador de acceso debe ser compatible
    { 
        Administrador,
        Estudiante
    }

    internal enum TipoVoto
    {
        Reina,
        Fotogenia
    }

    internal enum VotoTipoCRUD
    {
        ConsultaIndividualEstudiante,
        ConsultaTodosEstudiantes,
        InsertarVoto
    }

    internal enum CandidataTipoCrud
    { 
        ConsultaIndividualCandidata,
        ConsultaTodasCandidatas,
        InsertarCandidata,
        ModificarCandidata,
        EliminarCandidata,
        ConsultaCortaTodasCandidatasIdNombreApellido,
        VerificarCandidataYaExiste,
        ConsultaIndividualIdCandidata
    }

    internal enum EstudianteTipoCRUD 
    {
        ConsultaTodosEstudiantes,
        ValidarLoginUsuario,
        ConsultaEstudiantesXRoles,
        InsertarEstudiante,
        ModificarEstudiante,
        EliminarEstudiante,
        VerificarEstudianteYaExiste
    }

    internal enum CarreraTipoCrud 
    { 
        ConsultaTodasCarreras,
        InsertarCarrera,
        ModificarCarrera,
        EliminarCarrera
    }

    internal enum CustomFontFamilies 
    { 
        Alata,
        FiraCode,
        LeelawadeeUI,
        Montserrat
    }

    internal static class CommonUtils
    {
        // *** Miembros de Fuentes Tipográficas Personalizadas

        private static PrivateFontCollection appFamilyFontCollection;
        private static readonly Dictionary<CustomFontFamilies, FontFamily> customFontFamiliesDict;
        internal static float FONT_SIZE_BIG_TITLE = 28.0F,
            FONT_SIZE_BIG_SUB_TITLE = 16.0F,
            FONT_SIZE_MID_TITLE = 13.0F,
            FONT_SIZE_MENU_CONTENT = 10.0F,
            FONT_SIZE_CONTENT = 11.0F,
            FONT_SIZE_OK_CANCEL_BUTTON = 14.0F,
            FONT_SIZE_SUB_BUTTON = 10.0F;

        // * Datos Utiles de la Aplicacion
        internal static string LINK_REPO_GITHUB = "https://github.com/Narcimc/ProyectCS";

        // *** Constructor Estático
        static CommonUtils() 
        {
            // Se crean varias FontFamily con las fuentes que se cargan desde Resources/Fonts y se las almacena en un Diccionario en tiempo de ejecucion para un facil acceso y seteo de fuentes en la interfaz grafica
            customFontFamiliesDict = new Dictionary<CustomFontFamilies, FontFamily>();

            string fontsDirPath = Path.Combine( Directory.GetParent( Directory.GetParent( Application.StartupPath ).FullName ).FullName, @"Resources\Fonts" ),
                alataPath = Path.Combine( fontsDirPath, @"Alata-Regular.ttf" ),
                firaCodePath = Path.Combine( fontsDirPath, @"FiraCodeNerdFontMono-Bold.ttf" ),
                leelawadeeUIRegularPath = Path.Combine( fontsDirPath, @"LeelawadeeUI-Regular.ttf" ),
                leelawadeeUIBoldPath = Path.Combine( fontsDirPath, @"LeelawadeeUI-Bold.ttf" ),
                leelawadeeUISemiLightPath = Path.Combine( fontsDirPath, @"LeelawadeeUI-SemiLight.ttf" ),
                montserratRegularPath = Path.Combine( fontsDirPath, @"Montserrat-Regular.ttf" ),
                montserratBoldPath = Path.Combine( fontsDirPath, @"Montserrat-Bold.ttf" );

            if ( File.Exists( alataPath ) )
            {
                appFamilyFontCollection = new PrivateFontCollection();
                appFamilyFontCollection.AddFontFile( alataPath );
                customFontFamiliesDict.Add( CustomFontFamilies.Alata, new FontFamily( "Alata", appFamilyFontCollection ) );
            }

            if ( File.Exists( firaCodePath ) ) 
            {
                appFamilyFontCollection = new PrivateFontCollection();
                appFamilyFontCollection.AddFontFile( firaCodePath );
                customFontFamiliesDict.Add( CustomFontFamilies.FiraCode, new FontFamily( "FiraCode Nerd Font Mono", appFamilyFontCollection ) );
            }

            if ( File.Exists( leelawadeeUIRegularPath ) && File.Exists( leelawadeeUIBoldPath ) && File.Exists( leelawadeeUISemiLightPath ) ) 
            {
                appFamilyFontCollection = new PrivateFontCollection();
                appFamilyFontCollection.AddFontFile( leelawadeeUIRegularPath );
                appFamilyFontCollection.AddFontFile( leelawadeeUIBoldPath );
                appFamilyFontCollection.AddFontFile( leelawadeeUISemiLightPath );
                customFontFamiliesDict.Add( CustomFontFamilies.LeelawadeeUI, new FontFamily( "Leelawadee UI", appFamilyFontCollection ) );
            }

            if ( File.Exists( montserratRegularPath ) && File.Exists( montserratBoldPath ) ) 
            {
                appFamilyFontCollection = new PrivateFontCollection();
                appFamilyFontCollection.AddFontFile( montserratRegularPath );
                appFamilyFontCollection.AddFontFile( montserratBoldPath );
                customFontFamiliesDict.Add( CustomFontFamilies.Montserrat, new FontFamily( "Montserrat", appFamilyFontCollection ) );
            }            
        }

        // *** Métodos Estáticos

        internal static FontFamily GetCustomFont( CustomFontFamilies customFontFamily ) => customFontFamiliesDict[ customFontFamily ];
        
        internal static void LlenarComboTipoUsuario( ComboBox comboTipoUsuario ) 
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            foreach ( TipoUsuario tipoUser in Enum.GetValues( typeof( TipoUsuario ) ) )
                items.Add( new ComboBoxItem { Display = tipoUser.ToString(), Value = ( int ) tipoUser + 1 } );

            ComboSetter( comboTipoUsuario, items );
        }

        internal static void LlenarCombo( ComboBox comboBoxAny, Dictionary<int, string> dictAny )
        {
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            foreach ( KeyValuePair<int, string> kvp in dictAny )
                items.Add( new ComboBoxItem { Display = kvp.Value, Value = kvp.Key } );

            ComboSetter( comboBoxAny, items );
        }

        private static void ComboSetter( ComboBox comboB, List<ComboBoxItem> items ) 
        {
            comboB.DataSource = items;
            comboB.DisplayMember = "Display";
            comboB.ValueMember = "Value";
        }

        internal static void MostrarOcultarContrasenia( TextBox txtContrasenia, PictureBox pbShowingIcon )
        {   // Cambiar la visibilidad de la contraseña
            if ( txtContrasenia.PasswordChar == '*' )
            {
                txtContrasenia.PasswordChar = '\0'; // Se Muestra la Contraseña
                pbShowingIcon.Image = Resources.visibility_off_24px_001928_FILL1_wght400_GRAD0_opsz24;
            }
            else
            {
                txtContrasenia.PasswordChar = '*'; // Se Oculta la Contraseña
                pbShowingIcon.Image = Resources.visibility_24px_001928_FILL1_wght400_GRAD0_opsz24;
            }
        }

        // *** Clases Estaticas Anidadas - Agrupan Miembros mejorando la sintaxis, legibilidad y practicidad del codigo

        // * Fuentes Tipográficas Personalizadas para la aplicación, Predefinidas y listas para usar en controles
        internal static class PredefinedCustomFonts
        {
            internal static Font BigTitleGreetingsFont = new Font( customFontFamiliesDict[ CustomFontFamilies.LeelawadeeUI ], FONT_SIZE_BIG_TITLE, FontStyle.Regular ),
                BigSubTitleWelcomeFont = new Font( customFontFamiliesDict[ CustomFontFamilies.LeelawadeeUI ], FONT_SIZE_BIG_SUB_TITLE, FontStyle.Regular ),
                MidTitleFont = new Font( customFontFamiliesDict[ CustomFontFamilies.Alata ], FONT_SIZE_MID_TITLE, FontStyle.Regular ),
                MenuContentFont = new Font( customFontFamiliesDict[ CustomFontFamilies.LeelawadeeUI ], FONT_SIZE_MENU_CONTENT, FontStyle.Regular ),
                ContentFont = new Font( customFontFamiliesDict[ CustomFontFamilies.LeelawadeeUI ], FONT_SIZE_CONTENT, FontStyle.Regular ),
                MainActionButtonFont = new Font( customFontFamiliesDict[ CustomFontFamilies.Montserrat ], FONT_SIZE_OK_CANCEL_BUTTON, FontStyle.Bold ),
                MainOptionsActionButtonFont = new Font( customFontFamiliesDict[ CustomFontFamilies.Montserrat ], FONT_SIZE_MID_TITLE, FontStyle.Bold ),
                SubActionButtonFont = new Font( customFontFamiliesDict[ CustomFontFamilies.Montserrat ], FONT_SIZE_SUB_BUTTON, FontStyle.Bold ),
                SecondaryActionButtonFont = new Font( customFontFamiliesDict[ CustomFontFamilies.LeelawadeeUI ], FONT_SIZE_OK_CANCEL_BUTTON, FontStyle.Regular );
        }

        // * Mensajes Comunes
        internal static class Messages
        {
            internal static string COMMON_ERROR_MSJ = "Oops, algo no salio muy bien...",
                VOTO_YA_REGISTRADO_MSJ = "Su voto ya ha sido registrado",
                ERROR_AL_VOTAR_MSJ = "Ocurrió un error al registrar el voto, intentelo de nuevo, si este error persiste contacte al administrador del sistema.",
                NULL_EMPTY_MSJ_FEM = "no puede ser nula, estar vacía o ser solo espacios en blanco, verifique nuevamente por favor.",
                FUNCIONALIDAD_EN_CAMINO = "Esta funcionalidad llegará en una próxima versión :).";
            internal static string[] WELCOME_MSJS = { "Recibe una calurosa Bienvenida.", "Saludos cordiales.", "Espero tengas un ¡excelente día!", "Lindo día para el éxito.", "Hoy triunfaremos en nuestros Proyectos." };
        }
    }
}
