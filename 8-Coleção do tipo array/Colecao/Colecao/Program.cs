using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Vetores

            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i * 10;

                Console.WriteLine("[" + i + "] " + numeros[i]);
            }
          
            Console.WriteLine("");

            string [] herois = new string[3];

            herois[0] = "Seiya";
            herois[1] = "Yusuke";
            herois[2] = "Naruto";

            for (int i = 0; i < herois.Length; i++)
            {
                Console.WriteLine("[" + i + "] " + herois[i]);

            }

          

            #endregion

            #region Matrizes

             
            int [,] numbers = new int [2,3];

            numbers[0, 0] = 10;
            numbers[0, 1] = 20;
            numbers[0, 2] = 30;

            numbers[1, 0] = 40;
            numbers[1, 1] = 50;
            numbers[1, 2] = 60;

            Console.WriteLine();

            Console.Write("[" + numbers[0, 0] + "]");
            Console.Write("[" + numbers[0, 1] + "]");
            Console.Write("[" + numbers[0, 2] + "]");
            Console.WriteLine();
            Console.Write("[" + numbers[1, 0] + "]");
            Console.Write("[" + numbers[1, 1] + "]");
            Console.Write("[" + numbers[1, 2] + "]");


            Console.WriteLine();
            string[,] names =
            {

                { "Naruto", "Goku", "Bucky"  },

                {"Sasuke", "hyhoga", "Vegeta" }

            };


            Console.WriteLine();

            Console.Write("[" + names[0, 0] + "]");
            Console.Write("[" + names[0, 1] + "]");
            Console.Write("[" + names[0, 2] + "]");
            Console.WriteLine();
            Console.Write("[" + names[1, 0] + "]");
            Console.Write("[" + names[1, 1] + "]");
            Console.Write("[" + names[1, 2] + "]");



            #endregion

            #region Multiplicar Matrizes


            int[,] matriz1 = new int[2, 3];

            int[,] matriz2 = new int[3, 2];

            int[,] matrizResultado = new int[3, 2];


            Console.WriteLine("Preecha a matriz #1");

            for (int linha = 0; linha < 2; linha++)
            {

                for (int coluna = 0; coluna < 3; coluna ++)
                {
                    
                    Console.Write("#1 .Posição [" + linha + "][" + coluna + "]: ");
                    matriz1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Preecha a matriz #1");

            for (int linha = 0; linha < 3; linha++)
            {

                for (int coluna = 0; coluna < 2; coluna++)
                {

                    Console.Write("#2 .Posição [" + linha + "][" + coluna + "]: ");
                    matriz2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Resultado da  matriz #1 * matriz #2");

            matrizResultado[0, 0] = (matriz1[0, 0] * matriz2[0, 0]) + (matriz1[0, 1] * matriz2[1, 0]) + (matriz1[0, 2] * matriz2[2, 0]);
            matrizResultado[1, 0] = (matriz1[1, 0] * matriz2[0, 0]) + (matriz1[1, 1] * matriz2[1, 0]) + (matriz1[1, 2] * matriz2[2, 0]);
            matrizResultado[0, 1] = (matriz1[0, 0] * matriz2[0, 1]) + (matriz1[0, 1] * matriz2[1, 1]) + (matriz1[0, 2] * matriz2[2, 1]);
            matrizResultado[1, 1] = (matriz1[1, 0] * matriz2[0, 1]) + (matriz1[1, 1] * matriz2[1, 1]) + (matriz1[1, 2] * matriz2[2, 1]);

            Console.WriteLine("[" + matrizResultado[0, 0] + "][" + matrizResultado[0, 1] + "]");
            Console.WriteLine("[" + matrizResultado[1, 0] + "][" + matrizResultado[1, 1] + "]");

            Console.ReadKey();



            #endregion




            Console.ReadKey();
        }
    }
}
