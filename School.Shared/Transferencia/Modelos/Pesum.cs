namespace School.Shared.Transferencia.Modelos;

internal class Pesum
{
    public int Id { get; set; }
    
    public string Descripcion { get; set; } = null!;
    
    public int IdMateria { get; set; }
    
    public string Estado { get; set; } = null!;
}
