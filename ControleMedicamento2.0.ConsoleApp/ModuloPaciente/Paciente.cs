using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloPaciente
{
    internal class Paciente : EntidadeBase
    {
        public string nome { get; set; }
        public string sus { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
     
        public Paciente(string nome, string cpf, string sus, string telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.sus = sus;
            this.telefone = telefone;
        }


        public override void AtualizarInformacoes(EntidadeBase entidadeAtualizada)
        {
            Paciente paciente = (Paciente)entidadeAtualizada;

            nome = paciente.nome;
            sus = paciente.sus;
            cpf = paciente.cpf;
            telefone = paciente.telefone;
        }

        public override ArrayList Verificacao()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(cpf))
                erros.Add("O campo cpf nao foi preenchido corretamente!");

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo nome nao foi preenchido corretamente!");

            if (string.IsNullOrEmpty(sus))
                erros.Add("O campo sus nao foi preenchido corretamente!");

            if (string.IsNullOrEmpty(telefone))
                erros.Add("O campo telefone nao foi preenchido corretamente!");

            return erros;
        }
    }
}
