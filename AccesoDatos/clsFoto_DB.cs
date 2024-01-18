using SIEleccionReina.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIEleccionReina.AccesoDatos
{
    internal class clsFoto_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;
        public clsFoto_DB()
        {
            objConexion = ConexionDAO.checkEstado();
        }
        public int Ingresar_Foto(clsFoto obj_Info, int tipoCrud)
        {
            try
            {
                int respuesta = 0;
                string query = "SP_CRUD_FOTO";
                con = objConexion.getCon();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                con.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_foto", SqlDbType.Int).Value = obj_Info.Id_foto;
                comando.Parameters.Add("@foto_Album", SqlDbType.VarChar).Value = obj_Info.Foto_Album;
                comando.Parameters.Add("@id_album", SqlDbType.Int).Value = obj_Info.Id_album;
                comando.Parameters.Add("@titulo_foto", SqlDbType.VarChar).Value = obj_Info.Titulo_foto;
                comando.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = obj_Info.Descripcion;
                comando.Parameters.Add("@comentario", SqlDbType.VarChar).Value = obj_Info.Comentario;
                comando.ExecuteNonQuery();

                respuesta = 1;
                return respuesta;
            }
            catch (Exception ex)
            {
                return 0;
                throw ex.InnerException;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public DataTable Combo_Foto(clsFoto obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_FOTO";
                con = objConexion.getCon();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                con.Open();
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
            catch (Exception ex)
            {
                throw ex.InnerException;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}
