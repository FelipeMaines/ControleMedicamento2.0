using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloAquisicao;
using ControleMedicamento2._0.ConsoleApp.ModuloFuncionario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloFornecedor
{
    public class TelaFornecedor : TelaBase<Fornecedor, RepositorioFornecedor>
    {
        public TelaFornecedor(RepositorioFornecedor repositorioFornecedor) : base(repositorioFornecedor)
        {
            nomeEntidade = "Fornecedor";
            sufixo = "es";
        }

        public override void MostrarObjetos(List<Fornecedor> array)
        {

            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10}", "id", "nome", "medicamento", "telefone", "cidade");

            Console.WriteLine("-----------------------------------------------------------------------");

            foreach(Fornecedor fornecedor in array)
            {
                Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | {4, -10}",fornecedor.id, fornecedor.nome, fornecedor.medicamento, fornecedor.telefone, fornecedor.cidade);
            }
        }

        public override void MostrarTabela()
        {
            List<Fornecedor> array = repositorioBase.SelecionarTodos();

            MostrarObjetos(array);
        }

        public override Fornecedor ObterRegistro()
        {
            Console.WriteLine("Qual o nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o medicamento? ");
            string medicamento = Console.ReadLine();

            Console.WriteLine("Qual a cidade: ");
            string cidade = Console.ReadLine();

            Console.WriteLine("Qual o telefone");
            string telfone = Console.ReadLine();

            return new Fornecedor(nome, medicamento, cidade, telfone);
        }
    }
}
