using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using SIEleccionReina.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SIEleccionReina
{
    public partial class FormRegistroCandidata : Form
    {
        private SIEleccionReinaController controlador;
        private int edad = 0;

        public FormRegistroCandidata()
        {
            InitializeComponent();
            controlador = SIEleccionReinaController.Instance;
            this.Icon = Resources.SIER_Icon_Alpha;
        }

        private void RegistroDeCandidatas_Load(object sender, EventArgs e)
        {
            CommonUtils.LlenarCombo( CmbCarrera, controlador.CarrerasDisponibles );
            EstablecerTipografias();
            CalcularEdad();
            TxtNombres.Focus();
        }

        private void EstablecerTipografias()
        {
            LblNombres.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblApellidos.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblCedula.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblCarrera.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblFechaNacimiento.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblEdad.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblEdadCantidad.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblSemestre.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblIntereses.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblAspiraciones.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            LblHabilidades.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtNombres.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtApellidos.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            MTxtCedula.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            CmbCarrera.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            DateFechaNacimiento.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            NUDSemestre.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtIntereses.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtAspiraciones.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtHabilidades.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            TxtDescriptionImage.Font = CommonUtils.PredefinedCustomFonts.ContentFont;
            BtnCargarFoto.Font = CommonUtils.PredefinedCustomFonts.SubActionButtonFont;
            BtnGuardarRegistro.Font = CommonUtils.PredefinedCustomFonts.MainActionButtonFont;
        }

        private void BtnGuardarRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                EPRegistroCandidata.Clear();
                Cursor = Cursors.WaitCursor;

                if ( Validaciones.IsNameLastNameValid( nameLastNameControl: TxtNombres ) && 
                     Validaciones.IsNameLastNameValid( nameLastNameControl: TxtApellidos ) && 
                     Validaciones.IsUserCedulaValid( cedulaControl: MTxtCedula ) && 
                     Validaciones.IsCarreraValid( carreraControl: CmbCarrera ) && 
                     Validaciones.IsInteresesAspiracionesHabilidadesValid( interAspHabControl: TxtIntereses ) && 
                     Validaciones.IsInteresesAspiracionesHabilidadesValid( interAspHabControl: TxtAspiraciones ) && 
                     Validaciones.IsInteresesAspiracionesHabilidadesValid( interAspHabControl: TxtHabilidades ) 
                    )
                {
                    if ( !controlador.VerificarRegistroCandidata( candidataCedula: MTxtCedula.Text, tipoCRUD: CandidataTipoCrud.VerificarCandidataYaExiste, exControl: BtnGuardarRegistro ) )
                    {
                        var strImagen = controlador.ImageToBase64( PBoxFotografia.Image, System.Drawing.Imaging.ImageFormat.Jpeg );

                        ClsCandidata candidata = new ClsCandidata( 0,
                        idCarrera: ( int ) CmbCarrera.SelectedValue,
                        cedula: MTxtCedula.Text,
                        nombres: TxtNombres.Text.Trim(),
                        apellidos: TxtApellidos.Text.Trim(),
                        semestre: ( int ) NUDSemestre.Value,
                        foto: strImagen,
                        fecha_nacimiento: DateFechaNacimiento.Value,
                        edad: edad,
                        aspiraciones: TxtAspiraciones.Text.Trim(),
                        intereses: TxtIntereses.Text.Trim(),
                        habilidades: TxtHabilidades.Text.Trim()
                        );

                        controlador.IngresarModificarEliminarCandidata( CandidataTipoCrud.InsertarCandidata, candidataObjInfo: candidata );
                        Cursor = Cursors.Default;

                        Close();
                    }
                }
            }
            catch ( InvalidValueException invEx )
            {
                EPRegistroCandidata.SetError( invEx.ErrorSourceControl, invEx.Message );
                Cursor = Cursors.Default;
                invEx.ErrorSourceControl.Focus();
            }
        }

        private void BtnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileFoto.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)| *.jpg; *.jpeg; *.gif; *.bmp;";
            if (OpenFileFoto.ShowDialog() == DialogResult.OK)
            {
                TxtDescriptionImage.Text = OpenFileFoto.FileName;
                PBoxFotografia.Image = new Bitmap(OpenFileFoto.FileName);
            }
        }

        private void DateFechaNacimiento_ValueChanged( object sender, EventArgs e )
        {
            CalcularEdad();
        }

        private void CalcularEdad() 
        {
            DateTime birthDate = DateFechaNacimiento.Value;
            edad = DateTime.Now.Year - birthDate.Year;
            LblEdadCantidad.Text = edad + " años";
        }
    }
}