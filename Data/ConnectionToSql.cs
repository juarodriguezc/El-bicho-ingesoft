using System;
using System.Data.SqlClient;
namespace Business
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql() {
            connectionString = "Server = DESKTOP-36J0QHR; DataBase = ymca-user-control; integrated security = true";
            //Acá se reemplaza con el servidor de cada uno
        }
        protected SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }
    }
}
