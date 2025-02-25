using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    class ListasDoblesLigadas<T>
    {
        private Nodo<T> cabeza;
        private Nodo<T> cola;

        public ListasDoblesLigadas()
        {
            cabeza = null;
            cola = null;
        }

        //Se agrega al final de la lista
        public void AgregarAlFinal(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);
            if (cola == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                cola.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = cola;
                cola = nuevoNodo;
            }
        }

        //Se agrega al principio de la lista
        public void AgregarAlInicio(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);
            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cola = nuevoNodo;
            }
            else
            {
                nuevoNodo.Siguiente = cabeza;
                cabeza.Anterior = nuevoNodo;
                cabeza = nuevoNodo;
            }
        }

        //Se imprime la lista desde el principio
        public void ImprimirDesdeInicio()
        {
            Nodo<T> actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }

        //Se imprime la lista desde el final
        public void ImprimirDesdeFin()
        {
            Nodo<T> actual = cola;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Anterior;
            }
            Console.WriteLine();
        }

        //Para eliminar un nodo de la lista
        public void Eliminar(T valor)
        {
            Nodo<T> actual = cabeza;
            while (actual != null)
            {
                if (actual.Valor.Equals(valor))
                {
                    if (actual.Anterior != null)
                        actual.Anterior.Siguiente = actual.Siguiente;
                    else
                        cabeza = actual.Siguiente;

                    if (actual.Siguiente != null)
                        actual.Siguiente.Anterior = actual.Anterior;
                    else
                        cola = actual.Anterior;

                    actual = null;
                    return;
                }
                actual = actual.Siguiente;
            }
        }
    }
}
