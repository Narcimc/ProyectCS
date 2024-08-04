using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIEleccionReina.Formularios
{
    public partial class FormRegistroEstudiante : Form
    {
        //private ClsEstudiante_DB Obj_conexion;
        private ClsEstudiante estudianteObj;
        private SIEleccionReinaController controlador;
        TipoUsuario tipoUsuarioInvocador;

        public FormRegistroEstudiante( TipoUsuario tipoUsuarioInvocador )
        {
            InitializeComponent();
            //Obj_conexion = new ClsEstudiante_DB();
            estudianteObj = new ClsEstudiante();
            controlador = SIEleccionReinaController.Instance;
            this.tipoUsuarioInvocador = tipoUsuarioInvocador;
        }

        private void FormRegistroEstudiante_Load( object sender, EventArgs e )
        {
            EstablecerTipografias();
            CommonUtils.LlenarComboTipoUsuario( CmbTipoUsuario ); // Se llena los ComboBoxes
            CommonUtils.LlenarCombo( CmbCarrera, controlador.CarrerasDisponibles );
            
            if ( tipoUsuarioInvocador.Equals( TipoUsuario.Administrador ) )
            {
                CmbTipoUsuario.SelectedIndex = 0;
            }
            else 
            {
                CmbTipoUsuario.SelectedIndex = 1;
                CmbTipoUsuario.Enabled = false;
            }

            MTxtUsuarioCI.Focus();
        }

        private void EstablecerTipografias()
        {
            LblUsuario.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblUsuarioIndicacion.Font = new Font( CommonUtils.GetCustomFont( CustomFontFamilies.LeelawadeeUI ), 8.0F, FontStyle.Regular );
            LblTipoUsuario.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblCarrera.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblSemestre.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblContrasenia.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblConfirmarContrasenia.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            MTxtUsuarioCI.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            CmbTipoUsuario.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            CmbCarrera.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            NUDSemestre.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtContrasenia.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtConfirmarContrasenia.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            BtnRegistrar.Font = CommonUtils.PredefinedCustomFonts.MainActionButtonFont;
            BtnCancelar.Font = CommonUtils.PredefinedCustomFonts.SecondaryActionButtonFont;
        }

        private void BtnRegistrar_Click( object sender, EventArgs e )
        {

        }

        private void BtnCancelar_Click( object sender, EventArgs e ) => Close();

        private void PBVerContrasenia_Click( object sender, EventArgs e ) 
            => controlador.MostrarOcultarContrasenia( txtContrasenia: TxtContrasenia, pbShowingIcon: PBVerContrasenia );

        private void PBVerConfirmContrasenia_Click( object sender, EventArgs e )
            => controlador.MostrarOcultarContrasenia( txtContrasenia: TxtConfirmarContrasenia, pbShowingIcon: PBVerConfirmContrasenia );
    }
}
