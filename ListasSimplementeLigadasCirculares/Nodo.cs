using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasSimplementeLigadasCirculares
{
    class Nodo
    {
        public int Datos;
        public Nodo Siguiente;
        public Nodo(int datos)
        {
            Datos = datos;
            Siguiente = null;
        }
    }
}
