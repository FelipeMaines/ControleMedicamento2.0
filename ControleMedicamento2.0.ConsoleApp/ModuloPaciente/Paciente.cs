using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using System;
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
    }
}
