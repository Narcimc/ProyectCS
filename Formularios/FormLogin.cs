using SIEleccionReina.Control;
using SIEleccionReina.Formularios;
using SIEleccionReina.Properties;
using System;
using System.Windows.Forms;

namespace SIEleccionReina
{
    public partial class FormLogin : Form
    {
        private SIEleccionReinaController controlador;

        public FormLogin()
        {
            InitializeComponent();
            controlador = SIEleccionReinaController.Instance;
            Cursor = Cursors.WaitCursor;
            controlador.ObtenerCarreras();
            Cursor = Cursors.Default;
            this.Icon = Resources.SIER_Icon_Alpha;
        }

        private void FormLogin_Load( object sender, EventArgs e )
        {
            EstablecerTipografias();
            CommonUtils.LlenarComboTipoUsuario( CmbTipoUsuario );
            MTxtUsuarioCI.Focus();
        }

        private void EstablecerTipografias() 
        {
            LblFacultad.Font = CommonUtils.PredefinedCustomFonts.MidTitleFont;
            LblTipoUsuario.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblUsuario.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblContrasenia.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            CmbTipoUsuario.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            MTxtUsuarioCI.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtContrasenia.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            BtnIniciarSesion.Font = CommonUtils.PredefinedCustomFonts.MainActionButtonFont;
            BtnRegistrarme.Font = CommonUtils.PredefinedCustomFonts.SubActionButtonFont;
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                EPLogin.Clear();
                Cursor = Cursors.WaitCursor;

                if ( Validaciones.IsUserCedulaValid( cedulaControl: MTxtUsuarioCI ) && 
                    Validaciones.IsPasswordValid( passwordControl: TxtContrasenia ) &&
                    controlador.ValidarLogin( 
                        usuario: MTxtUsuarioCI.Text, 
                        pwd: TxtContrasenia.Text, 
                        userType: ( int ) CmbTipoUsuario.SelectedValue, 
                        exControl: BtnIniciarSesion
                        ) ) 
                {   // Ir al Panel Principal correspondiente según el Tipo de Usuario
                    Cursor = Cursors.Default;
                    this.Hide();
                    TipoUsuario rolUsuario = ( TipoUsuario ) CmbTipoUsuario.SelectedIndex;

                    DialogResult continuarCerrarFlag = rolUsuario.Equals( TipoUsuario.Administrador ) ? 
                        ( new FormModuloAdministrador() ).ShowDialog() : 
                        ( new FormModuloEstudiante() ).ShowDialog();

                    if ( continuarCerrarFlag == DialogResult.OK )
                    {
                        LimpiarCampos();
                        this.Show();
                        MTxtUsuarioCI.Focus();
                    }
                    else
                        this.Close();
                }
            }
            catch ( SIEleccionReinaException invalounEx ) when ( invalounEx is InvalidValueException || invalounEx is LoginUnsuccessfulException )
            {
                EPLogin.SetError( invalounEx.ErrorSourceControl, invalounEx.Message );
                TmrErrorClear.Start();
                Cursor = Cursors.Default;
                invalounEx.ErrorSourceControl.Focus();
            }
        }

        private void PBVerContrasenia_Click(object sender, EventArgs e) 
            => CommonUtils.MostrarOcultarContrasenia( TxtContrasenia, PBVerContrasenia );

        private void LimpiarCampos() 
        { 
            MTxtUsuarioCI.Text = string.Empty;
            TxtContrasenia.Text = string.Empty;
            CmbTipoUsuario.SelectedIndex = 0;
        }

        private void TxtContrasenia_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                BtnIniciarSesion.PerformClick();
        }

        private void TmrErrorClear_Tick( object sender, EventArgs e )
        {
            EPLogin.Clear();
            TmrErrorClear.Stop();
        }

        private void BtnRegistrarme_Click( object sender, EventArgs e ) => ( new FormRegistroEstudiante( TipoUsuario.Estudiante ) ).ShowDialog();

        private void MTxtUsuarioCI_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                BtnIniciarSesion.PerformClick();
        }

        private void TxtContrasenia_Enter( object sender, EventArgs e ) => PBVerContrasenia.Visible = true;

        private void TxtContrasenia_Leave( object sender, EventArgs e ) => PBVerContrasenia.Visible = false;
    }
}
