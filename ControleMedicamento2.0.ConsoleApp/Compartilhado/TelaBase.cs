using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp
{
    public abstract class TelaBase<T, TRepositorio> where T : EntidadeBase where TRepositorio : RepositorioBase<T>
    {
        protected TRepositorio repositorioBase = null;
        public string nomeEntidade = "";
        public string sufixo = "";

        public TelaBase(TRepositorio repositorio)
        {
            repositorioBase = repositorio;
        }

        public abstract T ObterRegistro();

        public virtual void CriarInserirEntidade()
        {
            Console.WriteLine("Criando entidade...");

            T entidade = ObterRegistro();

            if(VerificarErros(entidade))
            {
                Mensagem("Algum campo nao foi preenchido corretamente!", ConsoleColor.Red);
                Console.ReadLine();
                CriarInserirEntidade();

                return;
            }    

            repositorioBase.Inserir(entidade);

            Mensagem("Entidade Criada com sucesso!", ConsoleColor.Green);

            Console.ReadLine();
            Console.Clear();
        }

        public abstract void MostrarObjetos(List<T> array);

        public virtual void MostrarTabela()
        {
            List<T> array = repositorioBase.SelecionarTodos();

            MostrarObjetos(array);
        }

        public void Mensagem(string str, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(str);
            Console.ResetColor();
        }

        public virtual void EditarEntidade()
        {
            MostrarTabela();

            Console.WriteLine("Qual o id da Entidade que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            T entidateAtualizada = ObterRegistro();

            repositorioBase.Editar(entidateAtualizada, id);

            Mensagem("Entidade Modificada Com Sucesso", ConsoleColor.Green);

            Console.ReadLine();
            Console.Clear();
        }

        public virtual void ExcluirEntidade()
        {
            MostrarTabela();

            Console.WriteLine("Qual o id da Entidade que deseja Excluir: ");
            int id = int.Parse(Console.ReadLine());

            repositorioBase.Excluir(id);

            Mensagem("Entidade Excluida Com Sucesso", ConsoleColor.Green);

            Console.ReadLine();
            Console.Clear();
        }

        public virtual string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine($"Cadastro de {nomeEntidade}{sufixo} \n");

            Console.WriteLine($"Digite 1 para Inserir {nomeEntidade}");
            Console.WriteLine($"Digite 2 para Visualizar {nomeEntidade}{sufixo}");
            Console.WriteLine($"Digite 3 para Editar {nomeEntidade}{sufixo}");
            Console.WriteLine($"Digite 4 para Excluir {nomeEntidade}{sufixo}");
            Console.WriteLine($"Digite 0 para Sair\n");


           Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        protected bool VerificarErros(T entidade)
        {
            bool erro = false;

            ArrayList erros = entidade.Verificacao();

            if (erros.Count > 0)
            {
                erro = true;

                foreach(string err in erros)
                {
                    Mensagem(err, ConsoleColor.Red);
                }
            }

            return erro;
        }
    }
}
