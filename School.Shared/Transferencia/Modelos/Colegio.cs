namespace School.Shared.Transferencia.Modelos;

public class Colegio
{
    public int id { get; set; }
    public string nombre { get; set; } = null!;

    public string identificacion { get; set; } = null!;

    public string ubicacion { get; set; } = null!;

    public string direccion { get; set; } = null!;

    public int representante_legal { get; set; }
}