namespace School.Shared.Transferencia.Modelos.CursoAggregament.Request;

public class AddNotaCursoSpec
{
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Porcentaje { get; set; }
    public bool Estado { get; set; }
    public int Periodo { get; set; }
    public int CursoId { get; set; }
    public int ProfesorId { get; set; }
    public int MateriaId { get; set; }
}