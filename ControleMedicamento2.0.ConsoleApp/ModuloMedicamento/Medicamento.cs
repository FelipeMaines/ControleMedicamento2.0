using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloMedicamento
{
    public class Medicamento : EntidadeBase
    {

        public string nome { get; set; }
        public string descricao { get; set; }
        public int quantidadeEstoque { get; set; }
        public int quantidadeMinima { get; set; }
        public Fornecedor fornecedor { get; set; }

        public Medicamento(string nome, string descricao, int quantidadeEstoque, int quantidadeMinima, Fornecedor fornecedor)
        {
            this.nome = nome;
            this.descricao = descricao;
            this.quantidadeEstoque = quantidadeEstoque;
            this.quantidadeMinima = quantidadeMinima;
            this.fornecedor = fornecedor;
        }

        public override void AtualizarInformacoes(EntidadeBase entidadeAtualizada)
        {
            Medicamento medicamento = (Medicamento)entidadeAtualizada;

            nome = medicamento.nome;
            descricao = medicamento.descricao;
            quantidadeEstoque = medicamento.quantidadeEstoque;
            quantidadeMinima = medicamento.quantidadeMinima;
            fornecedor = medicamento.fornecedor;
        }

        public override ArrayList Verificacao()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(descricao))
                erros.Add("O campo descricao nao foi preenchido corretamente!");

            if(string.IsNullOrEmpty(nome))
                erros.Add("O campo nome nao foi preenchido corretamente!");

            if (quantidadeEstoque <= 0)
                erros.Add("Quantidade em estoque menor que zero!");

            if (fornecedor == null)
                erros.Add("O campo fornecedor eh obrigatorio!");

            return erros;
        }

    }
}
