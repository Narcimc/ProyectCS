using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SIEleccionReina.AccesoDatos
{
    public class ConexionDAO
    {
        private static ConexionDAO objConexion = null;
        private SqlConnection con;

        private ConexionDAO()
        {
            string connectionString = ConfigurationManager.AppSettings["ConexionSql"];
            con = new SqlConnection(connectionString);
        }

        public static ConexionDAO checkEstado()
        {
            if (objConexion == null)
            {
                objConexion = new ConexionDAO();
            }
            return objConexion;
        }

        public SqlConnection getCon()
        {
            string connectionString = ConfigurationManager.AppSettings["ConexionSql"];
            con = new SqlConnection(connectionString);
            return con;
        }

        public SqlConnection getConTanque()
        {
            string connectionString = ConfigurationManager.AppSettings["ConexionTanque"];
            con = new SqlConnection(connectionString);
            return con;
        }

        public void cerrarConexion()
        {
            objConexion = null;
        }

    }
}
