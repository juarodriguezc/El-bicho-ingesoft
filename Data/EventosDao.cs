using Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Data
{
    public class EventosDao : ConnectionToSql
    {
        public List<string> ConsultarEventosDia(int id_usuario, DateTime dia)
        {
            List<string> Eventos = new List<string>();
            DateTime dia_fin = dia.AddDays(1);
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Parameters.AddWithValue("@Id_user", id_usuario);
            command.Parameters.AddWithValue("@dia", dia);
            command.Parameters.AddWithValue("@dia_fin", dia_fin);
            command.Connection = connection;
            command.CommandText = "SELECT E.ASUNTO_EVENTO, P.ID_USUARIO, E.FECHA_EVENTO FROM EVENTOS AS E," +
                " P_EVENTOS AS P WHERE P.ID_EVENTO = E.ID_EVENTO AND P.ID_USUARIO = @Id_user" +
                " AND E.FECHA_EVENTO >= @dia AND E.FECHA_EVENTO < @dia_fin";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                //Console.WriteLine("Datos correctos ");
                while (reader.Read())
                {

                    Eventos.Add(reader.GetString(0));

                }
                connection.Close();

            }
            Console.WriteLine(Eventos);
            connection.Close();
            return Eventos;
        }

        public string[] ConsultarProxEvento(int id_usuario)
        {
            string[] prox = { "dia", "hora", "asunto" };

            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Parameters.AddWithValue("@Id_user", id_usuario);
            command.Parameters.AddWithValue("@dia", DateTime.Today);
            command.Connection = connection;
            command.CommandText = "SELECT E.ASUNTO_EVENTO, P.ID_USUARIO, E.FECHA_EVENTO FROM EVENTOS AS E," +
                " P_EVENTOS AS P WHERE P.ID_EVENTO = E.ID_EVENTO AND P.ID_USUARIO = @Id_user" +
                " AND E.FECHA_EVENTO > @dia ORDER BY E.FECHA_EVENTO LIMIT 1";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                //Console.WriteLine("Datos correctos ");
                while (reader.Read())
                {

                    prox[0] = (reader.GetString(2));
                    prox[2] = (reader.GetString(0));
                }
                connection.Close();

            }
            else
            {
                prox = null;
            }
            connection.Close();
            return prox;
        }
        public List<string[]> ShowUsersCargo()
        {
            List<String[]> UsersCargo = new List<string[]>();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT P.NOMBRE_PERSONA, P.APELLIDO_PERSONA, U.ROL_EMPRESA, P.ID_PERSONA FROM PERSONA as P," +
                " USUARIO as U WHERE P.ID_PERSONA=U.ID_PERSONA";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] usu = new string[2];
                    usu[0] = reader.GetString(0) + " " + reader.GetString(1) + "-"+ reader.GetString(2).Substring(0,3);
                    usu[1] = reader.GetString(3);
                    UsersCargo.Add(usu);
                }
            }
            reader.Close();
            connection.Close();
            return UsersCargo;
        }
        public void createEvent(string id_owner, List<string> list_invitados, string asunto, DateTime fecha_evento) {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            string id_evento = " ";
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_owner", id_owner);
            command.Parameters.AddWithValue("@asunto", asunto);
            command.Parameters.AddWithValue("@fecha_evento", fecha_evento);
            command.CommandText = "SELECT ID_USUARIO FROM USUARIO WHERE ID_PERSONA = @id_owner";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                command.Parameters.AddWithValue("@id_usuario_owner", reader.GetString(0));
            }
            reader.Close();
            command.CommandText = "INSERT INTO EVENTOS (ID_USUARIO, FECHA_EVENTO, ASUNTO_EVENTO) VALUES (@id_usuario_owner, @fecha_evento, @asunto)";
            command.ExecuteNonQuery();
            command.CommandText = "SELECT ID_EVENTO FROM EVENTOS WHERE ID_USUARIO = @id_usuario_owner ORDER BY ID_EVENTO DESC LIMIT 1";
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                id_evento = reader.GetString(0);
                command.Parameters.AddWithValue("@id_evento", id_evento);
            }
            reader.Close();
            foreach (string id_invitado in list_invitados) {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id_invitado", id_invitado);
                command.Parameters.AddWithValue("@id_evento", id_evento);
                command.CommandText = "SELECT ID_USUARIO FROM USUARIO WHERE ID_PERSONA = @id_invitado";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    command.Parameters.AddWithValue("@id_usuario_invitado", reader.GetString(0));
                }
                reader.Close();
                command.CommandText = "INSERT INTO P_EVENTOS VALUES (@id_evento, @id_usuario_invitado)";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void updateEvent(int id_evento, int id_owner, List<string> list_invitados, string asunto, DateTime fecha_evento) {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            MySqlDataReader reader;
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_evento", id_evento);
            command.Parameters.AddWithValue("@id_owner", id_owner);
            command.CommandText = "DELETE FROM P_EVENTOS WHERE ID_EVENTO = @id_evento AND ID_USUARIO != @id_owner";
            command.ExecuteNonQuery();
            command.Parameters.AddWithValue("@asunto", asunto);
            command.Parameters.AddWithValue("@fecha_evento", fecha_evento);
            command.CommandText = "UPDATE EVENTOS SET FECHA_EVENTO=@fecha_evento, ASUNTO_EVENTO = @asunto" +
                " WHERE ID_EVENTO = @id_evento";
            command.ExecuteNonQuery();
            foreach (string id_invitado in list_invitados)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@id_invitado", id_invitado);
                command.Parameters.AddWithValue("@id_evento", id_evento);
                command.CommandText = "SELECT ID_USUARIO FROM USUARIO WHERE ID_PERSONA = @id_invitado";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    command.Parameters.AddWithValue("@id_usuario_invitado", reader.GetString(0));
                }
                reader.Close();
                command.CommandText = "INSERT INTO P_EVENTOS VALUES (@id_evento, @id_usuario_invitado)";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public DataTable MostrarEventosPersona(int id_usuario) {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_usuario", id_usuario);
            command.CommandText = "SELECT E.ID_EVENTO AS 'Id', E.FECHA_EVENTO AS 'Fecha del evento', E.ASUNTO_EVENTO AS 'Asunto del evento'," +
                " COUNT(P.ID_USUARIO)-1" +
                " AS 'Invitados' FROM EVENTOS AS E, P_EVENTOS AS P" +
                " WHERE P.ID_EVENTO = E.ID_EVENTO AND FECHA_EVENTO > CURDATE() AND E.ID_USUARIO = @id_usuario GROUP BY (E.ID_EVENTO)";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }
        public List<string> ShowUsersEvent(int id_evento, int id_usuario)
        {
            List<String> UsersEvent = new List<string>();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_evento", id_evento);
            command.Parameters.AddWithValue("@id_usuario", id_usuario);
            command.CommandText = "SELECT U.ID_PERSONA FROM USUARIO AS U, P_EVENTOS AS P, EVENTOS AS E WHERE U.ID_USUARIO = P.ID_USUARIO AND" +
                " P.ID_EVENTO = E.ID_EVENTO AND E.ID_EVENTO = @id_evento AND  P.ID_USUARIO != @id_usuario";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("Invitado: " + reader.GetString(0));
                    UsersEvent.Add(reader.GetString(0));
                    
                }
            }
            reader.Close();
            connection.Close();
            return UsersEvent;
        }
        public DataTable EventosDosFechas(int id_usuario, DateTime fecha_inicio, DateTime fecha_fin)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_usuario", id_usuario);
            command.Parameters.AddWithValue("@fecha_inicio", Min(fecha_inicio,fecha_fin));
            command.Parameters.AddWithValue("@fecha_fin", Max(fecha_inicio, fecha_fin));
            command.CommandText = "SELECT E.ID_EVENTO AS 'Id', E.FECHA_EVENTO AS 'Fecha del evento', E.ASUNTO_EVENTO AS 'Asunto del evento' " +
                "FROM EVENTOS AS E, P_EVENTOS AS P WHERE P.ID_EVENTO = E.ID_EVENTO " +
                "AND E.FECHA_EVENTO > @fecha_inicio AND E.FECHA_EVENTO < @fecha_fin AND P.ID_USUARIO = @id_usuario";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }
        public DataTable TotalEventos(int id_usuario)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_usuario", id_usuario);
            command.CommandText = "SELECT E.ID_EVENTO AS 'Id', E.FECHA_EVENTO AS 'Fecha del evento', E.ASUNTO_EVENTO AS 'Asunto del evento' " +
                "FROM EVENTOS AS E, P_EVENTOS AS P WHERE P.ID_EVENTO = E.ID_EVENTO " +
                "AND P.ID_USUARIO = @id_usuario";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }
        public DataTable EventosProximos(int id_usuario, DateTime fecha)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_usuario", id_usuario);
            command.Parameters.AddWithValue("@fecha", fecha);
            command.CommandText = "SELECT E.ID_EVENTO AS 'Id', E.FECHA_EVENTO AS 'Fecha del evento', E.ASUNTO_EVENTO AS 'Asunto del evento' " +
                "FROM EVENTOS AS E, P_EVENTOS AS P WHERE P.ID_EVENTO = E.ID_EVENTO AND E.FECHA_EVENTO > @fecha " +
                "AND P.ID_USUARIO = @id_usuario";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }
        public static DateTime Max(DateTime a, DateTime b)
        {
            return a > b ? a : b;
        }
        public static DateTime Min(DateTime a, DateTime b)
        {
            return a < b ? a : b;
        }
    }
    
}
