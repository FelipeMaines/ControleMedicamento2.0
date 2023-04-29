using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloMedicamento
{
    internal class RepositorioMedicamento : RepositorioBase
    {
        public RepositorioMedicamento(ArrayList ListaMedicamento)
        {
            listaRegistros = ListaMedicamento;
        }

        public override EntidadeBase BuscarPorId(int id)
        {
            return (Medicamento)base.BuscarPorId(id);
        }
    }
}
