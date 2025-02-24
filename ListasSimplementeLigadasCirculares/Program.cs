namespace ListasSimplementeLigadasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListasSimplesCirculares lista = new ListasSimplesCirculares();

            lista.Agregar(12);
            lista.Agregar(27);
            lista.Agregar(35);
            lista.Agregar(44);
            lista.Agregar(76);
            lista.Agregar(98);

            Console.WriteLine("Elementos en la lista simple circular:");
            lista.Mostrar();

            lista.Eliminar(27);
            Console.WriteLine("\nDespués de eliminar el nodo con el valro 27:");
            lista.Mostrar();
        }
    }
}
