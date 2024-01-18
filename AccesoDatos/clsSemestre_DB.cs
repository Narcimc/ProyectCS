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
    internal class clsSemestre_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;
        public clsSemestre_DB()
        {
            objConexion = ConexionDAO.checkEstado();
        }
        public int Ingresar_Semestre(clsSemestre obj_Info, int tipoCrud)
        {
            try
            {
                int respuesta = 0;
                string query = "SP_CRUD_SEMESTRE";
                con = objConexion.getCon();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                con.Open();
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_semestre", SqlDbType.Int).Value = obj_Info.Id_semestre;
                comando.Parameters.Add("@numero_semestre", SqlDbType.VarChar).Value = obj_Info.Numero_semestre;
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

        public DataTable Combo_semestre (clsSemestre obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_SEMESTRE";
                con = objConexion.getCon();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                con.Open();
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
