using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloPaciente
{
    public class RepositorioPaciente : RepositorioBase<Paciente>
    {
        public RepositorioPaciente(List<Paciente> arrayList)
        {
            listaRegistros = arrayList;
        }
    }
}
