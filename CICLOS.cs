using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA
{
    public class CICLOS
    {
        static double n1, n2, n3;
        public static void MúltiplosDe3QueHayEntre1y100()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("los multilpos de 3 a 100 son: ");
            for (n1 = 3; n1 <= 100; n1 += 3)
            {
                Console.WriteLine(n1);
            }
        }
        public static void ImparesEntre0Y100()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("los numeros impares del 0 al 100 son : ");
            for (n1 = 1; n1 <= 100; n1 += 2)
            {
                Console.WriteLine(n1);
            }
        }
        public static void ParesDel1Al100()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("los numeros pares del 1 al 100 son : ");
            for (n1 = 2; n1 <= 100; n1 += 2)
            {
                Console.WriteLine(n1);
            }
        }
        public static void CuadradosDeLosNúmerosDel1Al30()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Los cuadrados de los 30 primeros números son: ");
            for (n1 = 3; n1 <= 30; n1++)
            {
                Console.WriteLine("El cuadrado de " + n1 + " es: " + Math.Pow(n1, 2));
            }
        }
        public static void SumarLos100PrimerosNúmerosNaturales()
        {
            Console.WriteLine("----------------------");
            int numero2 = 0;
            Console.WriteLine("Los cuadrados de los 100 primeros números son: ");
            for (n1 = 0; n1 <= 100; n1++)
            {
                Console.WriteLine("El cuadrado de " + n1 + " es: " + Math.Pow(n1, 2));
                numero2 = numero2 + (int)(Math.Pow(n1, 2));
            }
            Console.WriteLine("la suma de los cuadrados es: " + n1);
        }
        public static void Dados2NumerosNaturales()
        {
            Console.WriteLine("----------------------");
            for (n1 = 30; n1 <= 40; n1++)
            {
                Console.WriteLine("el numero comprendido es: " + n1);
            }
        }
        public static void SumarTodosLosNumeros()
        {
            Console.WriteLine("----------------------");
            string linea;
            Console.WriteLine("Ingrese un valor (0 para finalizar) :");
            do
            {

                linea = Console.ReadLine();
                n2 = int.Parse(linea);
                if (n2 != 0)
                {
                    n1 = n1 + n2;
                    Console.WriteLine("El resultado de la suma es : " + n1 + "\n");
                }
                else
                {
                    Console.WriteLine("No se ingresan mas valores");
                }
            }
            while (n2 != 0);

        }

    }
}
