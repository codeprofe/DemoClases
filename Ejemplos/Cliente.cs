namespace Democlases.Ejemplos;

public class Cliente : Empleado
{
    private void MostrarNombre()
    {
        Console.WriteLine(this.Nombre);
    }

    public void Prueba()
    {
        this.MostrarDatos();
    }
}