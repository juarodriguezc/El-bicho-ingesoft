﻿using Business;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;
using MySql.Data.MySqlClient;

namespace Data
{
    public class RespuestaDao : ConnectionToSql
    {
        public string GenRespuesta(string azure_msg)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@azure_msg", azure_msg);
            command.CommandText = "SELECT TXTMENSAJE FROM MENSAJE INNER JOIN FUNCIONES f ON f.ID_FUNCION = MENSAJE.ID_FUNCION WHERE f.NOMBRE_FUNCION = @azure_msg  ORDER BY RAND() LIMIT 1";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader2 = command.ExecuteReader();
            if (reader2.HasRows)
            {
                string temp = "";
                while (reader2.Read())
                {
                    temp = reader2.GetString(0);
                }
                connection.Close();
                return temp;
            }
            else
            {
                connection.Close();
                return "Lo siento, no tengo una respuesta programada :'(";
            }

        }

    }
}
