using Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class ModeloSesion
    {
        SesionDao sesion = new SesionDao();
        public void createSesion(int Id_user, DateTime Date) {
            sesion.createSesion(Id_user, Date);
        }
        public void create_reg_function(int Id_funcion, int Id_acceso) {
            sesion.create_reg_function(Id_funcion, Id_acceso);
        }
    }
}
