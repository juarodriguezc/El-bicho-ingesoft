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

        public bool Add_user(string id_persona, string nombre, string apellido, DateTime fecha_nacimiento, string telefono, string genero, string correo, string contrasenia, string rol_empresa, string nickname, string pais_n)
        {
            return userDao.Add_user(id_persona, nombre, apellido, fecha_nacimiento, telefono, genero, correo, contrasenia, rol_empresa, nickname, pais_n);
        }


        public bool RecuperaContra(string correo)
        {
            return userDao.RecuperaContra(correo);
        }

        public DataTable MostrarUsuarios(string correo)
        {
            return userDao.MostrarUsuarios(correo);
        }

        public void EditarUsuario(string id_persona, string correo, string nombre, string apellido, DateTime fecha_nacimiento, string contrasenia, string rol_empresa, string genero, string telefono, string nickname)
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

        public DataTable MostrarInfoPersonas()
        {
            return userDao.personasInfo();
        }

        public DataTable showInfoCompanies()
        {
            return userDao.showCompanies();
        }
        public DataTable MostrarUsuarios(int id_usuario)
        {
            return userDao.MostrarUsuarios(id_usuario);
        }
        public DataTable CompletaUsuarios(int id_usuario)
        {
            return userDao.CompletaUsuarios(id_usuario);
        }
        public DateTime getNacimiento(int id_persona)
        {
            return userDao.getNacimiento(id_persona);
        }

        public bool verificarExistenciaUsuario(string usuario, string id_usuario)
        {
            return userDao.verificarExistenciaUsuario(usuario, id_usuario);
        }

        public bool verificarExistenciaEmail(string email, string id_usuario)
        {
            return userDao.verificarExistenciaEmail(email, id_usuario);
        }

        public DataTable showProgram()
        {
            return userDao.showPrograms();
        }
    }
}
