
namespace ControleBiblioteca {
    partial class FormLivro {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLivrosCadastrados = new System.Windows.Forms.TabPage();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label24 = new System.Windows.Forms.Label();
            this.tabLivros = new System.Windows.Forms.TabPage();
            this.txtDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarCL = new System.Windows.Forms.Button();
            this.btnSalvarLivro = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescricaoLivro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLivrosCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabLivros.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLivrosCadastrados);
            this.tabControl1.Controls.Add(this.tabLivros);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLivrosCadastrados
            // 
            this.tabLivrosCadastrados.Controls.Add(this.btnNovoLivro);
            this.tabLivrosCadastrados.Controls.Add(this.dataGridView1);
            this.tabLivrosCadastrados.Controls.Add(this.label24);
            this.tabLivrosCadastrados.Location = new System.Drawing.Point(4, 24);
            this.tabLivrosCadastrados.Name = "tabLivrosCadastrados";
            this.tabLivrosCadastrados.Padding = new System.Windows.Forms.Padding(3);
            this.tabLivrosCadastrados.Size = new System.Drawing.Size(791, 381);
            this.tabLivrosCadastrados.TabIndex = 6;
            this.tabLivrosCadastrados.Text = "Livros Cadastrados";
            this.tabLivrosCadastrados.UseVisualStyleBackColor = true;
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoLivro.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoLivro.ForeColor = System.Drawing.Color.Black;
            this.btnNovoLivro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoLivro.Location = new System.Drawing.Point(3, 36);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Size = new System.Drawing.Size(115, 38);
            this.btnNovoLivro.TabIndex = 31;
            this.btnNovoLivro.Text = "Novo";
            this.btnNovoLivro.UseCompatibleTextRendering = true;
            this.btnNovoLivro.UseVisualStyleBackColor = false;
            this.btnNovoLivro.Click += new System.EventHandler(this.btnNovoLivro_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(779, 295);
            this.dataGridView1.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(6, 3);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(196, 30);
            this.label24.TabIndex = 2;
            this.label24.Text = "Livros Cadastrados";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabLivros
            // 
            this.tabLivros.Controls.Add(this.txtDataEntrada);
            this.tabLivros.Controls.Add(this.btnCancelarCL);
            this.tabLivros.Controls.Add(this.btnSalvarLivro);
            this.tabLivros.Controls.Add(this.label16);
            this.tabLivros.Controls.Add(this.txtCategoria);
            this.tabLivros.Controls.Add(this.label15);
            this.tabLivros.Controls.Add(this.txtAutor);
            this.tabLivros.Controls.Add(this.label14);
            this.tabLivros.Controls.Add(this.txtDescricaoLivro);
            this.tabLivros.Controls.Add(this.label13);
            this.tabLivros.Controls.Add(this.label12);
            this.tabLivros.Location = new System.Drawing.Point(4, 24);
            this.tabLivros.Name = "tabLivros";
            this.tabLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLivros.Size = new System.Drawing.Size(791, 381);
            this.tabLivros.TabIndex = 2;
            this.tabLivros.Text = "Cadastro de Livros";
            this.tabLivros.UseVisualStyleBackColor = true;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataEntrada.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataEntrada.Location = new System.Drawing.Point(390, 112);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(347, 29);
            this.txtDataEntrada.TabIndex = 26;
            // 
            // btnCancelarCL
            // 
            this.btnCancelarCL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCL.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarCL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarCL.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarCL.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarCL.Location = new System.Drawing.Point(622, 193);
            this.btnCancelarCL.Name = "btnCancelarCL";
            this.btnCancelarCL.Size = new System.Drawing.Size(115, 40);
            this.btnCancelarCL.TabIndex = 23;
            this.btnCancelarCL.Text = "Cancelar";
            this.btnCancelarCL.UseCompatibleTextRendering = true;
            this.btnCancelarCL.UseVisualStyleBackColor = false;
            // 
            // btnSalvarLivro
            // 
            this.btnSalvarLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarLivro.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarLivro.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarLivro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarLivro.Location = new System.Drawing.Point(622, 147);
            this.btnSalvarLivro.Name = "btnSalvarLivro";
            this.btnSalvarLivro.Size = new System.Drawing.Size(115, 40);
            this.btnSalvarLivro.TabIndex = 22;
            this.btnSalvarLivro.Text = "Cadastrar";
            this.btnSalvarLivro.UseCompatibleTextRendering = true;
            this.btnSalvarLivro.UseVisualStyleBackColor = false;
            this.btnSalvarLivro.Click += new System.EventHandler(this.btnSalvarLivro_Click);
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(390, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 21);
            this.label16.TabIndex = 12;
            this.label16.Text = "Data entrada";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCategoria.Location = new System.Drawing.Point(8, 112);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(366, 29);
            this.txtCategoria.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(8, 88);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 21);
            this.label15.TabIndex = 10;
            this.label15.Text = "Categoria";
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAutor.Location = new System.Drawing.Point(390, 56);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(347, 29);
            this.txtAutor.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(386, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 21);
            this.label14.TabIndex = 8;
            this.label14.Text = "Autor";
            // 
            // txtDescricaoLivro
            // 
            this.txtDescricaoLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricaoLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescricaoLivro.Location = new System.Drawing.Point(8, 56);
            this.txtDescricaoLivro.Name = "txtDescricaoLivro";
            this.txtDescricaoLivro.Size = new System.Drawing.Size(366, 29);
            this.txtDescricaoLivro.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(293, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 30);
            this.label13.TabIndex = 3;
            this.label13.Text = "Novo cadastro";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(8, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Descrição";
            // 
            // FormLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormLivro";
            this.Text = "Controle de Alugueis";
            this.tabControl1.ResumeLayout(false);
            this.tabLivrosCadastrados.ResumeLayout(false);
            this.tabLivrosCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabLivros.ResumeLayout(false);
            this.tabLivros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLivros;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescricaoLivro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabLivrosCadastrados;
        private System.Windows.Forms.Button btnCancelarCL;
        private System.Windows.Forms.Button btnSalvarLivro;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovoLivro;
        private System.Windows.Forms.DateTimePicker txtDataEntrada;
    }
}

