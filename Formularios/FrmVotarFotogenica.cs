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
    public partial class FrmVotarFotogenica : Form
    {
        public FrmVotarFotogenica()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSig_Click(object sender, EventArgs e)
        {

        }

        private void BTNVotar_Click(object sender, EventArgs e)
        {
            BTNVotar.Enabled = false;
            MessageBox.Show("¡VOTACION EXITOSA!", "VOTACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
