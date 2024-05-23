using SIEleccionReina.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                int respuesta = 0;
                string query = "SP_CRUD_CARRERA";
                con = objConexion.GetConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                con.Open();
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_carrera", SqlDbType.Int).Value = obj_Info.Id_carrera;
                comando.Parameters.Add("@nombre_carrera", SqlDbType.VarChar).Value = obj_Info.Nombre_carrera;
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

        public DataTable Combo_Carrera(clsCarrera obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_CARRERA";
                con = objConexion.GetConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                con.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_carrera", SqlDbType.Int).Value = obj_Info.Id_carrera;
                comando.Parameters.Add("@nombre_carrera", SqlDbType.VarChar).Value = obj_Info.Nombre_carrera;
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
