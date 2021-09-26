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

            public int GetCodigo()
            {
                return codigo;
            }

            public void SetCodigo(int codigo)
            {
                this.codigo = codigo;
            }

            public float GetPreco()
            {
                return preco;
            }

            public void SetPreco(float preco)
            {
                this.preco = preco;
            }

            public string GetDescricao()
            {
                return descricao;
            }

            public void SetDescricao(string descricao)
            {
                this.descricao = descricao;
            }

            public string GetAtivo()
            {
                return ativo;
            }

            public void SetAtivo(string ativo)
            {
                this.ativo = ativo;
            }

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

                    p.SetCodigo(codigo);
                    Console.Write("Código: " + p.GetCodigo());
                    p.SetDescricao(descricao);
                    Console.Write("\nDescrição: " + p.GetDescricao());
                    p.SetPreco(preco);
                    Console.Write("\nPreço: " + (float)p.GetPreco());
                    p.SetAtivo(ativo);
                    Console.Write("\nAtivo: " + p.GetAtivo());
                    Console.ReadKey();
                }
            }
        }
    }
}