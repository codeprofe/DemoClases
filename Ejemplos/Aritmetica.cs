namespace Democlases.Ejemplos;
public class Aritmetica {
    public int Sumar(int a, int b)
    {
        return a + b;
    }

    public int Restar(int a, int b)
    {
        return a - b;
    }

    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    public int Dividir(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("No se puede dividir por cero.");
        }
        return a / b;
    }
}
