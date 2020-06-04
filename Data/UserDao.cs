using Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using MySql.Data.MySqlClient;

namespace Data
{
    public class UserDao:ConnectionToSql
    {
        /*public bool Login(string correo, string contrasenia) {
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
                            UserLoginCache.Rol_empresa = reader.GetString(6);
                        }
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
        }*/

        public bool Login(string correo, string contrasenia)
        {
            var connection = GetConnection();
            connection.Open();
            var sql = "select * from USUARIO where CORREO = @correo and  CONTRASENIA = @contrasenia";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@correo", correo);
            command.Parameters.AddWithValue("@contrasenia", contrasenia);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UserLoginCache.Id_usuario = reader.GetInt32(0);
                    UserLoginCache.Nombre = reader.GetString(2);
                    UserLoginCache.Apellido = reader.GetString(3);
                    UserLoginCache.Correo = reader.GetString(1);
                    UserLoginCache.Fecha_nacimiento = reader.GetDateTime(4);
                    //UserLoginCache.Id_usuario = reader.GetInt32(6);
                    UserLoginCache.Rol_empresa = reader.GetString(6);

                }
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }
            
        }

        /*public bool Add_user(string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa)
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
        }*/

        public bool Add_user(string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa)
        {
            var connection = GetConnection();
            connection.Open();
            var sql = "SELECT * FROM USUARIO WHERE correo = @correo";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@correo", correo);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            command.Parameters.AddWithValue("@contrasenia", contrasenia);
            command.Parameters.AddWithValue("@rol_empresa", rol_empresa);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) return false;
            reader.Close();
            command.CommandText = "INSERT INTO USUARIO (CORREO,NOMBRE,APELLIDO,FECHA_NACIMIENTO,CONTRASENIA,ROL_EMPRESA) VALUES(@correo, @nombre, @apellido, @fecha_nacimiento, @contrasenia, @rol_empresa)";
            command.ExecuteNonQuery();
            connection.Close();
            return true;        
        }

        /*public bool RecuperaContra(string correo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@correo", correo);
                    command.CommandText = "select * from USUARIO where CORREO = @correo";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("Datos correctos ");
                        while (reader.Read())
                        {
                            UserRecuperaCache.nombre_completo = reader.GetString(2);
                            UserRecuperaCache.nombre_completo += " " + reader.GetString(3);
                            UserRecuperaCache.contrasenia = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Datos correctos ");
                        return false;
                    }
                }
            }
        }*/

        public bool RecuperaContra(string correo)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;

            command.Parameters.AddWithValue("@correo", correo);
            command.CommandText = "select * from USUARIO where CORREO = @correo";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("Datos correctos ");
                while (reader.Read())
                {
                    UserRecuperaCache.nombre_completo = reader.GetString(2);
                    UserRecuperaCache.nombre_completo += " " + reader.GetString(3);
                    UserRecuperaCache.contrasenia = reader.GetString(5);
                }
                connection.Close();
                return true;
            }
            else
            {
                Console.WriteLine("Datos correctos ");
                connection.Close();
                return false;
            }
        }


        /*public DataTable MostrarUsuarios(string correo) {
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@correo", correo);
                    command.CommandText = "SELECT Nombre, Apellido, Correo, Contrasenia as Contraseña, Fecha_nacimiento as Nacimiento, Rol_empresa as 'Tipo usuario' FROM USUARIO WHERE CORREO != @correo;";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }*/

        public DataTable MostrarUsuarios(string correo)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@correo", correo);
            command.CommandText = "SELECT Id_usuario as Id, Nombre, Apellido, Correo, Contrasenia as Password, Fecha_nacimiento as Nacimiento, Rol_empresa as 'Tipo usuario' FROM USUARIO WHERE CORREO != @correo;";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

        public void EditarUsuario(int id, string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@correo", correo);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            command.Parameters.AddWithValue("@contrasenia", contrasenia);
            command.Parameters.AddWithValue("@rol_empresa", rol_empresa);
            command.CommandText = "UPDATE USUARIO SET NOMBRE = @nombre, APELLIDO = @apellido," +
                " FECHA_NACIMIENTO = @fecha_nacimiento, CONTRASENIA = @contrasenia, ROL_EMPRESA = @rol_empresa, CORREO = @correo where ID_USUARIO = @id";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();
            connection.Close();

        }
        public DataTable MostrarRegistroConversacion()
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT nombre, apellido, correo, FECHA_ACCESO, a.ID_ACCESO, q.NOMBRE_FUNCION FROM REG_FUNCION as f, REG_ACCESO as a, USUARIO as u, FUNCIONES as q WHERE u.ID_USUARIO = a.ID_USUARIO AND a.ID_ACCESO = f.ID_ACCESO and q.ID_FUNCION = f.ID_FUNCION ORDER BY FECHA_ACCESO;";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

    }
}
