
namespace ControleBiblioteca {
    partial class FormPessoa {
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
            this.tabPessoasCadastradas = new System.Windows.Forms.TabPage();
            this.btnNovoPessoa = new System.Windows.Forms.Button();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.label23 = new System.Windows.Forms.Label();
            this.tabPessoas = new System.Windows.Forms.TabPage();
            this.txtDataNasc = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarCP = new System.Windows.Forms.Button();
            this.btnSalvarPessoa = new System.Windows.Forms.Button();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPessoasCadastradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            this.tabPessoas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPessoasCadastradas);
            this.tabControl1.Controls.Add(this.tabPessoas);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPessoasCadastradas
            // 
            this.tabPessoasCadastradas.Controls.Add(this.btnNovoPessoa);
            this.tabPessoasCadastradas.Controls.Add(this.dgvPessoas);
            this.tabPessoasCadastradas.Controls.Add(this.label23);
            this.tabPessoasCadastradas.Location = new System.Drawing.Point(4, 24);
            this.tabPessoasCadastradas.Name = "tabPessoasCadastradas";
            this.tabPessoasCadastradas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPessoasCadastradas.Size = new System.Drawing.Size(791, 381);
            this.tabPessoasCadastradas.TabIndex = 5;
            this.tabPessoasCadastradas.Text = "Pessoas Cadastradas";
            this.tabPessoasCadastradas.UseVisualStyleBackColor = true;
            // 
            // btnNovoPessoa
            // 
            this.btnNovoPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoPessoa.BackColor = System.Drawing.Color.Transparent;
            this.btnNovoPessoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNovoPessoa.ForeColor = System.Drawing.Color.Black;
            this.btnNovoPessoa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNovoPessoa.Location = new System.Drawing.Point(3, 32);
            this.btnNovoPessoa.Name = "btnNovoPessoa";
            this.btnNovoPessoa.Size = new System.Drawing.Size(115, 38);
            this.btnNovoPessoa.TabIndex = 30;
            this.btnNovoPessoa.Text = "Novo";
            this.btnNovoPessoa.UseCompatibleTextRendering = true;
            this.btnNovoPessoa.UseVisualStyleBackColor = false;
            this.btnNovoPessoa.Click += new System.EventHandler(this.btnNovoPessoa_Click);
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Location = new System.Drawing.Point(3, 76);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.RowTemplate.Height = 25;
            this.dgvPessoas.Size = new System.Drawing.Size(779, 299);
            this.dgvPessoas.TabIndex = 2;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(3, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(210, 30);
            this.label23.TabIndex = 1;
            this.label23.Text = "Pessoas Cadastradas";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPessoas
            // 
            this.tabPessoas.Controls.Add(this.txtDataNasc);
            this.tabPessoas.Controls.Add(this.btnCancelarCP);
            this.tabPessoas.Controls.Add(this.btnSalvarPessoa);
            this.tabPessoas.Controls.Add(this.txtCidade);
            this.tabPessoas.Controls.Add(this.txtEstado);
            this.tabPessoas.Controls.Add(this.txtBairro);
            this.tabPessoas.Controls.Add(this.txtNumero);
            this.tabPessoas.Controls.Add(this.txtLogradouro);
            this.tabPessoas.Controls.Add(this.label11);
            this.tabPessoas.Controls.Add(this.label10);
            this.tabPessoas.Controls.Add(this.label9);
            this.tabPessoas.Controls.Add(this.label8);
            this.tabPessoas.Controls.Add(this.label7);
            this.tabPessoas.Controls.Add(this.txtEmail);
            this.tabPessoas.Controls.Add(this.txtTelefone);
            this.tabPessoas.Controls.Add(this.txtCpf);
            this.tabPessoas.Controls.Add(this.txtNome);
            this.tabPessoas.Controls.Add(this.label6);
            this.tabPessoas.Controls.Add(this.label5);
            this.tabPessoas.Controls.Add(this.label4);
            this.tabPessoas.Controls.Add(this.label3);
            this.tabPessoas.Controls.Add(this.label2);
            this.tabPessoas.Controls.Add(this.label1);
            this.tabPessoas.Location = new System.Drawing.Point(4, 24);
            this.tabPessoas.Name = "tabPessoas";
            this.tabPessoas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPessoas.Size = new System.Drawing.Size(791, 381);
            this.tabPessoas.TabIndex = 1;
            this.tabPessoas.Text = "Cadastro de Pessoas";
            this.tabPessoas.UseVisualStyleBackColor = true;
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataNasc.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataNasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataNasc.Location = new System.Drawing.Point(176, 116);
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(179, 29);
            this.txtDataNasc.TabIndex = 23;
            // 
            // btnCancelarCP
            // 
            this.btnCancelarCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCP.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarCP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarCP.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarCP.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarCP.Location = new System.Drawing.Point(623, 251);
            this.btnCancelarCP.Name = "btnCancelarCP";
            this.btnCancelarCP.Size = new System.Drawing.Size(115, 38);
            this.btnCancelarCP.TabIndex = 22;
            this.btnCancelarCP.Text = "Cancelar";
            this.btnCancelarCP.UseCompatibleTextRendering = true;
            this.btnCancelarCP.UseVisualStyleBackColor = false;
            // 
            // btnSalvarPessoa
            // 
            this.btnSalvarPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarPessoa.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvarPessoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarPessoa.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarPessoa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarPessoa.Location = new System.Drawing.Point(623, 207);
            this.btnSalvarPessoa.Name = "btnSalvarPessoa";
            this.btnSalvarPessoa.Size = new System.Drawing.Size(115, 38);
            this.btnSalvarPessoa.TabIndex = 21;
            this.btnSalvarPessoa.Text = "Cadastrar";
            this.btnSalvarPessoa.UseCompatibleTextRendering = true;
            this.btnSalvarPessoa.UseVisualStyleBackColor = false;
            this.btnSalvarPessoa.Click += new System.EventHandler(this.btnSalvarPessoa_Click);
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(477, 172);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(261, 29);
            this.txtCidade.TabIndex = 20;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEstado.Location = new System.Drawing.Point(368, 172);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(99, 29);
            this.txtEstado.TabIndex = 19;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(477, 116);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(261, 29);
            this.txtBairro.TabIndex = 18;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(368, 116);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(99, 29);
            this.txtNumero.TabIndex = 17;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogradouro.Location = new System.Drawing.Point(368, 60);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(370, 29);
            this.txtLogradouro.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(477, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 21);
            this.label11.TabIndex = 15;
            this.label11.Text = "Bairro";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(493, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Cidade";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(368, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Estado";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(368, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 12;
            this.label8.Text = "Número";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(368, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Logradouro";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(176, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 29);
            this.txtEmail.TabIndex = 10;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTelefone.Location = new System.Drawing.Point(8, 172);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(160, 29);
            this.txtTelefone.TabIndex = 9;
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCpf.Location = new System.Drawing.Point(8, 116);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(160, 29);
            this.txtCpf.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.Location = new System.Drawing.Point(8, 60);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(347, 29);
            this.txtNome.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(176, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(174, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data de nascimento";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome completo";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(282, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Novo cadastro";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPessoa";
            this.Text = "Controle de Alugueis";
            this.tabControl1.ResumeLayout(false);
            this.tabPessoasCadastradas.ResumeLayout(false);
            this.tabPessoasCadastradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            this.tabPessoas.ResumeLayout(false);
            this.tabPessoas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPessoas;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TabPage tabPessoasCadastradas;
        private System.Windows.Forms.Button btnSalvarPessoa;
        private System.Windows.Forms.Button btnCancelarCP;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.Button btnNovoPessoa;
        private System.Windows.Forms.DateTimePicker txtDataNasc;
    }
}

