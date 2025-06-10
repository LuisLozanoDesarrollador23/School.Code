using System.Text.Json.Serialization;

namespace School.Shared.Transferencia.Modelos.UsuarioAggregament.Request;

public class EditarUsuarioSpec
{
    [JsonPropertyName("tipo_documento")] public string TipoDocumento { get; set; }

    [JsonPropertyName("numero_documento")] public string NumeroDocumento { get; set; }

    [JsonPropertyName("primer_nombre")] public string PrimerNombre { get; set; }

    [JsonPropertyName("segundo_nombre")] public string? SegundoNombre { get; set; }

    [JsonPropertyName("primer_apellido")] public string PrimerApellido { get; set; }

    [JsonPropertyName("segundo_apellido")] public string SegundoApellido { get; set; }

    [JsonPropertyName("correo")] public string Correo { get; set; }

    [JsonPropertyName("fecha_nacimiento")] public DateTime FechaNacimiento { get; set; }

    [JsonPropertyName("promedio")] public string? Promedio { get; set; }

    [JsonPropertyName("tipo_usuario")] public string TipoUsuario { get; set; }

    [JsonPropertyName("estado")] public bool Estado { get; set; }

    [JsonPropertyName("fecha_ingreso")] public DateTime FechaIngreso { get; set; }

    [JsonPropertyName("fecha_ultima_actualizacion")]
    public DateTime? FechaUltimaActualizacion { get; set; }
}