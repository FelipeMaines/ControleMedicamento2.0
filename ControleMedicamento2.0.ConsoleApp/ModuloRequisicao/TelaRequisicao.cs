using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFuncionario;
using ControleMedicamento2._0.ConsoleApp.ModuloMedicamento;
using ControleMedicamento2._0.ConsoleApp.ModuloPaciente;
using System;
using System.Collections;


namespace ControleMedicamento2._0.ConsoleApp.ModuloRequisicao
{
    public class TelaRequisicao : TelaBase<Requisicao, RepositorioRequisicao>
    {
        private RepositorioPaciente repositorioPaciente;
        private TelaPaciente telaPaciente;
        private RepositorioFuncionario repositorioFuncionario;
        private TelaFuncionario telaFuncionario;
        private RepositorioMedicamento repositorioMedicamento;
        private TelaMedicamento telaMedicamento;
        public string nomeEntidade;

        public TelaRequisicao(RepositorioRequisicao repositorio, RepositorioMedicamento repositorioMedicamento,
            RepositorioFuncionario repositorioFuncionario, RepositorioPaciente repositorioPaciente, 
            TelaMedicamento telaMedicamento, TelaPaciente telaPaciente, TelaFuncionario telaFuncionario) : base(repositorio)
        {
            nomeEntidade = "Requisicao";

            this.repositorioPaciente = repositorioPaciente;
            this.telaPaciente = telaPaciente;
            this.repositorioFuncionario = repositorioFuncionario;
            this.telaFuncionario = telaFuncionario;
            this.repositorioMedicamento = repositorioMedicamento;
            this.telaMedicamento = telaMedicamento;
        }

        public override void MostrarObjetos(List<Requisicao> array)
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | {4, -10} | {5, -10} |", "id", "paciente", "medicamento", "Qtd Retirada", "Data", "Funcionario");

            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (Requisicao requisicao in array)
            {
                Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | {4, -10} | {5, -10} |", requisicao.id, requisicao.paciente.nome, requisicao.medicamento.nome, requisicao.quantidadePegada, requisicao.data, requisicao.funcionario.nome);
            }
        }

        public override void MostrarTabela()
        {
            List<Requisicao> array = repositorioBase.SelecionarTodos();

            MostrarObjetos(array);
        }

        public override Requisicao ObterRegistro()
        {
            Console.Clear();

            telaFuncionario.MostrarTabela();
            Console.WriteLine("Qual o id do funcionario fazendo a requisicao:");
            int idFuncionario = int.Parse(Console.ReadLine());

            Funcionario funcionario = repositorioFuncionario.BuscarPorId(idFuncionario);

            Console.Clear();

            telaMedicamento.MostrarTabela();
            Console.WriteLine("Qual o id do medicamento fazendo a requisicao:");
            int idMedicamento = int.Parse(Console.ReadLine());

            Medicamento medicamento = (Medicamento)repositorioMedicamento.BuscarPorId(idMedicamento);

            Console.Clear();

            telaPaciente. MostrarTabela();
            Console.WriteLine("Qual o id do paciente que deseja fazer a requisicao: ");
            int idPaciente = int.Parse(Console.ReadLine());

            Paciente paciente = (Paciente)repositorioPaciente.BuscarPorId(idPaciente);

            Console.Clear();

            Console.WriteLine($"Qual a quantidade de {medicamento.nome}: ");
            Console.WriteLine($"qtd em estoque: {medicamento.quantidadeEstoque}");

            int quantidadePegada = int.Parse(Console.ReadLine());

            if(medicamento.quantidadeEstoque >= quantidadePegada)
            medicamento.quantidadeEstoque -= quantidadePegada;

            else
            {
                Mensagem("Nao ah esse numero de medicamentos em estoque!", ConsoleColor.DarkRed);
                return null;
            }

            DateTime data = DateTime.Today;

            return new Requisicao(funcionario, medicamento, paciente, quantidadePegada, data);
        }
    }
}
