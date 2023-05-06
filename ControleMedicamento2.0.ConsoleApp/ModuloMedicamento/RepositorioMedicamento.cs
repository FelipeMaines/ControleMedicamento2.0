﻿using ControleMedicamento2._0.ConsoleApp.Compartilhado;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloMedicamento
{
    public class RepositorioMedicamento : RepositorioBase<Medicamento>
    {
        public RepositorioMedicamento(List<Medicamento> ListaMedicamento)
        {
            listaRegistros = ListaMedicamento;
        }

        public override Medicamento BuscarPorId(int id)
        {
            return base.BuscarPorId(id);
        }
    }
}
