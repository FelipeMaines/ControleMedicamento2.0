using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloFornecedor
{
    internal class RepositorioFornecedor : RepositorioBase
    {
        public RepositorioFornecedor(ArrayList arrayList)
        {
            this.listaRegistros = arrayList;
        }

        public override EntidadeBase BuscarPorId(int id)
        {
            return (Fornecedor)base.BuscarPorId(id);
        }
    }
}
