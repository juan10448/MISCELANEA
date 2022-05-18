using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA
{
    public class CONDICIONALES
    {
        static double n1, n2, n3;
        public static void PositivoNegativo()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {
                Console.Write("el numero " + numero + " es un numero neutro.");

            }
            else if (numero > 0)
            {
                Console.Write("el numero " + numero + " es un numero positivo.");
            }
            else
            {
                Console.Write("el numero " + numero + " es un numero negativo.");
            }
        }

        public static void NumeroYMayor()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("ingrese primero numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            if (n1 >= n2)
            {
                Console.WriteLine("el numero mayor es: " + n1);
            }
            else if (n2 >= n1)
            {
                Console.WriteLine("el numero mayor es: " + n2);
            }
        }
        public static void EnteroOpositivoYCalcularMayorYMenor()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("ingrese primero numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese segundo numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tercer numero: ");
            n3 = int.Parse(Console.ReadLine());
            if (n1 >= n2 && n1 >= n3)
            {
                Console.WriteLine("el numero mayor es: " + n1);
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                Console.WriteLine("el numero mayor es: " + n2);
            }
            else if (n3 >= n1 && n3 >= n2)
            {
                Console.WriteLine("el numero mayor es: " + n3);
            }
        }
        public static void SumarSiAEsMenorQueBSinoRestarlos()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("ingresar primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar segundo numero");
            n2 = int.Parse(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine("el numero mayor es: " + n1 + n2);
            }
            else if (n1 >= n2)
            {
                Console.WriteLine("sumar el mayor: " + (n1 + n2));
            }
            else
            {
                Console.WriteLine("se resta: " + (n1 - n2));
            }
        }

        public static void Cociente()
        {
            Console.WriteLine("----------------------");
            Console.Write("dar valor de A: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("dar valor de B: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = n1 % n2;
            Console.Write("el modulo de su division es: ");
            Console.WriteLine(n3);
            Console.WriteLine("---------------");

        }

        public static void SumarSiunoEsNegativoSiNoMultiplicarlos()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("ingresar primer numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar segundo numero");
            n2 = int.Parse(Console.ReadLine());
            if (n1 < 0 || (n2 < 0))
            {
                Console.WriteLine("Se realizara la suma de los numeros.");
                Console.WriteLine("El resultado de la suma de A y B es: " + (n1 + n2));
            }
            else
            {
                Console.WriteLine("Se realizara la multiplicación de los numeros.");
                Console.WriteLine("El resultado de la multiplicación de A y B es: " + (n1 * n2));
            }
        }

        public static void AñoBisiesto()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("ingrese el año");
            n1 = int.Parse(Console.ReadLine());
            if (n1 / 4 == 0)
            {
                if (n1 / 100 == 0)
                {
                    if (n1 / 400 == 0)
                    {
                        Console.WriteLine("el año " + n1 + " es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("el año " + n1 + " no es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("el año " + n1 + " es bisiesto");
                }

            }
            else
            {
                Console.WriteLine("el año " + n1 + " no es bisiesto");
            }
        }






    }
}
