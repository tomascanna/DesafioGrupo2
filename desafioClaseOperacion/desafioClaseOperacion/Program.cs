using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioClaseOperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,opc;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el primer numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Digite 1 para la suma");
                Console.WriteLine("Digite 2 para la resta");
                Console.WriteLine("Digite 3 para salir");
                opc = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (opc)
                {
                    case 1:
                        {
                            
                            Console.WriteLine("El resultado de la suma es: {0}", Operacion.suma(n1, n2));
                            Console.ReadKey();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("El resultado de la resta es: {0}",Operacion.resta(n1, n2));
                            Console.ReadKey();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Saliendo...");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("La opcion ingresada no es valida");
                            Console.ReadKey();
                            break;
                        }
                        
                }
            } while (opc != 3);
        }
    }
}
