using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.Compartilhado
{
    public abstract class EntidadeBase
    {
        public int id { get; set; }


        public abstract void AtualizarInformacoes(EntidadeBase entidadeAtualizada);

        public abstract ArrayList Verificacao();
        
    }
}
