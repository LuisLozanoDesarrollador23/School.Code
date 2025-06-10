using System.Text.Json.Serialization;

namespace School.Shared.Transferencia.Modelos.UsuarioAggregament.Request;

public class CrearUsuarioSpec
{
    [JsonPropertyName("tipo_documento")] public string TipoDocumento { get; set; } = null!;

    [JsonPropertyName("numero_documento")] public string NumeroDocumento { get; set; } = null!;

    [JsonPropertyName("primer_nombre")] public string PrimerNombre { get; set; } = null!;

    [JsonPropertyName("segundo_nombre")] public string SegundoNombre { get; set; } = null!;

    [JsonPropertyName("primer_apellido")] public string PrimerApellido { get; set; } = null!;

    [JsonPropertyName("segundo_apellido")] public string SegundoApellido { get; set; } = null!;

    [JsonPropertyName("correo")] public string Correo { get; set; } = null!;

    [JsonPropertyName("fecha_nacimiento")] public DateTime FechaNacimiento { get; set; }

    [JsonPropertyName("promedio")] public string? Promedio { get; set; }

    [JsonPropertyName("tipo_usuario")] public string TipoUsuario { get; set; } = null!;

    [JsonPropertyName("estado")] public bool Estado { get; set; }

    [JsonPropertyName("fecha_ingreso")] public DateTime FechaIngreso { get; set; }

    [JsonPropertyName("fecha_ultima_actualizacion")]
    public DateTime? FechaUltimaActualizacion { get; set; }
}