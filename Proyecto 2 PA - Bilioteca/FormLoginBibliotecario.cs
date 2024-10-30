using System;
using System.Windows.Forms;

public partial class FormLoginBibliotecario : Form
{
    private Biblioteca biblioteca;

    public FormLoginBibliotecario(Biblioteca biblioteca)
    {
        InitializeComponent();
        this.biblioteca = biblioteca;
    }

    private void btnIngresar_Click(object sender, EventArgs e)
    {
        // Validación de usuario y contraseña (aquí puedes agregar lógica de autenticación)
        if (txtUsuario.Text == "admin" && txtContrasena.Text == "1234")
        {
            var formBibliotecario = new FormBibliotecario(biblioteca);
            formBibliotecario.Show();
            this.Hide(); // Oculta el formulario de inicio de sesión
        }
        else
        {
            MessageBox.Show("Usuario o contraseña incorrectos.");
        }
    }
}
