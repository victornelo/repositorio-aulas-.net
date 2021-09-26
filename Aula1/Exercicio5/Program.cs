using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double distancia;
            double preco;
            double consumo;
            double gasto;

            Console.Write("Informe a distância que será percorrida na viagem: ");
            distancia = double.Parse(Console.ReadLine());

            Console.Write("Informe o consumo de combustível (Km/Litro) do veículo: ");
            consumo = double.Parse(Console.ReadLine());

            Console.Write("Informe o preço do combustível: ");
            preco = double.Parse(Console.ReadLine());

            gasto = (distancia / consumo) * preco;

            Console.Write("O gasto na viagem foi de: " + gasto);
            Console.ReadKey();
        }
    }
}
