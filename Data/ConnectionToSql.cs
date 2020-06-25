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
            connectionString = "SERVER=bakwcfnopay8gvcka7a3-mysql.services.clever-cloud.com;PORT=3306;DATABASE=bakwcfnopay8gvcka7a3;UID=uvc7ggeiesuwudwp;PASSWORD=SnwJMqn7TjSAdnwIujqW;";
        }
        protected MySqlConnection GetConnection() {
            return new MySqlConnection(connectionString);
        }
        
    }
}
