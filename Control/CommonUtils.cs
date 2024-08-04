using SIEleccionReina.Entidades;
using SIEleccionReina.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIEleccionReina.Control
{
    public enum TipoUsuario 
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
        ConsultaCortaTodasCandidatasIdNombreApellido
    }

    internal enum EstudianteTipoCRUD 
    {
        ConsultaTodosEstudiantes,
        ValidarLoginUsuario,
        ConsultaEstudiantesXRoles,
        InsertarEstudiante,
        ModificarEstudiante,
        EliminarEstudiante
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

        private static PrivateFontCollection appFontsCollection;
        private static readonly Dictionary<CustomFontFamilies, FontFamily> customFontFamiliesDict;
        internal static float FONT_SIZE_BIG_TITLE = 28.0F;
        internal static float FONT_SIZE_MID_TITLE = 13.0F;
        internal static float FONT_SIZE_CONTENT = 11.0F;
        internal static float FONT_SIZE_OK_CANCEL_BUTTON = 14.0F;
        internal static float FONT_SIZE_SUB_BUTTON = 10.0F;


        // *** Constructor Estático
        static CommonUtils() 
        {
            // Se crean varias FontFamily con las fuentes que se cargan desde Resources/Fonts y se las almacena en un Diccionario en tiempo de ejecucion para un facil acceso y seteo de fuentes en la interfaz grafica
            customFontFamiliesDict = new Dictionary<CustomFontFamilies, FontFamily>();

            string fontsDirPath = Path.Combine( Directory.GetParent( Directory.GetParent( Application.StartupPath ).FullName ).FullName, @"Resources\Fonts" );
            string alataPath = Path.Combine( fontsDirPath, @"Alata-Regular.ttf" );
            string firaCodePath = Path.Combine( fontsDirPath, @"FiraCodeNerdFontMono-Bold.ttf" );
            string leelawadeeUIRegularPath = Path.Combine( fontsDirPath, @"LeelawadeeUI-Regular.ttf" );
            string leelawadeeUIBoldPath = Path.Combine( fontsDirPath, @"LeelawadeeUI-Bold.ttf" );
            string leelawadeeUISemiLightPath = Path.Combine( fontsDirPath, @"LeelawadeeUI-SemiLight.ttf" );
            string montserratRegularPath = Path.Combine( fontsDirPath, @"Montserrat-Regular.ttf" );
            string montserratBoldPath = Path.Combine( fontsDirPath, @"Montserrat-Bold.ttf" );

            appFontsCollection = new PrivateFontCollection();
            appFontsCollection.AddFontFile( alataPath );
            customFontFamiliesDict.Add( CustomFontFamilies.Alata, new FontFamily( "Alata", appFontsCollection ) );

            appFontsCollection = new PrivateFontCollection();
            appFontsCollection.AddFontFile( firaCodePath );
            customFontFamiliesDict.Add( CustomFontFamilies.FiraCode, new FontFamily( "FiraCode Nerd Font Mono", appFontsCollection ) );

            appFontsCollection = new PrivateFontCollection();
            appFontsCollection.AddFontFile( leelawadeeUIRegularPath );
            appFontsCollection.AddFontFile( leelawadeeUIBoldPath );
            appFontsCollection.AddFontFile( leelawadeeUISemiLightPath );
            customFontFamiliesDict.Add( CustomFontFamilies.LeelawadeeUI, new FontFamily( "Leelawadee UI", appFontsCollection ) );

            appFontsCollection = new PrivateFontCollection();
            appFontsCollection.AddFontFile( montserratRegularPath );
            appFontsCollection.AddFontFile( montserratBoldPath );
            customFontFamiliesDict.Add( CustomFontFamilies.Montserrat, new FontFamily( "Montserrat", appFontsCollection ) );
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

        // *** Clases Estaticas Anidadas - Agrupan Miembros mejorando la sintaxis, legibilidad y practicidad del codigo

        // * Fuentes Tipográficas Personalizadas para la aplicación, Predefinidas y listas para usar en controles
        internal static class PredefinedCustomFonts
        {
            internal static Font MidTitleFont = new Font( customFontFamiliesDict[ CustomFontFamilies.Alata ], FONT_SIZE_MID_TITLE, FontStyle.Regular );
            internal static Font ContentFont = new Font( customFontFamiliesDict[ CustomFontFamilies.LeelawadeeUI ], FONT_SIZE_CONTENT, FontStyle.Regular );
            internal static Font MainActionButtonFont = new Font( customFontFamiliesDict[ CustomFontFamilies.Montserrat ], FONT_SIZE_OK_CANCEL_BUTTON, FontStyle.Bold );
            internal static Font SubActionButtonFont = new Font( customFontFamiliesDict[ CustomFontFamilies.Montserrat ], FONT_SIZE_SUB_BUTTON, FontStyle.Bold );
            internal static Font SecondaryActionButtonFont = new Font( customFontFamiliesDict[ CustomFontFamilies.LeelawadeeUI ], FONT_SIZE_OK_CANCEL_BUTTON, FontStyle.Regular );
        }

        // * Mensajes Comunes
        internal static class Messages
        {
            internal static string COMMON_ERROR_MSJ = "Oops, algo no salio muy bien...";
            internal static string VOTO_YA_REGISTRADO_MSJ = "Su voto ya ha sido registrado";
            internal static string ERROR_AL_VOTAR_MSJ = "Ocurrió un error al registrar el voto, intentelo de nuevo, si este error persiste contacte al administrador del sistema.";
            internal static string NULL_EMPTY_MSJ_FEM = "no puede ser nula, estar vacía o ser solo espacios en blanco, verifique nuevamente por favor.";
        }
    }
}
