using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using ControleMedicamento2._0.ConsoleApp.ModuloFuncionario;
using ControleMedicamento2._0.ConsoleApp.ModuloMedicamento;
using ControleMedicamento2._0.ConsoleApp.ModuloPaciente;
using System.Collections;

namespace ControleMedicamento2._0.ConsoleApp.ModuloRequisicao
{
    public class Requisicao : EntidadeBase
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

        public override ArrayList Verificacao()
        {
            ArrayList erros = new ArrayList();

            if (paciente == null)
                erros.Add("O campo *paciente eh obrigatorio*");

            if (medicamento == null)
                erros.Add("O campo *Medicamento* eh obrigatorio!");

            if (funcionario == null)
                erros.Add("O campo *Funcionario* eh obrigatorio!");

            if (quantidadePegada == null || quantidadePegada <= 0)
                erros.Add("O campo *Quantidade de medicamento nao foi preenchido corretamente*");

            return erros;
        }
    }
}
