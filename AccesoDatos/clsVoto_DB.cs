using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SIEleccionReina.AccesoDatos
{
    internal class ClsVoto_DB
    {
        private ConexionDAO objConexion;
        private SqlConnection con;
        private const string QUERY = "SP_CRUD_VOTO";

        internal ClsVoto_DB() => objConexion = ConexionDAO.GetInstance(); // Constructor

        internal int Ingresar_Voto( ClsVoto obj_Info, VotoTipoCRUD tipoCrud )
        {
            try
            {
                SqlCommand comando = ArmarComandoSql( obj_Info, tipoCrud );
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

        internal bool VerificarVotoRegistrado( ClsVoto obj_Info, VotoTipoCRUD tipoCrud )
        {
            try
            {
                SqlCommand comando = ArmarComandoSql( obj_Info, tipoCrud );
                SqlDataReader reader = comando.ExecuteReader( CommandBehavior.SingleRow );
                reader.Read();
                return reader.GetBoolean( 0 );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, CommonUtils.Messages.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Error );
                return false;
            }
            finally
            {
                if ( con != null )
                    objConexion.CerrarConexion();
            }
        }

        private SqlCommand ArmarComandoSql( ClsVoto obj_Info, VotoTipoCRUD tipoCrud )
        {
            con = objConexion.GetOpenConnection();
            SqlCommand comando = new SqlCommand( QUERY, con ) { CommandTimeout = 1000000 };

            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add( "@id_crud", SqlDbType.Int ).Value = ( int ) tipoCrud;
            comando.Parameters.Add( "@id_voto", SqlDbType.Int ).Value = obj_Info.Id_voto;
            comando.Parameters.Add( "@id_estudiante", SqlDbType.Int ).Value = obj_Info.Id_estudiante;
            comando.Parameters.Add( "@id_candidata", SqlDbType.Int ).Value = obj_Info.Id_candidata;
            comando.Parameters.Add( "@tipo_voto", SqlDbType.VarChar ).Value = obj_Info.Tipo_voto;

            return comando;
        }
    }
}
