using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Data.Database
{
    public class Adapter
    {
        //Clave por defecto a utilizar en la cadena de conexión

        const string consKeyDefaultCnnString = "ConexionMaki";

        private SqlConnection _sqlConn;

        
        //Propiedad SQLConn

        public SqlConnection sqlConn
        {
            get
            {
                return _sqlConn;
            }

            set
            {
                _sqlConn = value;
            }
        }


        protected void OpenConnection()
        {
            string sqlConnection = ConfigurationManager.ConnectionStrings[consKeyDefaultCnnString].ConnectionString;
           
            sqlConn = new SqlConnection(sqlConnection);
           
            sqlConn.Open();

        }

        protected void CloseConnection()
        {
            sqlConn.Close();

            sqlConn = null;
        
        }

        protected SqlDataReader ExecuteReader(String commandText)
        {
            throw new Exception("Metodo no implementado");
        }
    }
}
