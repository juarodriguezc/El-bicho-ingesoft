using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Business;
using Data;

namespace Business
{
    public class ModeloStock
    {
        StockDao stockDao = new StockDao();

        public DataTable MostrarProductosStock()
        {
            return stockDao.MostrarProductosStock();
        }

        public bool RealizarMovimiento(string producto, int id_usuario, int cantidad_movimiento, string tipo_movimiento)
        {
            return stockDao.RealizarMovimiento(producto, id_usuario, cantidad_movimiento, tipo_movimiento);
        }

        public List<string> nombresProductos()
        {
            return stockDao.nombresProductos();
        }

        public int cantidadProducto(string producto)
        {
            return stockDao.cantidadProducto(producto);
        }

        public bool addProducto(string producto, int cantidad, string localizacion)
        {
            return stockDao.addProducto(producto, cantidad, localizacion);
        }
    }
}
