using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SIEleccionReina.AccesoDatos
{
    internal class ClsCarrera_DB
    {
        private ConexionDAO objConexion;
        private SqlConnection con;
        private const string QUERY = "SP_CRUD_CARRERA";

        public ClsCarrera_DB() => objConexion = ConexionDAO.GetInstance(); // Constructor

        public int Ingresar_Carrera( KeyValuePair<int?, string> carrera, CarreraTipoCrud tipoCrud )
        {
            try
            {
                SqlCommand comando = ArmarComandoSql( carrera, tipoCrud );
                comando.ExecuteNonQuery();
                return 1;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, CommonUtils.Messages.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Error );
                return 0;
            }
            finally
            {
                if ( con != null )
                    objConexion.CerrarConexion();
            }
        }

        public DataTable Obtener_Carreras( CarreraTipoCrud tipoCrud )
        {
            try
            {
                DataTable ds = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter( ArmarComandoSql( null, tipoCrud ) );
                adapter.Fill(ds);
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

        private SqlCommand ArmarComandoSql( KeyValuePair<int?, string>? carrera, CarreraTipoCrud tipoCrud )
        {
            con = objConexion.GetOpenConnection();
            SqlCommand comando = new SqlCommand( QUERY, con ) { CommandTimeout = 1000000 };

            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add( "@id_crud", SqlDbType.Int ).Value = ( int ) tipoCrud;

            if ( carrera.Value.Key != null )
                comando.Parameters.Add( "@id_carrera", SqlDbType.Int ).Value = carrera.Value.Value;

            if ( tipoCrud.Equals( CarreraTipoCrud.InsertarCarrera ) || tipoCrud.Equals( CarreraTipoCrud.ModificarCarrera ) )
                comando.Parameters.Add( "@nombre_carrera", SqlDbType.VarChar ).Value = carrera.Value.Value;

            return comando;
        }
    }
}
