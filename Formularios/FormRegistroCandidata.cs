using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
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

                if ( Validaciones.IsNameLastNameValid( nameLastName: TxtNombres.Text.Trim(), exControl: TxtNombres ) && 
                     Validaciones.IsNameLastNameValid( nameLastName: TxtApellidos.Text.Trim(), exControl: TxtApellidos ) && 
                     Validaciones.IsUserCedulaValid( userCedula: MTxtCedula.Text, exControl: MTxtCedula ) && 
                     Validaciones.IsCarreraValid( carrera: CmbCarrera.Text, exControl: CmbCarrera ) && 
                     Validaciones.IsInteresesAspiracionesHabilidadesValid( interAspHab: TxtIntereses.Text.Trim(), exControl: TxtIntereses ) && 
                     Validaciones.IsInteresesAspiracionesHabilidadesValid( interAspHab: TxtAspiraciones.Text.Trim(), exControl: TxtAspiraciones ) && 
                     Validaciones.IsInteresesAspiracionesHabilidadesValid( interAspHab: TxtHabilidades.Text.Trim(), exControl: TxtHabilidades ) 
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
                        aspiraciones: TxtAspiraciones.Text,
                        intereses: TxtIntereses.Text,
                        habilidades: TxtHabilidades.Text
                        );

                        controlador.IngresarModificarEliminarCandidata( CandidataTipoCrud.InsertarCandidata, candidataObjInfo: candidata );
                        Close();
                    }
                }
            }
            catch ( InvalidValueException invEx )
            {
                EPRegistroCandidata.SetError( invEx.ErrorSourceControl, invEx.Message );
                invEx.ErrorSourceControl.Focus();
            }
        }

        private void BtnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            OpenFilaFoto.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)| *.jpg; *.jpeg; *.gif; *.bmp;";
            if (OpenFilaFoto.ShowDialog() == DialogResult.OK)
            {
                TxtDescriptionImage.Text = OpenFilaFoto.FileName;
                PBoxFotografia.Image = new Bitmap(OpenFilaFoto.FileName);
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