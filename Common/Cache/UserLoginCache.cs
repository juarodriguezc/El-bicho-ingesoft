using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Cache
{
    public static class UserLoginCache
    {
        public static int Id_usuario { get; set; }
        public static string Correo { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static DateTime Fecha_nacimiento { get; set; }
        public static int Rol_empresa { get; set; }
    }
}
