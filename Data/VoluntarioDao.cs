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
    public class VoluntarioDao:ConnectionToSql
    {
        public bool Add_volunteer(int id_persona, string nombre, string apellido, DateTime fecha_nacimiento, string telefono, string genero, string correo)
        {
            var connection = GetConnection();
            connection.Open();
            var sql = "SELECT * FROM PERSONA as P WHERE P.Correo_persona = @correo or P.Id_persona=@Id_persona";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@genero", genero);
            command.Parameters.AddWithValue("@telefono", telefono);
            command.Parameters.AddWithValue("@Id_persona", id_persona);
            command.Parameters.AddWithValue("@correo", correo);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) return false;
            reader.Close();

            command.CommandText = "INSERT INTO PERSONA (Id_persona, Nombre_persona, Apellido_persona, Fecha_nacimiento, Telefono_persona, Genero, Correo_persona) VALUES(@Id_persona, @nombre, @apellido, @fecha_nacimiento, @telefono, @genero, @correo)";
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }

        public DataTable MostrarVoluntarios()
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT P.Id_persona, P.Nombre_persona as 'Nombre', P.Apellido_persona as 'Apellido', P.Correo_persona as 'Correo', P.Fecha_nacimiento as 'Nacimiento', P.telefono_persona as 'Telefono' , P.Genero FROM PERSONA as P";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

        public DataTable MostrarVoluntariosByCountry(string country)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@pais", country);
            command.CommandText = "SELECT P.Id_persona, P.Nombre_persona as 'Nombre', P.Apellido_persona as 'Apellido', P.Correo_persona as 'Correo', P.Fecha_nacimiento as 'Nacimiento', P.telefono_persona as 'Telefono' , P.Genero FROM PERSONA as P";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }
    }
}
