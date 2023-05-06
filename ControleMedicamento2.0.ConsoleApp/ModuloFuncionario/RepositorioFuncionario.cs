using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloFuncionario
{
    public class RepositorioFuncionario : RepositorioBase<Funcionario>
    {
        public RepositorioFuncionario(List<Funcionario> listaFuncionario)
        {
            this.listaRegistros = listaFuncionario;
        }

        public override Funcionario BuscarPorId(int id)
        {
            return (Funcionario)base.BuscarPorId(id);
        }

    }
}
