using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco;
            double desconto;
            double novo_preco;

            Console.Write("Digite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());
            Console.Write("Digite o desconto: ");
            desconto = double.Parse(Console.ReadLine());

            desconto /= 100;
            novo_preco = preco - desconto;

            Console.Write("O preço do produto com desconto é: " + desconto);
            Console.ReadKey();
        }
    }
}
