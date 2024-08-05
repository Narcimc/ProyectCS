using SIEleccionReina.Control;
using SIEleccionReina.Formularios;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SIEleccionReina
{
    public partial class FormModuloAdministrador : Form
    {
        private SIEleccionReinaController controlador;

        public FormModuloAdministrador()
        {
            InitializeComponent();
            controlador = SIEleccionReinaController.Instance;
            this.DialogResult = DialogResult.Abort; // Se inicia asumiendo que el usuario va a cerrar la ventana, sin embargo si solo cierra sesión este valor cambia
        }

        private void FormModuloAdministrador_Load( object sender, EventArgs e )
        {
            LblSaludoUser.Text += controlador.EstudianteLogueado.PrimerNombre + "...";
            Random random = new Random();
            LblMsjBienvenida.Text = CommonUtils.Messages.WELCOME_MSJS[ random.Next( 0, CommonUtils.Messages.WELCOME_MSJS.Length ) ];
            EstablecerTipografias();
        }

        private void EstablecerTipografias()
        {
            LblSaludoUser.Font = CommonUtils.PredefinedCustomFonts.BigTitleGreetingsFont;
            LblMsjBienvenida.Font = CommonUtils.PredefinedCustomFonts.BigSubTitleWelcomeFont;
            BtnInscripcionCandidatas.Font = CommonUtils.PredefinedCustomFonts.MainOptionsActionButtonFont;
            BtnRegistroFoto.Font = CommonUtils.PredefinedCustomFonts.MainOptionsActionButtonFont;
            BtnResultados.Font = CommonUtils.PredefinedCustomFonts.MainOptionsActionButtonFont;
        }

        private void BtnInscripcionCandidatas_Click(object sender, EventArgs e)
        {
            FormRegistroCandidata vRegistroCandidata = new FormRegistroCandidata();
            vRegistroCandidata.ShowDialog();
        }

        private void BtnRegistroFoto_Click(object sender, EventArgs e)
        {
            MessageBox.Show( CommonUtils.Messages.FUNCIONALIDAD_EN_CAMINO, "Funcionalidad en camino...", MessageBoxButtons.OK, MessageBoxIcon.Information );
            //FormRegistroFotos vGaleriaFotos = new FormRegistroFotos();
            //vGaleriaFotos.ShowDialog();
        }

        private void BtnResultados_Click( object sender, EventArgs e )
        {
            MessageBox.Show( CommonUtils.Messages.FUNCIONALIDAD_EN_CAMINO, "Funcionalidad en camino...", MessageBoxButtons.OK, MessageBoxIcon.Information );
            //FormResultados vResultados = new FormResultados();
            //vResultados.ShowDialog();
        }

        private void salirToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.Close();
        }

        private void cerrarSesiónToolStripMenuItem_Click( object sender, EventArgs e )
        {
            this.DialogResult = DialogResult.OK; // Si el usuario cierra sesión en lugar de cerrar, entonces se establece el valor de Ok, continua la ejecución y se muestra la ventana de Login
            this.Close();
        }

        private void registrarCandidataToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ( new FormRegistroCandidata() ).ShowDialog();
        }

        private void crearÁlbumToolStripMenuItem_Click( object sender, EventArgs e )
        {
            MessageBox.Show( CommonUtils.Messages.FUNCIONALIDAD_EN_CAMINO, "Funcionalidad en camino...", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void agregarFotosToolStripMenuItem_Click( object sender, EventArgs e )
        {
            MessageBox.Show( CommonUtils.Messages.FUNCIONALIDAD_EN_CAMINO, "Funcionalidad en camino...", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void registrarEstudianteToolStripMenuItem_Click( object sender, EventArgs e )
        {
            ( new FormRegistroEstudiante( tipoUsuarioInvocador: TipoUsuario.Administrador ) ).ShowDialog();
        }

        private void resultadosToolStripMenuItem_Click( object sender, EventArgs e )
        {
            MessageBox.Show( CommonUtils.Messages.FUNCIONALIDAD_EN_CAMINO, "Funcionalidad en camino...", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }

        private void sIEREnGitHubToolStripMenuItem_Click( object sender, EventArgs e )
        {
            try
            {
                Process.Start( new ProcessStartInfo
                {
                    FileName = CommonUtils.LINK_REPO_GITHUB,
                    UseShellExecute = true
                } );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, CommonUtils.Messages.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Warning );
            }
        }

        private void acercaDeSIERToolStripMenuItem_Click( object sender, EventArgs e ) => ( new FormAcercaDe() ).ShowDialog();
    }
}
