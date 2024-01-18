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
    internal class clsAlbum_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;
        public clsAlbum_DB()
        {
            objConexion = ConexionDAO.checkEstado();
        }
        public int Ingresar_Album(clsAlbum obj_Info, int tipoCrud)
        {
            try
            {
                int respuesta = 0;
                string query = "SP_CRUD_ALBUMES";
                con = objConexion.getCon();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                con.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_album", SqlDbType.Int).Value = obj_Info.Id_album;
                comando.Parameters.Add("@id_candidata", SqlDbType.Int).Value = obj_Info.Id_candidata;
                comando.Parameters.Add("@titulo", SqlDbType.VarChar).Value = obj_Info.Titulo;
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

        public DataTable Combo_Album(clsAlbum obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_ALBUMES";
                con = objConexion.getCon();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                con.Open();
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
