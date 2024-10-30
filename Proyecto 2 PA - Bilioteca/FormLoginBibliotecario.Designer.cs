partial class FormLoginBibliotecario
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblUsuario;
    private System.Windows.Forms.Label lblContrasena;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.TextBox txtContrasena;
    private System.Windows.Forms.Button btnIngresar;

    private void InitializeComponent()
    {
        this.lblUsuario = new System.Windows.Forms.Label();
        this.lblContrasena = new System.Windows.Forms.Label();
        this.txtUsuario = new System.Windows.Forms.TextBox();
        this.txtContrasena = new System.Windows.Forms.TextBox();
        this.btnIngresar = new System.Windows.Forms.Button();
        
        // lblUsuario
        this.lblUsuario.AutoSize = true;
        this.lblUsuario.Location = new System.Drawing.Point(50, 30);
        this.lblUsuario.Text = "Usuario:";

        // txtUsuario
        this.txtUsuario.Location = new System.Drawing.Point(130, 30);

        // lblContrasena
        this.lblContrasena.AutoSize = true;
        this.lblContrasena.Location = new System.Drawing.Point(50, 70);
        this.lblContrasena.Text = "Contraseña:";

        // txtContrasena
        this.txtContrasena.Location = new System.Drawing.Point(130, 70);
        this.txtContrasena.PasswordChar = '*';

        // btnIngresar
        this.btnIngresar.Location = new System.Drawing.Point(130, 110);
        this.btnIngresar.Text = "Ingresar";
        this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);

        // FormLoginBibliotecario
        this.ClientSize = new System.Drawing.Size(300, 200);
        this.Controls.Add(this.lblUsuario);
        this.Controls.Add(this.txtUsuario);
        this.Controls.Add(this.lblContrasena);
        this.Controls.Add(this.txtContrasena);
        this.Controls.Add(this.btnIngresar);
        this.Text = "Inicio de Sesión - Bibliotecario";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
