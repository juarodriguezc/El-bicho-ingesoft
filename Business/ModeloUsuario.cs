using System;
using Data;
namespace Data
{
    public class ModeloUsuario
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string correo, string contrasenia) {
            return userDao.Login(correo, contrasenia);
        }
    }
}
