using System;
using System.Data.SqlClient;
namespace Business
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql() {
            connectionString = "Server=SEBASFX504;DataBase = ymca_user_control; integrated security = true";
            //Acá se reemplaza con el servidor de cada uno
        }
        protected SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        }
    }
}
