using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA
{
    public class MENU
    {
        public static void Menuprincipal()
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("Elija a opcion que desea: " +
                "\n1.  Operadores" +
                "\n2.  condicionaless" +
                "\n3.  Ciclos." +
                "\n9.  Salir.");
        }
        public static void MenuOperadores()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Elija a opcion que desea:" +
                "\n1. Área del triangulo." +
                "\n2. Suma de dos numeros." +
                "\n3. Numero elevado al cuadrado. " +
                "\n4. Convertir euros a dolares." +
                "\n5  Area y perimetro de un cuadrado." +
                "\n6. Area y volumen de un cilindro." +
                "\n7. Longitud y area de una circunferencia." +
                "\n8. Promedio de tres numeros. " +
                "\n9. Salir.");
        }
        public static void MenuCondicionales()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Elija a opcion que desea:" +

                "\n1. Numero positivo y negativo." +
                "\n2. numero menor y mayor." +
                "\n3. Numero entero opositivo y calcular mayor y menor. " +
                "\n4. sumar si A es menor que B o sino restarlos." +
                "\n5  encontrar el cociente entre A y B." +
                "\n6. A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos." +
                "\n7. calcular año bisiesto o no. ." +
                "\n8. Salir.");
        }
        public static void MenuCiclos()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Elija a opcion que desea:" +

                "\n1. Imprimir todos los múltiplos de 3 que hay entre 1 y 100. ." +
                "\n2. Imprimir los números impares entre 0 y 100." +
                "\n3. Imprimir los números pares del 1 al 100. " +
                "\n4. Escribir un programa que imprima por pantalla los cuadrados de los números del 1 al 30." +
                "\n5  programa que sume los cuadrados de los cien primeros números naturales." +
                "\n6. Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente." +
                "\n7.  Sumar todos los números que se digitan por teclado mientras no sea cero. ." +
                "\n8. Salir.");
        }
        
        public static void Volver()
        {
            
                String RespuestaContinuar = null;
            do
            {
                // COMANDO para regresar al MENU
                Console.WriteLine("\n¿Desea continuar usando el programa y volver al menu? SI/NO)");
                RespuestaContinuar = Console.ReadLine();
                if ((RespuestaContinuar == "SI") || (RespuestaContinuar == "si"))
                {
                    Console.Clear();
                    Class1.Main();
                }

                else if ((RespuestaContinuar == "NO") || (RespuestaContinuar == "no"))
                {
                    Console.Clear();
                    Console.WriteLine("Salió del programa.");
                    Environment.Exit(1);
                }
            } while ((RespuestaContinuar != "SI") && (RespuestaContinuar != "NO"));
        }
    }
}
