using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using SIEleccionReina.Formularios;
using SIEleccionReina.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            controlador.ObtenerCarreras();
        }

        private void FormLogin_Load( object sender, EventArgs e )
        {
            EstablecerTipografias();
            CommonUtils.LlenarComboTipoUsuario( CmbTipoUsuario ); // Se llena el ComboBox de Tipo de usuario
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

        private void MostrarValor()
        {
            MessageBox.Show( "Valor: " + ( int ) CmbTipoUsuario.SelectedValue );
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                MostrarValor();
                if ( Validaciones.IsUserValid( userCedula: MTxtUsuarioCI.Text, exControl: MTxtUsuarioCI ) && 
                    Validaciones.IsPasswordValid( password: TxtContrasenia.Text, exControl: TxtContrasenia ) &&
                    controlador.ValidarLogin( 
                        usuario: MTxtUsuarioCI.Text, 
                        pwd: TxtContrasenia.Text, 
                        userType: ( decimal ) CmbTipoUsuario.SelectedValue, 
                        exControl: BtnIniciarSesion
                        ) ) 
                {   // Ir al Panel Principal correspondiente según el Tipo de Usuario
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
            catch ( SIEleccionReinaException invalounEx ) when ( invalounEx is InvalidValueException || invalounEx is  LoginUnsuccessfulException )
            {
                EPLogin.SetError( invalounEx.ErrorSourceControl, invalounEx.Message );
                TmrErrorClear.Start();
                MTxtUsuarioCI.Focus();
            }
        }

        private void PBVerContrasenia_Click(object sender, EventArgs e) 
            => controlador.MostrarOcultarContrasenia( TxtContrasenia, PBVerContrasenia );

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
    }
}
