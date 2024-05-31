using SIEleccionReina.AccesoDatos;
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

        public FormReiFaSi()
        {
            InitializeComponent();
            Obj_conexion = new clsEstudiante_DB();
            obj_Estudiante = new ClsEstudiante();
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
                RegistrarEstudianteLogueado( datosEstudiante: tb );

                // Ir al menu
                this.Hide();

                if ( CmbTipoUsuario.Text.ToString().Equals( "Administrador", StringComparison.InvariantCultureIgnoreCase ) )
                {
                    ModuloAdministrador vAdministrador = new ModuloAdministrador();
                    vAdministrador.Show();
                }
                else
                {
                    FRMGaleriaFotos vFotos = new FRMGaleriaFotos();
                    vFotos.Show();
                }
            }
            else
            {
                MessageBox.Show("Ingrese los campos Usuario y Contraseña correctamente, o selecciona el Rol que corresponde al usuario de manera correcta", "Administrador del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsuario.Focus();
            }
        }

        private void RegistrarEstudianteLogueado( DataTable datosEstudiante )
        {
            clsEstudiante_DB.EstudianteLogueado = new ClsEstudiante()
            {
                Id_estudiante = ( int ) datosEstudiante.Rows[ 0 ]["id_estudiante"],
                Id_semestre = ( int ) datosEstudiante.Rows[ 0 ][ "id_semestre" ],
                Id_carrera = ( int ) datosEstudiante.Rows[ 0 ][ "id_carrera" ],
                Cedula = datosEstudiante.Rows[ 0 ][ "cedula" ].ToString(),
                Contrasenia = datosEstudiante.Rows[ 0 ][ "contrasenia" ].ToString(),
                Rol_usuario = datosEstudiante.Rows[ 0 ][ "rol_usuario" ].ToString()
            };
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
