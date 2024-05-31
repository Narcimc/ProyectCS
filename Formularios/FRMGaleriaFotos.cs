using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Entidades;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using SIEleccionReina.Control;

namespace SIEleccionReina.Formularios
{
    public partial class FRMGaleriaFotos : Form
    {
        private clsAlbum_DB Obj_Conexion;

        public FRMGaleriaFotos()
        {
            InitializeComponent();
            Obj_Conexion = new clsAlbum_DB();
        }

        private void FRMGaleriaFotos_Load(object sender, EventArgs e) => llenarDatosAlbum();

        public void llenarDatosAlbum()
        {
            DataTable tb = new DataTable();

            tb = Obj_Conexion.Combo_Album( new clsAlbum(), 5);

            CmbFotosGaleria.DisplayMember = "titulo";
            CmbFotosGaleria.ValueMember = "id_album";
            CmbFotosGaleria.DataSource = tb;
        }

        private void BTNGuardarFoto_Click(object sender, EventArgs e)
        {
            // Validar Titulo Foto
            if ( Validaciones.IsNullOrEmptyOrWhitespace( TXTTituloFoto.Text ) )
            {
                //MessageBox.Show("Ingresa el campo nombre", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EP.SetError( TXTTituloFoto, "Ingrese el campo del título, verifique nuevamente." );
                TXTTituloFoto.Focus();
                return;
            }

            // Validar Descripción
            if ( Validaciones.IsNullOrEmptyOrWhitespace( RTBDescripcionFoto.Text ) )
            {
                //MessageBox.Show("Ingresa el campo nombre", "Administradr del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EP.SetError( RTBDescripcionFoto, "Ingrese el campo de la descripción, verifique nuevamente." );
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
                MessageBox.Show( ex.ToString(), CommonUtils.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
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

        private void BTNLimpiarFoto_Click( object sender, EventArgs e )
        {
            TXTTituloFoto.Clear();
            RTBDescripcionFoto.Clear();
            PBoxCargarFotografia.CancelAsync();
            CmbFotosGaleria.Dispose();
        }
    }
}

