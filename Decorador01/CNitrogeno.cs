using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class CNitrogeno : IComponente
    {

        private IComponente decoramosA;

        public CNitrogeno(IComponente pComponente)
        {
            this.decoramosA = pComponente;
        }

        public void UsaN()
        {
            Console.WriteLine("Nitrogeno en uso.");
        }

        public override string ToString()
        {
            return "Sistema de Nitrogeno\r\n" + this.decoramosA.ToString();
        }

        //Métodos de la interfaz
        public double Costo()
        {
            return this.decoramosA.Costo() + 45000;
        }

        public string Funciona()
        {
            return decoramosA.Funciona() + ", Nitrogeno listo";
        }
    }
}
