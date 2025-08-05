//estructura base de un programa de consola en c#
using Democlases.Ejemplos;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Funciona");
        Cliente c = new Cliente();
        c.Nombre = "Julia";
        c.Prueba();

    }
}