using System;
using System.Windows.Forms;

public partial class FormLector : Form
{
    private Biblioteca biblioteca;
    private Lector lector;

    public FormLector(Biblioteca biblioteca, Lector lector)
    {
        InitializeComponent();
        this.biblioteca = biblioteca;
        this.lector = lector;
    }

    private void btnVerLibros_Click(object sender, EventArgs e)
    {
        // Mostrar libros disponibles en un cuadro de mensaje o en un DataGridView
        MessageBox.Show("Mostrando libros disponibles...");
    }

    private void btnSolicitarLibro_Click(object sender, EventArgs e)
    {
        string isbn = txtISBN.Text;
        biblioteca.SolicitarLibro(lector, isbn);
        MessageBox.Show("Solicitud realizada.");
    }
}
