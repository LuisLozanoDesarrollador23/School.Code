using System.Text.Json.Serialization;

namespace School.Shared.Transferencia.Modelos.UsuarioAggregament.Response;

public class Usuario
{
    [JsonPropertyName("id")] public int Id { get; set; }

    [JsonPropertyName("password")] public string Password { get; set; }

    [JsonPropertyName("last_login")] public DateTime? LastLogin { get; set; }

    [JsonPropertyName("tipo_documento")] public string TipoDocumento { get; set; }

    [JsonPropertyName("numero_documento")] public string NumeroDocumento { get; set; }

    [JsonPropertyName("primer_nombre")] public string PrimerNombre { get; set; }

    [JsonPropertyName("segundo_nombre")] public string? SegundoNombre { get; set; }

    [JsonPropertyName("primer_apellido")] public string PrimerApellido { get; set; }

    [JsonPropertyName("segundo_apellido")] public string? SegundoApellido { get; set; }

    [JsonPropertyName("nombre_tutor")] public string NombreTutor { get; set; }

    [JsonPropertyName("telefono_contacto")]
    public string TelefonoContacto { get; set; }

    [JsonPropertyName("correo")] public string Correo { get; set; }

    [JsonPropertyName("fecha_nacimiento")] public DateTime? FechaNacimiento { get; set; }

    [JsonPropertyName("tipo_usuario")] public string TipoUsuario { get; set; }

    [JsonPropertyName("estado")] public bool Estado { get; set; }

    [JsonPropertyName("fecha_ingreso")] public DateTime? FechaIngreso { get; set; }

    [JsonPropertyName("fecha_ultima_actualizacion")]
    public DateTime FechaUltimaActualizacion { get; set; }

    [JsonPropertyName("is_staff")] public bool IsStaff { get; set; }

    [JsonPropertyName("is_superuser")] public bool IsSuperuser { get; set; }
}