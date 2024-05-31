using SIEleccionReina.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIEleccionReina.Control;
using System.Windows.Forms;

namespace SIEleccionReina.AccesoDatos
{
    internal class clsCandidata_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;

        public clsCandidata_DB()
        {
            objConexion = ConexionDAO.GetInstance();
        }
        public int Ingresar_Candidata(clsCandidatas obj_Info, int tipoCrud)
        {
            try
            {
                int respuesta = 0;
                string query = "SP_CRUD_CANDIDATA";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };

                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_candidata", SqlDbType.Int).Value = obj_Info.Id_candidata;
                comando.Parameters.Add("@id_carrera", SqlDbType.Int).Value = obj_Info.Id_carrera;
                comando.Parameters.Add("@id_semestre", SqlDbType.Int).Value = obj_Info.Id_semestre;
                comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = obj_Info.Cedula;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = obj_Info.Nombre;
                comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = obj_Info.Apellido;
                comando.Parameters.Add("@foto", SqlDbType.VarChar).Value = obj_Info.Foto;
                comando.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = obj_Info.Fecha_nacimiento;
                comando.Parameters.Add("@edad", SqlDbType.Int).Value = obj_Info.Edad;
                comando.Parameters.Add("@aspiraciones", SqlDbType.VarChar).Value = obj_Info.Aspiraciones;
                comando.Parameters.Add("@intereses", SqlDbType.VarChar).Value = obj_Info.Intereses;
                comando.Parameters.Add("@habilidades", SqlDbType.VarChar).Value = obj_Info.Habilidades;
                comando.ExecuteNonQuery();

                respuesta = 1;
                return respuesta;
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

        public DataTable Combo_Candidata(clsCandidatas obj_Info, int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_CANDIDATA";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                con.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
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
