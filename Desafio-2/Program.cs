//Desafio
//Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000).
//Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.
//Entrada
//O arquivo de entrada contém um número inteiro positivo N.
//Saida
//Imprima a saída conforme o exemplo fornecido.
//   Exemplo Entrada       Exemplo Saida
//          5                   1 1 1
//                              2 4 8
//                              3 9 27
//                              4 16 64
//                              5 25 125


using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite um número ! ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            for (int contador = 1; contador <= numeroDigitado; contador++)
            {
                int primeiroResultado = contador * contador;
                int segundoResultado = primeiroResultado * contador;

                Console.WriteLine("" + contador + " " + primeiroResultado + " " + segundoResultado + "");
            }

            Console.ReadKey();
        }
    }
}
