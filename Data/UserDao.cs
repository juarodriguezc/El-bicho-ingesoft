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
        /*public bool Login(string correo, string contrasenia) {
            using (var connection = GetConnection()) {
                connection.Open();
                using (var command = new SqlCommand()) {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.CommandText = "select * from USUARIO where CORREO = @correo and  CONTRASENIA = @contrasenia";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) {
                            UserLoginCache.Id_usuario = reader.GetInt32(0);
                            UserLoginCache.Nombre = reader.GetString(2);
                            UserLoginCache.Apellido = reader.GetString(3);
                            UserLoginCache.Correo = reader.GetString(1);
                            UserLoginCache.Fecha_nacimiento = reader.GetDateTime(4);
                            UserLoginCache.Rol_empresa = reader.GetString(6);
                        }
                        return true;
                    }
                    else {
                        return false;
                    }
                }
            }
        }*/

        public bool Login(string correo, string contrasenia)
        {
            var connection = GetConnection();
            connection.Open();
            //var sql = "select * from USUARIO where CORREO = @correo and  CONTRASENIA = @contrasenia";
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
                    UserLoginCache.Nickname = reader.GetString(10);
                    UserLoginCache.Rol_empresa = reader.GetString(12);

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

        /*public bool Add_user(string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@correo", correo);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                    command.Parameters.AddWithValue("@contrasenia", contrasenia);
                    command.Parameters.AddWithValue("@rol_empresa", rol_empresa);
                    //Verificar la existencia del correo
                    command.CommandText = "SELECT * FROM USUARIO WHERE correo = @correo";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) return false; //No se añade el usuario y se retorna false
                    reader.Close();
                    command.CommandText = "INSERT INTO USUARIO VALUES(@correo, @nombre, @apellido, @fecha_nacimiento, @contrasenia, @rol_empresa)";
                    command.CommandType = CommandType.Text;
                    command.ExecuteNonQuery();
                    return true; //Se añade el usuario y se retorna true
                }
            }
        }*/

        public bool Add_user(int id_persona, string nombre, string apellido, DateTime fecha_nacimiento, string telefono, string genero, string correo, string contrasenia, string rol_empresa, string nickname)
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

            command.CommandText = "INSERT INTO PERSONA (Id_persona, Nombre_persona, Apellido_persona, Fecha_nacimiento, Telefono_persona, Genero, Correo_persona) VALUES(@Id_persona, @nombre, @apellido, @fecha_nacimiento, @telefono, @genero, @correo)";
            command.ExecuteNonQuery();
            command.CommandText = "INSERT INTO USUARIO (Id_persona, Nickname, Contrasenia, Rol_empresa) VALUES(@Id_persona, @nickname, @contrasenia, @rol_empresa)";
            command.ExecuteNonQuery();
            command.CommandText = "UPDATE PERSONA set PERSONA.Id_usuario=(SELECT Id_usuario from USUARIO where Id_persona=@Id_persona) WHERE PERSONA.Id_persona=@Id_persona";
            command.ExecuteNonQuery();

            connection.Close();
            return true;
        }

        /*public bool RecuperaContra(string correo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@correo", correo);
                    command.CommandText = "select * from USUARIO where CORREO = @correo";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("Datos correctos ");
                        while (reader.Read())
                        {
                            UserRecuperaCache.nombre_completo = reader.GetString(2);
                            UserRecuperaCache.nombre_completo += " " + reader.GetString(3);
                            UserRecuperaCache.contrasenia = reader.GetString(5);
                        }
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Datos correctos ");
                        return false;
                    }
                }
            }
        }*/

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


        /*public DataTable MostrarUsuarios(string correo) {
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddWithValue("@correo", correo);
                    command.CommandText = "SELECT Nombre, Apellido, Correo, Contrasenia as Contraseña, Fecha_nacimiento as Nacimiento, Rol_empresa as 'Tipo usuario' FROM USUARIO WHERE CORREO != @correo;";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    tabla.Load(reader);
                    return tabla;
                }
            }
        }*/

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
            /*command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@correo", correo);
            command.Parameters.AddWithValue("@nombre", nombre);
            command.Parameters.AddWithValue("@apellido", apellido);
            command.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
            command.Parameters.AddWithValue("@contrasenia", contrasenia);
            command.Parameters.AddWithValue("@rol_empresa", rol_empresa);
            command.CommandText = "UPDATE USUARIO SET NOMBRE = @nombre, APELLIDO = @apellido," +
                " FECHA_NACIMIENTO = @fecha_nacimiento, CONTRASENIA = @contrasenia, ROL_EMPRESA = @rol_empresa, CORREO = @correo where ID_USUARIO = @id";*/
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

        //Felipe 
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

        public List<string> ConsultarEventosDia(int id_usuario, DateTime dia) {
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
        public string[] ConsultarProxEvento(int id_usuario) {
            string[] prox = {"dia","hora","asunto" };

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
            else {
                prox = null;
            }
            
            connection.Close();

            return prox;

        }

        //Merge 23 de junio
        //añadir solicitud
        public int Add_UserRequest(int idP, int idUsFrom, int idUsTo, string asunto, string descrip)
        {
            var connection = GetConnection();
            connection.Open();
            var sql = "SELECT * FROM PETICIONES WHERE ID_PETICION = @idPet";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@idPet", idP);
            command.Parameters.AddWithValue("@idUserFrom", idUsFrom);
            command.Parameters.AddWithValue("@idUserTo", idUsTo);
            command.Parameters.AddWithValue("@asuntoSol", asunto);
            command.Parameters.AddWithValue("@Desc", descrip);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                //Ya existe un id de peticion igual
                return 1;
            }
            reader.Close();

            //Verificar existencia de UserTo
            var sql1 = "SELECT * FROM USUARIO WHERE ID_USUARIO = @idUserTo";
            var command1 = new MySqlCommand(sql1, connection);
            command1.Parameters.AddWithValue("@idUserTo", idUsFrom);
            MySqlDataReader reader1 = command1.ExecuteReader();

            if (!reader1.HasRows)
            {
                //No existe UserTo
                return 2;
            }
            reader1.Close();

            command.CommandText = "INSERT INTO PETICIONES (Id_peticion, Id_usuario_from, Id_usuario_to, Asunto_peticion, Desc_peticion) VALUES(@idPet, @idUserFrom, @idUserTo, @asuntoSol, @Desc)";
            command.ExecuteNonQuery();

            connection.Close();
            return 0;
        }

        //Obtener correo dirigente
        public string MailDirect(int idDirectivo)
        {
            string mailD = "";
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@idD", idDirectivo);
            command.CommandText = "SELECT PERSONA.Correo_persona FROM USUARIO, PERSONA WHERE USUARIO.Id_usuario = @idD AND PERSONA.Id_persona = USUARIO.Id_persona";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);

            var columnsWidths = new int[tabla.Columns.Count];
            foreach (DataRow row in tabla.Rows)
            {
                for (int i = 0; i < tabla.Columns.Count; i++)
                {
                    mailD = row[i].ToString();
                    connection.Close();
                }
            }
            return mailD;
        }
        //Fin merge 23 de junio
        public bool Add_program(int idP, int IdC, string nomP, DateTime dateIn, string typePro)
        {
            var connection = GetConnection();
            connection.Open();
            var sql = "SELECT * FROM PROGRAMA WHERE Id_programa = @idP";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@idP", idP);
            command.Parameters.AddWithValue("@idC", IdC);
            command.Parameters.AddWithValue("@NomP", nomP);
            command.Parameters.AddWithValue("@dateIni", dateIn);
            command.Parameters.AddWithValue("@type", typePro);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                Console.WriteLine("Ya existe el id del programa");
                return false;
            }
            reader.Close();


            sql = "SELECT * FROM COMPANIA WHERE ID_COMPANIA = @IdC";
            var command2 = new MySqlCommand(sql, connection);
            command2.Parameters.AddWithValue("@idC", IdC);
            MySqlDataReader reader2 = command2.ExecuteReader();

            if (!reader2.HasRows)
            {
                Console.WriteLine("No existe esa compañia");
                return false;
            }

            reader2.Close();

            command.CommandText = "INSERT INTO PROGRAMA (ID_PROGRAMA, ID_COMPANIA, NOMBRE_PROGRAMA, FECHA_PROGRAMA, TIPO_PROGRAMA) VALUES(@idP, @idC, @NomP, @dateIni, @type)";
            command.ExecuteNonQuery();

            connection.Close();
            return true;
        }
        //Error de merge solucionado
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

        public DataTable MostrarProgramaEspecifico(int idP , int idC, string nomP, DateTime fechaIn, string typeP)
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;

            if(idP != 0)
            {
                command.Parameters.AddWithValue("@data", idP);
                command.CommandText = "SELECT * FROM PROGRAMA WHERE Id_programa = @data";
            }
            else if (idC != 0)
            {
                command.Parameters.AddWithValue("@data", idC);
                command.CommandText = "SELECT * FROM PROGRAMA WHERE Id_compania = @data";
            }
            else if(nomP != null)
            {
                command.Parameters.AddWithValue("@data", nomP);
                command.CommandText = "SELECT * FROM PROGRAMA WHERE Nombre_programa = @data";
            }
            else if(fechaIn != DateTime.MinValue)
            {
                command.Parameters.AddWithValue("@data", fechaIn);
                command.CommandText = "SELECT * FROM PROGRAMA WHERE Fecha_programa = @data";
            }
            else if(typeP != null)
            {
                command.Parameters.AddWithValue("@data", typeP);
                command.CommandText = "SELECT * FROM PROGRAMA WHERE Tipo_programa = @data";
            }
            
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }

    }
}
