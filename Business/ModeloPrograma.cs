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

        public string nameCompany(int idC)
        {
            return programa.buscarNombreCompanies(idC);
        }

        public int buscarIdCompany(string name)
        {
            return programa.buscarIdCompany(name);
        }

        public void editProgram(int idP, int idC, string name, string tipo, DateTime fechaIni, DateTime fechaFin)
        {
            programa.editProgram(idP, idC, name, tipo, fechaIni, fechaFin);
        }

        public bool existeCompania(int idC)
        {
            return programa.existeCompany(idC);
        }

        public DataTable programaActivos()
        {
            return programa.programaActivos();
        }

        public DataTable MostrarInfoProgramaEspc(int idP, int idC, string nomP, DateTime fechaIn, string typeP)
        {
            return programa.MostrarProgramaEspecifico(idP, idC, nomP, fechaIn, typeP);
        }

    }
}
