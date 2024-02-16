namespace ImportacaoDeContratos
{
    partial class frmPesquisaArquivos
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
            label3 = new Label();
            txtData = new TextBox();
            label1 = new Label();
            radTodos = new RadioButton();
            radData = new RadioButton();
            grdArquivos = new DataGridView();
            btnPesquisar = new Button();
            panel1 = new Panel();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdArquivos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(252, 15);
            label3.Name = "label3";
            label3.Size = new Size(350, 28);
            label3.TabIndex = 7;
            label3.Text = "PESQUISA ARQUIVOS IMPORTADOS";
            // 
            // txtData
            // 
            txtData.Location = new Point(129, 93);
            txtData.Name = "txtData";
            txtData.Size = new Size(133, 27);
            txtData.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 175);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // radTodos
            // 
            radTodos.AutoSize = true;
            radTodos.Location = new Point(19, 63);
            radTodos.Name = "radTodos";
            radTodos.Size = new Size(70, 24);
            radTodos.TabIndex = 10;
            radTodos.Text = "Todos";
            radTodos.UseVisualStyleBackColor = true;
            // 
            // radData
            // 
            radData.AutoSize = true;
            radData.Location = new Point(19, 93);
            radData.Name = "radData";
            radData.Size = new Size(87, 24);
            radData.TabIndex = 11;
            radData.Text = "Por Data";
            radData.UseVisualStyleBackColor = true;
            // 
            // grdArquivos
            // 
            grdArquivos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdArquivos.Location = new Point(30, 198);
            grdArquivos.Name = "grdArquivos";
            grdArquivos.RowHeadersWidth = 51;
            grdArquivos.Size = new Size(891, 436);
            grdArquivos.TabIndex = 12;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(673, 93);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 13;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += this.btnPesquisar_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(txtData);
            panel1.Controls.Add(radTodos);
            panel1.Controls.Add(radData);
            panel1.Location = new Point(30, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 141);
            panel1.TabIndex = 14;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(773, 93);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 31;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmPesquisaArquivos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 654);
            Controls.Add(panel1);
            Controls.Add(grdArquivos);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmPesquisaArquivos";
            Text = "PesquisaArquivos";
            ((System.ComponentModel.ISupportInitialize)grdArquivos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox txtData;
        private Label label1;
        private RadioButton radTodos;
        private RadioButton radData;
        private DataGridView grdArquivos;
        private Button btnPesquisar;
        private Panel panel1;
        private Button btnLimpar;
    }
}