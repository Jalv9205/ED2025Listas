using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    class ListasDoblesCirculares<T>
    {
        private Nodo<T> cabeza;

        public ListasDoblesCirculares()
        {
            cabeza = null;
        }

        //Se agrega al final de la lista
        public void AgregarAlFinal(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                nuevoNodo.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = nuevoNodo;
            }
            else
            {
                Nodo<T> cola = cabeza.Anterior;

                nuevoNodo.Siguiente = cabeza;
                nuevoNodo.Anterior = cola;

                cola.Siguiente = nuevoNodo;
                cabeza.Anterior = nuevoNodo;
            }
        }

        //Se agrega al inicio de la lista
        public void AgregarAlInicio(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                nuevoNodo.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = nuevoNodo;
            }
            else
            {
                Nodo<T> cola = cabeza.Anterior;

                nuevoNodo.Siguiente = cabeza;
                nuevoNodo.Anterior = cola;

                cola.Siguiente = nuevoNodo;
                cabeza.Anterior = nuevoNodo;

 
                cabeza = nuevoNodo;
            }
        }

        //Se imprime la lista desde el principio
        public void ImprimirDesdeInicio()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo<T> actual = cabeza;
            do
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            } while (actual != cabeza);

            Console.WriteLine();
        }

        //Se imprime la lista desde el final
        public void ImprimirDesdeFin()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo<T> actual = cabeza.Anterior;
            do
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Anterior;
            } while (actual != cabeza.Anterior);

            Console.WriteLine();
        }

        //Para eliminar un nodo de la lista
        public void Eliminar(T valor)
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo<T> actual = cabeza;
            do
            {
                if (actual.Valor.Equals(valor))
                {
                    if (actual.Siguiente == actual)
                    {
                        cabeza = null;
                    }
                    else
                    {
                        Nodo<T> anterior = actual.Anterior;
                        Nodo<T> siguiente = actual.Siguiente;

                        anterior.Siguiente = siguiente;
                        siguiente.Anterior = anterior;

                        if (actual == cabeza)
                        {
                            cabeza = siguiente;
                        }
                    }
                    return;
                }
                actual = actual.Siguiente;
            } while (actual != cabeza);
        }
    }
}
