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
        public bool Add_user(string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, int rol_empresa)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.Parameters.AddWithValue("@rol_empresa", rol_empresa);
                    //Verificar la existencia del correo
                    command.CommandText = "SELECT * FROM USUARIO WHERE correo = @correo";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) return false; //No se añade el usuario y se retorna false
                    reader.Close();
                    command.CommandText = "INSERT INTO USUARIO VALUES(@correo, @nombre, @apellido, @fecha_nacimiento, @contrasenia, @rol_empresa)";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true; //Se añade el usuario y se retorna true
                }
            }
        }



    }
}
