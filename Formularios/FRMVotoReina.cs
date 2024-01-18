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
    public partial class FRMVotoReina : Form
    {
        public FRMVotoReina()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void LblNmbCandidata_Click(object sender, EventArgs e)
        {

        }

        private void BTNVotar_Click(object sender, EventArgs e)
        {
            BTNVotar.Enabled = false;
            MessageBox.Show("¡VOTACION EXITOSA!", "VOTACION" , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnFotogenica_Click(object sender, EventArgs e)
        {
            FrmVotarFotogenica votoFotogenica = new FrmVotarFotogenica();
            votoFotogenica.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
