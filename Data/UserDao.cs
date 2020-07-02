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
    public class UserDao : ConnectionToSql
    {
        public bool Login(string correo, string contrasenia)
        {
            var connection = GetConnection();
            connection.Open();
            MySqlDataReader reader;

            if (correo.Contains("@"))
            {
                var sql = "SELECT * FROM PERSONA as P, USUARIO as U WHERE P.ID_PERSONA=U.ID_PERSONA and P.CORREO_PERSONA = @correo and U.CONTRASENIA = @contrasenia ";
                var command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@correo", correo);
                command.Parameters.AddWithValue("@contrasenia", contrasenia);
                reader = command.ExecuteReader();
            }
            else
            {
                var sql = "SELECT * FROM PERSONA as P, USUARIO as U WHERE P.ID_PERSONA=U.ID_PERSONA and U.NICKNAME = @nickname and U.CONTRASENIA = @contrasenia ";
                var command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@nickname", correo);
                command.Parameters.AddWithValue("@contrasenia", contrasenia);
                reader = command.ExecuteReader();

            }

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    UserLoginCache.Id_Persona = reader.GetInt32(0);
                    UserLoginCache.Id_usuario = reader.GetInt32(1);
                    UserLoginCache.Nombre = reader.GetString(2);
                    UserLoginCache.Apellido = reader.GetString(3);
                    UserLoginCache.Fecha_nacimiento = reader.GetDateTime(4);
                    UserLoginCache.Telefono = reader.GetString(5);
                    UserLoginCache.Genero = reader.GetString(6);
                    UserLoginCache.Correo = reader.GetString(7);
                    UserLoginCache.Nickname = reader.GetString(12);
                    UserLoginCache.Rol_empresa = reader.GetString(14);
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

        public bool Add_user(string id_persona, string nombre, string apellido, DateTime fecha_nacimiento, string telefono, string genero, string correo, string contrasenia, string rol_empresa, string nickname)
        {
            var connection = GetConnection();
            connection.Open();
            var sql = "SELECT * FROM PERSONA as P, USUARIO as U WHERE P.Correo_persona = @correo or U.Nickname= @nickname or P.Id_persona=@Id_persona";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@genero", genero);
            command.Parameters.AddWithValue("@telefono", telefono);
            command.Parameters.AddWithValue("@Id_persona", id_persona);
            command.Parameters.AddWithValue("@correo", correo);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            command.Parameters.AddWithValue("@contrasenia", contrasenia);
            command.Parameters.AddWithValue("@rol_empresa", rol_empresa);
            command.Parameters.AddWithValue("@nickname", nickname);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) return false;
            reader.Close();

            command.CommandText = "INSERT INTO PERSONA (Id_persona, Nombre_persona, Apellido_persona, Fecha_nacimiento, Telefono_persona, Genero, Correo_persona, Pais_origen, Rol_persona) VALUES(@Id_persona, @nombre, @apellido, @fecha_nacimiento, @telefono, @genero, @correo, 'Colombia', 'Trabajador')";
            command.ExecuteNonQuery();
            command.CommandText = "INSERT INTO USUARIO (Id_persona, Nickname, Contrasenia, Rol_empresa) VALUES(@Id_persona, @nickname, @contrasenia, @rol_empresa)";
            command.ExecuteNonQuery();
            command.CommandText = "UPDATE PERSONA set PERSONA.Id_usuario=(SELECT Id_usuario from USUARIO where Id_persona=@Id_persona) WHERE PERSONA.Id_persona=@Id_persona";
            command.ExecuteNonQuery();

            connection.Close();
            return true;
        }

        public bool RecuperaContra(string correo)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;

            command.Parameters.AddWithValue("@correo", correo);
            command.CommandText = "select * from PERSONA where CORREO_PERSONA = @correo ";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("Datos correctos ");
                while (reader.Read())
                {
                    Random rnd = new Random();
                    UserRecuperaCache.id_persona = reader.GetInt32(0);
                    UserRecuperaCache.nombre_completo = reader.GetString(2);
                    UserRecuperaCache.nombre_completo += " " + reader.GetString(3);
                    UserRecuperaCache.cod_verificación = rnd.Next(1000, 9999);
                    UserRecuperaCache.fecha_envio = DateTime.Now;
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

        public DataTable MostrarUsuarios(string correo)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@correo", correo);
            command.CommandText = "SELECT P.Id_persona, P.Nombre_persona as 'Nombre', P.Apellido_persona as 'Apellido', U.Contrasenia as 'Password', P.Correo_persona as 'Correo', P.Fecha_nacimiento as 'Nacimiento', U.Rol_empresa as 'Tipo usuario', P.telefono_persona as 'Telefono' , P.Genero, U.Nickname as 'Usuario' FROM PERSONA as P, USUARIO as U WHERE P.ID_USUARIO=U.ID_USUARIO AND CORREO_PERSONA != @correo;";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

        public void EditarUsuario(int id_persona, string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa, string genero, string telefono, string nickname)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@genero", genero);
            command.Parameters.AddWithValue("@telefono", telefono);
            command.Parameters.AddWithValue("@Id_persona", id_persona);
            command.Parameters.AddWithValue("@correo", correo);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            command.Parameters.AddWithValue("@contrasenia", contrasenia);
            command.Parameters.AddWithValue("@rol_empresa", rol_empresa);
            command.Parameters.AddWithValue("@nickname", nickname);
            command.CommandText = "UPDATE PERSONA SET NOMBRE_PERSONA = @nombre, APELLIDO_PERSONA = @apellido," +
            " FECHA_NACIMIENTO = @fecha_nacimiento, CORREO_PERSONA = @correo, TELEFONO_PERSONA = @telefono, GENERO = @genero where ID_PERSONA = @id_persona";
            command.CommandType = CommandType.Text;
            command.ExecuteNonQuery();

            command.CommandText = "UPDATE USUARIO SET NICKNAME = @nickname," +
            " CONTRASENIA = @contrasenia, ROL_EMPRESA = @rol_empresa where ID_PERSONA = @id_persona";
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
            command.CommandText = "SELECT P.nombre_persona as Nombre, P.apellido_persona as Apellido, P.Correo_persona as 'Correo electronico'," +
                " a.FECHA_ACCESO as 'Fecha de acceso', a.ID_ACCESO as 'ID acceso', " +
                "q.NOMBRE_FUNCION as 'Funcion usada' FROM PERSONA as P, REG_FUNCION as f, REG_ACCESO as a, USUARIO as u, FUNCIONES as q " +
                "WHERE P.Id_persona=u.Id_persona and u.ID_USUARIO = a.ID_USUARIO and a.ID_ACCESO = f.ID_ACCESO and " +
                "q.ID_FUNCION = f.ID_FUNCION ORDER BY FECHA_ACCESO;";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

        public void CambiarPassword(int id_persona, string contrasenia)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@contrasenia", contrasenia);
            command.Parameters.AddWithValue("@id_persona", id_persona);
            command.CommandText = "UPDATE USUARIO set contrasenia=@contrasenia WHERE Id_persona=@Id_persona ";
            command.ExecuteNonQuery();
            connection.Close();

        }

        public DataTable personasInfo()
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PERSONA";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

        public DataTable showCompanies()
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM COMPANIA";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;

        }

        public DataTable MostrarUsuarios(int id_usuario)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_usuario", id_usuario);
            command.CommandText = "SELECT P.NOMBRE_PERSONA AS 'NOMBRE', P.APELLIDO_PERSONA AS 'APELLIDO', P.TELEFONO_PERSONA AS 'TELEFONO', " +
                "P.CORREO_PERSONA AS 'CORREO ELECTRONICO', U.ROL_EMPRESA AS 'CARGO' FROM PERSONA AS P, USUARIO AS U " +
                "WHERE P.ID_PERSONA = U.ID_PERSONA AND U.ID_USUARIO != @id_usuario";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;

        }

        public DataTable CompletaUsuarios(int id_usuario)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_usuario", id_usuario);
            command.CommandText = "SELECT P.ID_PERSONA, P.NOMBRE_PERSONA AS 'NOMBRE', P.APELLIDO_PERSONA AS 'APELLIDO', P.TELEFONO_PERSONA AS 'TELEFONO', " +
                "P.CORREO_PERSONA AS 'CORREO ELECTRONICO', P.FECHA_NACIMIENTO AS 'FECHA NACIMIENTO', U.ROL_EMPRESA AS 'CARGO', P.GENERO, " +
                "P.PAIS_ORIGEN AS 'PAIS DE ORIGEN' FROM PERSONA AS P, USUARIO AS U " +
                "WHERE P.ID_PERSONA = U.ID_PERSONA AND U.ID_USUARIO != @id_usuario";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;

        }

        //Arreglar esto 

        public DataTable showPrograms()
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PROGRAMA";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;

        }

        public DateTime getNacimiento(int id_persona) {
            DateTime fecha_nacimiento = DateTime.Today;
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_persona", id_persona);
            command.CommandText = "SELECT  P.FECHA_NACIMIENTO FROM PERSONA AS P WHERE P.ID_PERSONA = @id_persona";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                fecha_nacimiento = DateTime.Parse((DateTime.Parse(reader.GetString(0))).ToString("yyyy - MM - dd"));
            }
            connection.Close();
            return fecha_nacimiento;
        }


    }
}
