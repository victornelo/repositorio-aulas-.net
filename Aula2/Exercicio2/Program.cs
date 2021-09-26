using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    class Program
    {
        public class Produto
        {
            private int codigo;
            private float preco;
            private string descricao, ativo;

            public int Codigo { get; set; }

            public float Preco { get; set; }

            public string Descricao { get; set; }

            public string Ativo { get; set; }

            class Inicio
            {
                public static void Main(string[] args)
                {
                    int codigo;
                    float preco;
                    string descricao, ativo;

                    Console.WriteLine("Digite o código do produto: ");

                    codigo = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a descrição do produto: ");
                    descricao = Console.ReadLine();

                    Console.WriteLine("Digite o preço do produto: ");
                    preco = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o ativo do produto: ");
                    ativo = Console.ReadLine();

                    Produto p = new Produto();


                    p.Codigo = codigo;
                    Console.Write("Código: " + p.Codigo);

                    p.Descricao= descricao;
                    Console.Write("\nDescrição: " + p.Descricao);

                    p.Preco = preco;
                    Console.Write("\nPreço: " + p.Preco);

                    p.Ativo = ativo;
                    Console.Write("\nAtivo: " + p.Ativo);
                    Console.ReadKey();

                }
            }
        }
    }
}