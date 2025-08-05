namespace Democlases.Ejemplos;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }

    public string Cedula { get; set; }

    public void MostrarDatos()
    {
        Console.WriteLine(this.Nombre);
        Console.WriteLine(this.Apellido);
        Console.WriteLine(this.Cedula);
     }

}