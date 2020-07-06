using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business
{
    public class ModeloEmpresa
    {
        EmpresaDao empresa = new Data.EmpresaDao();
        public bool add_empresa(string nombre_empresa, string direccion, string nit, string telefono_empresa)
        {

            return empresa.add_empresa(nombre_empresa,direccion,nit,telefono_empresa);
        }
    }
}
