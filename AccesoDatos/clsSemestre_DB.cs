using SIEleccionReina.Entidades;
using System;
using System.Data.SqlClient;
using System.Data;
using SIEleccionReina.Control;
using System.Windows.Forms;

namespace SIEleccionReina.AccesoDatos
{
    [Obsolete( "DEPRECATED: Esta clase está actualmente Obsoleta y ha sido marcada para ser eliminada en una próxima iteración, " +
        "por favor evite su uso, y el de cualquiera de sus métodos, dado que actualmente carece de propósito y ya no existen los " +
        "medios en la Base de Datos para poder usarla, por lo tanto su intento de uso dará como resultado un error.", true )]
    internal class ClsSemestre_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;

        public ClsSemestre_DB()
        {
            objConexion = ConexionDAO.GetInstance();
        }

        public int Ingresar_Semestre(ClsSemestre obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_SEMESTRE";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_semestre", SqlDbType.Int).Value = obj_Info.Id_semestre;
                comando.Parameters.Add("@numero_semestre", SqlDbType.VarChar).Value = obj_Info.Numero_semestre;
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

        public DataTable Combo_semestre (ClsSemestre obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_SEMESTRE";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_semestre", SqlDbType.Int).Value = obj_Info.Id_semestre;
                comando.Parameters.Add("@numero_semestre", SqlDbType.VarChar).Value = obj_Info.Numero_semestre;
                comando.ExecuteNonQuery();
                DataTable ds = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);

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
    }
}
