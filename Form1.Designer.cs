namespace Produto
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
             this.lblNome = new System.Windows.Forms.Label();
            this.lblIdEditar = new System.Windows.Forms.Label();
            this.lblNovoNome = new System.Windows.Forms.Label();
            this.lblIdRemover = new System.Windows.Forms.Label();

            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdEditar = new System.Windows.Forms.TextBox();
            this.txtNovoNome = new System.Windows.Forms.TextBox();
            this.txtIdRemover = new System.Windows.Forms.TextBox();

            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lstProdutos = new System.Windows.Forms.ListBox();

            this.SuspendLayout();

            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 12);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";

            this.lblIdEditar.AutoSize = true;
            this.lblIdEditar.Location = new System.Drawing.Point(12, 38);
            this.lblIdEditar.Name = "lblIdEditar";
            this.lblIdEditar.Size = new System.Drawing.Size(19, 13);
            this.lblIdEditar.TabIndex = 1;
            this.lblIdEditar.Text = "ID:";

            this.lblNovoNome.AutoSize = true;
            this.lblNovoNome.Location = new System.Drawing.Point(12, 76);
            this.lblNovoNome.Name = "lblNovoNome";
            this.lblNovoNome.Size = new System.Drawing.Size(64, 13);
            this.lblNovoNome.TabIndex = 2;
            this.lblNovoNome.Text = "Novo Nome:";

            this.lblIdRemover.AutoSize = true;
            this.lblIdRemover.Location = new System.Drawing.Point(12, 114);
            this.lblIdRemover.Name = "lblIdRemover";
            this.lblIdRemover.Size = new System.Drawing.Size(19, 13);
            this.lblIdRemover.TabIndex = 3;
            this.lblIdRemover.Text = "ID:";

            this.txtNome.Location = new System.Drawing.Point(82, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 4;

            this.txtIdEditar.Location = new System.Drawing.Point(82, 38);
            this.txtIdEditar.Name = "txtIdEditar";
            this.txtIdEditar.Size = new System.Drawing.Size(100, 20);
            this.txtIdEditar.TabIndex = 5;

            this.txtNovoNome.Location = new System.Drawing.Point(82, 76);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(200, 20);
            this.txtNovoNome.TabIndex = 6;

            this.txtIdRemover.Location = new System.Drawing.Point(82, 114);
            this.txtIdRemover.Name = "txtIdRemover";
            this.txtIdRemover.Size = new System.Drawing.Size(100, 20);
            this.txtIdRemover.TabIndex = 7;

            this.btnAdicionar.Location = new System.Drawing.Point(288, 10);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 8;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);

            this.btnEditar.Location = new System.Drawing.Point(288, 38);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            this.btnRemover.Location = new System.Drawing.Point(288, 76);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);

            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(12, 150);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(351, 186);
            this.lstProdutos.TabIndex = 11;


            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(375, 348);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtIdRemover);
            this.Controls.Add(this.lblIdRemover);
            this.Controls.Add(this.txtNovoNome);
            this.Controls.Add(this.lblNovoNome);
            this.Controls.Add(this.txtIdEditar);
            this.Controls.Add(this.lblIdEditar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "CRUD de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdEditar;
        private System.Windows.Forms.TextBox txtNovoNome;
        private System.Windows.Forms.TextBox txtIdRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdEditar;
        private System.Windows.Forms.Label lblNovoNome;
        private System.Windows.Forms.Label lblIdRemover;  
    }
}