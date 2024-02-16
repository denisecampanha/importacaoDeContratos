namespace ImportacaoDeContratos
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog1 = new OpenFileDialog();
            panel1 = new Panel();
            btnSair = new Button();
            btnEntrar = new Button();
            label3 = new Label();
            txtSenha = new TextBox();
            txtLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnSair);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 398);
            panel1.TabIndex = 7;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(401, 327);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(270, 327);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(94, 29);
            btnEntrar.TabIndex = 12;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(214, 41);
            label3.Name = "label3";
            label3.Size = new Size(299, 28);
            label3.TabIndex = 11;
            label3.Text = "IMPORTAÇÃO DE CONTRATOS";
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(255, 210);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(301, 27);
            txtSenha.TabIndex = 10;
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(255, 132);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(301, 27);
            txtLogin.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 213);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 8;
            label2.Text = "Senha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 135);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Login:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "frmLogin";
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Panel panel1;
        private Button btnSair;
        private Button btnEntrar;
        private Label label3;
        private TextBox txtSenha;
        private TextBox txtLogin;
        private Label label2;
        private Label label1;
    }
}
