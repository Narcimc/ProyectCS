using SIEleccionReina.Control;
using SIEleccionReina.Formularios;
using System;
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

        private void BtnInscripcionCandidatas_Click(object sender, EventArgs e)
        {
            RegistroDeCandidatas vRegistroCandidata = new RegistroDeCandidatas();
            vRegistroCandidata.ShowDialog();
        }

        private void BtnRegistroFoto_Click(object sender, EventArgs e)
        {
            FormRegistroFotos vGaleriaFotos = new FormRegistroFotos();
            vGaleriaFotos.ShowDialog();
        }

        private void BtnResultados_Click( object sender, EventArgs e )
        {
            FormResultados vResultados = new FormResultados();
            vResultados.ShowDialog();
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

        }

        private void crearÁlbumToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void agregarFotosToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void registrarEstudianteToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }

        private void resultadosToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }
    }
}
