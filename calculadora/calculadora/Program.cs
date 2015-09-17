using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, op, n1;

            Console.WriteLine("HOLA MUNDO");
            Console.ReadKey();
            Console.WriteLine("INGRESE PRIMER NUMERO");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE SEGUNDO NUMERO");
            n1 = int.Parse(Console.ReadLine());


            do
            {
                Console.WriteLine("1. SUMA");
                Console.WriteLine("2. RESTA");
                Console.WriteLine("3. MULTIPLICACION");
                Console.WriteLine("4. DIVISION");
                Console.WriteLine("5. POTENCIA");
                Console.WriteLine("6.SALIR");
                Console.WriteLine("INGRESE LA OPCION: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            int r= n+n1;
                            Console.WriteLine("LA SUMA ES:" + r);
                            break;
                        }
                    case 2:
                        {


                            int r = n - n1;
                            Console.WriteLine("la resta es:"+r);

                            

                            break;
                        }
                    case 3:
                        {
                            int mult = n * n1;
                            Console.WriteLine("la multiplicacionn es: " + mult);
                            
                            break;
                        }
                    case 5:
                        {
                            int r = (n^3) + (n1^2);
                            Console.WriteLine("la suma de potencia es:" + r);
                            break; 
                        }

                    case 4:
                        {
                            int r = n / n1;
                            Console.WriteLine("la division es:" + r);
                            break;
                        }


                }

            } while (op != 6);

            Console.ReadKey();

        }
    }
}
