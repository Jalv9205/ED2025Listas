namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListasDoblesLigadas<int> lista = new ListasDoblesLigadas<int>();

            lista.AgregarAlFinal(1);
            lista.AgregarAlFinal(2);
            lista.AgregarAlFinal(3);
            lista.AgregarAlInicio(0);

            Console.WriteLine("Lista desde el principio:");
            lista.ImprimirDesdeInicio();

            Console.WriteLine("Lista desde el final:");
            lista.ImprimirDesdeFin();

            lista.Eliminar(2);
            Console.WriteLine("Lista después de eliminar el 2:");
            lista.ImprimirDesdeInicio();
        }
    }
}
