using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SIEleccionReina.AccesoDatos
{
    internal class ConexionDAO
    {
        private static ConexionDAO objConexion = null;
        private SqlConnection con;

        private ConexionDAO()
        {
            string connectionString = ConfigurationManager.AppSettings["ConexionSql"];
            con = new SqlConnection(connectionString);
        }

        internal static ConexionDAO GetInstance()
        {
            if (objConexion == null)
            {
                objConexion = new ConexionDAO();
            }
            return objConexion;
        }

        internal SqlConnection GetOpenConnection()
        {
            if ( con.State == ConnectionState.Closed )
                con.Open();

            return con;
        }

        internal void CerrarConexion()
        {
            if ( con.State == ConnectionState.Open )
                con.Close();
        }
    }
}
