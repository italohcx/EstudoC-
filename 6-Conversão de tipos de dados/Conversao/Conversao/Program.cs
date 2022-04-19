using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Conversao Implicita

            byte num1 = 100; //8 bits
            ushort num2 = num1;

            float num3 = 1250.45f;

            double num4 = num3;

            int numero = 'A';

            #endregion

            #region Conversao Explicita 

            ushort num5 = 300;

            byte num6 = (byte) num5;

            double num7 = 123450.1304;

            float num8 = (float) num7;

            Console.WriteLine(num6);
            Console.ReadKey();

            #endregion

            #region Metodos parse


            String txtNumero = "1990";

            int numero1 = int.Parse(txtNumero);

            Console.WriteLine(numero1);
            Console.ReadKey();

            #endregion

            #region Class Convert

            string txt = Convert.ToString(num7);
            Console.WriteLine(txt);
            Console.ReadKey();
           



            #endregion


        }
    }
}
