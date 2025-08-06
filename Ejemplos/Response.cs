
namespace Democlases.Ejemplos;

public class Response<T,D> where T : Persona
{
    public int StatusCode { get; set; }
    public D Message { get; set; }
    public T[] Data { get; set; }

    public Response(int statusCode, D message, T[]? data = null)
    {
        StatusCode = statusCode;
        Message = message;
        Data = data;
    }
}