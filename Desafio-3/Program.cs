//Desafio
//O programa deve ler um valor inteiro D indefinidas vezes, ele só irá parar quando o valor de D for igual a 0.
//Para cada D lido, imprima a soma dos 5 pares consecutivos a partir de D, inclusive ele mesmo ,
//se for par. Se o valor de entrada for 4, por exemplo, a saída deve ser 40, que é o resultado da operação: 4+6+8+10+12,
//enquanto que se o valor de entrada for 11, por exempo, a saída deve ser 80, que é a soma de 12+14+16+18+20.
//Entrada
//O arquivo de entrada contém muitos valores inteiros. O último valor do arquivo é zero..
//Saida
//Imprima a saida conforme a explicação acima e o exemplo abaixo.
//Exemplo Entrada         Exemplo Saida
//        4                     40
//        11                    80
//        0




using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(" Digite um número maior que 0 !");
                int valordigitado = int.Parse(Console.ReadLine());

                int somaPar1 = valordigitado + 2;
                int somaPar2 = somaPar1 + 2;
                int somaPar3 = somaPar2 + 2;
                int somaPar4 = somaPar3 + 2;
                int totalPar = valordigitado + somaPar1 + somaPar2 + somaPar3 + somaPar4;

                int somaImpar1 = valordigitado + 1;
                int somaImpar2 = somaImpar1 + 2;
                int somaImpar3 = somaImpar2 + 2;
                int somaImpar4 = somaImpar3 + 2;
                int somaImpar5 = somaImpar4 + 2;
                int totalImpar = +somaImpar1 + somaImpar2 + somaImpar3 + somaImpar4 + somaImpar5;

                if (valordigitado <= 0)
                    Console.WriteLine(" Valor menor ou igual a 0 !");
                Console.WriteLine(" Programa encerrado !!! ");

                if (valordigitado % 2 == 0)

                {
                    Console.WriteLine(totalPar);

                    {
                        continue;
                    }
                }

                else
                {
                    Console.WriteLine(totalImpar);
                    {
                        continue;
                    }

                }
            }

            Console.ReadKey();

        }
    }
}

