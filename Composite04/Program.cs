using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite04
{
    class Program
    {
        /*
         Composite
         -Nos permite crear jerarquías estructuradas con componentes sencillos o grupos de componentes, 
          a los que se le pueden aplicar las mismas operaciones
         -El componente puede ser un objeto sencillo o una coleccion de otros componentes
         -Las operaciones más comunes son : adicionar, remover, agrupar, buscar
         -Se utiliza donde necesitamos tener a los elementos de forma organizada o jerarquica
         -Trabajamos con dos tipos de elementos: El componente y el compuesto
         -Ambos tipos de elementos tienen una interfaz comun

         -Permite adicionas nuevos tipos de componentes siempre y cuando implementen a la interfaz
         -Los reproductores de audio o video que nos permiten organizar en album o olista de reproduccion
         -Se utiliza en Model-view-Controller
         -En WinForms es utlizado, el Form es un contenedor de otros controles
         
         Variaciones
         -Orden-Los elementos son organizados
         -Cache -Si un valor calcula constatemente a partir de los hijos, puede guardarse en el padre para no
          tener que calcularlo constantemente.
        */
        static void Main(string[] args)
        {
            IComponente<string> arbol = new Compuesto<string>("root");
            IComponente<string> trabajo = arbol;

            string opcion = "";
            string dato = "";

            while (opcion != "6")
            {
                Console.WriteLine("Estoy en {0}",trabajo.Nombre);
                Console.WriteLine("1-Adicionar Compueto 2-Adicionar Componente 3-Borrar 4-Buscar 5-Mostrar 6-Salir");
                opcion = Console.ReadLine();
                Console.WriteLine("-----------------------");

                if (opcion == "1")
                {
                    Console.WriteLine("Dame el nombre del compuesto: ");
                    dato = Console.ReadLine();

                    IComponente<String> c = new Compuesto<string>(dato);
                    trabajo.Adicionar(c);
                    trabajo = c;
                }

                if (opcion == "2")
                {
                    Console.WriteLine("Dame el nombre del componente: ");
                    dato = Console.ReadLine();

                    trabajo.Adicionar(new Componente<string>(dato));
                }

                if (opcion == "3")
                {
                    Console.WriteLine("Dame el elemento a borrar: ");
                    dato = Console.ReadLine();

                    trabajo.Borrar(dato);
                }

                if (opcion == "4")
                {
                    Console.WriteLine("Dame el elemento a encontrar: ");
                    dato = Console.ReadLine();
                    trabajo = arbol.Buscar(dato);
                }

                if (opcion == "5")
                {
                    Console.WriteLine(arbol.Mostrar(0));
                }

            }
        }
    }
}
