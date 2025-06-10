using System.Text.Json;
using School.Shared.Transferencia.Modelos.GradoAggregament.Response;

namespace School.Shared.Service.General.Grados;

public static class ServiceGrado
{
    public static async Task<(bool status, string? error, List<Grado>? Grados, Grado? grado)> BuscarGrados()
    {
        (bool status, string? error, List<Grado>? Grados, Grado? grado) responseFunction = (false, null, null, null);

        var web = new ApiClient();
        var response = await web.ConsultarRegistros("grados");
        if (string.IsNullOrWhiteSpace(response.Data))
        {
            responseFunction = (false,
                "La consulta del objeto a visualizar presentó algún error, por favor vuelva a intentarlo", null, null);
        }
        else
        {
            var grados = JsonSerializer.Deserialize<List<Grado>>(response.Data);
            responseFunction = (true, null, grados, null);
        }

        return responseFunction;
    }
}