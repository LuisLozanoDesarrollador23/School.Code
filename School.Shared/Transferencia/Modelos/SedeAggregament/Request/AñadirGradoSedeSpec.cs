namespace School.Shared.Transferencia.Modelos.SedeAggregament.Request;

/// <summary>
///     Especificación para la creación de una sede
/// </summary>
public class AñadirGradoSedeSpec
{
    // Nombre de la sede
    public int? sede { get; set; }

    //  Ubicación de la sede
    public int? grado { get; set; }
}