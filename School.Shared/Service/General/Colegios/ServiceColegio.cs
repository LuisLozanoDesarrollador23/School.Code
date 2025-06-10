using System.Text.Json;
using School.Shared.Transferencia.Modelos;

namespace School.Shared.Service.General.Colegios;

public static class ServiceColegio
{
    public static async Task<(bool status, string? error, Colegio? colegio)> BuscarColegio()
    {
        (bool status, string? error, Colegio? colegio) responseFunction = (false, null, null);

        var web = new ApiClient();
        var response = await web.ConsultarRegistros("colegios", CommonValues.IdColegio);
        if (string.IsNullOrWhiteSpace(response.Data))
        {
            responseFunction = (false,
                "La consulta del objeto a visualizar presentó algún error, por favor vuelva a intentarlo", null);
        }
        else
        {
            var colegio = JsonSerializer.Deserialize<Colegio>(response.Data);
            responseFunction = (true, null, colegio);
        }

        return responseFunction;
    }
}