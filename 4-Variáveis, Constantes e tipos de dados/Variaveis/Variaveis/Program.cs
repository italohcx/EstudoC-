
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{

    class Program
    {
        enum Notas
        {
          Minimo, 
          Média, 
          Máxima   
        }


        static void Main (string[] args)
        {


            #region Numericas integrais
            // intgral assinado -> suportam número negativos
            sbyte num1 = 10; // 8bits
            short num2 = 20; // 16bits
            int num3 = 30;   // 32bits
            long num4 = 40L; // 64bits

            //integral sem sinal -> não suportam números negativos
            byte num5 = 10;   // 8bits
            ushort num6 = 20; // 16bits
            uint num7 = 30;   // 32bits
            ulong num8 = 40L; // 64bits

            #endregion

            #region Numericas flutantes

            float real1 = 100.34f;       // 32bits
            double real2 = 12500.755;    // 64 bits
            decimal real3 = 752538.457m; //128 bits

            #endregion

            #region Char


            char letra = 'C';



            #endregion

            #region Boolean

            bool verify = false;

            #endregion

            #region String (Cadeia de caracteres)

            string text = "Sequencia de carateres";

            #endregion

            #region Var Implícito Var (apenas reservar um espaço na memória)

            var valor = 140;
            
            var str = "valor em string";


            #endregion

            #region Object (Base para todos os tipo e aceita qualquer tipo, mas não server para operaçãoes matemáticas

            object obj = 1000;
            obj = true;
            obj = "String text";


            #endregion

            #region Constantes

            const double pi = 3.1415;

            #endregion


            #region Enumaradores

            Notas notas = Notas.Minimo;


            Console.WriteLine(notas);
            Console.ReadKey();

            #endregion






        }

    }


}