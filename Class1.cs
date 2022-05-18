using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISCELANEA
{
    public class Class1
    { 
       public static void Main ()
        {


             try
              {
                    MENU.Menuprincipal();
                    int Menu = 0;
                Menu = Convert.ToInt32(Console.ReadLine());
                switch (Menu)
                {
                    case 1:
                        MENU.MenuOperadores();
                        int operacion = Convert.ToInt32(Console.ReadLine());
                        switch (operacion)
                        {

                            case 1:
                                OPERADORES.AreaTriangulo();
                                MENU.Volver();
                                break;

                            case 2:
                                OPERADORES.Suma();
                                MENU.Volver();
                                break;
                            case 3:
                                OPERADORES.Cuadrado();
                                MENU.Volver();
                                break;
                            case 4:
                                OPERADORES.EuroADolares();
                                MENU.Volver();
                                break;
                            case 5:
                                OPERADORES.AreaYPerimetroCuadrado();
                                MENU.Volver();
                                break;
                            case 6:
                                OPERADORES.AreaYVolumenCilindro();
                                MENU.Volver();
                                break;
                            case 7:
                                OPERADORES.LongitudYAreaCircunferencia();
                                MENU.Volver();
                                break;
                            case 8:
                                OPERADORES.PromedioDeTresNumero();
                                MENU.Volver();
                                break;
                            case 9:
                                Console.WriteLine("----------------------");
                                Console.WriteLine("Salir");
                                break;

                            default:
                                {
                                    Console.WriteLine("Dato invalido");
                                    break;
                                }

                        }
                        break;



                    case 2:

                        MENU.MenuCondicionales();
                        int condiconales = Convert.ToInt32(Console.ReadLine());
                        switch (condiconales)
                        {
                            case 1:
                                CONDICIONALES.PositivoNegativo();
                                MENU.Volver();
                                break;

                            case 2:
                                CONDICIONALES.NumeroYMayor();
                                MENU.Volver();
                                break;

                            case 3:
                                CONDICIONALES.EnteroOpositivoYCalcularMayorYMenor();
                                MENU.Volver();
                                break;

                            case 4:
                                CONDICIONALES.SumarSiAEsMenorQueBSinoRestarlos();
                                MENU.Volver();
                                break;

                            case 5:
                                CONDICIONALES.Cociente();
                                MENU.Volver();
                                break;

                            case 6:

                                CONDICIONALES.SumarSiunoEsNegativoSiNoMultiplicarlos();
                                MENU.Volver();
                                break;

                            case 7:
                                CONDICIONALES.AñoBisiesto();    
                                MENU.Volver();
                                break;



                            case 8:
                                Console.WriteLine("----------------------");
                                Console.WriteLine("Salir");
                                break;

                            default:
                                {
                                    Console.WriteLine("Dato invalido");
                                    break;
                                }
                        }
                        break;






                    case 3:


                        MENU.MenuCiclos();
                        int ciclos = Convert.ToInt32(Console.ReadLine());
                        switch (ciclos)
                        {
                            case 1:
                                CICLOS.MúltiplosDe3QueHayEntre1y100();
                                MENU.Volver();
                                break;

                            case 2:
                                CICLOS.ImparesEntre0Y100();
                                MENU.Volver();
                                break;

                            case 3:
                                CICLOS.ParesDel1Al100();
                                MENU.Volver();
                               
                                break;

                            case 4:
                                CICLOS.CuadradosDeLosNúmerosDel1Al30(); 
                                MENU.Volver();
                                
                                break;

                            case 5:
                               CICLOS.SumarLos100PrimerosNúmerosNaturales();
                                MENU.Volver();  

                                break;

                            case 6:
                                CICLOS.Dados2NumerosNaturales();
                                MENU.Volver();
                              
                                break;

                            case 7:
                                CICLOS.SumarTodosLosNumeros();
                                MENU.Volver();
                              
                                break;

                            case 8:
                                Console.WriteLine("----------------------");
                                Console.WriteLine("Salir");
                                break;

                            default:
                                {
                                    Console.WriteLine("Dato invalido");
                                    break;
                                }
                                    
                        }
                        break;

                    case 9:
                        Console.WriteLine("Salir");
                        break;
                    default:
                        {
                            Console.WriteLine("Dato invalido.");
                            break;
                        }
                }
               
                    Console.ReadKey();


             }catch
                {
                    Console.WriteLine("Dato invalido.");
                MENU.Volver();
                }
           
            
            
            
            
            



        }

    }
}
    

