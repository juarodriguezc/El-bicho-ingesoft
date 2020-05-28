using Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class UserDao:ConnectionToSql
    {
        public bool Login(string correo, string contrasenia) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.CommandText = "select * from USUARIO where CORREO = @correo and  CONTRASENIA = @contrasenia";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
        }
    }
}
