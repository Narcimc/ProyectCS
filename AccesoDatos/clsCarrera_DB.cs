using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace SIEleccionReina.AccesoDatos
{
    internal class ClsCarrera_DB
    {
        private ConexionDAO objConexion;
        private SqlConnection con;
        private const string QUERY = "SP_CRUD_CARRERA";

        internal ClsCarrera_DB() => objConexion = ConexionDAO.GetInstance(); // Constructor

        internal int IngresarModificarEliminarCarrera( KeyValuePair<int, string> carrera, CarreraTipoCrud tipoCrud )
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

        internal DataTable Obtener_Carreras( CarreraTipoCrud tipoCrud )
        {
            try
            {
                DataTable ds = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter( ArmarComandoSql( new KeyValuePair<int, string>( 0, "" ), tipoCrud ) );
                adapter.Fill(ds);
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

        internal SqlCommand ArmarComandoSql( KeyValuePair<int, string> carrera, CarreraTipoCrud tipoCrud )
        {
            con = objConexion.GetOpenConnection();
            SqlCommand comando = new SqlCommand( QUERY, con ) { CommandTimeout = 1000000 };
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add( "@id_crud", SqlDbType.Int ).Value = ( int ) tipoCrud;
            comando.Parameters.Add( "@id_carrera", SqlDbType.Int ).Value = carrera.Key;
            comando.Parameters.Add( "@nombre_carrera", SqlDbType.VarChar ).Value = carrera.Value;

            return comando;
        }
    }
}
