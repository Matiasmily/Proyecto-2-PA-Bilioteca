using System;
using System.Collections.Generic;
using System.Linq;

public class Biblioteca
{
    private List<Libro> libros = new List<Libro>();
    private Stack<string> acciones = new Stack<string>(); // Pila para deshacer acciones
    private Queue<Lector> listaEspera = new Queue<Lector>(); // Cola para lista de espera

    public void AgregarLibro(Libro libro)
    {
        if (libros.Any(l => l.ISBN == libro.ISBN))
            throw new Exception("El ISBN ya existe.");
        libros.Add(libro);
        acciones.Push($"Agregó el libro {libro.Titulo}");
    }

    public Libro BuscarLibroPorTitulo(string titulo)
    {
        return libros.FirstOrDefault(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase));
    }

    public void DeshacerUltimaAccion()
    {
        if (acciones.Count > 0)
            acciones.Pop();
    }

    public void SolicitarLibro(Lector lector, string isbn)
    {
        var libro = libros.FirstOrDefault(l => l.ISBN == isbn);
        if (libro != null && libro.Disponible)
        {
            libro.Disponible = false;
            acciones.Push($"Préstamo del libro {libro.Titulo} a {lector.Nombre}");
        }
        else
        {
            listaEspera.Enqueue(lector);
            Console.WriteLine($"{lector.Nombre} ha sido agregado a la lista de espera para el libro {isbn}");
        }
    }
}
