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
    public class VoluntarioDao : ConnectionToSql
    {
        public bool Add_volunteer(int id_persona, string nombre, string apellido, DateTime fecha_nacimiento, string telefono, string genero, string correo, string pais_origen)
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
            command.Parameters.AddWithValue("@pais", pais_origen);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) return false;
            reader.Close();
            command.CommandText = "INSERT INTO PERSONA (Id_persona, Nombre_persona, Apellido_persona, Fecha_nacimiento, Telefono_persona, Genero, Correo_persona, PAIS_ORIGEN,ROL_PERSONA) VALUES(@Id_persona, @nombre, @apellido, @fecha_nacimiento, @telefono, @genero, @correo,@pais,'Voluntario')";
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

        public DataTable MostrarVoluntariosPorPrograma(string opcion, string valor)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            if (opcion == "Id persona")
            {
                valor= "%" + valor+ "%";
                command.Parameters.AddWithValue("@data", valor);
                command.CommandText = "SELECT P.Id_persona as 'Numero de identificacion', P.Nombre_persona as 'Nombre', P.APELLIDO_PERSONA as 'Apellido', PR.NOMBRE_PROGRAMA as 'Nombre Programa', PR.FECHA_INICIO as 'Fecha Inicio', PR.FECHA_FIN as 'Fecha Fin',  A.ROL_PROGRAMA as 'Rol',A.CALIFICACION as'Calificacion' FROM PERSONA as P, PER_PROG as A, PROGRAMA as PR WHERE P.ID_PERSONA =A.ID_PERSONA AND A.ID_PROGRAMA=PR.ID_PROGRAMA AND P.Id_persona like @data;";
            }
            else if (opcion == "Nombre persona")
            {
                valor = "%" + valor + "%";
                command.Parameters.AddWithValue("@data", valor);
                command.CommandText = "SELECT P.Id_persona as 'Numero de identificacion', P.Nombre_persona as 'Nombre', P.APELLIDO_PERSONA as 'Apellido', PR.NOMBRE_PROGRAMA as 'Nombre Programa', PR.FECHA_INICIO as 'Fecha Inicio', PR.FECHA_FIN as 'Fecha Fin',  A.ROL_PROGRAMA as 'Rol',A.CALIFICACION as'Calificacion' FROM PERSONA as P, PER_PROG as A, PROGRAMA as PR WHERE P.ID_PERSONA =A.ID_PERSONA AND A.ID_PROGRAMA=PR.ID_PROGRAMA AND P.NOMBRE_PERSONA like @data;";
            }
            else if (opcion== "Apellido persona")
            {
                valor = "%" + valor + "%";
                command.Parameters.AddWithValue("@data", valor);
                command.CommandText = "SELECT P.Id_persona as 'Numero de identificacion', P.Nombre_persona as 'Nombre', P.APELLIDO_PERSONA as 'Apellido', PR.NOMBRE_PROGRAMA as 'Nombre Programa', PR.FECHA_INICIO as 'Fecha Inicio', PR.FECHA_FIN as 'Fecha Fin', A.ROL_PROGRAMA as 'Rol',A.CALIFICACION as'Calificacion' FROM PERSONA as P, PER_PROG as A, PROGRAMA as PR WHERE P.ID_PERSONA =A.ID_PERSONA AND A.ID_PROGRAMA=PR.ID_PROGRAMA AND P.APELLIDO_PERSONA like @data;";
            }
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

        public DataTable MostrarVoluntariosDifferentToCountryWithActivePrograms(string country)
        {
            DateTime dateNow = DateTime.Now;
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@pais", country);
            command.Parameters.AddWithValue("@dateActual", dateNow);
            command.CommandText = "SELECT P.Id_persona, P.Nombre_persona as 'Nombre', P.Apellido_persona as 'Apellido', P.Correo_persona as 'Correo', P.Fecha_nacimiento as 'Nacimiento', P.telefono_persona as 'Telefono' , P.Genero FROM PERSONA as P , PER_PROG as A, PROGRAMA as PR WHERE P.ID_PERSONA =A.ID_PERSONA AND A.ID_PROGRAMA=PR.ID_PROGRAMA P.PAIS_ORIGEN!=@pais AND PR.FECHA_INICIO>= @dateActual AND PR.FECHA_FIN< @dateActual ";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }
    }
}
