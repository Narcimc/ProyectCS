using SIEleccionReina.Entidades;
using System;
using System.Data.SqlClient;
using System.Data;
using SIEleccionReina.Control;
using System.Windows.Forms;

namespace SIEleccionReina.AccesoDatos
{
    internal class clsSemestre_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;

        public clsSemestre_DB()
        {
            objConexion = ConexionDAO.GetInstance();
        }

        public int Ingresar_Semestre(clsSemestre obj_Info, int tipoCrud)
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
                MessageBox.Show( ex.Message, CommonUtils.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Error );
                return 0;
            }
            finally
            {
                if ( con != null )
                    objConexion.CerrarConexion();
            }
        }

        public DataTable Combo_semestre (clsSemestre obj_Info, int tipoCrud)
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
