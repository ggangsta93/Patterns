using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    /*
      DECORADOR
     -Provee un mecanismo para colocar un nuevo comportamiendo y/o estado a un objeto de forma dinamica
     -El objeto no sabe que esta siendo decorado
     -Tiene una instancia de la clase original y tambien desciende de ella
     -No necesitamos una superclase con todas las caracteristicas
     -Cada decoracion es independiente de las demás
     -Podemos colocarlas segun las necesitamos
     -No depende de la herencia para adicionar nuevos comportamientos
     -Algunos recomiendan usar clases abstractas, en lo personal prefiero uso de interfaz
    */

    /*
     CUANDO USARLO
     -Tenemos una clase a la que necesita adicionar comportamientos, pero no es posible/recomendable hacer herencia
     -Se desea adicionar comportamientos o estados de forma dinamica
     -Hacer cambios a un objeto de la clase sin modificar a otros de la misma clase
     -Deseamos evitar hacer clases hijas, pues acabariamos con muchas clases
     DESVENTAJAS
     -El decorador y el objeto al que envuelve tienen que implementa la misma cadena de herencia, o implementar la misma interfaz
     -Si bien la cantidad de clases disminuyen, podemos acabar con muchos "objetos pequeños" en memoria
     -Si se usa indiscriminadamente, puede complicar el mantenimiento al tener muchos objetos con muchas decoraciones
      y perder la pista de que objeto tiene que caracteristicas.
    */
    class Program
    {
        static void Main(string[] args)
        {
            IComponente miAuto = new CAuto("2018", "4 puertas", 20000);
            Console.WriteLine(miAuto); // ==  Console.WriteLine(miAuto.ToString());


            ((CAuto)miAuto).Puertas(true);

            Console.WriteLine("--------------------------Se agrega: Nitrogeno");
            miAuto = new CNitrogeno(miAuto);
            //Console.WriteLine(miAuto.Costo());
            //Console.WriteLine(miAuto.Funciona());
            //Console.WriteLine(miAuto);

            Console.WriteLine("--------------------------Se agrega: Sistema Sonido");
            miAuto = new CSistemaSonido(miAuto);
            //Console.WriteLine(miAuto.Costo());
            //Console.WriteLine(miAuto.Funciona());
            //Console.WriteLine(miAuto);

            Console.WriteLine("--------------------------Se agrega: Suspension");
            miAuto = new CSuspension(miAuto);
            Console.WriteLine(miAuto.Costo());
            Console.WriteLine(miAuto.Funciona());
            Console.WriteLine(miAuto);

            Console.WriteLine("--------------------------");
            //Ojo. No podemos usar métodos especificos una vez que decoremos sobre ella

            //((CNitrogeno)miAuto).UsaN();
            //((CAuto)miAuto).Puertas(false);

            //Console.ReadKey();
        }
    }
}
