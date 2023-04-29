using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp
{
    internal class RepositorioBase
    {
        protected ArrayList listaRegistros;
        protected int contadorId = 0;

        public virtual void Inserir(EntidadeBase entidade)
        {
            contadorId++;

            entidade.id = contadorId;
            listaRegistros.Add(entidade);
        }

        public virtual ArrayList SelecionarTodos()
        {
            return listaRegistros;
        }

        public virtual EntidadeBase BuscarPorId(int id)
        {
            EntidadeBase entidade = null;

            foreach ( EntidadeBase a in listaRegistros)
            {
                if(a.id == id)
                    entidade = a;
            }

            return entidade;
        }

        public virtual void Editar(EntidadeBase entidadeAtualizada, int id)
        {
            EntidadeBase entidadeSelecionada = BuscarPorId(id);

            entidadeSelecionada.AtualizarInformacoes(entidadeAtualizada);
        }

        public virtual void Excluir(int id)
        {
            EntidadeBase entidade = BuscarPorId(id);

            listaRegistros.Remove(entidade);

            contadorId--;
        }
    }
}
