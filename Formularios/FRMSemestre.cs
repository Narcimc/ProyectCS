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
    [Obsolete( "DEPRECATED: Esta clase está actualmente Obsoleta y ha sido marcada para ser eliminada en una próxima iteración, " +
        "por favor evite su uso, y el de cualquiera de sus métodos, dado que actualmente carece de propósito y ya no existen los " +
        "medios en la Base de Datos para poder usarla, por lo tanto su intento de uso dará como resultado un error.", true )]
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

            ClsSemestre Obj_Semestre = new ClsSemestre()
            {
                Numero_semestre = TxtSemestre.Text
            };

            ClsSemestre_DB Obj_Conexion = new ClsSemestre_DB();
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
