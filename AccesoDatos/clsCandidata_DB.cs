using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SIEleccionReina.AccesoDatos
{
    internal class ClsCandidata_DB
    {
        private ConexionDAO objConexion;
        private SqlConnection con;
        private const string QUERY = "SP_CRUD_CANDIDATA";

        internal ClsCandidata_DB() => objConexion = ConexionDAO.GetInstance(); // Constructor

        internal int IngresarModificarEliminarCandidata( CandidataTipoCrud tipoCrud, object candidataObjInfo )
        {
            try
            {
                SqlCommand comando = ArmarComandoSql( tipoCrud, candidataObjInfo );
                comando.ExecuteNonQuery();
                return 1;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, CommonUtils.Messages.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return 0;
            }
            finally
            {
                if ( con != null )
                    objConexion.CerrarConexion();
            }
        }

        internal DataTable ConsultarCandidatas( CandidataTipoCrud tipoCrud ) 
        {
            try
            {
                DataTable ds = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter( ArmarComandoSqlBase( tipoCrud ) );
                adapter.Fill( ds );
                return ds;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, CommonUtils.Messages.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Error );
                return null;
            }
            finally
            {
                if ( con != null )
                    objConexion.CerrarConexion();
            }
        }

        internal DataTable ConsultarCandidatas( CandidataTipoCrud tipoCrud, object candidataObjInfo )
        {   
            try
            {
                DataTable ds = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter( ArmarComandoSql( tipoCrud, candidataObjInfo ) );
                adapter.Fill( ds );
                return ds;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, CommonUtils.Messages.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Error );
                return null;
            }
            finally
            {
                if ( con != null )
                    objConexion.CerrarConexion();
            }
        }

        private SqlCommand ArmarComandoSqlBase( CandidataTipoCrud tipoCrud ) 
        {
            con = objConexion.GetOpenConnection();
            SqlCommand comando = new SqlCommand( QUERY, con ) { CommandTimeout = 1000000 };
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add( "@id_crud", SqlDbType.Int ).Value = ( int ) tipoCrud;
            return comando;
        }

        private SqlCommand ArmarComandoSql( CandidataTipoCrud tipoCrud, object candidataObjInfo )
        {
            SqlCommand comando = ArmarComandoSqlBase( tipoCrud );

            ClsCandidata candidataObj = null;

            if ( candidataObjInfo is ClsCandidata )
                candidataObj = candidataObjInfo as ClsCandidata;

            switch ( tipoCrud )
            {
                case CandidataTipoCrud.InsertarCandidata:
                case CandidataTipoCrud.ModificarCandidata:
                    comando.Parameters.Add( "@id_candidata", SqlDbType.Int ).Value = candidataObj.Id;
                    comando.Parameters.Add( "@id_carrera", SqlDbType.Int ).Value = candidataObj.CarreraId;
                    comando.Parameters.Add( "@semestre", SqlDbType.Int ).Value = candidataObj.Semestre;
                    comando.Parameters.Add( "@cedula", SqlDbType.VarChar ).Value = candidataObj.Cedula;
                    comando.Parameters.Add( "@nombres", SqlDbType.VarChar ).Value = candidataObj.Nombres;
                    comando.Parameters.Add( "@apellidos", SqlDbType.VarChar ).Value = candidataObj.Apellidos;
                    comando.Parameters.Add( "@foto", SqlDbType.VarChar ).Value = candidataObj.Foto;
                    comando.Parameters.Add( "@fecha_nacimiento", SqlDbType.Date ).Value = candidataObj.Fecha_nacimiento;
                    comando.Parameters.Add( "@edad", SqlDbType.Int ).Value = candidataObj.Edad;
                    comando.Parameters.Add( "@aspiraciones", SqlDbType.VarChar ).Value = candidataObj.Aspiraciones;
                    comando.Parameters.Add( "@intereses", SqlDbType.VarChar ).Value = candidataObj.Intereses;
                    comando.Parameters.Add( "@habilidades", SqlDbType.VarChar ).Value = candidataObj.Habilidades;

                    break;
                case CandidataTipoCrud.ConsultaIndividualCandidata:
                case CandidataTipoCrud.EliminarCandidata:
                    if ( candidataObjInfo is int idCand )
                        comando.Parameters.Add( "@id_candidata", SqlDbType.Int ).Value = idCand;

                    break;
                default:
                    break;
            }

            return comando;
        }
    }
}
