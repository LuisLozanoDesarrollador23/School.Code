namespace School.Shared.Transferencia.Modelos.SedeAggregament.Response;


public class SedeColegio
{
    public int id { get; set; }
    
    public string nombre { get; set; } = null!;
    
    public string ubicacion { get; set; } = null!;
    
    public string direccion { get; set; } = null!;
    
    public int colegio { get; set; }    
}
