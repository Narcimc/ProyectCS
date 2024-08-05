using SIEleccionReina.Control;
using System;
using System.Windows.Forms;

namespace SIEleccionReina.Formularios
{
    public partial class FormVotoReina : Form
    {
        private SIEleccionReinaController controlador;
        private int indexCandidata = 0;

        public FormVotoReina()
        {
            InitializeComponent();
            controlador = SIEleccionReinaController.Instance;
        }

        private void FRMVotoReina_Load( object sender, EventArgs e )
        {
            if( controlador.EstudianteVotoReinaYaRegistrado )
                controlador.VotoYaRegistradoButtonPreparer( botonVotar: this.BTNVotar );

            controlador.MostrarInfoCandidata( LblNmbCandidata, PBOXImagenCandidata, indexCandidata );
        }

        private void BTNVotar_Click(object sender, EventArgs e)
        {
            if ( controlador.Votar( idCandidata: controlador.ListaCandidatas[ indexCandidata ].Id, tipoVoto: TipoVoto.Reina ) > 0 )
            {
                MessageBox.Show( "¡VOTACION EXITOSA!", "Votación de Reina de la UG", MessageBoxButtons.OK, MessageBoxIcon.Information );
                controlador.VotoYaRegistradoButtonPreparer( botonVotar: this.BTNVotar );
                controlador.EstudianteVotoReinaYaRegistrado = true;
            }
            else
                MessageBox.Show( CommonUtils.Messages.ERROR_AL_VOTAR_MSJ, "VOTACION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
        }

        private void BtnFotogenica_Click(object sender, EventArgs e)
        {
            FormVotoFotogenica votoFotogenica = new FormVotoFotogenica();
            votoFotogenica.ShowDialog();
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
            if( !BtnAtras.Enabled )
                BtnAtras.Enabled = true;

            indexCandidata++;
            controlador.MostrarInfoCandidata( LblNmbCandidata, PBOXImagenCandidata, indexCandidata );
            
            if( indexCandidata == controlador.ListaCandidatas.Count - 1 )
                BtnSiguiente.Enabled = false;
        }

        private void btnSalir_Click( object sender, EventArgs e ) => this.Close();
    }
}
