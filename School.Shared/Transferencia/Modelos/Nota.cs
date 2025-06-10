namespace School.Shared.Transferencia.Modelos;

public class Nota
{
    public int Id { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public decimal Porcentaje { get; set; }

    public string Estado { get; set; }

    public int Periodo { get; set; }

    public int IdCurso { get; set; }

    public int IdProfesor { get; set; }

    public int IdMateria { get; set; }
}