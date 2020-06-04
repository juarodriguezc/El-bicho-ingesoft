using System;
using System.Data;
using Data;
namespace Business
{
    public class ModeloUsuario
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string correo, string contrasenia)
        {
            return userDao.Login(correo, contrasenia);
        }

        public bool Add_user(string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa)
        {
            return userDao.Add_user(correo, nombre, apellido, fecha_nacimiento, contrasenia, rol_empresa);
        }

        public bool RecuperaContra(string correo)
        {
            return userDao.RecuperaContra(correo);
        }

        public DataTable MostrarUsuarios(string correo)
        {
            return userDao.MostrarUsuarios(correo);
        }
        public void EditarUsuario(int id, string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa)
        {
            userDao.EditarUsuario(id, correo, nombre, apellido, fecha_nacimiento, contrasenia, rol_empresa);
        }

        public DataTable MostrarRegistroConversacion() {
            return userDao.MostrarRegistroConversacion();
        }
    }
}
