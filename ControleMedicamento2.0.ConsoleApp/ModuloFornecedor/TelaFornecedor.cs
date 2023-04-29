using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFuncionario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloFornecedor
{
    internal class TelaFornecedor : TelaBase
    {
        public TelaFornecedor(RepositorioFornecedor repositorioFornecedor) : base(repositorioFornecedor)
        {
            nomeEntidade = "Fornecedor";
            sufixo = "es";
        }

        public override void MostrarObjetos(ArrayList array)
        {

            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10}", "id", "nome", "medicamento", "telefone", "cidade");

            Console.WriteLine("-----------------------------------------------------------------------");

            foreach(Fornecedor fornecedor in array)
            {
                Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | {4, -10}",fornecedor.id, fornecedor.nome, fornecedor.medicamento, fornecedor.telefone, fornecedor.cidade);
            }
        }

        public override EntidadeBase ObterRegistro()
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
