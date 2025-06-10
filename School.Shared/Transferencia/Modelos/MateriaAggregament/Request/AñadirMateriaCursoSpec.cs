namespace School.Shared.Transferencia.Modelos.MateriaAggregament.Request;

/// <summary>
///     Especificación para la creación de una sede
/// </summary>
public class AñadirMateriaCursoSpec
{
    // Nombre de la sede
    public int? materia { get; set; }

    //  Ubicación de la sede
    public int? profesor { get; set; }

    public int? curso { get; set; }
}