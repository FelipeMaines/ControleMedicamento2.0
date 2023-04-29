using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloFornecedor
{
    internal class Fornecedor : EntidadeBase
    {
        public Fornecedor(string? nome, string? medicamento, string? cidade, string? telefone)
        {
            this.nome = nome;
            this.medicamento = medicamento;
            this.cidade = cidade;
            this.telefone = telefone;
        }

        public string nome { get; set; }
        public string medicamento { get; set; }
        public string telefone { get; set; }
        public string cidade { get; set; }

        public override void AtualizarInformacoes(EntidadeBase entidadeAtualizada)
        {
            Fornecedor parametroAtualizado = (Fornecedor)entidadeAtualizada;

            this.nome = parametroAtualizado.nome;
            this.medicamento = parametroAtualizado.medicamento;
            this.telefone = parametroAtualizado.telefone;
            this.cidade = parametroAtualizado.cidade;

        }
    }
}
