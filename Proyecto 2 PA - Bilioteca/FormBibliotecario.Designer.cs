partial class FormBibliotecario
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button btnGestionLibros;
    private System.Windows.Forms.Button btnGestionUsuarios;
    private System.Windows.Forms.Button btnGestionPrestamos;

    private void InitializeComponent()
    {
        this.btnGestionLibros = new System.Windows.Forms.Button();
        this.btnGestionUsuarios = new System.Windows.Forms.Button();
        this.btnGestionPrestamos = new System.Windows.Forms.Button();

        // btnGestionLibros
        this.btnGestionLibros.Location = new System.Drawing.Point(50, 50);
        this.btnGestionLibros.Size = new System.Drawing.Size(150, 40);
        this.btnGestionLibros.Text = "Gestión de Libros";
        this.btnGestionLibros.Click += new System.EventHandler(this.btnGestionLibros_Click);

        // btnGestionUsuarios
        this.btnGestionUsuarios.Location = new System.Drawing.Point(50, 100);
        this.btnGestionUsuarios.Size = new System.Drawing.Size(150, 40);
        this.btnGestionUsuarios.Text = "Gestión de Usuarios";
        this.btnGestionUsuarios.Click += new System.EventHandler(this.btnGestionUsuarios_Click);

        // btnGestionPrestamos
        this.btnGestionPrestamos.Location = new System.Drawing.Point(50, 150);
        this.btnGestionPrestamos.Size = new System.Drawing.Size(150, 40);
        this.btnGestionPrestamos.Text = "Gestión de Préstamos";
        this.btnGestionPrestamos.Click += new System.EventHandler(this.btnGestionPrestamos_Click);

        // FormBibliotecario
        this.ClientSize = new System.Drawing.Size(400, 300);
        this.Controls.Add(this.btnGestionLibros);
        this.Controls.Add(this.btnGestionUsuarios);
        this.Controls.Add(this.btnGestionPrestamos);
        this.Text = "Menú Bibliotecario";
    }
}
