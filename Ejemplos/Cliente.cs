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

    public override void MostrarDatos()
    {

        System.Console.WriteLine("Yo soy la clase Cliente");
    }
}