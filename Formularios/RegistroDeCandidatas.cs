using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Entidades;
using SIEleccionReina.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIEleccionReina
{
    public partial class RegistroDeCandidatas : Form
    {
        public RegistroDeCandidatas()
        {
            InitializeComponent();
            // Asignar el manejador de eventos al TextBox
            TxtCedula.KeyPress += new KeyPressEventHandler(TxtCedula_KeyPress);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The selected date is " + DateFechaDeNacimiento.Value.ToShortDateString());
        }

        private void RegistroDeCandidatas_Load(object sender, EventArgs e)
        {
            llenardatos();
        }

        public void llenardatos()
        {
            DataTable tb = new DataTable();
            clsCarrera_DB Obj_conexion = new clsCarrera_DB();
            clsSemestre_DB Obj_Conexion = new clsSemestre_DB();

            clsCarrera obj_Carrera = new clsCarrera()
            {
                Nombre_carrera = ""
            };

            tb = Obj_conexion.Combo_Carrera(obj_Carrera, 1);

            CmbCarrera.DisplayMember = "nombre_carrera";
            CmbCarrera.ValueMember = "id_carrera";
            CmbCarrera.DataSource = tb;

            clsSemestre Obj_Semestre = new clsSemestre()
            {
                Numero_semestre = ""
            };

            tb = Obj_Conexion.Combo_semestre(Obj_Semestre, 1);

            CmbSemestre.DisplayMember = "numero_semestre";
            CmbSemestre.ValueMember = "id_semestre";
            CmbSemestre.DataSource = tb;
        }


        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblNombre_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            //MessageBox.Show("The selected date is " + DateFechaDeNacimiento.Value.ToShortDateString());
        }

        private void LblAspiraciones_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //private void BtnLimpiar_Click(object sender, EventArgs e)
        //{
        //    TxtCedula.Clear();
        //    TxtNombre.Clear();
        //    TxtApellido.Clear();
        //    TxtAspiraciones.Clear();
        //    TxtEdad.Clear();
        //    TxtHabilidades.Clear();
        //    TxtIntereses.Clear();
        //    TxtDescripcionImage.Clear();
        //}

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnGuardarRegistro_Click(object sender, EventArgs e)
        {
            // Valida Nombre
            if (String.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Ingresa el campo nombre", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtNombre.Focus();
                return;
            }

            //Validar Apellido
            if (String.IsNullOrEmpty(TxtApellido.Text))
            {
                MessageBox.Show("Ingresa el campo apellido", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtApellido.Focus();
                return;

            }

            //Validar Cedula
            if (String.IsNullOrEmpty(TxtCedula.Text))
            {
                MessageBox.Show("Ingresa el campo cédula", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtCedula.Focus();
                return;
            }

            //Validar Edad
            if (String.IsNullOrEmpty(TxtEdad.Text))
            {
                MessageBox.Show("Ingresa el campo edad", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtEdad.Focus();
                return;
            }

            //Validar Carrera
            if (CmbCarrera.SelectedIndex == 0)
            {
                MessageBox.Show("Ingresa el campo carrera", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbCarrera.Focus();
                return;
            }

            //Validar Semestre
            if (CmbSemestre.SelectedIndex == 0)
            {
                MessageBox.Show("Ingresa el campo semestre", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CmbSemestre.Focus();
                return;
            }

            //Validar Fecha
            if (DateFechaDeNacimiento.UseWaitCursor == false)
            //if(DateFechaDeNacimiento.Equals.DateFechaDeNacimiento.Value)
            {
                MessageBox.Show("Ingresa el campo edad", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DateFechaDeNacimiento.Focus();
                return;
            }

            //Validar Intereses
            if (String.IsNullOrEmpty(TxtIntereses.Text))
            {
                MessageBox.Show("Ingresa el campo intereses", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtIntereses.Focus();
                return;
            }

            //Validar Habilidades
            if (String.IsNullOrEmpty(TxtHabilidades.Text))
            {
                MessageBox.Show("Ingresa el campo habilidades", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtHabilidades.Focus();
                return;
            }

            //Validar Aspiraciones
            if (String.IsNullOrEmpty(TxtAspiraciones.Text))
            {
                MessageBox.Show("Ingresa el campo aspiraciones", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtAspiraciones.Focus();
                return;
            }

            try

            {

                // byte[] array = File.ReadAllBytes(TxtDescripcionImage.Text);

                var strImagen = ImageToBase64(PBoxFotografia.Image, System.Drawing.Imaging.ImageFormat.Jpeg);

                clsCandidatas candidata = new clsCandidatas()
                {
                    Apellido = TxtApellido.Text,
                    Fecha_nacimiento = DateFechaDeNacimiento.Value,
                    Nombre = TxtNombre.Text,
                    Cedula = TxtCedula.Text,
                    Edad = Int16.Parse(TxtEdad.Text),  //Convert.ToInt32(TxtEdad.Text),
                    Aspiraciones = TxtAspiraciones.Text,
                    Habilidades = TxtHabilidades.Text,
                    Intereses = TxtIntereses.Text,
                    Foto = strImagen,
                    Id_carrera = Convert.ToInt32(CmbCarrera.SelectedValue),
                    Id_semestre = Convert.ToInt32(CmbSemestre.SelectedValue)
                };
                TxtCedula.Clear();
                TxtNombre.Clear();
                TxtApellido.Clear();
                TxtAspiraciones.Clear();
                TxtEdad.Clear();
                TxtHabilidades.Clear();
                TxtIntereses.Clear();
                TxtDescripcionImage.Clear();

                clsCandidata_DB canDB = new clsCandidata_DB();
                canDB.Ingresar_Candidata(candidata, 2);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void TxtHabilidades_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verificar si la tecla presionada es un dígito o tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            if (TxtCedula.Text.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void LblApellido_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            OpenFilaFoto.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)| *.jpg; *.jpeg; *.gif; *.bmp;";
            if (OpenFilaFoto.ShowDialog() == DialogResult.OK)
            {
                TxtDescripcionImage.Text = OpenFilaFoto.FileName;
                PBoxFotografia.Image = new Bitmap(OpenFilaFoto.FileName);
            }
        }

        private void TxtDescripcionImage_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtIntereses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtHabilidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtAspiraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            //{
            //    e.Handled = true;
            //}
            //if (TxtEdad.Text.Length >= 3)
            //{
            //    e.Handled = true;
            //}
        }

        private void CmbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //private void bntSalir_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnCrearAlbum_Click(object sender, EventArgs e)
        //{
        //    // Crear una instancia del nuevo formulario
        //    FRMGaleriaFotos Galeria = new FRMGaleriaFotos();

        //    // Mostrar el formulario
        //    Galeria.Show();
        //}
    }
}