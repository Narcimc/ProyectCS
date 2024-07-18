using SIEleccionReina.Control;
using SIEleccionReina.Entidades;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SIEleccionReina.AccesoDatos
{
    internal class clsCarrera_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;

        public clsCarrera_DB()
        {
            objConexion = ConexionDAO.GetInstance();
        }

        public int Ingresar_Carrera(clsCarrera obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_CARRERA";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_carrera", SqlDbType.Int).Value = obj_Info.Id_carrera;
                comando.Parameters.Add("@nombre_carrera", SqlDbType.VarChar).Value = obj_Info.Nombre_carrera;
                
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

        public DataTable Combo_Carrera(clsCarrera obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_CARRERA";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_carrera", SqlDbType.Int).Value = obj_Info.Id_carrera;
                comando.Parameters.Add("@nombre_carrera", SqlDbType.VarChar).Value = obj_Info.Nombre_carrera;
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
