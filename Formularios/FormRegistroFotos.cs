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
    public partial class FormRegistroFotos : Form
    {
        private ClsAlbum_DB Obj_Conexion;
        private SIEleccionReinaController controlador;

        public FormRegistroFotos()
        {
            InitializeComponent();
            Obj_Conexion = new ClsAlbum_DB();
            controlador = SIEleccionReinaController.Instance;
        }

        private void FRMGaleriaFotos_Load(object sender, EventArgs e) => llenarDatosAlbum();

        public void llenarDatosAlbum()
        {
            DataTable tb = new DataTable();

            tb = Obj_Conexion.Combo_Album( new ClsAlbum(), 5);

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
                var strImagen = controlador.ImageToBase64( PBoxCargarFotografia.Image, System.Drawing.Imaging.ImageFormat.Jpeg );

                ClsFoto fotoGaleria = new ClsFoto()
                {
                    Titulo_foto = TXTTituloFoto.Text,
                    Descripcion = RTBDescripcionFoto.Text,
                    Foto_Album = strImagen,
                    Id_album = ( int ) CmbFotosGaleria.SelectedValue,
                };

                ClsFoto_DB canFoto = new ClsFoto_DB();
                canFoto.Ingresar_Foto(fotoGaleria, 2);

            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, CommonUtils.Messages.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
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

