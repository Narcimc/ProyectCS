using SIEleccionReina.Control;
using System;
using System.Windows.Forms;

namespace SIEleccionReina.Formularios
{
    public partial class FormVotoFotogenica : Form
    {
        private SIEleccionReinaController controlador;
        private int indexCandidata = 0;

        public FormVotoFotogenica()
        {
            InitializeComponent();
            controlador = SIEleccionReinaController.Instance;
        }

        private void FrmVotarFotogenica_Load( object sender, EventArgs e )
        {
            if ( controlador.EstudianteVotoFotogeniaYaRegistrado )
                controlador.VotoYaRegistradoButtonPreparer( botonVotar: this.BTNVotar );

            controlador.MostrarInfoCandidata( LblNmbCandidata, PBOXImagenCandidata, indexCandidata );
        }

        private void BTNVotar_Click(object sender, EventArgs e)
        {   // TODO: Establecer apropiadamente el idCandidata cuando este lista la coleccion de candidatas
            if ( controlador.Votar( idCandidata: controlador.ListaCandidatas[ indexCandidata ].Id, tipoVoto: TipoVoto.Fotogenia ) > 0 )
            {
                MessageBox.Show( "¡VOTACIÓN EXITOSA!", "Votación de Miss Fotogenia de la UG", MessageBoxButtons.OK, MessageBoxIcon.Information );
                controlador.VotoYaRegistradoButtonPreparer( botonVotar: this.BTNVotar );
                controlador.EstudianteVotoFotogeniaYaRegistrado = true;
            }
            else
                MessageBox.Show( CommonUtils.Messages.ERROR_AL_VOTAR_MSJ, "VOTACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
        }

        private void BtnAtras_Click( object sender, EventArgs e )
        {
            if ( !BtnSiguiente.Enabled )
                BtnSiguiente.Enabled = true;

            indexCandidata--;
            controlador.MostrarInfoCandidata( LblNmbCandidata, PBOXImagenCandidata, indexCandidata );

            if ( indexCandidata == 0 )
                BtnAtras.Enabled = false;
        }

        private void BtnSiguiente_Click( object sender, EventArgs e )
        {
            if ( !BtnAtras.Enabled )
                BtnAtras.Enabled = true;

            indexCandidata++;
            controlador.MostrarInfoCandidata( LblNmbCandidata, PBOXImagenCandidata, indexCandidata );

            if ( indexCandidata == controlador.ListaCandidatas.Count - 1 )
                BtnSiguiente.Enabled = false;
        }

        private void BTNSalir_Click(object sender, EventArgs e) => this.Close();
    }
}
