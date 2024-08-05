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
        private SIEleccionReinaController controlador;
        private TipoUsuario tipoUsuarioInvocador;

        public FormRegistroEstudiante( TipoUsuario tipoUsuarioInvocador )
        {
            InitializeComponent();
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
            TxtNombres.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtApellidos.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtContrasenia.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtConfirmarContrasenia.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            BtnRegistrar.Font = CommonUtils.PredefinedCustomFonts.MainActionButtonFont;
            BtnCancelar.Font = CommonUtils.PredefinedCustomFonts.SecondaryActionButtonFont;
        }

        private void BtnRegistrar_Click( object sender, EventArgs e )
        {
            try
            {
                EPRegistroEstudiante.Clear();

                if ( Validaciones.IsUserCedulaValid( userCedula: MTxtUsuarioCI.Text, exControl: MTxtUsuarioCI ) &&
                     Validaciones.IsNameLastNameValid( nameLastName: TxtNombres.Text.Trim(), exControl: TxtNombres ) &&
                     Validaciones.IsNameLastNameValid( nameLastName: TxtApellidos.Text.Trim(), exControl: TxtApellidos ) &&
                     Validaciones.IsCarreraValid( carrera: CmbCarrera.Text, exControl: CmbCarrera ) &&
                     Validaciones.IsPasswordValid( password: TxtContrasenia.Text, exControl: TxtContrasenia ) &&
                     Validaciones.IsPasswordConfirmationValid( password: TxtContrasenia.Text, passwordConfirmation: TxtConfirmarContrasenia.Text, exControl: TxtConfirmarContrasenia )
                    )
                {
                    if( !controlador.VerificarRegistroEstudiante( estudianteCedula: MTxtUsuarioCI.Text, tipoCRUD: EstudianteTipoCRUD.VerificarEstudianteYaExiste, exControl: BtnRegistrar ) )
                    {
                        ClsEstudiante estudiante = new ClsEstudiante( 0,
                        idCarrera: ( int ) CmbCarrera.SelectedValue,
                        cedula: MTxtUsuarioCI.Text,
                        semestre: ( int ) NUDSemestre.Value,
                        contrasenia: TxtContrasenia.Text,
                        id_rol_usuario: ( int ) CmbTipoUsuario.SelectedValue,
                        nombres: TxtNombres.Text.Trim(),
                        apellidos: TxtApellidos.Text.Trim()
                        );

                        controlador.IngresarModificarEliminarEstudiante( estudianteObjInfo: estudiante, EstudianteTipoCRUD.InsertarEstudiante );
                        Close();
                    }                    
                }
            }
            catch ( InvalidValueException invEx )
            {
                EPRegistroEstudiante.SetError( invEx.ErrorSourceControl, invEx.Message );
                invEx.ErrorSourceControl.Focus();
            }
        }

        private void BtnCancelar_Click( object sender, EventArgs e ) 
            => Close();

        private void PBVerContrasenia_Click( object sender, EventArgs e ) 
            => CommonUtils.MostrarOcultarContrasenia( txtContrasenia: TxtContrasenia, pbShowingIcon: PBVerContrasenia );

        private void PBVerConfirmContrasenia_Click( object sender, EventArgs e )
            => CommonUtils.MostrarOcultarContrasenia( txtContrasenia: TxtConfirmarContrasenia, pbShowingIcon: PBVerConfirmContrasenia );

        private void TxtConfirmarContrasenia_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                BtnRegistrar.PerformClick();
        }

        private void TxtContrasenia_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                BtnRegistrar.PerformClick();
        }
    }
}
