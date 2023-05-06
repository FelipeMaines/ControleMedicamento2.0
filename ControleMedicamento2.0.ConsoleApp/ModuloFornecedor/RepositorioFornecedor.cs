using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloFornecedor
{
    public class RepositorioFornecedor : RepositorioBase<Fornecedor>
    {
        public RepositorioFornecedor(List<Fornecedor> arrayList)
        {
            this.listaRegistros = arrayList;
        }

        public override Fornecedor BuscarPorId(int id)
        {
            return base.BuscarPorId(id);
        }
    }
}
