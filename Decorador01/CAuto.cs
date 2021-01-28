using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class CAuto:IComponente
    {
        private string modelo;
        private string caracteristicas;
        public double costo;

        public CAuto(string pModelo, string pCaract, double pCosto)
        {
            this.modelo = pModelo;
            this.caracteristicas = pCaract;
            this.costo = pCosto;
        }
        public void Puertas(bool pEstado)
        {
            if (pEstado)
                Console.WriteLine("Puertas cerradas");
            else
                Console.WriteLine("Puertas abiertas");
        }

       

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }

        //Métodos implementados de IComponente
        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendí el motor";
        }

    }
}
