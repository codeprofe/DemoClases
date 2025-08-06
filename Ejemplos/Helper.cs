namespace Democlases.Ejemplos;

public static class Helper
{
    public static void Mostrar(this string data)
    {
        Console.WriteLine(data);
    }
    public static void MostrarMensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }

    public static int CalcularEdad(DateTime fechaNacimiento)
    {
        var edad = DateTime.Now.Year - fechaNacimiento.Year;
        if (DateTime.Now < fechaNacimiento.AddYears(edad))
        {
            edad--;
        }
        return edad;
    }
}