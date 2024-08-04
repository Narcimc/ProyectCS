using SIEleccionReina.Entidades;
using System;
using System.Data.SqlClient;
using System.Data;
using SIEleccionReina.Control;
using System.Windows.Forms;

namespace SIEleccionReina.AccesoDatos
{
    internal class ClsFoto_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;

        internal ClsFoto_DB()
        {
            objConexion = ConexionDAO.GetInstance();
        }

        internal int Ingresar_Foto(ClsFoto obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_FOTO";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_foto", SqlDbType.Int).Value = obj_Info.Id_foto;
                comando.Parameters.Add("@foto_Album", SqlDbType.VarChar).Value = obj_Info.Foto_Album;
                comando.Parameters.Add("@id_album", SqlDbType.Int).Value = obj_Info.Id_album;
                comando.Parameters.Add("@titulo_foto", SqlDbType.VarChar).Value = obj_Info.Titulo_foto;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj_Info.Descripcion;
                comando.Parameters.Add("@comentario", SqlDbType.VarChar).Value = obj_Info.Comentario;
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

        internal DataTable Combo_Foto(ClsFoto obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_FOTO";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };

                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_foto", SqlDbType.Int).Value = obj_Info.Id_foto;
                comando.Parameters.Add("@id_album", SqlDbType.Int).Value = obj_Info.Id_album;
                comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = obj_Info.Titulo_foto;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj_Info.Descripcion;
                comando.Parameters.Add("@comentario", SqlDbType.VarChar).Value = obj_Info.Comentario;
                DataTable ds = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);

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
    }
}
