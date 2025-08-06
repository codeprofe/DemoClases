namespace Democlases.Ejemplos;

public class Suplidor : Persona
{


    public string Telefono { get; set; } = string.Empty;

    // métodos
    public string MostrarNombreSuplidor()
    {
        return this.Nombre;
    }

    public override void Saludar()
    {
        Console.WriteLine($"Hola, soy {Nombre} {Apellido}, proveedor de {Telefono}");
    }
}