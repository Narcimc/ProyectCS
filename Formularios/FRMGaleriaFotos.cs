using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SIEleccionReina.Formularios
{
    public partial class FRMGaleriaFotos : Form
    {
        public FRMGaleriaFotos()
        {
            InitializeComponent();
        }

        private void FRMGaleriaFotos_Load(object sender, EventArgs e)
        {
            llenarDatosAlbum();
        }

        public void llenarDatosAlbum()
        {
            DataTable tb = new DataTable();
            clsAlbum_DB Obj_Conexion = new clsAlbum_DB();

            clsAlbum Obj_Candidata = new clsAlbum()
            {
                Titulo = " "
            };

            tb = Obj_Conexion.Combo_Album(Obj_Candidata, 5);

            CmbFotosGaleria.DisplayMember = "titulo";
            CmbFotosGaleria.ValueMember = "id_album";
            CmbFotosGaleria.DataSource = tb;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            TXTTituloFoto.Clear();
            RTBDescripcionFoto.Clear();
            PBoxCargarFotografia.CancelAsync();
            CmbFotosGaleria.Dispose();
        }

        private void BTNGuardarFoto_Click(object sender, EventArgs e)
        {
            // Validar Titulo Foto
            if (String.IsNullOrEmpty(TXTTituloFoto.Text))
            {
                MessageBox.Show("Ingresa el campo nombre", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTTituloFoto.Focus();
                return;
            }

            // Validar Descripción
            if (String.IsNullOrEmpty(RTBDescripcionFoto.Text))
            {
                MessageBox.Show("Ingresa el campo nombre", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RTBDescripcionFoto.Focus();
                return;
            }


            try

            {

                // byte[] array = File.ReadAllBytes(TxtDescripcionImage.Text);

                var strImagen = ImageToBase64(PBoxCargarFotografia.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
               



                clsFoto fotoGaleria = new clsFoto()
                {
                    Titulo_foto = TXTTituloFoto.Text,
                    Descripcion = RTBDescripcionFoto.Text,
                    Foto_Album = strImagen,
                    Id_album = Convert.ToInt32(CmbFotosGaleria.SelectedValue),

                };

                clsFoto_DB canFoto = new clsFoto_DB();
                canFoto.Ingresar_Foto(fotoGaleria, 2);

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

        //Base64 String to Image


       

        private void BtnBuscarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            OFDBuscarFoto.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)| *.jpg; *.jpeg; *.gif; *.bmp;";
            if (OFDBuscarFoto.ShowDialog() == DialogResult.OK)
            {
                //TxtDescripcionImage.Text = OpenFilaFoto.FileName;
                PBoxCargarFotografia.Image = new Bitmap(OFDBuscarFoto.FileName);
            }
        }

        private void PBoxCargarFotografia_Click(object sender, EventArgs e)
        {

        }

        private void CmbFotosGaleria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblAlbum_Click(object sender, EventArgs e)
        {

        }
    }
}

