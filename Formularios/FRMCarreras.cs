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
    public partial class FRMCarreras : Form
    {
        public FRMCarreras()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Validar Carrera
            if (String.IsNullOrEmpty(TxtCarrera.Text))
            {
                MessageBox.Show("Ingresa el campo carrera", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCarrera.Focus();
                return;
            }

            clsCarrera Obj_Carrera = new clsCarrera()
            {
                Nombre_carrera = TxtCarrera.Text
            };

            clsCarrera_DB Obj_Conexion = new clsCarrera_DB();
            Obj_Conexion.Ingresar_Carrera(Obj_Carrera, 2);


        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtCarrera.Clear();
        }

        private void FRMCarreras_Load(object sender, EventArgs e)
        {

        }
    }
}
