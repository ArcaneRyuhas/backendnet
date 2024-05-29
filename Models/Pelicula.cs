namespace backendnet.Models;

public class Pelicula
{
    public int PeliculaId { get; set; }
    public string Titulo { get; set; }
    public string Sinopsis { get; set; }
    public int Anio { get; set; }
    public string Poster {get; set;}

    public ICollection<Categoria>? Categorias{ get; set; }
}