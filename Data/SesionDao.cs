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
    public class SesionDao:ConnectionToSql
    {
        public void createSesion(int Id_user, DateTime Date)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;

            command.Parameters.AddWithValue("@Id_usuario", Id_user);
            command.Parameters.AddWithValue("@Date", Date);
            command.CommandText = "INSERT INTO REG_ACCESO (ID_USUARIO,FECHA_ACCESO) VALUES (@Id_usuario, @Date);";
            command.ExecuteNonQuery();      

            command.CommandText = "SELECT * FROM `REG_ACCESO` WHERE id_usuario=@Id_usuario order by FECHA_ACCESO DESC LIMIT 1";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    SesionCache.Id_acceso = reader.GetInt32(0);
                    
                }
            }
            connection.Close();
        }
        public void create_reg_function(int Id_funcion, int Id_acceso)
        {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            //Console.WriteLine("Id_acceso: "+Id_acceso);
            command.Parameters.AddWithValue("@Id_funcion", Id_funcion);
            command.Parameters.AddWithValue("@Id_acceso", Id_acceso);
            command.CommandText = "INSERT INTO REG_FUNCION(ID_FUNCION,ID_ACCESO) VALUES(@Id_funcion, @Id_acceso);";
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
