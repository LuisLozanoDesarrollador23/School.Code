using System.Text.Json;
using School.Shared.Transferencia.Modelos;
using School.Shared.Transferencia.Modelos.MateriaAggregament.Request;
using School.Shared.Transferencia.Modelos.SedeAggregament.Request;
using School.Shared.Transferencia.Modelos.SedeAggregament.Response;

namespace School.Shared.Service.General.Sedes;

public static class ServiceSede
{
    public static async Task<(bool status, string? error, List<SedeColegio>? sedes, SedeColegio? sede)>
        BuscarSedes(string? idSede = null)
    {
        (bool status, string? error, List<SedeColegio> sedes, SedeColegio? sede)?
            responseFunction = new();

        var web = new ApiClient();
        var response = await web.ConsultarRegistros("sedes", idSede != null ? int.Parse(idSede) : null);
        if (string.IsNullOrWhiteSpace(response.Data))
        {
            responseFunction = (false,
                "La consulta del objeto a visualizar presentó algún error, por favor vuelva a intentarlo", null, null)!;
        }
        else
        {
            if (!string.IsNullOrWhiteSpace(idSede))
            {
                var sede = JsonSerializer.Deserialize<SedeColegio>(response.Data);
                responseFunction = (true, null, null, sede)!;
            }
            else
            {
                var sedes = JsonSerializer.Deserialize<List<SedeColegio>>(response.Data);
                responseFunction = (true, null, sedes, null)!;
            }
        }

        return ((bool status, string? error, List<SedeColegio>? sedes, SedeColegio? sede))responseFunction;
    }


    public static async Task<(bool status, string? error, List<GradoHabilitado>? gradosHabilitados)>
        BuscarGradosHabilitados()
    {
        (bool status, string? error, List<GradoHabilitado> gradosHabilitados)? responseFunction = new();

        var web = new ApiClient();
        var response = await web.ConsultarRegistros("grados-habilitados");
        if (string.IsNullOrWhiteSpace(response.Data))
        {
            responseFunction = (false,
                "La consulta del objeto a visualizar presentó algún error, por favor vuelva a intentarlo", null)!;
        }
        else
        {
            var gradoHabilitados = JsonSerializer.Deserialize<List<GradoHabilitado>>(response.Data);
            responseFunction = (true, null, gradoHabilitados)!;
        }

        return ((bool status, string? error, List<GradoHabilitado>? gradosHabilitados))responseFunction;
    }

    public static async Task<(bool status, string message)> GuardarGradoEnSede(AñadirGradoSedeSpec spec)
    {
        var web = new ApiClient();
        var response = await web.CrearRegistro("grados-habilitados", spec);
        return (response.Success ? (true, null) : (false, response.Message))!;
    }

    public static async Task<(bool status, string message)> GuardarMateriaEnCurso(AñadirMateriaCursoSpec spec)
    {
        var web = new ApiClient();
        var response = await web.CrearRegistro("materia-curso", spec);
        return (response.Success ? (true, null) : (false, response.Message))!;
    }
}