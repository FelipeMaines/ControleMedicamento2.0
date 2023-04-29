using ControleMedicamento2._0.ConsoleApp.ModuloAquisicao;
using ControleMedicamento2._0.ConsoleApp.ModuloFornecedor;
using ControleMedicamento2._0.ConsoleApp.ModuloFuncionario;
using ControleMedicamento2._0.ConsoleApp.ModuloMedicamento;
using ControleMedicamento2._0.ConsoleApp.ModuloPaciente;
using ControleMedicamento2._0.ConsoleApp.ModuloRequisicao;
using System.Collections;
using System.ComponentModel.Design;

namespace ControleMedicamento2._0.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioFuncionario repositorioFuncionario = new RepositorioFuncionario(new ArrayList());
            RepositorioFornecedor repositorioFornecedor = new RepositorioFornecedor(new ArrayList());
            RepositorioMedicamento repositorioMedicamento = new RepositorioMedicamento(new ArrayList());
            RepositorioPaciente repositorioPaciente = new RepositorioPaciente(new ArrayList());
            RepositorioAquisicao repositorioAquisicao = new RepositorioAquisicao(new ArrayList());
            RepositorioRequisicao repositorioRequisicao = new RepositorioRequisicao(new ArrayList());

            TelaFuncionario telaFuncionario = new TelaFuncionario(repositorioFuncionario);
            TelaFornecedor telaFornecedor = new TelaFornecedor(repositorioFornecedor);
            TelaPaciente telaPaciente = new TelaPaciente(repositorioPaciente);
            TelaMedicamento telaMedicamento = new TelaMedicamento(repositorioMedicamento, repositorioFornecedor, telaFornecedor);
            TelaRequisicao telaRequisicao = new TelaRequisicao(repositorioRequisicao, repositorioMedicamento, repositorioFuncionario, repositorioPaciente,telaMedicamento, telaPaciente, telaFuncionario);
            TelaAquisicao telaAquisicao = new TelaAquisicao(repositorioAquisicao, repositorioMedicamento, repositorioFornecedor, repositorioFuncionario, telaMedicamento, telaFornecedor, telaFuncionario);
            TelaPrincipal telaPrincipal = new TelaPrincipal();

            while (true)
            {

                string opcao = telaPrincipal.ApresentarMenu();


                switch (opcao)
                {
                    case "1":
                        {
                            string submenu = "";

                            do
                            {
                                submenu = telaFornecedor.ApresentarMenu();

                                if (submenu == "1")
                                {
                                    Console.Clear();
                                    telaFornecedor.CriarInserirEntidade();
                                }

                                else if (submenu == "2")
                                {
                                    Console.Clear();
                                    telaFornecedor.MostrarTabela();
                                    Console.ReadLine();
                                    Console.Clear();
                                }

                                else if (submenu == "3")
                                {
                                    Console.Clear();
                                    telaFornecedor.EditarEntidade();
                                    Console.ReadLine();
                                }

                                else if (submenu == "4")
                                {
                                    Console.Clear();
                                    telaFornecedor.ExcluirEntidade();
                                    Console.ReadLine();
                                }
                            } while (submenu != "s" && submenu != "0");

                            break;
                        }

                    case "2":
                        {
                            string submenu2 = " ";

                            do
                            {
                                submenu2 = telaFuncionario.ApresentarMenu();

                                if (submenu2 == "1")
                                {
                                    telaFuncionario.CriarInserirEntidade();
                                }

                                else if (submenu2 == "2")
                                {
                                    telaFuncionario.MostrarTabela();
                                }

                                else if (submenu2 == "3")
                                {
                                    telaFuncionario.EditarEntidade();
                                }

                                else if (submenu2 == "4")
                                {
                                    telaFuncionario.ExcluirEntidade();
                                }
                            } while (submenu2 != "s" && submenu2 != "0");

                            break;
                        }

                    case "3":
                        {
                            string submenu3 = "";

                            do
                            {
                                submenu3 = telaPaciente.ApresentarMenu();

                                if (submenu3 == "1")
                                {
                                    telaPaciente.CriarInserirEntidade();
                                }

                                else if (submenu3 == "2")
                                {
                                    telaPaciente.MostrarTabela();
                                }

                                else if (submenu3 == "3")
                                {
                                    telaPaciente.EditarEntidade();
                                }

                                else if (submenu3 == "4")
                                {
                                    telaPaciente.ExcluirEntidade();
                                }

                            } while (submenu3 != "0" && submenu3 != "s");
                            break;
                        }

                    case "4":
                        {
                            string submenu4 = "";

                            do
                            {
                                submenu4 = telaMedicamento.ApresentarMenu();

                                if (submenu4 == "1")
                                {
                                    telaMedicamento.CriarInserirEntidade();
                                }

                                else if (submenu4 == "2")
                                {
                                    telaMedicamento.MostrarTabela();
                                }

                                else if (submenu4 == "3")
                                {
                                    telaMedicamento.EditarEntidade();
                                }

                                else if (submenu4 == "4")
                                {
                                    telaMedicamento.ExcluirEntidade();
                                }

                                else if (submenu4 == "5")
                                {
                                    Console.WriteLine("Producao");
                                }

                                else if (submenu4 == "6")
                                {
                                    Console.WriteLine("Producao");
                                }

                            } while (submenu4 != "0" && submenu4 != "s");
                            break;
                        }

                    case "5":
                        string submenu5 = "";

                        do
                        {
                            submenu5 = telaAquisicao.ApresentarMenu();

                            if (submenu5 == "1")
                            {
                                telaAquisicao.CriarInserirEntidade();
                            }

                            else if (submenu5 == "2")
                            {
                                telaAquisicao.MostrarTabela();
                            }

                            else if (submenu5 == "3")
                            {
                                telaAquisicao.EditarEntidade();
                            }

                            else if (submenu5 == "4")
                            {
                                telaAquisicao.ExcluirEntidade();
                            }

                        } while (submenu5 != "0" && submenu5 != "s");
                        break;


                    case "6":
                        string submenu6 = "";

                        do
                        {
                            submenu6 = telaRequisicao.ApresentarMenu();

                            if (submenu6 == "1")
                            {
                                telaRequisicao.CriarInserirEntidade();
                            }

                            else if (submenu6 == "2")
                            {
                                telaRequisicao.MostrarTabela();
                            }

                            else if (submenu6 == "3")
                            {
                                telaRequisicao.EditarEntidade();
                            }

                            else if (submenu6 == "4")
                            {
                                telaRequisicao.ExcluirEntidade();
                            }

                        } while (submenu6 != "0" && submenu6 != "s");
                        break;
                
                }
            }
        }
    }
}