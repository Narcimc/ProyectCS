using SIEleccionReina.Control;
using System;
using System.Windows.Forms;

namespace SIEleccionReina.Formularios
{
    public partial class FrmReina : Form
    {
        private SIEleccionReinaController controlador;
        private int indexCandidata = 0;

        public FrmReina()
        {
            InitializeComponent();
            controlador = SIEleccionReinaController.Instance;
        }

        private void FrmReina_Load(object sender, EventArgs e)
        {
            controlador.MostrarInfoCandidata( lblNombreCandidata, PBOXImagenCandidata, indexCandidata );
        }

        //private void FRMFotos_Load(object sender, EventArgs e)
        //{
        //    llenarDatosFoto();
        //}

        //string QUERY = "SELECT Imagen FROM Fotos WHERE ID = @FotoID";


        //public void llenarDatosFoto()
        //{
        //    DataTable tb = new DataTable();
        //    clsFoto_DB Obj_Conexion = new clsFoto_DB();

        //    clsFoto Obj_Foto = new clsFoto()
        //    {
        //        Comentario = " "
        //    };

        //    tb = Obj_Conexion.Combo_Foto(Obj_Foto, 5);

        //}
        
        private void BtnAtras_Click(object sender, EventArgs e)
        {
            if ( !BtnSiguiente.Enabled )
                BtnSiguiente.Enabled = true;

            indexCandidata--;
            controlador.MostrarInfoCandidata( lblNombreCandidata, PBOXImagenCandidata, indexCandidata );

            if ( indexCandidata == 0 )
                BtnAtras.Enabled = false;
        }

        private void BtnSiguiente_Click( object sender, EventArgs e )
        {
            if ( !BtnAtras.Enabled )
                BtnAtras.Enabled = true;

            indexCandidata++;
            controlador.MostrarInfoCandidata( lblNombreCandidata, PBOXImagenCandidata, indexCandidata );

            if ( indexCandidata == controlador.ListaCandidatas.Count - 1 )
                BtnSiguiente.Enabled = false;
        }

        private void BTNAbrirInformacion_Click(object sender, EventArgs e)
        {
            // Crear una instancia del nuevo formulario
            FRMVistaDatosCandidata formularioinfo = new FRMVistaDatosCandidata( indexCandidata );

            // Mostrar el formulario
            formularioinfo.ShowDialog();
        }

        private void btnGuadarComentario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}
