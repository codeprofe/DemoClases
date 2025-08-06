namespace Democlases.Ejemplos;
public static class Aritmetica {
    public static int Sumar(int a)
    {
        return a + 0;
    }

    public static  int Sumar(int a, int b)
    {
        return a + b;
    }

    public static int Sumar(int a, int b, int c)
    {
        return a + b + c;
    }


    public static int Restar(int a, int b)
    {
        return a - b;
    }

    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    // public int Dividir(int a, int b)
    // {
    //     if (b == 0)
    //     {
    //         throw new DivideByZeroException("No se puede dividir por cero.");
    //     }
    //     return a / b;
    // }
}
