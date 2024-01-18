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
    public partial class FrmEstudiante : Form
    {
        public FrmEstudiante()
        {
            InitializeComponent();
        }

        private void BtnVerCandidatas_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            FrmReina formularioReina = new FrmReina();

            // Mostrar el formulario
            formularioReina.Show();
        }

        private void BtnVotoReina_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            FRMVotoReina VotoReina = new FRMVotoReina();

            // Mostrar el formulario
            VotoReina.Show();
        }

        private void BtnVotarPorFotogenica_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            FrmVotarFotogenica VotoFotogenica = new FrmVotarFotogenica();

            // Mostrar el formulario
            VotoFotogenica.Show();
        }
    }
}
