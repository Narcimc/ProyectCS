using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using System;
using System.Drawing;
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
                Cursor = Cursors.WaitCursor;

                // Se validan los datos del estudiante
                if ( Validaciones.IsUserCedulaValid( cedulaControl: MTxtUsuarioCI ) &&
                     Validaciones.IsNameLastNameValid( nameLastNameControl: TxtNombres ) &&
                     Validaciones.IsNameLastNameValid( nameLastNameControl: TxtApellidos ) &&
                     Validaciones.IsCarreraValid( carreraControl: CmbCarrera ) &&
                     Validaciones.IsPasswordValid( passwordControl: TxtContrasenia ) &&
                     Validaciones.IsPasswordConfirmationValid( password: TxtContrasenia.Text, passwordConfirmationControl: TxtConfirmarContrasenia )
                    )
                {   // Una vez se han aprobado las validaciones, se verifica si el estudiante ya está registrado
                    if( !controlador.VerificarRegistroEstudiante( estudianteCedula: MTxtUsuarioCI.Text, tipoCRUD: EstudianteTipoCRUD.VerificarEstudianteYaExiste, exControl: BtnRegistrar ) )
                    {   // Si el estudiante todavía no está registrado, entonces se crea un objeto ClsEstudiante con los datos y se envía a registrarlo
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
                        Cursor = Cursors.Default;

                        Close();
                    }                    
                }
            }
            catch ( InvalidValueException invEx )
            {
                EPRegistroEstudiante.SetError( invEx.ErrorSourceControl, invEx.Message );
                Cursor = Cursors.Default;
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

        private void TxtContrasenia_Enter( object sender, EventArgs e ) => PBVerContrasenia.Visible = true;

        private void TxtContrasenia_Leave( object sender, EventArgs e ) => PBVerContrasenia.Visible = false;

        private void TxtConfirmarContrasenia_Enter( object sender, EventArgs e ) => PBVerConfirmContrasenia.Visible = true;

        private void TxtConfirmarContrasenia_Leave( object sender, EventArgs e ) => PBVerConfirmContrasenia.Visible = false;
    }
}
