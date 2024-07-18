using SIEleccionReina.AccesoDatos;
using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using SIEleccionReina.Formularios;
using System;
using System.Data;
using System.Windows.Forms;

namespace SIEleccionReina
{
    public partial class FormReiFaSi : Form
    {
        private clsEstudiante_DB Obj_conexion;
        private ClsEstudiante obj_Estudiante;
        private SIEleccionReinaController controlador;

        public FormReiFaSi()
        {
            InitializeComponent();
            Obj_conexion = new clsEstudiante_DB();
            obj_Estudiante = new ClsEstudiante();
            controlador = SIEleccionReinaController.Instance;
        }
       
        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();

            obj_Estudiante.Cedula = TxtUsuario.Text;
            obj_Estudiante.Contrasenia = TxtContrasenia.Text;
            obj_Estudiante.Rol_usuario = CmbTipoUsuario.Text.ToString();

            tb = Obj_conexion.ValidarLogin(obj_Estudiante, 10); // Validar Usuario y Contraseña

            if ( tb != null && tb.Rows.Count > 0 )
            {
                controlador.RegistrarEstudianteLogueado( datosEstudiante: tb );
                controlador.VerificarVotosRegistradosEstudiante();
                controlador.ObtenerCandidatas();

                // Ir al menu
                this.Hide();

                if ( CmbTipoUsuario.Text.ToString().Equals( "Administrador", StringComparison.InvariantCultureIgnoreCase ) )
                {
                    ModuloAdministrador vAdministrador = new ModuloAdministrador();
                    vAdministrador.ShowDialog();
                }
                else
                {
                    FrmEstudiante ventanaPrincipalEstudiante = new FrmEstudiante();
                    ventanaPrincipalEstudiante.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese los campos Usuario y Contraseña correctamente, o selecciona el Rol que corresponde al usuario de manera correcta", "Administrador del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsuario.Focus();
            }
        }

        private void VerContrasenia_Click(object sender, EventArgs e)
        {
            // Cambiar la visibilidad de la contraseña
            if (TxtContrasenia.PasswordChar == '*')
                TxtContrasenia.PasswordChar = '\0'; // Mostrar la contraseña
            else
                TxtContrasenia.PasswordChar = '*'; // Ocultar la contraseña
        }

        private void FormReiFaSi_Load(object sender, EventArgs e) => llenardatosRol();

        public void llenardatosRol()
        {
            DataTable tb = new DataTable();
            
            tb = Obj_conexion.Combo_Estudiante( tipoCrud: 11 );
            
            CmbTipoUsuario.DisplayMember = "rol_usuario";
            CmbTipoUsuario.ValueMember = "id_estudiante";
            CmbTipoUsuario.DataSource = tb;
        }

        private void TxtContrasenia_KeyUp( object sender, KeyEventArgs e )
        {
            if ( e.KeyCode == Keys.Enter )
                BtnAcceder.PerformClick();
        }

    }
}
