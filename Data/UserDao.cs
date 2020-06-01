using Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

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
                        while (reader.Read()) {
                            UserLoginCache.Id_usuario = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(2);
                            UserLoginCache.Apellido = reader.GetString(3);
                            UserLoginCache.Correo = reader.GetString(1);
                            UserLoginCache.Fecha_nacimiento = reader.GetDateTime(4);
                            UserLoginCache.Rol_empresa = reader.GetInt32(6);
                        }
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
