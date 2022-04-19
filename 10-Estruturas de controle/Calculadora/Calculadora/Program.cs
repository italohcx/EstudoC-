using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##################### CALCULADORA 1.0 #####################");

        INICIO:
            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha o tipo de opração (+ - x /): ");
            char op = char.Parse(Console.ReadLine());


            // estrutura de controle

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Erro, opção inválida");
                    break;
                case '+':

                    resultado = num1 + num2;

                    Console.WriteLine("Opção Soma, resultado = " + resultado);
                    break;

                case '-':

                    resultado = num1 - num2;

                    Console.WriteLine("Opção Subtração, resultado = " + resultado);

                    break;

                case 'x':

                    resultado = num1 * num2;

                    Console.WriteLine("Opção Multiplicação, resultado = " + resultado);

                    break;

                case '/':

                    resultado = num1 / num2;

                    Console.WriteLine("Opção Divisão, resultado = " + resultado);

                    break;
            }


            Console.Write("Continua na calculadora (s / n): ");

            char opc = char.Parse(Console.ReadLine());


            if (opc == 's'|| opc == 'S')
            {

                goto INICIO;
            }
                
         
          
        }
    }
}
