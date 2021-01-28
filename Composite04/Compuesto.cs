using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite04
{
    class Compuesto<T> : IComponente<T>
    {

        //Lista donde guardamos los elementos que va guardar
        List<IComponente<T>> elementos;
        
        //Identificador
        public T Nombre { get; set; }


        public Compuesto(T pNombre)
        {
            Nombre = pNombre;
            //Instanciamos la lista
            elementos = new List<IComponente<T>>();
        }
        public void Adicionar(IComponente<T> pElemento)
        {
            elementos.Add(pElemento);
        }

        public IComponente<T> Borrar(T pElemento)
        {
            //Buscar el elemento borrado
            IComponente<T> elemento = this.Buscar(pElemento);
            //Si la encontramos , la eliminamos de la lista
            if (elemento != null)
            {
                (this as Compuesto<T>).elementos.Remove(elemento);
            }
            return this;
        }

        public IComponente<T> Buscar(T pElemento)
        {
            //si somos quien se busca nos regresamos
            if (Nombre.Equals(pElemento))
                return this;
            IComponente<T> encontrado = null;

            //Recorremos la lista y buscamos en nuestros elementos
            foreach (IComponente<T>  elemento in elementos)
            {
                encontrado = elemento.Buscar(pElemento);
                if (encontrado != null)
                    break;
            }
            return encontrado;
        }

        public string Mostrar(int pProfundidad)
        {
            //Construimos la cadena con una cantidad de -igual a la profundidad
            StringBuilder infoElemento = new StringBuilder(new String('-',pProfundidad));

            //Adicionamos la informacion del compuesto
            infoElemento.Append("Compuesto: "+Nombre+" elementos: "+elementos.Count+"\r\n");

            //Adicionamos los elementos
            foreach (IComponente<T> elemento in elementos)
                infoElemento.Append(elemento.Mostrar(pProfundidad+1));

            return infoElemento.ToString();            
        }
    }
}
