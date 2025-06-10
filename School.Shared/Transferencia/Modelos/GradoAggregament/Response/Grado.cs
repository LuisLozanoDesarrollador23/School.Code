namespace School.Shared.Transferencia.Modelos.GradoAggregament.Response;

public class Grado
{
    public int id { get; set; }

    public string descripcion { get; set; } = null!;

    public int periodo { get; set; }

    public string tipoCalificacion { get; set; } = null!;
}