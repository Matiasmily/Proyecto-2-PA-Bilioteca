public abstract class Usuario
{
    public string Nombre { get; set; }
    public int ID { get; set; }
    public string Rol { get; set; }

    protected Usuario(string nombre, int id, string rol)
    {
        Nombre = nombre;
        ID = id;
        Rol = rol;
    }
}

public class Lector : Usuario
{
    public Lector(string nombre, int id) : base(nombre, id, "Lector") { }
}

public class Bibliotecario : Usuario
{
    public Bibliotecario(string nombre, int id) : base(nombre, id, "Bibliotecario") { }
}
