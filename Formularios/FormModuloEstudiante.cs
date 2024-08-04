using SIEleccionReina.Control;
using System;
using System.Windows.Forms;

namespace SIEleccionReina.Formularios
{
    public partial class FormModuloEstudiante : Form
    {
        private SIEleccionReinaController controlador;

        public FormModuloEstudiante()
        {
            InitializeComponent();
            controlador = SIEleccionReinaController.Instance;
            this.DialogResult = DialogResult.Abort; // Se inicia asumiendo que el usuario va a cerrar la ventana, sin embargo si solo cierra sesión este valor cambia
        }

        private void BtnVerCandidatas_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            FormCandidatas formularioReina = new FormCandidatas();

            // Mostrar el formulario
            formularioReina.ShowDialog();
        }

        private void BtnVotoReina_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            FormVotoReina VotoReina = new FormVotoReina();

            // Mostrar el formulario
            VotoReina.ShowDialog();
        }

        private void BtnVotarPorFotogenica_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            FormVotoFotogenica VotoFotogenica = new FormVotoFotogenica();

            // Mostrar el formulario
            VotoFotogenica.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click( object sender, EventArgs e )
        {

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

        private void perfilToolStripMenuItem_Click( object sender, EventArgs e )
        {

        }
    }
}
