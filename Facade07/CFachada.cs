using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subsistemas
{
    /*
     Fachada
         °Tenemos un sistema compuesto de varios subsistemas y este patrón nos permite tener una vista de alto nivel
         °Simplica el control de los subsistemas y la interfaz hacia los mismos
         °No solo simplifica, tambien ayuda a esconder el detalle de los subsistemas
         °Se pueden tener varias fachadas a la vez
    Variaciones
        °Opaco: Los subsistemas solo se puedeb acceder por medio del objeto fachada
        °Transparente: Los subsistemas se pueden acceder via la fachada o directamente
        °Estatica: La clase fachada se rea a partir de una clase estatica por lo que no es necesario instanciarla
     */
    class CFachada
    {
        //Estos son los subsistemas que se estan utilizando
        private CSistemaCompra compra = new CSistemaCompra();
        private CSubsistemaAlmacen almacen = new CSubsistemaAlmacen();
        private CSubsistemaEnvio envio = new CSubsistemaEnvio();

        //Este metodo es usada para realizar de forma sencilla una operacion
        //más compleja que requiere de uno o varios subsistemas

        public void comprar()
        {
            if (compra.Comprar())
            {
                if (almacen.SacarAlmacen())
                {
                    envio.EnviarPedido();
                }
            }

        }
    }
}
