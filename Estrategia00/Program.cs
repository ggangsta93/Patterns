using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia00
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = "";
            double x = 5;
            double y = 6;
            double r = 0;
            int opcion = 1;
            IOperacion miOperacion=null;

            while (opcion != 0)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                Console.Write("Digite la operación a realizar:");
                dato = Console.ReadLine();
                opcion = Convert.ToInt32(dato);

                Console.WriteLine("Digite valor 1: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite valor 2: ");
                y = Convert.ToDouble(Console.ReadLine());

                if (opcion == 1)
                {miOperacion = new CSuma();}
                else if (opcion == 2)
                {miOperacion = new CResta();}
                else if (opcion == 3) 
                {miOperacion = new CMulti();}
                else if(opcion == 4)
                {miOperacion = new CDivi();}
                r = miOperacion.operacion(x, y);
    
                Console.WriteLine("La operación es = "+r);
            }
        }
    }
}
