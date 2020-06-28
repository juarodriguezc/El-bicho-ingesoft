using Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

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
            command.Parameters.AddWithValue("@dia", DateTime.Now);
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

    }
}
