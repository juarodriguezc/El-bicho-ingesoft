using Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Data
{
    public class ProgramaDao : ConnectionToSql
    {
        public DataTable programaSegunFecha(DateTime date)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@date", date);
            command.CommandText = "SELECT * FROM PROGRAMA WHERE Fecha_programa = @date";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

        public List<string> companyList()
        {
            List<String> companies = new List<string>();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM COMPANIA";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            if(reader.HasRows)
            { 
                while(reader.Read())
                {
                    String a = reader.GetString(1);
                    //Console.WriteLine(a);
                    companies.Add(a);
                }
            }
            reader.Close();

            return companies;
        }

        public int buscarIdCompany(string nombreCompany)
        {
            var connection = GetConnection();
            connection.Open();
            int idCompany= 0;
            var sql = "SELECT * FROM COMPANIA WHERE NOMBRE_COMPANIA = @nombreCompania";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@nombreCompania", nombreCompany);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idCompany = reader.GetInt32(0);
                }
            }
            reader.Close();

            connection.Close();
            return idCompany;
        }

        public bool add_program(string nombreCompany, string nombrePrograma, DateTime fechaInicio, DateTime fechaFin, string tipoPrograma)
        {
            var connection = GetConnection();
            connection.Open();
            int idCompany = buscarIdCompany(nombreCompany);

            var sql = "SELECT * FROM PROGRAMA WHERE Nombre_Programa = @nombrePrograma";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@nombrePrograma", nombrePrograma+ fechaInicio.ToString());
            command.Parameters.AddWithValue("@IdCompania", idCompany);
            command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
            command.Parameters.AddWithValue("@fechaFin", fechaFin);
            command.Parameters.AddWithValue("@tipoPrograma", tipoPrograma);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                return false;
            }
            reader.Close();

            command.CommandText = "INSERT INTO PROGRAMA (id_compania,Nombre_programa,fecha_inicio,fecha_fin,tipo_programa) VALUES(@IdCompania, @nombrePrograma, @fechaInicio, @fechaFin, @tipoPrograma)";
            command.ExecuteNonQuery();

            connection.Close();
            return true;
        }

        public DataTable programaActivos()
        {
            DateTime dateNow = DateTime.Now;
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@dateActual", dateNow);
            command.CommandText = "SELECT C.NOMBRE_COMPANIA, P.NOMBRE_PROGRAMA, P.FECHA_INICIO, P.FECHA_FIN, P.TIPO_PROGRAMA FROM PROGRAMA as P, COMPANIA as C WHERE P.FECHA_INICIO>= @dateActual AND P.FECHA_FIN< @dateActual ";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

    }
}
