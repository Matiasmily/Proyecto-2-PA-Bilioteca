namespace Proyecto_2_PA___Biblioteca
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnBibliotecario;
        private System.Windows.Forms.Button btnLector;
        private System.Windows.Forms.Label lblBienvenida;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnBibliotecario = new System.Windows.Forms.Button();
            this.btnLector = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();

            // lblBienvenida
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.Location = new System.Drawing.Point(180, 50);
            this.lblBienvenida.Text = "Bienvenido a la Biblioteca";

            // btnBibliotecario
            this.btnBibliotecario.Location = new System.Drawing.Point(100, 150);
            this.btnBibliotecario.Size = new System.Drawing.Size(120, 40);
            this.btnBibliotecario.Text = "Bibliotecario";
            this.btnBibliotecario.Click += new System.EventHandler(this.btnBibliotecario_Click);

            // btnLector
            this.btnLector.Location = new System.Drawing.Point(300, 150);
            this.btnLector.Size = new System.Drawing.Size(120, 40);
            this.btnLector.Text = "Lector";
            this.btnLector.Click += new System.EventHandler(this.btnLector_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnBibliotecario);
            this.Controls.Add(this.btnLector);
            this.Text = "BIBLIOTECA EL MOSQUETE";
        }
    }
}

