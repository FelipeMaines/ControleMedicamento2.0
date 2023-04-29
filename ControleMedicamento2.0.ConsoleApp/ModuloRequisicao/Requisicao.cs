using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFuncionario;
using ControleMedicamento2._0.ConsoleApp.ModuloMedicamento;
using ControleMedicamento2._0.ConsoleApp.ModuloPaciente;


namespace ControleMedicamento2._0.ConsoleApp.ModuloRequisicao
{
    internal class Requisicao : EntidadeBase
    {
        public Paciente paciente { get; set; }
        public Medicamento medicamento { get; set; }
        public Funcionario funcionario { get; set; }
        public DateTime data { get; set; }
        public int quantidadePegada { get; set; }
        public Requisicao(Funcionario funcionario, Medicamento medicamento, Paciente paciente, int quantidadePegada, DateTime data)
        {
            this.funcionario = funcionario;
            this.medicamento = medicamento;
            this.paciente = paciente;
            this.quantidadePegada = quantidadePegada;
            this.data = data;
        }

        public override void AtualizarInformacoes(EntidadeBase entidadeAtualizada)
        {
            Requisicao requisicaoAtualizada = (Requisicao)entidadeAtualizada;

            this.funcionario = requisicaoAtualizada.funcionario;
            this.medicamento = requisicaoAtualizada.medicamento;
            this.paciente = requisicaoAtualizada.paciente;
            this.quantidadePegada = requisicaoAtualizada.quantidadePegada;
            this.data = requisicaoAtualizada.data;
        }
    }
}
