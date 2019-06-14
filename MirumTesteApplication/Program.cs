using System;
using MirumTeste.ApplicationCore.Entity;
using MirumTeste.ApplicationCore.Services;
using MirumTeste.ApplicationCore.Interface;
using MirumTeste.UI.Web.Controllers;

namespace MirumTesteApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
            
        }
        static void Menu()
        {
            Console.WriteLine("Digite a opção desejada");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Pessoas");
            Console.WriteLine("2 - Cargos");
            Console.WriteLine("3 - Listar Pessoas por Cargo");



            ConsoleKeyInfo consoleKeyInfo;
            consoleKeyInfo = Console.ReadKey(true);

            switch (consoleKeyInfo.KeyChar)
            {
                case '1':
                    Pessoas();
                    break;
                case '2':
                    Cargos();
                    break;
                case '3':
                    ListarPorCargo();
                    break;
                default:
                    Console.WriteLine("opção inválida");
                    Menu();
                    break;
            }


        }
        static void ListarPorCargo()
        {

        }

        static void Pessoas()
        {
            Console.WriteLine("Digite a opção desejada");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Editar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Excluir");
            ConsoleKeyInfo consoleKeyInfo;
            consoleKeyInfo = Console.ReadKey(true);

            switch (consoleKeyInfo.KeyChar)
            {
                case '1':
                    EditarPessoas();
                    break;
                case '2':
                    CadastrarPessoas();
                    break;
                case '3':
                    ExcluirPessoas();
                    break;
                default:
                    Console.WriteLine("opção inválida");
                    Menu();
                    break;
            }
        }
        static void Cargos()
        {
            Console.WriteLine("Digite a opção desejada");
            Console.WriteLine("------------------------");
            Console.WriteLine("1 - Editar");
            Console.WriteLine("2 - Cadastrar");
            Console.WriteLine("3 - Excluir");

            ConsoleKeyInfo consoleKeyInfo;
            consoleKeyInfo = Console.ReadKey(true);

            switch (consoleKeyInfo.KeyChar)
            {
                case '1':
                    EditarCargos();
                    break;
                case '2':
                    CadastrarCargos();
                    break;
                case '3':
                    ExcluirCargos();
                    break;
                default:
                    Console.WriteLine("opção inválida");
                    Menu();
                    break;
            }
        }

        static void CadastrarPessoas()
        {
            Console.WriteLine("Informe Nome");
            Console.WriteLine("informe RG");
            Console.WriteLine("informe email");
        }
        static void EditarPessoas()
        {

        }

        static void ExcluirPessoas()
        {
        }

        static void CadastrarCargos()
        {
            Console.WriteLine("Informe Nome");
            Console.WriteLine("informe RG");
            Console.WriteLine("informe email");
        }
        static void EditarCargos()
        {

        }

        static void ExcluirCargos()
        {
        }
    }
}
