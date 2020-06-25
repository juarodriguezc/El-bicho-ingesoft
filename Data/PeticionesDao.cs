using Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class PeticionesDao : ConnectionToSql
    {
        public List<string> nombresDirectivos()
        {
            List<String> directivos = new List<string>();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT P.NOMBRE_PERSONA, P.APELLIDO_PERSONA FROM PERSONA as P, USUARIO as U WHERE P.ID_PERSONA=U.ID_PERSONA AND (U.ROL_EMPRESA='Administrador' OR U.ROL_EMPRESA='Jefe de área')";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    String a = reader.GetString(0)+" "+ reader.GetString(1);
                    directivos.Add(a);
                }
            }
            reader.Close();

            return directivos;
        }

        public int getIdDirectivo(string nombre_directivo)
        {
            char delimitador = ' ';
            string[] nombre = nombre_directivo.Split(delimitador);  
            int idDirectivo= 0;
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@nombreDirectivo", nombre[0]);
            command.Parameters.AddWithValue("@apellidoDirectivo", nombre[1]);
            command.CommandText = "SELECT P.ID_USUARIO, P.NOMBRE_PERSONA, P.APELLIDO_PERSONA FROM PERSONA as P, USUARIO as U WHERE P.ID_PERSONA=U.ID_PERSONA AND P.NOMBRE_PERSONA = @nombreDirectivo and P.APELLIDO_PERSONA = @apellidoDirectivo";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idDirectivo = reader.GetInt32(0);
                }
            }

            reader.Close();
            return idDirectivo;

        }

        public void add_user_request(int idUsuarioFrom, string nombre_directivo, string tipo_peticion, string asunto_solicitud, string descripcion_solicitud)
        {
            int idDirectivo = getIdDirectivo(nombre_directivo);

            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@idUsuarioFrom", idUsuarioFrom);
            command.Parameters.AddWithValue("@idUsuarioTo", idDirectivo);
            command.Parameters.AddWithValue("@tipoPeticion", tipo_peticion);
            command.Parameters.AddWithValue("@asuntoSolicitud", asunto_solicitud);
            command.Parameters.AddWithValue("@descripcionSolicitud", descripcion_solicitud);

            command.CommandText = "INSERT INTO PETICIONES (Id_usuario_from, Id_usuario_to, Tipo_peticion, Asunto_peticion, Desc_peticion) VALUES(@idUsuarioFrom, @idUsuarioTo, @tipoPeticion, @asuntoSolicitud, @descripcionSolicitud)";
            command.ExecuteNonQuery();

            connection.Close();
        }


        public string mailDirect(string nombre_directivo)
        {
            int idDirectivo = getIdDirectivo(nombre_directivo);
            string mailD = "";
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@idUserDirectivo", idDirectivo);
            command.CommandText = "SELECT Correo_persona FROM PERSONA WHERE Id_usuario=@idUserDirectivo";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    mailD = reader.GetString(0);
                }
            }
            
            return mailD;
        }
    }
}
