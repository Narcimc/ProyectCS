using SIEleccionReina.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIEleccionReina
{
    public partial class ModuloAdministrador : Form
    {
        public ModuloAdministrador()
        {
            InitializeComponent();
        }

        private void BtnInscripcionCandidatas_Click(object sender, EventArgs e)
        {
            RegistroDeCandidatas vRegistroCand = new RegistroDeCandidatas();
            vRegistroCand.ShowDialog();
        }

        private void BtnRegistroFoto_Click(object sender, EventArgs e)
        {
            FRMGaleriaFotos vGaleriaFot = new FRMGaleriaFotos();
            vGaleriaFot.ShowDialog();
        }

        private void BtnResultados_Click( object sender, EventArgs e )
        {
            FrmResultados vResultados = new FrmResultados();
            vResultados.ShowDialog();
        }
    }
}
