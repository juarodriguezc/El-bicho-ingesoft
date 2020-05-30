using System;
using Data;

namespace Business
{
    public class ModeloRespuesta
    {
        RespuestaDao respuestaDao = new RespuestaDao();
        public string generarRespuesta(string azure_msg) {
            return respuestaDao.GenRespuesta(azure_msg);
        }
    }
}
