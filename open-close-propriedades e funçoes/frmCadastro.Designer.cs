namespace open_close_propriedades_e_funçoes
{
    partial class frmCadastro
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
            btnFechar = new Button();
            txtNome = new TextBox();
            label1 = new Label();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(146, 137);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(146, 44);
            btnFechar.TabIndex = 0;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(213, 31);
            txtNome.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(95, 66);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(197, 31);
            txtTelefone.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(79, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(213, 31);
            txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 5;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 100);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 234);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefone);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Controls.Add(btnFechar);
            Name = "frmCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFechar;
        private TextBox txtNome;
        private Label label1;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Label label2;
        private Label label3;
    }
}