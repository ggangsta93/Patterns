using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy02
{
    //Haremos uso de anidamiento adentro de la clase
    //Esto hace que cualquier clase colocada como privada y anidada
    //solo sea conocida por CProxy
    class CProxy
    {
        public interface ISujeto
        {
            void Peticion(int pOpcion);
        }

        public class ProxySencillo : ISujeto
        {
            private CCocina cocina;
            public void Peticion(int pOpcion)
            {
                if (cocina == null)
                {
                    Console.WriteLine("Activando el sujeto");
                    cocina = new CCocina();
                }
                if (pOpcion == 1)
                    cocina.RecetaSecreta();
                if (pOpcion == 2)
                    cocina.Cocinar(5);

            }
        }

        public class ProxySeguro : ISujeto
        {
            private CCocina cocina;
            string password;
            public void Peticion(int pOpcion)
            {
                Console.WriteLine("Dame el password: ");
                password = Console.ReadLine();
                if(password == "abc123")
                {
                    if (cocina == null)
                    {
                        Console.WriteLine("Activando el sujeto");
                        cocina = new CCocina();
                    }
                    if (pOpcion == 1)
                        cocina.RecetaSecreta();
                    if (pOpcion == 2)
                        cocina.Cocinar(5);
                }
               
            }

             
        }

        //Esta es la clase que estamos protegiendo con el proxy
        protected class CCocina
        {
            public void RecetaSecreta()
            {
                Console.WriteLine("Pan");
                Console.WriteLine("Aceite de oliva");
                Console.WriteLine("Especias");
                Console.WriteLine("Jamon");
                Console.WriteLine("Queso");
            }

            public void Cocinar(int n)
            {
                Console.WriteLine("Cocinar {0} recetas ",n);
            }
        }
    }
}
