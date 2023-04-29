using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using ControleMedicamento2._0.ConsoleApp.ModuloFuncionario;
using ControleMedicamento2._0.ConsoleApp.ModuloMedicamento;
using ControleMedicamento2._0.ConsoleApp.ModuloPaciente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloAquisicao
{
    internal class TelaAquisicao : TelaBase
    {
        public RepositorioFuncionario repositorioFuncionario;
        public RepositorioMedicamento repositorioMedicamento;
        public TelaFuncionario telaFuncionario;
        public TelaMedicamento telaMedicamento;
        public RepositorioFornecedor repositorioFornecedor;
        public TelaFornecedor telaFornecedor;

        public TelaAquisicao(RepositorioBase repositorio, RepositorioMedicamento repositorioMedicamento,
            RepositorioFornecedor repositorioFornecedor, RepositorioFuncionario repositorioFuncionario,
            TelaMedicamento telaMedicamento, TelaFornecedor telaFornecedor, TelaFuncionario telaFuncionario) : base(repositorio)
        {
            this.repositorioMedicamento = repositorioMedicamento;
            this.repositorioFornecedor = repositorioFornecedor;
            this.repositorioFuncionario = repositorioFuncionario;
            this.telaMedicamento = telaMedicamento;
            this.telaFornecedor = telaFornecedor;
            this.telaFuncionario = telaFuncionario;

            nomeEntidade = "Requisições de Entrada";
        }

        public override void MostrarObjetos(ArrayList array)
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -15} | {4, -15} |", "id", "funcionario", "medicamento", "quantidade Adicionada", "data");

            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (Aquisicao aquisicao in array)
            {
                Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -15} | {4, -15} |", aquisicao.id, aquisicao.funcionario.nome, aquisicao.medicamento.nome, aquisicao.quantiadeAdicionar, aquisicao.data);
            }
        }

        public override EntidadeBase ObterRegistro()
        {
            Console.Clear();

            telaFornecedor.MostrarTabela();
            Console.WriteLine("Qual o id do forncedor: ");
            int idFornecedor = int.Parse(Console.ReadLine());

            Fornecedor fornecedor = (Fornecedor)repositorioFornecedor.BuscarPorId(idFornecedor);

            Console.Clear();

            telaMedicamento.MostrarTabela();
            Console.WriteLine("Qual o id do medicamento: ");
            int idMedicamento = int.Parse(Console.ReadLine());

            Medicamento medicamento = (Medicamento)repositorioMedicamento.BuscarPorId(idMedicamento);

            Console.Clear();

            telaFuncionario.MostrarTabela();
            Console.WriteLine("Qual o id do funcionario: ");
            int idFuncionario = int.Parse(Console.ReadLine());

            Funcionario funcionario = repositorioFuncionario.BuscarPorId(idFuncionario);

            DateTime data = DateTime.Today;

            Console.WriteLine($"Qual a quantiade de {medicamento.nome} que deseja adicionar: ");
            Console.WriteLine($"Quantidade em estoque: {medicamento.quantidadeEstoque}");

            int quantiadeAdicionar = int.Parse(Console.ReadLine());

            medicamento.quantidadeEstoque += quantiadeAdicionar;

            return new Aquisicao(fornecedor, medicamento, funcionario, data, quantiadeAdicionar);
        }
    }
}
