using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Entidades;
using SIEleccionReina.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SIEleccionReina
{
    
    public partial class FormReiFaSi : Form
    {
        public FormReiFaSi()
        {
            InitializeComponent();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            //Validar Usuario


            //Validar Contraseña



            DataTable tb = new DataTable();
            clsEstudiante_DB Obj_conexion = new clsEstudiante_DB();

            ClsEstudiante obj_Estudiante = new ClsEstudiante()
            {
                Cedula = TxtUsuario.Text,
                Contrasenia = TxtContrasenia.Text,

            };

            tb = Obj_conexion.Combo_Estudiante(obj_Estudiante, 10);

            if (tb.Rows.Count > 0)
            {
                // Ir al menu
                this.Hide();

                if (CmbTipoUsuario.Text.ToString() == "Administrador")
                {
                    ModuloAdministrador vAdministrador = new ModuloAdministrador();
                    vAdministrador.Show();
                }
                else
                {
                    FRMGaleriaFotos vFotos = new FRMGaleriaFotos();
                    vFotos.Show();
                }


            }
            else
            {
                MessageBox.Show("Ingresa el campo Usuario y Contraseña Correctamente", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsuario.Focus();
            }
        }


    

    private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void VerContrasenia_Click(object sender, EventArgs e)
        {
            // Cambiar la visibilidad de la contraseña
            if (TxtContrasenia.PasswordChar == '*')
                TxtContrasenia.PasswordChar = '\0'; // Mostrar la contraseña
            else
                TxtContrasenia.PasswordChar = '*'; // Ocultar la contraseña


        }

      

        private void FormReiFaSi_Load(object sender, EventArgs e)
        {
            llenardatosRol();
        }

        public void llenardatosRol()
        {
            
                DataTable tb = new DataTable();
                clsEstudiante_DB Obj_conexion = new clsEstudiante_DB();
                ClsEstudiante Obj_Estudiante = new ClsEstudiante();

                tb = Obj_conexion.Combo_Estudiante(Obj_Estudiante, 11);

                CmbTipoUsuario.DisplayMember = "rol_usuario";
                CmbTipoUsuario.ValueMember = "id_estudiante";
                CmbTipoUsuario.DataSource = tb;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
