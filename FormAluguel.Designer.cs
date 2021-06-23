
namespace ControleBiblioteca {
    partial class FormAluguel {
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
            this.tabAlugueisCadastrados = new System.Windows.Forms.TabPage();
            this.btnNovoAluguel = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabAluguel = new System.Windows.Forms.TabPage();
            this.txtDataSaida = new System.Windows.Forms.DateTimePicker();
            this.txtDataRetorno = new System.Windows.Forms.DateTimePicker();
            this.btnSalvarAluguel = new System.Windows.Forms.Button();
            this.btnCancelarA = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbLivroAlugado = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbPessoa = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabAlugueisCadastrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabAluguel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAlugueisCadastrados);
            this.tabControl1.Controls.Add(this.tabAluguel);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAlugueisCadastrados
            // 
            this.tabAlugueisCadastrados.Controls.Add(this.btnNovoAluguel);
            this.tabAlugueisCadastrados.Controls.Add(this.label25);
            this.tabAlugueisCadastrados.Controls.Add(this.dataGridView2);
            this.tabAlugueisCadastrados.Location = new System.Drawing.Point(4, 24);
            this.tabAlugueisCadastrados.Name = "tabAlugueisCadastrados";
            this.tabAlugueisCadastrados.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlugueisCadastrados.Size = new System.Drawing.Size(791, 381);
            this.tabAlugueisCadastrados.TabIndex = 4;
            this.tabAlugueisCadastrados.Text = "Alugueis";
            this.tabAlugueisCadastrados.UseVisualStyleBackColor = true;
            // 
            // btnNovoAluguel
            // 
            this.btnNovoAluguel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoAluguel.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoAluguel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoAluguel.ForeColor = System.Drawing.Color.Black;
            this.btnNovoAluguel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoAluguel.Location = new System.Drawing.Point(3, 36);
            this.btnNovoAluguel.Name = "btnNovoAluguel";
            this.btnNovoAluguel.Size = new System.Drawing.Size(115, 38);
            this.btnNovoAluguel.TabIndex = 31;
            this.btnNovoAluguel.Text = "Novo";
            this.btnNovoAluguel.UseCompatibleTextRendering = true;
            this.btnNovoAluguel.UseVisualStyleBackColor = false;
            this.btnNovoAluguel.Click += new System.EventHandler(this.btnNovoAluguel_Click);
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(8, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(216, 30);
            this.label25.TabIndex = 4;
            this.label25.Text = "Registro de Alugueis";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(779, 295);
            this.dataGridView2.TabIndex = 3;
            // 
            // tabAluguel
            // 
            this.tabAluguel.Controls.Add(this.txtDataSaida);
            this.tabAluguel.Controls.Add(this.txtDataRetorno);
            this.tabAluguel.Controls.Add(this.btnSalvarAluguel);
            this.tabAluguel.Controls.Add(this.btnCancelarA);
            this.tabAluguel.Controls.Add(this.label22);
            this.tabAluguel.Controls.Add(this.label21);
            this.tabAluguel.Controls.Add(this.cmbLivroAlugado);
            this.tabAluguel.Controls.Add(this.label20);
            this.tabAluguel.Controls.Add(this.cmbPessoa);
            this.tabAluguel.Controls.Add(this.label19);
            this.tabAluguel.Controls.Add(this.txtValor);
            this.tabAluguel.Controls.Add(this.label18);
            this.tabAluguel.Controls.Add(this.label17);
            this.tabAluguel.Location = new System.Drawing.Point(4, 24);
            this.tabAluguel.Name = "tabAluguel";
            this.tabAluguel.Padding = new System.Windows.Forms.Padding(3);
            this.tabAluguel.Size = new System.Drawing.Size(791, 381);
            this.tabAluguel.TabIndex = 3;
            this.tabAluguel.Text = "Registrar Aluguel";
            this.tabAluguel.UseVisualStyleBackColor = true;
            // 
            // txtDataSaida
            // 
            this.txtDataSaida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataSaida.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataSaida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataSaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataSaida.Location = new System.Drawing.Point(13, 113);
            this.txtDataSaida.Name = "txtDataSaida";
            this.txtDataSaida.Size = new System.Drawing.Size(168, 29);
            this.txtDataSaida.TabIndex = 31;
            // 
            // txtDataRetorno
            // 
            this.txtDataRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataRetorno.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataRetorno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataRetorno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataRetorno.Location = new System.Drawing.Point(187, 113);
            this.txtDataRetorno.Name = "txtDataRetorno";
            this.txtDataRetorno.Size = new System.Drawing.Size(168, 29);
            this.txtDataRetorno.TabIndex = 30;
            // 
            // btnSalvarAluguel
            // 
            this.btnSalvarAluguel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAluguel.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarAluguel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarAluguel.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarAluguel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarAluguel.Location = new System.Drawing.Point(610, 148);
            this.btnSalvarAluguel.Name = "btnSalvarAluguel";
            this.btnSalvarAluguel.Size = new System.Drawing.Size(115, 38);
            this.btnSalvarAluguel.TabIndex = 29;
            this.btnSalvarAluguel.Text = "Cadastrar";
            this.btnSalvarAluguel.UseCompatibleTextRendering = true;
            this.btnSalvarAluguel.UseVisualStyleBackColor = false;
            this.btnSalvarAluguel.Click += new System.EventHandler(this.btnSalvarAluguel_Click);
            // 
            // btnCancelarA
            // 
            this.btnCancelarA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarA.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarA.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarA.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarA.Location = new System.Drawing.Point(610, 192);
            this.btnCancelarA.Name = "btnCancelarA";
            this.btnCancelarA.Size = new System.Drawing.Size(115, 38);
            this.btnCancelarA.TabIndex = 28;
            this.btnCancelarA.Text = "Cancelar";
            this.btnCancelarA.UseCompatibleTextRendering = true;
            this.btnCancelarA.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(383, 89);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(138, 21);
            this.label22.TabIndex = 27;
            this.label22.Text = "Valor do Aluguel";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(187, 89);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(107, 21);
            this.label21.TabIndex = 26;
            this.label21.Text = "Data retorno";
            // 
            // cmbLivroAlugado
            // 
            this.cmbLivroAlugado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLivroAlugado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLivroAlugado.FormattingEnabled = true;
            this.cmbLivroAlugado.Location = new System.Drawing.Point(383, 57);
            this.cmbLivroAlugado.Name = "cmbLivroAlugado";
            this.cmbLivroAlugado.Size = new System.Drawing.Size(342, 29);
            this.cmbLivroAlugado.TabIndex = 23;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(383, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 21);
            this.label20.TabIndex = 22;
            this.label20.Text = "Livro";
            // 
            // cmbPessoa
            // 
            this.cmbPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPessoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPessoa.FormattingEnabled = true;
            this.cmbPessoa.Location = new System.Drawing.Point(8, 57);
            this.cmbPessoa.Name = "cmbPessoa";
            this.cmbPessoa.Size = new System.Drawing.Size(347, 29);
            this.cmbPessoa.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(8, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 21);
            this.label19.TabIndex = 9;
            this.label19.Text = "Pessoa";
            // 
            // txtValor
            // 
            this.txtValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtValor.Location = new System.Drawing.Point(383, 113);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(342, 29);
            this.txtValor.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(8, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 21);
            this.label18.TabIndex = 5;
            this.label18.Text = "Data saída";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(287, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(188, 30);
            this.label17.TabIndex = 4;
            this.label17.Text = "Cadastrar Aluguel";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAluguel";
            this.Text = "Controle de Alugueis";
            this.tabControl1.ResumeLayout(false);
            this.tabAlugueisCadastrados.ResumeLayout(false);
            this.tabAlugueisCadastrados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabAluguel.ResumeLayout(false);
            this.tabAluguel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAluguel;
        private System.Windows.Forms.TabPage tabAlugueisCadastrados;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbLivroAlugado;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbPessoa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnSalvarAluguel;
        private System.Windows.Forms.Button btnCancelarA;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnNovoAluguel;
        private System.Windows.Forms.DateTimePicker txtDataSaida;
        private System.Windows.Forms.DateTimePicker txtDataRetorno;
    }
}

