namespace School.Shared.Transferencia.Modelos.MateriaAggregament.Request;

/// <summary>
///     Especificación para la creación de una materia
/// </summary>
public class CrearMateriaSpec
{
    // Nombre de la materia
    public string nombre { get; set; } = null!;

    /// <summary>
    ///     Identificador del grado
    /// </summary>
    public int grado { get; set; }
}