namespace Democlases.Ejemplos;

public abstract class Persona
{
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;

    public string Cedula { get; set; } = string.Empty;

    public virtual void MostrarDatos()
    {
        Console.WriteLine("Yo soy la clase padre");
        Console.WriteLine(this.Nombre);
        Console.WriteLine(this.Apellido);
        Console.WriteLine(this.Cedula);
    }

    public abstract void Saludar();

}