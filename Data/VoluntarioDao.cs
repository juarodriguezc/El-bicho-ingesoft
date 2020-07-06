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
        public bool Add_volunteer(string id_persona, string nombre, string apellido, DateTime fecha_nacimiento, string telefono, string genero, string correo, string pais_origen, string tipo_p)
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
            command.Parameters.AddWithValue("@tipo_p", tipo_p);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) return false;
            reader.Close();
            command.CommandText = "INSERT INTO PERSONA (Id_persona, Nombre_persona, Apellido_persona, Fecha_nacimiento, Telefono_persona," +
                " Genero, Correo_persona, PAIS_ORIGEN,ROL_PERSONA) VALUES(@Id_persona, @nombre, @apellido, @fecha_nacimiento, @telefono," +
                " @genero, @correo,@pais,@tipo_p)";
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
            command.CommandText = "SELECT P.Id_persona as 'ID PERSONA', P.Nombre_persona as 'NOMBRE', P.Apellido_persona as 'APELLIDO'," +
                " PR.NOMBRE_PROGRAMA AS 'NOMBRE DEL PROGRAMA' "+
                " FROM PERSONA as P , PER_PROG as A, PROGRAMA as PR WHERE P.ID_PERSONA =A.ID_PERSONA AND " +
                "A.ID_PROGRAMA=PR.ID_PROGRAMA AND P.PAIS_ORIGEN!=@pais AND PR.FECHA_INICIO<= @dateActual AND " +
                "PR.FECHA_FIN>@dateActual and P.ROL_PERSONA = 'Voluntario'";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }
        
        public int getIdPrograma(string programa)
        {
            var connection = GetConnection();
            connection.Open();
            int idPrograma = 0;
            var sql = "SELECT * FROM PROGRAMA WHERE NOMBRE_PROGRAMA = @nombrePrograma";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@nombrePrograma", programa);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idPrograma = reader.GetInt32(0);
                }
            }
            reader.Close();

            connection.Close();
            return idPrograma;


        }

        public DataTable VoluntariosDisponibles(string programa)
        {
            int idPrograma = getIdPrograma(programa);

            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT P.Id_persona as 'Id persona', P.Nombre_persona as 'Nombre', P.Apellido_persona as 'Apellido' FROM PERSONA as P LEFT JOIN PER_PROG as PR ON P.ID_PERSONA=PR.ID_PERSONA AND PR.ID_PROGRAMA=@idPrograma WHERE PR.ID_PERSONA IS NULL";
            command.Parameters.AddWithValue("@idPrograma", idPrograma);
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

        public void add_VolunterProgram(string id_persona, string programa)
        {
            int idPrograma = getIdPrograma(programa);
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@id_persona", id_persona);
            command.Parameters.AddWithValue("@id_programa", idPrograma);
            command.CommandText = "INSERT INTO PER_PROG (Id_programa, Id_persona, Rol_programa, Calificacion) VALUES(@id_programa,@id_persona,'Voluntario',0)";
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
