using System.Text;

namespace ListasSimplementeLigadas
{
    internal class Lista
    {
        private Nodo _nodoInicial;

        public Lista() 
        {
            _nodoInicial = new Nodo();
        }

        //Se va agregando los datos al listado en su nodo correspondiente
        public void Agregar(string dato)
        {
            Nodo nodoActual = _nodoInicial;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;
            }

            Nodo nodoNuevo = new Nodo();
            nodoNuevo.Dato = dato;

            nodoActual.Siguiente = nodoNuevo;
        }

        //Validacion para saber si esta vacio el nodo
        public bool EstaVacio() 
        {
            //if (_nodoInicial.Siguiente == null)
            //{
            //    return true;
            //}

            //aqui se esta regresando el resultado de la operacion
            return (_nodoInicial.Siguiente == null); 
        }

        //Para vaciar el nodo
        public void Vaciar()
        {
            _nodoInicial.Siguiente = null;
        }


        //Metodo para buscar el nodo a eliminar
        public Nodo? Buscar(string dato) 
        {
            if (!EstaVacio())
            {
                Nodo nodoActual = _nodoInicial;

                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;

                    if (nodoActual.Dato == dato)
                    {
                        return nodoActual;
                    }
                }
            }
            return null;
        }

        //Se busca el nodo anterior para dirigir al otro nodo
        private Nodo? BuscarAnterior(string dato)
        {
            if (!EstaVacio())
            {
                Nodo nodoActual = _nodoInicial;

                while (nodoActual.Siguiente != null)
                {
                    if (nodoActual.Siguiente.Dato == dato)
                    {
                        return nodoActual;
                    }

                    nodoActual = nodoActual.Siguiente;
                }
            }
            return null;
        }

        //Metodo para eliminar un dato en el nodo correspondiente
        public void Eliminar(string dato)
        {
            if (!EstaVacio())
            {
                Nodo? nodoActual = Buscar(dato);

                if (nodoActual != null)
                {
                    Nodo? nodoAnterior = BuscarAnterior(dato);

                    if (nodoAnterior != null)
                    {
                        nodoAnterior.Siguiente = nodoActual.Siguiente;
                        nodoActual.Siguiente = null;
                    }
                }
            }
        }

        //Metodo para obtener los valores de la lista
        public string ObtenerValores() 
        {
            StringBuilder datos = new StringBuilder();
            Nodo nodoActual = _nodoInicial;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;

                datos.AppendLine(nodoActual.Dato);
            }

            return datos.ToString();
        }
    }
}
