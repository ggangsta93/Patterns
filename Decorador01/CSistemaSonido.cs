using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorador01
{
    class CSistemaSonido : IComponente
    {
        private IComponente decoramosA;

        public CSistemaSonido(IComponente pComponente)
        {
            this.decoramosA = pComponente;
        }

        public override string ToString()
        {
            return "Radio 350XZ+\r\n" + decoramosA.ToString();
        }
        //Métodos de la interfaz
        public double Costo()
        {
            return this.decoramosA.Costo() + 45000;
        }

        public string Funciona()
        {
            return this.decoramosA.Funciona() + ", Enciende radio";
        }
    }
}
