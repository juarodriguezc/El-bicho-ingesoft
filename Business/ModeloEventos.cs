using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ModeloEventos
    {
        EventosDao eventos = new EventosDao();

        public List<string> ConsultarEventosDia(int id_usuario, DateTime dia)
        {
            return eventos.ConsultarEventosDia(id_usuario, dia);
        }

        public string[] ConsultarProxEvento(int id_usuario)
        {
            return eventos.ConsultarProxEvento(id_usuario);

        }
        public List<string[]> ShowUsersCargo()
        {
            return eventos.ShowUsersCargo();
        }
    }
}
