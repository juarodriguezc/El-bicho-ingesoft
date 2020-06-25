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

    }
}
