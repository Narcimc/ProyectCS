using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using System;
using System.Windows.Forms;

namespace SIEleccionReina.Formularios
{
    public partial class FRMVistaDatosCandidata : Form
    {
        private SIEleccionReinaController controlador;
        private int indexCandidata = 0;

        public FRMVistaDatosCandidata( int indexCandidata )
        {
            InitializeComponent();
            controlador = SIEleccionReinaController.Instance;
            this.indexCandidata = indexCandidata;
        }

        private void FRMVistaDatosCandidata_Load( object sender, EventArgs e )
        {
            MostrarInfoCandidata();

            if ( indexCandidata == 0 )
                BtnAtras.Enabled = false;

            if ( indexCandidata == controlador.ListaCandidatas.Count - 1 )
                BtnSiguiente.Enabled = false;
        }

        private void BTNVolverAlbum_Click( object sender, EventArgs e ) => this.Close();

        private void BtnAtras_Click( object sender, EventArgs e )
        {
            if ( !BtnSiguiente.Enabled )
                BtnSiguiente.Enabled = true;

            indexCandidata--;
            MostrarInfoCandidata();

            if ( indexCandidata == 0 )
                BtnAtras.Enabled = false;
        }

        private void BtnSiguiente_Click( object sender, EventArgs e )
        {
            if ( !BtnAtras.Enabled )
                BtnAtras.Enabled = true;

            indexCandidata++;
            MostrarInfoCandidata();

            if ( indexCandidata == controlador.ListaCandidatas.Count - 1 )
                BtnSiguiente.Enabled = false;
        }

        private void MostrarInfoCandidata()
        {
            clsCandidata candidata = controlador.ListaCandidatas[ indexCandidata ];
            LblNmbCandidata.Text = $"{candidata.Nombre} {candidata.Apellido}";
            lblEdad.Text = $"Edad: {candidata.Edad} años";
            lblCarrera.Text = $"Carrera: { candidata.Carrera.Value }";
            lblSemestre.Text = $"Semestre: {candidata.Semestre.Value}";
            lblInteresesDato.Text = $"Sus intereses son {candidata.Intereses}";
            lblHabilidadesDato.Text = $"Sus habilidades son {candidata.Habilidades}";
            lblAspiracionesDato.Text = $"Sus aspiraciones son {candidata.Aspiraciones}";
            PBOXImagenCandidata.Image = controlador.Base64ToImage( candidata.Foto );
        }
    }
}
