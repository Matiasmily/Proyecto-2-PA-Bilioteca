partial class FormLector
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Button btnVerLibros;
    private System.Windows.Forms.Button btnSolicitarLibro;
    private System.Windows.Forms.TextBox txtISBN;
    private System.Windows.Forms.Label lblISBN;

    private void InitializeComponent()
    {
        this.btnVerLibros = new System.Windows.Forms.Button();
        this.btnSolicitarLibro = new System.Windows.Forms.Button();
        this.txtISBN = new System.Windows.Forms.TextBox();
        this.lblISBN = new System.Windows.Forms.Label();

        // lblISBN
        this.lblISBN.AutoSize = true;
        this.lblISBN.Location = new System.Drawing.Point(20, 50);
        this.lblISBN.Text = "ISBN del Libro:";

        // txtISBN
        this.txtISBN.Location = new System.Drawing.Point(100, 50);
        this.txtISBN.Size = new System.Drawing.Size(150, 22);

        // btnVerLibros
        this.btnVerLibros.Location = new System.Drawing.Point(20, 100);
        this.btnVerLibros.Size = new System.Drawing.Size(100, 40);
        this.btnVerLibros.Text = "Ver Libros";
        this.btnVerLibros.Click += new System.EventHandler(this.btnVerLibros_Click);

        // btnSolicitarLibro
        this.btnSolicitarLibro.Location = new System.Drawing.Point(150, 100);
        this.btnSolicitarLibro.Size = new System.Drawing.Size(100, 40);
        this.btnSolicitarLibro.Text = "Solicitar Libro";
        this.btnSolicitarLibro.Click += new System.EventHandler(this.btnSolicitarLibro_Click);

        // FormLector
        this.ClientSize = new System.Drawing.Size(300, 200);
        this.Controls.Add(this.lblISBN);
        this.Controls.Add(this.txtISBN);
        this.Controls.Add(this.btnVerLibros);
        this.Controls.Add(this.btnSolicitarLibro);
        this.Text = "Menú Lector";
    }
}
