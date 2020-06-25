using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Data;
namespace Business
{
    public class ModeloPrograma
    {
        ProgramaDao programa = new ProgramaDao();
        public DataTable MostarInfoProgramaSegunFecha(DateTime date)
        {
            return programa.programaSegunFecha(date);
        }

        public List<string> companyList()
        {
            return programa.companyList();
        }
        public bool add_program(string nombreCompany, string nombrePrograma, DateTime fechaInicio, DateTime fechaFin, string tipoPrograma)
        {
            return programa.add_program(nombreCompany, nombrePrograma, fechaInicio, fechaFin, tipoPrograma);
        }

        public DataTable programaActivos()
        {
            return programa.programaActivos();
        }
    }
}
