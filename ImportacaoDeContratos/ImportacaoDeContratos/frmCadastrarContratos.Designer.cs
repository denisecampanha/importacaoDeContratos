namespace ImportacaoDeContratos
{
    partial class frmCadastrarContratos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarContratos));
            panel1 = new Panel();
            btnPesqContratosCliente = new Button();
            btnPesqContratos = new Button();
            btnPesqArquivos = new Button();
            btnPasta = new Button();
            btnSair = new Button();
            btnImportar = new Button();
            txtArquivo = new TextBox();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnPesqContratosCliente);
            panel1.Controls.Add(btnPesqContratos);
            panel1.Controls.Add(btnPesqArquivos);
            panel1.Controls.Add(btnPasta);
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnImportar);
            panel1.Controls.Add(txtArquivo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(21, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(748, 395);
            panel1.TabIndex = 11;
            // 
            // btnPesqContratosCliente
            // 
            btnPesqContratosCliente.Location = new Point(498, 360);
            btnPesqContratosCliente.Name = "btnPesqContratosCliente";
            btnPesqContratosCliente.Size = new Size(205, 30);
            btnPesqContratosCliente.TabIndex = 19;
            btnPesqContratosCliente.Text = "Pesquisa Contratos Cliente";
            btnPesqContratosCliente.UseVisualStyleBackColor = true;
            btnPesqContratosCliente.Click += btnPesqContratosCliente_Click;
            // 
            // btnPesqContratos
            // 
            btnPesqContratos.Location = new Point(271, 360);
            btnPesqContratos.Name = "btnPesqContratos";
            btnPesqContratos.Size = new Size(205, 30);
            btnPesqContratos.TabIndex = 18;
            btnPesqContratos.Text = "Pesquisa de Contratos";
            btnPesqContratos.UseVisualStyleBackColor = true;
            btnPesqContratos.Click += btnPesqContratos_Click;
            // 
            // btnPesqArquivos
            // 
            btnPesqArquivos.Location = new Point(38, 360);
            btnPesqArquivos.Name = "btnPesqArquivos";
            btnPesqArquivos.Size = new Size(205, 30);
            btnPesqArquivos.TabIndex = 17;
            btnPesqArquivos.Text = "Pesquisa de Arquivos";
            btnPesqArquivos.UseVisualStyleBackColor = true;
            btnPesqArquivos.Click += button1_Click;
            // 
            // btnPasta
            // 
            btnPasta.Image = (Image)resources.GetObject("btnPasta.Image");
            btnPasta.Location = new Point(651, 129);
            btnPasta.Name = "btnPasta";
            btnPasta.Size = new Size(52, 31);
            btnPasta.TabIndex = 16;
            btnPasta.UseVisualStyleBackColor = true;
            btnPasta.Click += btnPasta_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(391, 237);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(159, 30);
            btnSair.TabIndex = 15;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(186, 237);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(159, 30);
            btnImportar.TabIndex = 14;
            btnImportar.Text = "Importar Contratos";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += this.btnImportar_Click;
            // 
            // txtArquivo
            // 
            txtArquivo.BorderStyle = BorderStyle.FixedSingle;
            txtArquivo.Enabled = false;
            txtArquivo.Location = new Point(109, 131);
            txtArquivo.Name = "txtArquivo";
            txtArquivo.Size = new Size(536, 27);
            txtArquivo.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 134);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 12;
            label1.Text = "Arquivo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(240, 48);
            label3.Name = "label3";
            label3.Size = new Size(254, 28);
            label3.TabIndex = 11;
            label3.Text = "CADASTRAR CONTRATOS";
            // 
            // frmCadastrarContratos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "frmCadastrarContratos";
            Text = "CadastrarContratos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnPasta;
        private Button btnSair;
        private Button btnImportar;
        private TextBox txtArquivo;
        private Label label1;
        private Label label3;
        private Button btnPesqArquivos;
        private Button btnPesqContratosCliente;
        private Button btnPesqContratos;
    }
}