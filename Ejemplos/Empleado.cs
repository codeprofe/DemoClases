namespace Democlases.Ejemplos;

public class Empleado : Persona
{

    public string Ciudad { get; set; } = string.Empty;
    public string Departamento { get; set; } = "";

    public void CambiarDepartamento(string nombredepa)
    {
        this.Departamento = nombredepa;
    }

    public override void Saludar()
    {
        throw new NotImplementedException();
    }
}