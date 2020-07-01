using Data;
using System;
using System.Collections.Generic;
using System.Data;
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
        public void createEvent(string id_owner, List<string> list_invitados, string asunto, DateTime fecha_evento)
        {
            eventos.createEvent(id_owner, list_invitados, asunto, fecha_evento);
        }
        public void updateEvent(int id_evento, int id_owner, List<string> list_invitados, string asunto, DateTime fecha_evento)
        {
            eventos.updateEvent(id_evento, id_owner, list_invitados, asunto, fecha_evento);
        }
        public DataTable MostrarEventosPersona(int id_usuario)
        {
            return eventos.MostrarEventosPersona(id_usuario);
        }
        public List<string> ShowUsersEvent(int id_evento, int id_usuario)
        {
            return eventos.ShowUsersEvent(id_evento, id_usuario);
        }
    }
}
