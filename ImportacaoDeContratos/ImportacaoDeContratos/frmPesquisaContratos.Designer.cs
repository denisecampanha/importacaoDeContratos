namespace ImportacaoDeContratos
{
    partial class frmPesquisaContratos
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
            btnPesquisar = new Button();
            grdContratos = new DataGridView();
            radData = new RadioButton();
            radTodos = new RadioButton();
            txtVecto = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)grdContratos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(319, 19);
            label3.Name = "label3";
            label3.Size = new Size(230, 28);
            label3.TabIndex = 6;
            label3.Text = "PESQUISA CONTRATOS";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(665, 88);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(94, 29);
            btnPesquisar.TabIndex = 20;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += this.btnPesquisar_Click;
            // 
            // grdContratos
            // 
            grdContratos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdContratos.Location = new Point(43, 177);
            grdContratos.Name = "grdContratos";
            grdContratos.RowHeadersWidth = 51;
            grdContratos.Size = new Size(891, 436);
            grdContratos.TabIndex = 19;
            // 
            // radData
            // 
            radData.AutoSize = true;
            radData.Location = new Point(22, 93);
            radData.Name = "radData";
            radData.Size = new Size(133, 24);
            radData.TabIndex = 18;
            radData.Text = "Por Vencimento";
            radData.UseVisualStyleBackColor = true;
            // 
            // radTodos
            // 
            radTodos.AutoSize = true;
            radTodos.Location = new Point(22, 63);
            radTodos.Name = "radTodos";
            radTodos.Size = new Size(70, 24);
            radTodos.TabIndex = 17;
            radTodos.Text = "Todos";
            radTodos.UseVisualStyleBackColor = true;
            // 
            // txtVecto
            // 
            txtVecto.Location = new Point(161, 93);
            txtVecto.Name = "txtVecto";
            txtVecto.Size = new Size(133, 27);
            txtVecto.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 154);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnLimpar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(radData);
            panel1.Controls.Add(btnPesquisar);
            panel1.Controls.Add(radTodos);
            panel1.Controls.Add(txtVecto);
            panel1.Location = new Point(43, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 136);
            panel1.TabIndex = 21;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(765, 88);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 30;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // frmPesquisaContratos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 647);
            Controls.Add(panel1);
            Controls.Add(grdContratos);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmPesquisaContratos";
            Text = "PesquisaContratos";
            ((System.ComponentModel.ISupportInitialize)grdContratos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnPesquisar;
        private DataGridView grdContratos;
        private RadioButton radData;
        private RadioButton radTodos;
        private TextBox txtVecto;
        private Label label1;
        private Panel panel1;
        private Button btnLimpar;
    }
}