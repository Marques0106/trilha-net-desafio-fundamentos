using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoHora = 0;

        private List<string> listaPlacas = new List<string> { };//declarando nossa lista para armazenarmos as placas
      public Estacionamento(decimal precoInicial, decimal precoHora)
        {
            this.precoInicial = precoInicial;
            this.precoHora = precoHora;
        }
        
        public void adicionarPlacas()
        {
            Console.WriteLine("Digite a placa do carro que será estacionado: ");
             listaPlacas.Add(Console.ReadLine());
            Console.WriteLine("Placa cadastrada");
        }
        //remover
        public void removerPlacas()
        {
            Console.WriteLine("Digite a placa do veiculo a ser retirado: ");
            string placa = Console.ReadLine();
            if (listaPlacas.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo ficou estacionado: ");
                int horas = int.Parse(Console.ReadLine());
                decimal valorFinal = (precoHora * horas) + precoInicial; 
                Console.WriteLine("A placa "+placa+" foi removida e o valor a ser cobrado é de: "+valorFinal);
                listaPlacas.Remove(placa);
            }
            else
            {
                Console.WriteLine("Não temos um veículo com esta placa, estacionado! Digite uma placa valida.");
            }
        }


        public void listarPlacas()
        {
            if (listaPlacas.Any())
                { int contadorForeach = 0;
                    foreach(string placa in listaPlacas)
                     {
                    Console.WriteLine("Temos estacionados os veiculos de placa: " + placa);
                    contadorForeach++;
                }
            } else { Console.WriteLine("Não há placas cadastradas! "); }
        }



    }
}
