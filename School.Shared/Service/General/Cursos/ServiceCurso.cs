using System.Text.Json;
using School.Shared.Transferencia.Modelos.CursoAggregament.Request;
using School.Shared.Transferencia.Modelos.CursoAggregament.Response;

namespace School.Shared.Service.General.Cursos;

public static class ServiceCurso
{
    public static async Task<(bool status, string? error, List<Curso>? cursos, Curso? curso)> BuscarCursos(
        string? idCurso = null)
    {
        (bool status, string? error, List<Curso>? cursos, Curso? curso)?
            responseFunction = new();

        var web = new ApiClient();
        var response = await web.ConsultarRegistros("cursos", idCurso != null ? int.Parse(idCurso) : null);
        if (string.IsNullOrWhiteSpace(response.Data))
        {
            responseFunction = (false,
                "La consulta del objeto a visualizar presentó algún error, por favor vuelva a intentarlo", null, null)!;
        }
        else
        {
            if (!string.IsNullOrWhiteSpace(idCurso))
            {
                var curso = JsonSerializer.Deserialize<Curso>(response.Data);
                responseFunction = (true, null, null, curso)!;
            }
            else
            {
                var cursos = JsonSerializer.Deserialize<List<Curso>>(response.Data);
                responseFunction = (true, null, cursos, null)!;
            }
        }

        return ((bool status, string? error, List<Curso>? cursos, Curso? curso))responseFunction;
    }

    public static async Task<(bool status, string message)> GuardarNota(AddNotaCursoSpec spec)
    {
        var web = new ApiClient();
        var response = await web.CrearRegistro("notas", spec);
        return (response.Success ? (true, null) : (false, response.Message))!;
    }
}