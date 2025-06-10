namespace School.Shared.Transferencia.Modelos.CursoAggregament.Request;

public class CrearCursoSpec
{
    public string descripcion { get; set; }

    public int anio_vigencia { get; set; }
    public string grado { get; set; }

    public string sede { get; set; }

    public int director { get; set; }
}