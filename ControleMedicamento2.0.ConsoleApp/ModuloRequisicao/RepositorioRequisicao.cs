﻿using ControleMedicamento2._0.ConsoleApp.ModuloFuncionario;
using ControleMedicamento2._0.ConsoleApp.ModuloMedicamento;
using ControleMedicamento2._0.ConsoleApp.ModuloPaciente;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicamento2._0.ConsoleApp.ModuloRequisicao
{
    internal class RepositorioRequisicao : RepositorioBase
    {
        public RepositorioRequisicao(ArrayList listaRequisicao)
        {
            listaRegistros = listaRequisicao;
        }



    }
}
