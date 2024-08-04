using SIEleccionReina.Entidades;
using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using SIEleccionReina.Control;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Media.Media3D;

namespace SIEleccionReina.AccesoDatos
{
    internal class ClsEstudiante_DB
    {
        private ConexionDAO objConexion;
        private SqlConnection con;
        private const string QUERY = "SP_CRUD_ESTUDIANTE";

        internal ClsEstudiante_DB() => objConexion = ConexionDAO.GetInstance(); // Constructor

        internal int IngresarModificarEliminarEstudiante( object estudianteObjInfo, EstudianteTipoCRUD tipoCrud ) 
        {
            try
            {
                SqlCommand comando = ArmarComandoSql( estudianteObjInfo, tipoCrud );
                comando.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, CommonUtils.Messages.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return 0;
            }
            finally
            {
                if (con != null)
                    objConexion.CerrarConexion();
            }
        }
        
        internal DataTable ValidarLogin( ClsEstudiante estudianteObjInfo, EstudianteTipoCRUD tipoCrud )
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter( ArmarComandoSql( estudianteObjInfo, tipoCrud ) );
                adapter.Fill( dt );
                return dt;
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, CommonUtils.Messages.COMMON_ERROR_MSJ, MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return null;
            }
            finally
            {
                if ( con != null )
                    objConexion.CerrarConexion();
            }
        }

        internal SqlCommand ArmarComandoSql( object estudianteObjInfo, EstudianteTipoCRUD tipoCrud )
        {
            con = objConexion.GetOpenConnection();
            SqlCommand comando = new SqlCommand( QUERY, con ) { CommandTimeout = 1000000 };

            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add( "@id_crud", SqlDbType.Int ).Value = ( int ) tipoCrud;

            ClsEstudiante estudianteObj = null;

            if ( estudianteObjInfo is ClsEstudiante )
                estudianteObj = estudianteObjInfo as ClsEstudiante;

            switch ( tipoCrud )
            {   
                case EstudianteTipoCRUD.ValidarLoginUsuario:
                    comando.Parameters.Add( "@cedula", SqlDbType.VarChar ).Value = estudianteObj.Cedula;
                    comando.Parameters.Add( "@contrasenia", SqlDbType.VarChar ).Value = estudianteObj.Contrasenia;
                    SqlParameter rolParameter = new SqlParameter( "@id_rol_usuario", SqlDbType.Decimal );
                    rolParameter.Precision = 3; // Precisión total de dígitos
                    rolParameter.Scale = 0;     // Número de dígitos a la derecha del punto decimal
                    comando.Parameters.Add( rolParameter ).Value = estudianteObj.IdRolUsuario;

                    break;
                // Para Insertar o Modificar un estudiante si se necesitan todos los parametros
                case EstudianteTipoCRUD.InsertarEstudiante:
                case EstudianteTipoCRUD.ModificarEstudiante:
                    comando.Parameters.Add( "@id_estudiante", SqlDbType.Int ).Value = estudianteObj.Id;
                    comando.Parameters.Add( "@id_carrera", SqlDbType.Int ).Value = estudianteObj.CarreraId;
                    comando.Parameters.Add( "@semestre", SqlDbType.Int ).Value = estudianteObj.Semestre;
                    comando.Parameters.Add( "@cedula", SqlDbType.VarChar ).Value = estudianteObj.Cedula;
                    comando.Parameters.Add( "@contrasenia", SqlDbType.VarChar ).Value = estudianteObj.Contrasenia;

                    SqlParameter rolParameter2 = new SqlParameter( "@id_rol_usuario", SqlDbType.Decimal );
                    rolParameter2.Precision = 3; // Precisión total de dígitos
                    rolParameter2.Scale = 0;     // Número de dígitos a la derecha del punto decimal
                    comando.Parameters.Add( rolParameter2 ).Value = estudianteObj.IdRolUsuario;

                    break;

                // Para eliminar y para Validar un estudiante, solamente ese necesita su id
                case EstudianteTipoCRUD.EliminarEstudiante:
                    if ( estudianteObjInfo is int idEst )
                        comando.Parameters.Add( "@id_estudiante", SqlDbType.Int ).Value = idEst;

                    break;
                default:
                    break;
            }

            return comando;
        }

    }
}