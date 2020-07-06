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
    public class EmpresaDao : ConnectionToSql
    {
        public bool add_empresa(string nombre_empresa, string direccion, string nit, string telefono_empresa) {
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@nombre_empresa", nombre_empresa);
            command.Parameters.AddWithValue("@direccion", direccion);
            command.Parameters.AddWithValue("@nit", nit);
            command.Parameters.AddWithValue("@telefono_empresa", telefono_empresa);
            command.CommandText = "SELECT * FROM COMPANIA WHERE NIT = @nit or TELEFONO_CONTACTO = @telefono_empresa";
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) return false;
            reader.Close();
            command.CommandText = "INSERT INTO COMPANIA (NOMBRE_COMPANIA, DIRECCION, NIT, TELEFONO_CONTACTO) " +
                "VALUES (@nombre_empresa, @direccion, @nit, @telefono_empresa)";
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
    }
}
