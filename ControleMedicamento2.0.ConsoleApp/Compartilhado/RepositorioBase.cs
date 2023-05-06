using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp
{
    public class RepositorioBase<T> where T : EntidadeBase
    {
        protected List<T> listaRegistros;
        protected int contadorId = 0;

        public virtual void Inserir(T entidade)
        {
            contadorId++;

            entidade.id = contadorId;
            listaRegistros.Add(entidade);
        }

        public virtual List<T> SelecionarTodos()
        {
            return listaRegistros;
        }

        public virtual T BuscarPorId(int id)
        {
            T entidade = null;

            foreach ( T a in listaRegistros)
            {
                if(a.id == id)
                    entidade = a;
            }

            return entidade;
        }

        public virtual void Editar(T entidadeAtualizada, int id)
        {
            T entidadeSelecionada = BuscarPorId(id);

            entidadeSelecionada.AtualizarInformacoes(entidadeAtualizada);
        }

        public virtual void Excluir(int id)
        {
            T entidade = BuscarPorId(id);

            listaRegistros.Remove(entidade);

            contadorId--;
        }
    }
}
