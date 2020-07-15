using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using Business;

namespace Data
{
    public class StockDao : ConnectionToSql
    {
       
        public DataTable MostrarProductosStock()
        {
            DataTable tabla = new DataTable();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT * FROM PRODUCTO;";
            MySqlDataReader reader = command.ExecuteReader();
            tabla.Load(reader);
            connection.Close();
            return tabla;
        }
        private int getIdProducto(string producto)
        {
            var connection = GetConnection();
            connection.Open();
            int idProducto = 0;
            var sql = "SELECT * FROM PRODUCTO WHERE NOMBRE_ACCESO = @producto";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@producto", producto);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idProducto = reader.GetInt32(0);
                }
            }
            reader.Close();
            connection.Close();
            return idProducto;
        }

        public bool RealizarMovimiento(string producto, int id_usuario, int cantidad_movimiento, string tipo_movimiento)
        {
            DateTime fechaMovimiento = DateTime.Now;
            var connection = GetConnection();
            connection.Open();
            int id_producto = getIdProducto(producto);
            Console.WriteLine("IDP"+ id_producto);
            var command = new MySqlCommand();
            command.Connection = connection;
            command.Parameters.AddWithValue("@idProducto", id_producto);
            command.Parameters.AddWithValue("@idUsuario", id_usuario);
            command.Parameters.AddWithValue("@fechaMov", fechaMovimiento);
            command.Parameters.AddWithValue("@Cantidad", cantidad_movimiento);

            if (tipo_movimiento.Equals("Retirar")) { 
                command.CommandText = "SELECT * FROM PRODUCTO WHERE Id_producto=@idProducto AND Cantidad>=@Cantidad";
                command.CommandType = CommandType.Text;
                MySqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows) return false;
                reader.Close();
            }

            if (tipo_movimiento.Equals("Retirar"))
            {
                command.Parameters.AddWithValue("@CantidadMov", -1*cantidad_movimiento);
            }
            else
            {
                command.Parameters.AddWithValue("@CantidadMov", cantidad_movimiento);
            }

            command.CommandText = "INSERT INTO MOVIMIENTOS(ID_PRODUCTO, ID_USUARIO, FECHA_MOVIMIENTO, CANTIDAD_MOVIMIENTO) VALUES (@idProducto, @idUsuario, @fechaMov, @CantidadMov)";
            command.ExecuteNonQuery();
            command.CommandText = "UPDATE PRODUCTO set Cantidad=Cantidad+@CantidadMov WHERE Id_producto=@idProducto";
            command.ExecuteNonQuery();

            connection.Close();
            return true;
        }

        public List<string> nombresProductos()
        {
            List<String> productos = new List<string>();
            var connection = GetConnection();
            connection.Open();
            var command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT NOMBRE_ACCESO FROM PRODUCTO";
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    String a = reader.GetString(0);
                    productos.Add(a);
                }
            }
            reader.Close();
            connection.Close();
            return productos;
        }

        public int cantidadProducto(string producto)
        {
            var connection = GetConnection();
            connection.Open();
            int cantidadProducto = 0;
            var sql = "SELECT CANTIDAD FROM PRODUCTO WHERE NOMBRE_ACCESO = @producto";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@producto", producto);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cantidadProducto = reader.GetInt32(0);
                }
            }
            reader.Close();
            connection.Close();
            return cantidadProducto;
        }

        public bool addProducto(string producto, int cantidad, string localizacion)
        {
            var connection = GetConnection();
            connection.Open();
            var sql = "SELECT * FROM PRODUCTO WHERE NOMBRE_ACCESO=@producto";
            var command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@producto", producto);
            command.Parameters.AddWithValue("@cantidad", cantidad);
            command.Parameters.AddWithValue("@localizacion", localizacion);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) return false;
            reader.Close();

            command.CommandText = "INSERT INTO PRODUCTO (NOMBRE_ACCESO,CANTIDAD,LOCALIZACION) VALUES(@producto, @cantidad, @localizacion)";
            command.ExecuteNonQuery();

            connection.Close();
            return true;
        }

    }
}
