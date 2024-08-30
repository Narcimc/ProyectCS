using SIEleccionReina.Control;
using SIEleccionReina.Properties;
using System;
using System.Windows.Forms;

namespace SIEleccionReina.Formularios
{
    public partial class FormCandidatas : Form
    {
        private SIEleccionReinaController controlador;
        private int indexCandidata = 0;

        public FormCandidatas()
        {
            InitializeComponent();
            controlador = SIEleccionReinaController.Instance;
            this.Icon = Resources.SIER_Icon_Alpha;
        }

        private void FrmReina_Load(object sender, EventArgs e)
        {
            controlador.MostrarInfoCandidata( lblNombreCandidata, PBOXImagenCandidata, indexCandidata );
        }

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
            FormInfoDetallesCandidata formularioinfo = new FormInfoDetallesCandidata( indexCandidata );

            // Mostrar el formulario
            formularioinfo.ShowDialog();
        }

        private void btnGuadarComentario_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}
