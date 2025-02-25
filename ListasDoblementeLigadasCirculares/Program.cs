namespace ListasDoblementeLigadasCirculares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListasDoblesCirculares<int> lista = new ListasDoblesCirculares<int>();

            lista.AgregarAlFinal(11);
            lista.AgregarAlFinal(28);
            lista.AgregarAlFinal(39);
            lista.AgregarAlInicio(56);

            Console.WriteLine("Lista desde el principio:");
            lista.ImprimirDesdeInicio();

            Console.WriteLine("Lista desde el final:");
            lista.ImprimirDesdeFin();

            lista.Eliminar(39);
            Console.WriteLine("Lista después de eliminar el 39:");
            lista.ImprimirDesdeInicio();
        }
    }
}
