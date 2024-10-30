using System;
using System.Windows.Forms;

namespace Proyecto_2_PA___Biblioteca
{
    public partial class Form1 : Form
    {
        private Biblioteca biblioteca = new Biblioteca();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBibliotecario_Click(object sender, EventArgs e)
        {
            var formLoginBibliotecario = new FormLoginBibliotecario(biblioteca);
            formLoginBibliotecario.Show();
            this.Hide(); // Oculta la pantalla de inicio
        }

        private void btnLector_Click(object sender, EventArgs e)
        {
            var formLector = new FormLector(biblioteca, new Lector("Lector", 1));
            formLector.Show();
            this.Hide(); // Oculta la pantalla de inicio
        }
    }
}
