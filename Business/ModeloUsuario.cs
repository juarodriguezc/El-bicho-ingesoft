using System;
using System.Collections.Generic;
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

        /*public bool Add_user(string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa)
        {
            return userDao.Add_user(correo, nombre, apellido, fecha_nacimiento, contrasenia, rol_empresa);
        }*/

        public bool Add_user(int id_persona, string nombre, string apellido, DateTime fecha_nacimiento, string telefono, string genero, string correo, string contrasenia, string rol_empresa, string nickname)
        {
            return userDao.Add_user(id_persona, nombre, apellido, fecha_nacimiento, telefono, genero, correo, contrasenia, rol_empresa, nickname);
        }


        public bool RecuperaContra(string correo)
        {
            return userDao.RecuperaContra(correo);
        }

        public DataTable MostrarUsuarios(string correo)
        {
            return userDao.MostrarUsuarios(correo);
        }

        /*public void EditarUsuario(int id, string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa)
        {
            userDao.EditarUsuario(id, correo, nombre, apellido, fecha_nacimiento, contrasenia, rol_empresa);
        }*/

        public void EditarUsuario(int id_persona, string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa, string genero, string telefono, string nickname)
        {
            userDao.EditarUsuario(id_persona, correo, nombre, apellido, fecha_nacimiento, contrasenia, rol_empresa, genero, telefono, nickname);
        }

        public DataTable MostrarRegistroConversacion()
        {
            return userDao.MostrarRegistroConversacion();
        }

        public void CambiarPassword(int id_persona, string contrasenia)
        {
            userDao.CambiarPassword(id_persona, contrasenia);
        }

        public List<string> ConsultarEventosDia(int id_usuario, DateTime dia)
        {
            return userDao.ConsultarEventosDia(id_usuario, dia);
        }
        public string[] ConsultarProxEvento(int id_usuario)
        {
            return userDao.ConsultarProxEvento(id_usuario);
        }
    }
}
