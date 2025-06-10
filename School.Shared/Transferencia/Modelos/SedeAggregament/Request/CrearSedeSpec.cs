namespace School.Shared.Transferencia.Modelos.SedeAggregament.Request;

/// <summary>
///     Especificación para la creación de una sede
/// </summary>
public class CrearSedeSpec
{
    // Nombre de la sede
    public string nombre { get; set; } = null!;

    //  Ubicación de la sede
    public string ubicacion { get; set; } = null!;

    // Dirección de la sede
    public string direccion { get; set; } = null!;

    // Identificador del colegio a la cual esta asociada la sede
    public int colegio { get; set; }

    // Identificador del coordinador de la sede 
    public int cordinador { get; set; } = 1;
}