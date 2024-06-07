﻿using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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

        public static ConexionDAO GetInstance()
        {
            if (objConexion == null)
            {
                objConexion = new ConexionDAO();
            }
            return objConexion;
        }

        public SqlConnection GetOpenConnection()
        {
            if ( con.State == ConnectionState.Closed )
                con.Open();

            return con;
        }

        public void CerrarConexion()
        {
            if ( con.State == ConnectionState.Open )
                con.Close();
        }
    }
}
