using System.Text.Json;
using School.Shared.Transferencia.Modelos.UsuarioAggregament.Response;

namespace School.Shared.Service.General.Usuarios;

public static class ServiceUsuario
{
    public static async Task<(bool status, string? error, List<Usuario>? usuarios, Usuario? usuario)>
        BuscarUsuarios(string? idUsuario = null)
    {
        (bool status, string? error, List<Usuario>? usuarios, Usuario? usuario)?
            responseFunction = new();

        try
        {
            var web = new ApiClient();
            var response = await web.ConsultarRegistros("usuarios", idUsuario != null ? int.Parse(idUsuario) : null);
            if (string.IsNullOrWhiteSpace(response.Data))
            {
                responseFunction = (false,
                    "La consulta del objeto a visualizar presentó algún error, por favor vuelva a intentarlo", null,
                    null)!;
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(idUsuario))
                {
                    var usuario = JsonSerializer.Deserialize<Usuario>(response.Data);
                    responseFunction = (true, null, null, usuario)!;
                }
                else
                {
                    var usuarios = JsonSerializer.Deserialize<List<Usuario>>(response.Data);
                    responseFunction = (true, null, usuarios, null)!;
                }
            }
        }
        catch (Exception e)
        {
            responseFunction = (false, e.Message, null, null)!;
        }

        return ((bool status, string? error, List<Usuario>? usuarios, Usuario? usuario))responseFunction;
    }
}