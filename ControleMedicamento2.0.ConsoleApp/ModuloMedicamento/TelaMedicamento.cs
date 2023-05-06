using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using ControleMedicamento2._0.ConsoleApp.ModuloFuncionario;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloMedicamento
{
    public class TelaMedicamento : TelaBase<Medicamento, RepositorioMedicamento>
    {
        public TelaFornecedor telaFornecedor;
        public RepositorioFornecedor repositorioFornecedor;

        public TelaMedicamento(RepositorioMedicamento repositorio, RepositorioFornecedor repositorioFornecedor, TelaFornecedor telaFornecedor) : base(repositorio)
        {
            this.repositorioFornecedor = repositorioFornecedor;
            this.telaFornecedor = telaFornecedor;
            this.nomeEntidade = "Medicamento";
            sufixo = "s";
        }

        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Medicamentos \n");

            Console.WriteLine("Digite 1 para Inserir Medicamento");
            Console.WriteLine("Digite 2 para Visualizar Medicamentos");
            Console.WriteLine("Digite 3 para Editar Medicamentos");
            Console.WriteLine("Digite 4 para Excluir Medicamentos");
            Console.WriteLine("Digite 5 para Visualizar Medicamentos Mais Retirados");
            Console.WriteLine("Digite 6 para Visualizar Medicamentos em Falta\n");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public override void MostrarTabela()
        {
            List<Medicamento> array = repositorioBase.SelecionarTodos();

            MostrarObjetos(array);
        }


        public override void MostrarObjetos(List<Medicamento> array)
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | {4, -10} | {5, -10} |", "id", "nome", "descricao", "Qtd Estoque", "Qtd Min", "Fornecedor");

            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (Medicamento medicamento in array)
            {
                Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | {4, -10} | {5, -10} |", medicamento.id, medicamento.nome, medicamento.descricao, medicamento.quantidadeEstoque, medicamento.quantidadeMinima, medicamento.fornecedor.nome);
            }
        }

        public override Medicamento ObterRegistro()
        {
            Console.Clear();

            telaFornecedor.MostrarTabela();

            Console.WriteLine("Qual o id do forncedor? ");
            int id = int.Parse(Console.ReadLine());

            Fornecedor fornecedor = (Fornecedor)repositorioFornecedor.BuscarPorId(id);

            Console.Clear();

            Console.WriteLine("Qual o nome do medicamento: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a descricao: ");
            string descricao = Console.ReadLine();

            Console.WriteLine("Qual a quantidade em estoque: ");
            int quantidadeEstoque = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade minima:");
            int quantidadeMinima = int.Parse(Console.ReadLine());


            return new Medicamento(nome, descricao, quantidadeEstoque, quantidadeMinima, fornecedor);
        }
    }
}
