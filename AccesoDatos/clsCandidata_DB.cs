using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SIEleccionReina.AccesoDatos
{
    internal class clsCandidata_DB
    {
        private ConexionDAO objConexion;
        private SqlConnection con;
        private const string QUERY = "SP_CRUD_CANDIDATA";

        public clsCandidata_DB() => objConexion = ConexionDAO.GetInstance(); // Constructor

        public int IngresarModificarEliminarCandidata( clsCandidata obj_Info, CandidataTipoCrud tipoCrud )
        {
            try
            {
                SqlCommand comando = ArmarComandoSql( obj_Info, tipoCrud );
                comando.ExecuteNonQuery();
                return 1;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, CommonUtils.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return 0;
            }
            finally
            {
                if ( con != null )
                    objConexion.CerrarConexion();
            }
        }

        public DataTable ConsultarCandidatas( clsCandidata obj_Info, CandidataTipoCrud tipoCrud )
        {   // Método Tanto para Obtener una candidata Individual como para Obtenerlas todas
            try
            {
                DataTable ds = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter( ArmarComandoSql( obj_Info, tipoCrud ) );
                adapter.Fill( ds );
                return ds;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, CommonUtils.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Error );
                return null;
            }
            finally
            {
                if ( con != null )
                    objConexion.CerrarConexion();
            }
        }

        private SqlCommand ArmarComandoSql( clsCandidata obj_Info, CandidataTipoCrud tipoCrud )
        {
            con = objConexion.GetOpenConnection();
            SqlCommand comando = new SqlCommand( QUERY, con ) { CommandTimeout = 1000000 };

            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add( "@id_crud", SqlDbType.Int ).Value = ( int ) tipoCrud;
            comando.Parameters.Add( "@id_candidata", SqlDbType.Int ).Value = obj_Info.Id_candidata;

            switch ( tipoCrud )
            {
                case CandidataTipoCrud.InsertarCandidata:
                case CandidataTipoCrud.ModificarCantidata:
                    comando.Parameters.Add( "@id_carrera", SqlDbType.Int ).Value = obj_Info.Carrera.Key;
                    comando.Parameters.Add( "@id_semestre", SqlDbType.Int ).Value = obj_Info.Semestre.Key;
                    comando.Parameters.Add( "@cedula", SqlDbType.VarChar ).Value = obj_Info.Cedula;
                    comando.Parameters.Add( "@nombre", SqlDbType.VarChar ).Value = obj_Info.Nombre;
                    comando.Parameters.Add( "@apellido", SqlDbType.VarChar ).Value = obj_Info.Apellido;
                    comando.Parameters.Add( "@foto", SqlDbType.VarChar ).Value = obj_Info.Foto;
                    comando.Parameters.Add( "@fecha_nacimiento", SqlDbType.Date ).Value = obj_Info.Fecha_nacimiento;
                    comando.Parameters.Add( "@edad", SqlDbType.Int ).Value = obj_Info.Edad;
                    comando.Parameters.Add( "@aspiraciones", SqlDbType.VarChar ).Value = obj_Info.Aspiraciones;
                    comando.Parameters.Add( "@intereses", SqlDbType.VarChar ).Value = obj_Info.Intereses;
                    comando.Parameters.Add( "@habilidades", SqlDbType.VarChar ).Value = obj_Info.Habilidades;

                    break;
                default:
                    // Dado que el caso de ConsultaTodasCandidatas solo necesita el tipoCrud, el cual ya esta establecido, entonces no se incluye aquí
                    // Dado que el id_candidata se utiliza casi en todos los casos, también se lo establece antes del switch
                    // El único caso en el que no se utiliza el id_candidata es en el de ConsultaTodasCandidatas y en Insertar, pero tampoco pasa nada
                    // si se lo asigna o no, de todas maneras el procedimiento almacenado espera recibir ese parámetro aunque lo utilice o no, lo cual 
                    // por otro lado tampoco deberia ser así, ese sería un problema lógico del Procedimiento Almacenado en la Base de Datos, lo cual 
                    // sería bueno solucionar, pero eso es harina de otro costal
                    break;
            }

            return comando;
        }
    }
}
