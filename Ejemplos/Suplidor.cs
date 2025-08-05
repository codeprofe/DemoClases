namespace Democlases.Ejemplos;

public class Suplidor: Persona
{


    public string Telefono { get; set; }

    // métodos
    public string MostrarNombreSuplidor()
    {
        return this.Nombre;
    }
}