using SIEleccionReina.AccesoDatos;
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
    public partial class FRMSemestre : Form
    {
        public FRMSemestre()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Validar Semestre
            if (String.IsNullOrEmpty(TxtSemestre.Text))
            {
                MessageBox.Show("Ingresa el campo semestre", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtSemestre.Focus();
                return;
            }

            clsSemestre Obj_Semestre = new clsSemestre()
            {
                Numero_semestre = TxtSemestre.Text
            };

            clsSemestre_DB Obj_Conexion = new clsSemestre_DB();
            Obj_Conexion.Ingresar_Semestre(Obj_Semestre, 2);

            TxtSemestre.Clear();
        }

        

        private void FRMSemestre_Load(object sender, EventArgs e)
        {

        }

        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
