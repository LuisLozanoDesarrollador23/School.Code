namespace School.Shared.Transferencia.ResponseApi;

/// <summary>
///     Respuesta de las peticiones del api
/// </summary>
/// <remarks>
///     Es utilizada para consulta de listas como por objeto por id
/// </remarks>
public class ResponseGets : ResponseBase
{
    public string? Data { get; set; }
}
