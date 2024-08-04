using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Control;
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
            try
            {
                Validaciones.IsCarreraValid( TxtCarrera.Text, TxtCarrera );
                ClsCarrera_DB Obj_Conexion = new ClsCarrera_DB();
                Obj_Conexion.IngresarModificarEliminarCarrera( new KeyValuePair<int, string>( 0, TxtCarrera.Text ), CarreraTipoCrud.InsertarCarrera );
            }
            catch ( InvalidValueException invex )
            {
                MessageBox.Show( invex.Message + "\nEl control que produjo el error es: " + invex.ErrorSourceControl.Name, "Carrera no válida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                TxtCarrera.Focus();
            }
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
