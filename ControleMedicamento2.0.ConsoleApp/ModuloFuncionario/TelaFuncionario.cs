using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloFuncionario
{
    internal class TelaFuncionario : TelaBase
    {
        public TelaFuncionario(RepositorioFuncionario repositorioFuncionario) : base(repositorioFuncionario)
        {
            nomeEntidade = "Funcionario";
            sufixo = "s";
        }

        public override void MostrarObjetos(ArrayList array)
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} |", "id", "nome", "cpf");

            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (Funcionario funcionario in array)
            {
                Console.WriteLine("{0, -10} | {1, -10} | {2, -10} |", funcionario.id, funcionario.nome, funcionario.cpf);
            }
        }

        public override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Qual o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o cpf");
            string cpf = Console.ReadLine();

            return new Funcionario(nome, cpf);
        }

        
    }
}
