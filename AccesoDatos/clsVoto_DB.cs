using SIEleccionReina.Entidades;
using System;
using System.Data.SqlClient;
using System.Data;
using SIEleccionReina.Control;
using System.Windows.Forms;

namespace SIEleccionReina.AccesoDatos
{
    internal class clsVoto_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;

        public clsVoto_DB()
        {
            objConexion = ConexionDAO.GetInstance();
        }

        public int Ingresar_Voto(clsVoto obj_Info, int tipoCrud)
        {
            try
            {
                int respuesta = 0;
                string query = "SP_CRUD_VOTO";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_voto", SqlDbType.Int).Value = obj_Info.Id_voto;
                comando.Parameters.Add("@id_estudiante", SqlDbType.Int).Value = obj_Info.Id_estudiante;
                comando.Parameters.Add("@id_candidata", SqlDbType.Int).Value = obj_Info.Id_candidata;
                comando.Parameters.Add("@tipo_voto", SqlDbType.VarChar).Value = obj_Info.Tipo_voto;
                comando.ExecuteNonQuery();

                respuesta = 1;
                return respuesta;
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

        public DataTable Combo_Voto(clsVoto obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_VOTO";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_voto", SqlDbType.Int).Value = obj_Info.Id_voto;
                comando.Parameters.Add("@id_estudiante", SqlDbType.Int).Value = obj_Info.Id_estudiante;
                comando.Parameters.Add("@id_candidata", SqlDbType.Int).Value = obj_Info.Id_candidata;
                comando.Parameters.Add("@tipo_voto", SqlDbType.VarChar).Value = obj_Info.Tipo_voto;
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
