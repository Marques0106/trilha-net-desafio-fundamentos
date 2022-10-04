using System;

namespace Estacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precoInicial = 0;
            decimal precoHora = 0;
            bool exibirMenu = true;
            Console.WriteLine("digite o valor inicial: ");
            precoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Digite o valor da hora: ");
            precoHora = Convert.ToDecimal(Console.ReadLine());
            Estacionamento est = new Estacionamento(precoInicial,precoHora);
            while (exibirMenu)
            {
                Console.WriteLine("Digite sua opção: ");
                Console.WriteLine("\n1 - Cadastrar Veículo");
                Console.WriteLine("\n2 - Remover Veículo");
                Console.WriteLine("\n3 - Listar Veículos");
                Console.WriteLine("\n4 - Encerrar");
                switch (Console.ReadLine())
                {
                    case "1":
                        est.adicionarPlacas();
                        break;
                    case "2":
                        est.removerPlacas();
                        break;
                    case "3":
                        est.listarPlacas();
                        break;
                    case "4":
                        exibirMenu = false;
                        break;
                    default:
                        Console.WriteLine("Opção invalida");
                        break;
                }
            }
        }
    }
}
