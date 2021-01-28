using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy02
{
    /*
     Proxy
     -El patron proxy da soporte a objetos que controlan la creacion y el acceso a otros objetos. Es un
      punto intermedio entre el cliente y esos objetos que son actividos cuando se cumplen con determinados
      requisitos.
     -un ejemplo de Proxy puede ser el mecanismo para registrarse y hacer login a un sitio web. No se tiene
      acceso a determinados objetos hasta que el usuario no este registrado y lleve a cabo el login de forma 
      correcta.
     -Otro uso de proxy es representar a un objeto que toma tiempo o recursos en crearse, de esta forma el 
      cliente piensa que esta comunicadocon el objeto, mientras el proxy decide la creacion cuando sea realmente 
      necesario. Es decir diferenciamos la instanciacion del momento real de su uso
     -Si un cálculo lleva mucho tiempo en realizarse, podemos usar el proxy para mostrar resultados intermedios
     -ADO .Net hace uso de proxy para llevar a cabo la conectividad con la base de datos.
     */
    class Program
    {
        static void Main(string[] args)
        {
            CProxy.ISujeto miProxy = new CProxy.ProxySencillo();
            miProxy.Peticion(1);
            //miProxy.Peticion(2);

            Console.WriteLine("------------");

            CProxy.ISujeto miProxyS = new CProxy.ProxySeguro();
            miProxyS.Peticion(1);
            //miProxyS.Peticion(2);

            //CProxy.CCocina myCocina = new CProxy.CCocina();  <-- no está visible

        }
    }
}
