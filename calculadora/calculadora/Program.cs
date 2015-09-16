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
                Console.WriteLine("SALIR");
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
                            
                            break;
                        }
                    case 3:
                        {
                            
                            break;
                        }


                }

            } while (op != 4);

            Console.ReadKey();

        }
    }
}
