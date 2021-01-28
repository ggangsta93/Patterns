using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class CSuspension : IComponente
    {
        private IComponente decoramosA;

        public CSuspension(IComponente pComponente)
        {
            this.decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Suspension de alto desempeño \r\n" +this.decoramosA.ToString();
        }
        //Métodos de la interfaz
        public double Costo()
        {
            return  this.decoramosA.Costo() + 8000;
        }

        public string Funciona()
        {
            return this.decoramosA.Funciona() + ", Elevando suspensión";
        }
    }
}
