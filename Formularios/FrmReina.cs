using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIEleccionReina.Formularios
{
    public partial class FrmReina : Form
    {
        private int imagenIndex = 0;
        public FrmReina()
        {
            InitializeComponent();
        }
        private void FRMFotos_Load(object sender, EventArgs e)
        {
            llenarDatosFoto();
        }

        //string query = "SELECT Imagen FROM Fotos WHERE ID = @FotoID";


        public void llenarDatosFoto()
        {
            DataTable tb = new DataTable();
            clsFoto_DB Obj_Conexion = new clsFoto_DB();

            clsFoto Obj_Foto = new clsFoto()
            {
                Comentario = " "
            };

            tb = Obj_Conexion.Combo_Foto(Obj_Foto, 5);

        }
        private void MostrarImagen()
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LblInformacion_Click(object sender, EventArgs e)
        {

        }

        private void BTNGuardarFoto_Click(object sender, EventArgs e)
        {
            //var strImagen = Base64ToImage(PBOXDevolverImagen.Image);

            //clsFoto fotoGaleria = new clsFoto()
            //{
            //    Titulo_foto = TXTTituloFoto.Text,
            //    Descripcion = RTBDescripcionFoto.Text,
            //    Foto_Album = strImagen,
            //    Id_album = Convert.ToInt32(CmbFotosGaleria.SelectedValue),

            //};

            //clsFoto_DB canFoto = new clsFoto_DB();
            //canFoto.Ingresar_Foto(fotoGaleria, 1);




        }

        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            imagenIndex++;
            MostrarImagen();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            imagenIndex++;
            MostrarImagen();
        }

        private void VerContrasenia_Click(object sender, EventArgs e)
        {

        }

        private void FrmReina_Load(object sender, EventArgs e)
        {

        }

        private void BTNAbrirInformacion_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            FRMVistaDatosCandidata formularioinfo = new FRMVistaDatosCandidata();

            // Mostrar el formulario
            formularioinfo.Show();
        }

        private void btnGuadarComentario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
