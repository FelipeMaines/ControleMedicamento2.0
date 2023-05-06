using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloAquisicao
{
    public class RepositorioAquisicao : RepositorioBase<Aquisicao>
    {
        public RepositorioAquisicao(List<Aquisicao> listaAquisicao)
        {
            listaRegistros = listaAquisicao;
        }


    }
}
