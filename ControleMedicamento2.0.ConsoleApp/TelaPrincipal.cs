using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp
{
    internal class TelaPrincipal
    {
        public string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Bem vindo ao * Controle de Medicamentos *\n");

            Console.WriteLine("Digite 1 para Cadastrar Fornecedores");
            Console.WriteLine("Digite 2 para Cadastrar Funcionários");
            Console.WriteLine("Digite 3 para Cadastrar Pacientes");
            Console.WriteLine("Digite 4 para Cadastrar Medicamentos");

            Console.WriteLine("Digite 5 para Cadastrar Requisições de Entrada");
            Console.WriteLine("Digite 6 para Cadastrar Requisições de Saída\n");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
    }
}
