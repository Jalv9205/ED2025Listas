using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadasCirculares
{
    class ListasSimplesCirculares
    {
        private Nodo cabeza;
        public ListasSimplesCirculares()
        {
            cabeza = null;
        }

        public void Agregar(int datos)
        {
            Nodo nuevoNodo = new Nodo(datos);

            if (cabeza == null)
            {
                cabeza = nuevoNodo;
                cabeza.Siguiente = cabeza;
            }
            else
            {
                Nodo temp = cabeza;
                while (temp.Siguiente != cabeza)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevoNodo;
                nuevoNodo.Siguiente = cabeza;
            }
        }

        public void Mostrar()
        {
            if (cabeza == null)
            {
                Console.WriteLine("Lista sin elementos.");
                return;
            }

            Nodo temp = cabeza;
            do
            {
                Console.WriteLine(temp.Datos);
                temp = temp.Siguiente;
            } while (temp != cabeza);
        }

        public void Eliminar(int datos)
        {
            if (cabeza == null)
            {
                Console.WriteLine("Lista sin elementos.");
                return;
            }

            Nodo temp = cabeza;
            Nodo previo = null;

            if (cabeza.Datos == datos)
            {
                if (cabeza.Siguiente == cabeza)
                {
                    cabeza = null;
                }
                else
                {
                    while (temp.Siguiente != cabeza)
                    {
                        temp = temp.Siguiente;
                    }
                    cabeza = cabeza.Siguiente;
                    temp.Siguiente = cabeza;
                }
                return;
            }

            do
            {
                previo = temp;
                temp = temp.Siguiente;
            } while (temp != cabeza && temp.Datos != datos);

            if (temp == cabeza)
            {
                Console.WriteLine("No se encuentra el elemento a buscar.");
                return;
            }

            previo.Siguiente = temp.Siguiente;
        }
    }
}
