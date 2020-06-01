using System;
using System.Collections.Generic;
using System.Text;
using Data;
namespace Business
{
    public class ModeloRecuperacion
    {
        RecuperaDao recuperaDao = new RecuperaDao();
        public bool VerificaDatos(string correo)
        {
            return recuperaDao.VerificaDatos(correo);
        }
    }
}
