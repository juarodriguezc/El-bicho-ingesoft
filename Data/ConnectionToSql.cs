using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;

namespace Business
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql() {
            connectionString = "SERVER=bakwcfnopay8gvcka7a3-mysql.services.clever-cloud.com;PORT=3306;DATABASE=bakwcfnopay8gvcka7a3;UID=uvc7ggeiesuwudwp;PASSWORD=SnwJMqn7TjSAdnwIujqW;";
        }
        protected MySqlConnection GetConnection() {
            return new MySqlConnection(connectionString);
        }
        
    }
}
