using System;
using System.Windows.Forms;

public partial class FormBibliotecario : Form
{
    private Biblioteca biblioteca;

    public FormBibliotecario(Biblioteca biblioteca)
    {
        InitializeComponent();
        this.biblioteca = biblioteca;
    }

    private void btnGestionLibros_Click(object sender, EventArgs e)
    {
        var formGestionLibros = new FormGestionLibros(biblioteca);
        formGestionLibros.Show();
    }

    private void btnGestionUsuarios_Click(object sender, EventArgs e)
    {
        var formGestionUsuarios = new FormGestionUsuarios(biblioteca);
        formGestionUsuarios.Show();
    }

    private void btnGestionPrestamos_Click(object sender, EventArgs e)
    {
        var formGestionPrestamos = new FormGestionPrestamos(biblioteca);
        formGestionPrestamos.Show();
    }
}

