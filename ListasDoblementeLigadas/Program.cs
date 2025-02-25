namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListasDoblesLigadas<int> lista = new ListasDoblesLigadas<int>();

            lista.AgregarAlFinal(13);
            lista.AgregarAlFinal(25);
            lista.AgregarAlFinal(39);
            lista.AgregarAlInicio(102);

            Console.WriteLine("Lista desde el principio:");
            lista.ImprimirDesdeInicio();

            Console.WriteLine("Lista desde el final:");
            lista.ImprimirDesdeFin();

            lista.Eliminar(102);
            Console.WriteLine("Lista después de eliminar el 102:");
            lista.ImprimirDesdeInicio();
        }
    }
}
