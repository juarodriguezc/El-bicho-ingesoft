using System;
using Data;
namespace Business
{
    public class ModeloUsuario
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string correo, string contrasenia) {
            return userDao.Login(correo, contrasenia);
        }

        public bool Add_user(string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, int rol_empresa ) {
            return userDao.Add_user(correo, nombre, apellido, fecha_nacimiento, contrasenia, rol_empresa);
        }
    }
}
