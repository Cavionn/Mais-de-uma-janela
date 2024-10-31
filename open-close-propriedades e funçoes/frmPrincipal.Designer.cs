namespace open_close_propriedades_e_funçoes
{
    partial class frmPrincipal
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
            btnCadastro1 = new Button();
            btnCadastro2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCadastro1
            // 
            btnCadastro1.Location = new Point(26, 22);
            btnCadastro1.Name = "btnCadastro1";
            btnCadastro1.Size = new Size(112, 34);
            btnCadastro1.TabIndex = 0;
            btnCadastro1.Text = "Cadastro1";
            btnCadastro1.UseVisualStyleBackColor = true;
            btnCadastro1.Click += btnCadastro1_Click;
            // 
            // btnCadastro2
            // 
            btnCadastro2.Location = new Point(144, 22);
            btnCadastro2.Name = "btnCadastro2";
            btnCadastro2.Size = new Size(112, 34);
            btnCadastro2.TabIndex = 1;
            btnCadastro2.Text = "Cadastro2";
            btnCadastro2.UseVisualStyleBackColor = true;
            btnCadastro2.Click += btnCadastro2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(578, 22);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(26, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(664, 262);
            dataGridView1.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 366);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(btnCadastro2);
            Controls.Add(btnCadastro1);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema finaceiro 1.0";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastro1;
        private Button btnCadastro2;
        private Button button1;
        private DataGridView dataGridView1;
    }
}