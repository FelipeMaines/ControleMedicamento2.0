using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloFuncionario
{
    internal class Funcionario : EntidadeBase
    {
        public string nome { get ; set; }
        public string cpf { get; set; }
      

        public Funcionario(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
            
        }

        public override void AtualizarInformacoes(EntidadeBase entidadeAtualizada)
        {
            Funcionario funcionarioAtualizado = (Funcionario) entidadeAtualizada;

            this.nome = funcionarioAtualizado.nome;
            this.cpf = funcionarioAtualizado.cpf;
        }

        public override ArrayList Verificacao()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome))
            {
                erros.Add("O campo nome nao foi preenchido corretamente!");
            }

            if(string.IsNullOrEmpty(cpf))
            {
                erros.Add("O campo cpf nao foi preenchido corretamente!");
            }

            return erros;
        }
    }
}
