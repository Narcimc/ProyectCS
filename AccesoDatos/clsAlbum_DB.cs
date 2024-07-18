using SIEleccionReina.Entidades;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using SIEleccionReina.Control;

namespace SIEleccionReina.AccesoDatos
{
    internal class clsAlbum_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;

        public clsAlbum_DB()
        {
            objConexion = ConexionDAO.GetInstance();
        }

        public int Ingresar_Album(clsAlbum obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_ALBUMES";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_album", SqlDbType.Int).Value = obj_Info.Id_album;
                comando.Parameters.Add("@id_candidata", SqlDbType.Int).Value = obj_Info.Id_candidata;
                comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = obj_Info.Titulo;
                
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

        public DataTable Combo_Album(clsAlbum obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_ALBUMES";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_album", SqlDbType.Int).Value = obj_Info.Id_album;
                comando.Parameters.Add("@id_candidata", SqlDbType.Int).Value = obj_Info.Id_candidata;
                comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = obj_Info.Titulo;
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
