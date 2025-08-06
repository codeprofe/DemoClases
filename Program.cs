//estructura base de un programa de consola en c#
using Democlases.Ejemplos;

public class Program
{
    public static void Main(string[] args)
    {
        Helper.MostrarMensaje("Bienvenido al programa de ejemplo de clases y objetos en C#");
        Console.WriteLine("Bienvenido al programa de ejemplo de clases y objetos en C#");
        Aritmetica.Sumar(5, 10, 5);

        Console.WriteLine("Creando un animal...", "", "");
        var data = new Empleado[] { new Empleado() { Nombre = "Juan", Ciudad = "Santo domingo" } };
        Response<Empleado, string> emp = new Response<Empleado, string>(200, "Empleado creado con éxito", data);

        string mensaje = "Hola";
        mensaje.Mostrar();
        "Hola soy un string literal".Mostrar();
    }
}