using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1; //Variável de entrada
            double nota2; //Variável de entrada
            double media; //Variável de entrada

            Console.Write("Informe a primeira nota do aluno: "); //Imprime uma instrução para o usuário
            nota1 = double.Parse(Console.ReadLine()); //Lê o dado informado pelo usuário

            Console.Write("Informe a segunda nota do aluno: "); //Imprime uma instrução para o usuário
            nota2 = double.Parse(Console.ReadLine()); //Lê o dado informado pelo usuário

            media = (nota1 + nota2) / 2; //Calcula a média das notas do aluno

            Console.Write("A média do aluno é: " + media); //Imprime o resultado para o usuário
            Console.ReadKey(); //Mantém o console aberto enquanto o usuário não pressionar alguma tecla
        }
    }
}
