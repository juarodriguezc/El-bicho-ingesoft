using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace Business
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql() {
            //connectionString = "Server=SEBASFX504;DataBase = ymca_user_control; integrated security = true";
            //connectionString = "Server = DESKTOP-36J0QHR; DataBase = ymca-user-control; integrated security = true";
            //Acá se reemplaza con el servidor de cada uno
            connectionString = "SERVER=sql10.freesqldatabase.com;PORT=3306;DATABASE=sql10347393;UID=sql10347393;PASSWORD=IcEtYN5t3d;";
        }
        protected MySqlConnection GetConnection() {
            return new MySqlConnection(connectionString);
        }
        
    }
}
