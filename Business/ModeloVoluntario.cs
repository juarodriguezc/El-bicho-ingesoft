using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Data;

namespace Business
{
    public class ModeloVoluntario
    {
        VoluntarioDao volunteerDao = new VoluntarioDao();

        public bool Add_volunteer(string id_persona, string nombre, string apellido, DateTime fecha_nacimiento, string telefono, string genero, string correo, string pais, string tipo_p ) 
        {
            return volunteerDao.Add_volunteer(id_persona, nombre, apellido, fecha_nacimiento, telefono, genero, correo, pais, tipo_p);
        }

        public DataTable MostrarVoluntariosPorPrograma(string opcion, string valor)
        {
            return volunteerDao.MostrarVoluntariosPorPrograma(opcion, valor);
        }

        public DataTable MostrarVoluntariosDifferentToCountryWithActivePrograms(string country)
        {
            return volunteerDao.MostrarVoluntariosDifferentToCountryWithActivePrograms("Colombia");
        }

        public DataTable VoluntariosDisponibles(string programa)
        {
            return volunteerDao.VoluntariosDisponibles(programa);
        }

        public void add_VolunterProgram(string id_persona, string programa)
        {
            volunteerDao.add_VolunterProgram(id_persona, programa);
        }
    }
}
