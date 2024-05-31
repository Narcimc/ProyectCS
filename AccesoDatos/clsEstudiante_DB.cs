using SIEleccionReina.Entidades;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using SIEleccionReina.Control;

namespace SIEleccionReina.AccesoDatos
{
    internal class clsEstudiante_DB
    {
        private ConexionDAO objConexion;
        private SqlCommand comando;
        private SqlConnection con;
        private static ClsEstudiante _estudianteLogueado;

        internal static ClsEstudiante EstudianteLogueado { get => _estudianteLogueado; set => _estudianteLogueado =  value ; }

        public clsEstudiante_DB()
        {
            objConexion = ConexionDAO.GetInstance();
        }

        public int Ingresar_Estudiante(ClsEstudiante obj_Info, int tipoCrud)
        {
            try
            {
                int respuesta = 0;
                string query = "SP_CRUD_ESTUDIANTE";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                //con.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                comando.Parameters.Add("@id_estudiante", SqlDbType.Int).Value = obj_Info.Id_estudiante;
                comando.Parameters.Add("@id_semestre", SqlDbType.Int).Value = obj_Info.Id_semestre;
                comando.Parameters.Add("@id_carrera", SqlDbType.Int).Value = obj_Info.Id_carrera;
                comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = obj_Info.Cedula;
                comando.Parameters.Add("@contrasenia", SqlDbType.VarChar).Value = obj_Info.Contrasenia;
                comando.Parameters.Add("@rol_usuario", SqlDbType.VarChar).Value = obj_Info.Rol_usuario;

                respuesta = comando.ExecuteNonQuery();
                return respuesta;
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, CommonUtils.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return 0;
            }
            finally
            {
                if (con != null)
                    objConexion.CerrarConexion();
            }
        }

        public DataTable Combo_Estudiante(int tipoCrud)
        {
            try
            {
                string query = "SP_CRUD_ESTUDIANTE";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand(query, con)
                {
                    CommandTimeout = 1000000
                };
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
                DataTable ds = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(comando);

                adapter.Fill(ds);

                return ds;
            }
            catch (Exception ex)
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
    
        public DataTable ValidarLogin( ClsEstudiante obj_Info, int tipoCrud )
        {
            try
            {
                string query = "SP_CRUD_ESTUDIANTE";
                con = objConexion.GetOpenConnection();
                comando = new SqlCommand( query, con )
                {
                    CommandTimeout = 1000000
                };
                //con.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add( "@id_crud", SqlDbType.Int ).Value = tipoCrud;
                comando.Parameters.Add( "@cedula", SqlDbType.VarChar ).Value = obj_Info.Cedula;
                comando.Parameters.Add( "@contrasenia", SqlDbType.VarChar ).Value = obj_Info.Contrasenia;
                comando.Parameters.Add( "@rol_usuario", SqlDbType.VarChar ).Value = obj_Info.Rol_usuario;

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter( comando );

                adapter.Fill( dt );

                return dt;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, CommonUtils.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return null;
            }
            finally
            {
                if ( con != null )
                    objConexion.CerrarConexion();
            }

        }

        //public DataTable Combo_Validar(ClsEstudiante obj_Info, int tipoCrud)
        //{
        //    try
        //    {
        //        string query = "SP_CRUD_ESTUDIANTE";
        //        con = objConexion.GetOpenConnection();
        //        comando = new SqlCommand(query, con)
        //        {
        //            CommandTimeout = 1000000
        //        };
        //        con.Open();
        //        comando.CommandType = CommandType.StoredProcedure;
        //        comando.Parameters.Add("@id_crud", SqlDbType.Int).Value = tipoCrud;
        //        //using (SqlConnection connection = new SqlConnection(CadenaDeConexion))
        //        //{
        //        //    connection.Open();

        //        using (SqlCommand command = new SqlCommand("SP_CRUD_ESTUDIANTE"))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;

        //            //// Agregar parámetros al procedimiento almacenado
        //            //command.Parameters.Add("@cedula", ced);
        //            //command.Parameters.AddWithValue("@Contrasenia", contrasenia);

        //            ////// Agregar parámetro de salida para obtener el resultado
        //            //sqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit);
        //            //resultadoParam.Direction = ParameterDirection.Output;
        //            //command.Parameters.Add(resultadoParam);

        //            ////// Ejecutar el procedimiento almacenado
        //            ////command.ExecuteNonQuery();

        //            //// Obtener el resultado del parámetro de salida
        //            //bool resultado = (bool)resultadoParam.Value;

        //            //return resultado;
        //        }
        //    }
        //}
        //DataTable ds = new DataTable();
        //SqlDataAdapter adapter = new SqlDataAdapter(comando);

        //adapter.Fill(ds);

        //    return ds;
        ////}
        //catch (Exception ex)
        //{
        //    throw ex.InnerException;
        //}
        //finally
        //{
        //    if (con != null)
        //    {
        //        con.Close();
        //    }
    }
}