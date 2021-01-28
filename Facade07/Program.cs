using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Subsistemas;
namespace Facade07
{
    class Program
    {
        static void Main(string[] args)
        {
            CFachada fachada = new CFachada();

            //Hacemos uso de subsistemas a traves de la interfaz
            //sencilla de la fachada
            fachada.comprar();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("--------");


        }
    }
}
