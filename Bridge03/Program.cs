using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge03
{
    class Program
    {
        /*
         Bridge (Como un hijo de Estrategia y adaptador)
         -Desacopla la implementacion de la abstraccion
         -Se usa cuando surge una nueva version del software pero la anterior aun se va a seguir usando con el cliente
         -Protege de cambio al cliente, ya que su sódigo no cambia, pues trabaja con una abstracción y no con un código concreto
         -El cliente indicará con que versión va a trabajar
         -Una interfaz provee el mecanismo de entrada a las diferentes implementaciones de la bstracción
         -Hace que la interfaz de una o más clases parezcan que tienen la de una clase en particular
        Ventajas
        -Permite que la interfaz del cliente permanezca constante sin importar los cambios que tenga la abstracción
        -Con esto evitamos recompilar al cliente, solo tenemos que recompilar el bride y las implmentaciones necesarias
        -Esconce las implementaciones del cliente
       */
        static void Main(string[] args)
        {
            //Main representa el cliente
            Dictionary<string, double> productos = new Dictionary<string, double>();

            //Estos son los productos a usar
            productos.Add("M101", 56.32);
            productos.Add("M234", 23.88);
            productos.Add("C654", 974.56);
            productos.Add("M401", 43.28);
            productos.Add("C345", 785.12);
            productos.Add("D567", 432.56);
            productos.Add("M103", 874.54);
            productos.Add("D901", 23.18);
            productos.Add("C732", 43.12);
            productos.Add("M056", 21.42);

            //Creamos el bridge
            CAbstraccion bridge = new CAbstraccion(new CImplementacion3(), productos);

            //CAbstraccion bridge=new CAbstraccion(1, productos);
            bridge.MostrarTotales();
            bridge.Listar();


        }
    }
}
