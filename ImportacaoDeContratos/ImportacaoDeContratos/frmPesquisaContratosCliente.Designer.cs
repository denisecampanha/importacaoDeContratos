namespace ImportacaoDeContratos
{
    partial class frmPesquisaContratosCliente
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
            btnPesquisar = new Button();
            grdContratosCliente = new DataGridView();
            txtNome = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnLimpar = new Button();
            panel2 = new Panel();
            txtMaiorAtraso = new TextBox();
            label5 = new Label();
            txtValorTotal = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdContratosCliente).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(664, 111);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 27;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // grdContratosCliente
            // 
            grdContratosCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdContratosCliente.Location = new Point(37, 202);
            grdContratosCliente.Name = "grdContratosCliente";
            grdContratosCliente.RowHeadersWidth = 51;
            grdContratosCliente.Size = new Size(891, 343);
            grdContratosCliente.TabIndex = 26;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(80, 66);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(778, 27);
            txtNome.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 165);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(253, 13);
            label3.Name = "label3";
            label3.Size = new Size(360, 28);
            label3.TabIndex = 21;
            label3.Text = "PESQUISA CONTRATOS POR CLIENTE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 69);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 28;
            label2.Text = "Nome:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(37, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 159);
            panel1.TabIndex = 29;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(764, 111);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 29;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtMaiorAtraso);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtValorTotal);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(37, 562);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 83);
            panel2.TabIndex = 30;
            // 
            // txtMaiorAtraso
            // 
            txtMaiorAtraso.Location = new Point(664, 28);
            txtMaiorAtraso.Name = "txtMaiorAtraso";
            txtMaiorAtraso.Size = new Size(194, 27);
            txtMaiorAtraso.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(506, 31);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 31;
            label5.Text = "Maior atraso em dias:";
            // 
            // txtValorTotal
            // 
            txtValorTotal.Location = new Point(197, 28);
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.Size = new Size(220, 27);
            txtValorTotal.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 31);
            label4.Name = "label4";
            label4.Size = new Size(175, 20);
            label4.TabIndex = 29;
            label4.Text = "Valor total dos contratos:";
            // 
            // frmPesquisaContratosCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 657);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(grdContratosCliente);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmPesquisaContratosCliente";
            Text = "PesquisaContratosCliente";
            ((System.ComponentModel.ISupportInitialize)grdContratosCliente).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPesquisar;
        private DataGridView grdContratosCliente;
        private TextBox txtNome;
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Button btnLimpar;
        private Panel panel2;
        private TextBox txtMaiorAtraso;
        private Label label5;
        private TextBox txtValorTotal;
        private Label label4;
    }
}