public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public bool Disponible { get; set; }

    public Libro(string titulo, string autor, string isbn, string genero)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        Disponible = true;
    }
}
