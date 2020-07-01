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

        public bool Add_volunteer(int id_persona, string nombre, string apellido, DateTime fecha_nacimiento, string telefono, string genero, string correo, string pais) 
        {
            return volunteerDao.Add_volunteer(id_persona, nombre, apellido, fecha_nacimiento, telefono, genero, correo, pais);
        }


        public DataTable MostrarVoluntariosPorPrograma(string opcion, string valor)
        {
            return volunteerDao.MostrarVoluntariosPorPrograma(opcion, valor);
        }

        public DataTable MostrarVoluntariosDifferentToCountryWithActivePrograms(string country)
        {
            return volunteerDao.MostrarVoluntariosDifferentToCountryWithActivePrograms("Colombia");
        }
    }
}
