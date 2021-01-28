using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight05
{
    class Program
    {
        /*
         Flywight
          -Permite compartir informacion que se encuentre en pequeños objetos que existen en grandes cantidades
          -Ayuda a reducir las necesidades de almacenamiento
          
          °El patron distingue entre dos estados que puede tener el objeto
           -Intrínseco: Se puede compartir a gran escala disminuye el almacenamiento
           -Extrinseco: EL estado se calcula en el momento
          °El estado "no compartido" o unshared es el conjunto de grupo a los que pertenece
        
            Partes importantes
         °CLiente:  
            Es el que mantiene mantienen el esato no compartido y colecciones de flywights
         °IFlyweight
            La interfaz por medio de la cual los Flywights pueden recibir o actuar sobre un estado intrínseco
         °FlyweightFactory
            Administra a los objetos Flyweight y garantiza que solo un valor creado
         °Flyweight
            Guarda el estado intrínseco que se comparte a todos los objetos
        */
        static void Main(string[] args)
        {

            int i = 0;
            List<int> Americana = new List<int>();
            List<int> Italiana = new List<int>();
            List<int> Mexicana = new List<int>();

            List<int> Carnes = new List<int>();
            List<int> Sopas = new List<int>();
            List<int> Ensaladas = new List<int>();

            List<int> Rapida = new List<int>();

            CFlyweightFactory flywf = new CFlyweightFactory();
            i = flywf.Adiciona("Hamburguesa");
            Americana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Wilconsin cheese");
            Americana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Minestrone");
            Italiana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Antipasto");
            Italiana.Add(i);
            Ensaladas.Add(i);

            i = flywf.Adiciona("Tacos al pastor");
            Mexicana.Add(i);
            Carnes.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Coditos");
            Mexicana.Add(i);
            Sopas.Add(i);

            i = flywf.Adiciona("Nopales");
            Italiana.Add(i);
            Rapida.Add(i);

            i = flywf.Adiciona("Pizza");
            Italiana.Add(i);
            Rapida.Add(i);

            //Mostramos y llevamos a cabo proceso en la comida rapida
            foreach (int n in Rapida)
            {
                CReceta receta = (CReceta)flywf[n];
                receta.CalculaCosto();
                receta.Mostrar();
            }

            Console.WriteLine("------");
            //Mostramos la americana
            foreach (int n in Americana)
            {
                CReceta receta = (CReceta)flywf[n];
                //receta.CalculaCosto();  //Estado extrinseco
                receta.Mostrar();
            }

            Console.WriteLine("------");
            //Mostramos la americana
            i = flywf.Adiciona("Pizza");
            Console.WriteLine("------");


        }
    }
}
