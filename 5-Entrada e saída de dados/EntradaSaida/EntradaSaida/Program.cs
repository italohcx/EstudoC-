using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EtradaSaida
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Jhon Doe");
            Console.ReadKey();


            #region Exerci

            string nome1, nome2, nome3, nome4, auxiliar;

            Console.Write("Digite o nome #1: ");

            nome1 = Console.ReadLine();

            Console.Write("Digite o nome #2: ");

            nome2 = Console.ReadLine();

            Console.Write("Digite o nome #3: ");

            nome3 = Console.ReadLine();

            Console.Write("Digite o nome #4: ");

             nome4 = Console.ReadLine();

            //Invertert os nomes 

            auxiliar = nome1;
            nome1 = nome4;
            nome4 = auxiliar;
            auxiliar = nome2;
            nome2 = nome3;
            nome3 = auxiliar;

            Console.WriteLine();

            Console.WriteLine("Nomes inseridos na sequencia invertida");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);




            #endregion









        }
    }

}
