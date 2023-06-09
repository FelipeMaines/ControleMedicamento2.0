﻿using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloMedicamento;
using System.Collections;


namespace ControleMedicamento2._0.ConsoleApp.ModuloPaciente
{
    public class TelaPaciente : TelaBase<Paciente, RepositorioPaciente>
    {
        public TelaPaciente(RepositorioPaciente repositorio) : base(repositorio)
        {
            nomeEntidade = "Paciente";
            sufixo = "s";
        }

        public override void MostrarObjetos(List<Paciente> array)
        {
            Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | {4, -10} |", "id", "nome", "cpf", "telefone", "sus");

            Console.WriteLine("-----------------------------------------------------------------------");

            foreach (Paciente paciente in array)
            {
                Console.WriteLine("{0, -10} | {1, -10} | {2, -10} | {3, -10} | {4, -10} |", paciente.id, paciente.nome, paciente.cpf, paciente.telefone, paciente.sus);
            }
        }
        public override void MostrarTabela()
        {
            List<Paciente> array = repositorioBase.SelecionarTodos();

            MostrarObjetos(array);
        }

        public override Paciente ObterRegistro()
        {
            Console.WriteLine("Qual o nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o cartao do sus: ");
            string sus = Console.ReadLine();

            Console.WriteLine("Qual o telefone");
            string telefone = Console.ReadLine();

            Console.WriteLine("Qual o cpf");
            string cpf = Console.ReadLine();

            return new Paciente(nome, cpf, sus, telefone);
        }
    }
}
