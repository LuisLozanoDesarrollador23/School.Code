namespace School.Shared.Transferencia.Modelos.CursoAggregament.Response;

public class Curso
{
    public int Id { get; set; }

    public string descripcion { get; set; } = null!;

    public int anio_vigencia { get; set; }

    public int grado { get; set; }

    public int sede { get; set; }
}