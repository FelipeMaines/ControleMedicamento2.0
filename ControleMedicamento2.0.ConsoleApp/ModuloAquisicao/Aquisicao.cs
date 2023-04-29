using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using ControleMedicamento2._0.ConsoleApp.ModuloFuncionario;
using ControleMedicamento2._0.ConsoleApp.ModuloMedicamento;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ControleMedicamento2._0.ConsoleApp.ModuloAquisicao
{
    internal class Aquisicao : EntidadeBase
    {
        public Fornecedor fornecedor;
        public Medicamento medicamento;
        public Funcionario funcionario;
        public DateTime data;
        public int quantiadeAdicionar;

        public Aquisicao(Fornecedor fornecedor, Medicamento medicamento, Funcionario funcionario, DateTime data, int quantiadeAdicionar)
        {
            this.fornecedor = fornecedor;
            this.medicamento = medicamento;
            this.funcionario = funcionario;
            this.data = data;
            this.quantiadeAdicionar = quantiadeAdicionar;
        }

        public override void AtualizarInformacoes(EntidadeBase entidadeAtualizada)
        {
            Aquisicao aquisicaoAtualizda = (Aquisicao)entidadeAtualizada;

            this.fornecedor = aquisicaoAtualizda.fornecedor;
            this.medicamento = aquisicaoAtualizda.medicamento;
            this.funcionario = aquisicaoAtualizda.funcionario;
            this.data = aquisicaoAtualizda.data;
            this.quantiadeAdicionar = aquisicaoAtualizda.quantiadeAdicionar;
        }

        public override ArrayList Verificacao()
        {
            ArrayList erros = new ArrayList();

            if (fornecedor == null)
                erros.Add("O campo *Fornecedor eh obrigatorio*");

            if (medicamento == null)
                erros.Add("O campo *Medicamento* eh obrigatorio!");

            if (funcionario == null)
                erros.Add("O campo *Funcionario* eh obrigatorio!");

            if (quantiadeAdicionar == null || quantiadeAdicionar <= 0)
                erros.Add("O campo *Quantidade de medicamento nao foi preenchido corretamente*");

            return erros;
        }
    }
}
