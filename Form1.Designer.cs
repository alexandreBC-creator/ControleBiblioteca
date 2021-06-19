
namespace ControleBiblioteca {
    partial class Form1 {
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
            this.tabInicio = new System.Windows.Forms.TabPage();
            this.tabPessoas = new System.Windows.Forms.TabPage();
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
            this.txtDtnasc = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPessoasCadastradas = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.tabLivros = new System.Windows.Forms.TabPage();
            this.btnCancelarCL = new System.Windows.Forms.Button();
            this.btnSalvarLivro = new System.Windows.Forms.Button();
            this.txtDataEntrada = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDescricaoLivro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabLivrosCadastrados = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.tabAluguel = new System.Windows.Forms.TabPage();
            this.btnSalvarAluguel = new System.Windows.Forms.Button();
            this.btnCancelarA = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.cmbLivroAlugado = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbPessoa = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabRanking = new System.Windows.Forms.TabPage();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label25 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPessoas.SuspendLayout();
            this.tabPessoasCadastradas.SuspendLayout();
            this.tabLivros.SuspendLayout();
            this.tabLivrosCadastrados.SuspendLayout();
            this.tabAluguel.SuspendLayout();
            this.tabRanking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInicio);
            this.tabControl1.Controls.Add(this.tabPessoas);
            this.tabControl1.Controls.Add(this.tabPessoasCadastradas);
            this.tabControl1.Controls.Add(this.tabLivros);
            this.tabControl1.Controls.Add(this.tabLivrosCadastrados);
            this.tabControl1.Controls.Add(this.tabAluguel);
            this.tabControl1.Controls.Add(this.tabRanking);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 349);
            this.tabControl1.TabIndex = 0;
            // 
            // tabInicio
            // 
            this.tabInicio.Location = new System.Drawing.Point(4, 24);
            this.tabInicio.Name = "tabInicio";
            this.tabInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tabInicio.Size = new System.Drawing.Size(791, 321);
            this.tabInicio.TabIndex = 0;
            this.tabInicio.Text = "Página Inicial";
            this.tabInicio.UseVisualStyleBackColor = true;
            // 
            // tabPessoas
            // 
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
            this.tabPessoas.Controls.Add(this.txtDtnasc);
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
            this.tabPessoas.Size = new System.Drawing.Size(791, 321);
            this.tabPessoas.TabIndex = 1;
            this.tabPessoas.Text = "Cadastro de Pessoas";
            this.tabPessoas.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCP
            // 
            this.btnCancelarCP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCP.BackColor = System.Drawing.Color.Red;
            this.btnCancelarCP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarCP.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarCP.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarCP.Location = new System.Drawing.Point(384, 207);
            this.btnCancelarCP.Name = "btnCancelarCP";
            this.btnCancelarCP.Size = new System.Drawing.Size(115, 47);
            this.btnCancelarCP.TabIndex = 22;
            this.btnCancelarCP.Text = "Cancelar";
            this.btnCancelarCP.UseCompatibleTextRendering = true;
            this.btnCancelarCP.UseVisualStyleBackColor = false;
            // 
            // btnSalvarPessoa
            // 
            this.btnSalvarPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarPessoa.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvarPessoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarPessoa.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarPessoa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarPessoa.Location = new System.Drawing.Point(240, 207);
            this.btnSalvarPessoa.Name = "btnSalvarPessoa";
            this.btnSalvarPessoa.Size = new System.Drawing.Size(115, 47);
            this.btnSalvarPessoa.TabIndex = 21;
            this.btnSalvarPessoa.Text = "Cadastrar";
            this.btnSalvarPessoa.UseCompatibleTextRendering = true;
            this.btnSalvarPessoa.UseVisualStyleBackColor = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.Location = new System.Drawing.Point(493, 172);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(261, 29);
            this.txtCidade.TabIndex = 20;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEstado.Location = new System.Drawing.Point(384, 172);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(99, 29);
            this.txtEstado.TabIndex = 19;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.Location = new System.Drawing.Point(493, 116);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(261, 29);
            this.txtBairro.TabIndex = 18;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(384, 116);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(99, 29);
            this.txtNumero.TabIndex = 17;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogradouro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogradouro.Location = new System.Drawing.Point(384, 60);
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
            this.label11.Location = new System.Drawing.Point(493, 92);
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
            this.label9.Location = new System.Drawing.Point(384, 148);
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
            this.label8.Location = new System.Drawing.Point(384, 92);
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
            this.label7.Location = new System.Drawing.Point(384, 36);
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
            // txtDtnasc
            // 
            this.txtDtnasc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDtnasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDtnasc.Location = new System.Drawing.Point(176, 116);
            this.txtDtnasc.Name = "txtDtnasc";
            this.txtDtnasc.Size = new System.Drawing.Size(179, 29);
            this.txtDtnasc.TabIndex = 8;
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
            // tabPessoasCadastradas
            // 
            this.tabPessoasCadastradas.Controls.Add(this.dgvPessoas);
            this.tabPessoasCadastradas.Controls.Add(this.label23);
            this.tabPessoasCadastradas.Location = new System.Drawing.Point(4, 24);
            this.tabPessoasCadastradas.Name = "tabPessoasCadastradas";
            this.tabPessoasCadastradas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPessoasCadastradas.Size = new System.Drawing.Size(791, 321);
            this.tabPessoasCadastradas.TabIndex = 5;
            this.tabPessoasCadastradas.Text = "Pessoas Cadastradas";
            this.tabPessoasCadastradas.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(6, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(210, 30);
            this.label23.TabIndex = 1;
            this.label23.Text = "Pessoas Cadastradas";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabLivros
            // 
            this.tabLivros.Controls.Add(this.btnCancelarCL);
            this.tabLivros.Controls.Add(this.btnSalvarLivro);
            this.tabLivros.Controls.Add(this.txtDataEntrada);
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
            this.tabLivros.Size = new System.Drawing.Size(791, 321);
            this.tabLivros.TabIndex = 2;
            this.tabLivros.Text = "Cadastro de Livros";
            this.tabLivros.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCL
            // 
            this.btnCancelarCL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarCL.BackColor = System.Drawing.Color.Red;
            this.btnCancelarCL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarCL.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarCL.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarCL.Location = new System.Drawing.Point(379, 147);
            this.btnCancelarCL.Name = "btnCancelarCL";
            this.btnCancelarCL.Size = new System.Drawing.Size(115, 47);
            this.btnCancelarCL.TabIndex = 23;
            this.btnCancelarCL.Text = "Cancelar";
            this.btnCancelarCL.UseCompatibleTextRendering = true;
            this.btnCancelarCL.UseVisualStyleBackColor = false;
            // 
            // btnSalvarLivro
            // 
            this.btnSalvarLivro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarLivro.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvarLivro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarLivro.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarLivro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarLivro.Location = new System.Drawing.Point(240, 147);
            this.btnSalvarLivro.Name = "btnSalvarLivro";
            this.btnSalvarLivro.Size = new System.Drawing.Size(115, 47);
            this.btnSalvarLivro.TabIndex = 22;
            this.btnSalvarLivro.Text = "Cadastrar";
            this.btnSalvarLivro.UseCompatibleTextRendering = true;
            this.btnSalvarLivro.UseVisualStyleBackColor = false;
            // 
            // txtDataEntrada
            // 
            this.txtDataEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataEntrada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDataEntrada.Location = new System.Drawing.Point(379, 112);
            this.txtDataEntrada.Name = "txtDataEntrada";
            this.txtDataEntrada.Size = new System.Drawing.Size(347, 29);
            this.txtDataEntrada.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(379, 88);
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
            this.txtCategoria.Size = new System.Drawing.Size(347, 29);
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
            this.txtAutor.Location = new System.Drawing.Point(379, 56);
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
            this.label14.Location = new System.Drawing.Point(379, 33);
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
            this.txtDescricaoLivro.Size = new System.Drawing.Size(347, 29);
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
            // tabLivrosCadastrados
            // 
            this.tabLivrosCadastrados.Controls.Add(this.dataGridView1);
            this.tabLivrosCadastrados.Controls.Add(this.label24);
            this.tabLivrosCadastrados.Location = new System.Drawing.Point(4, 24);
            this.tabLivrosCadastrados.Name = "tabLivrosCadastrados";
            this.tabLivrosCadastrados.Padding = new System.Windows.Forms.Padding(3);
            this.tabLivrosCadastrados.Size = new System.Drawing.Size(791, 321);
            this.tabLivrosCadastrados.TabIndex = 6;
            this.tabLivrosCadastrados.Text = "Livros Cadastrados";
            this.tabLivrosCadastrados.UseVisualStyleBackColor = true;
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
            // tabAluguel
            // 
            this.tabAluguel.Controls.Add(this.btnSalvarAluguel);
            this.tabAluguel.Controls.Add(this.btnCancelarA);
            this.tabAluguel.Controls.Add(this.label22);
            this.tabAluguel.Controls.Add(this.label21);
            this.tabAluguel.Controls.Add(this.maskedTextBox2);
            this.tabAluguel.Controls.Add(this.maskedTextBox1);
            this.tabAluguel.Controls.Add(this.cmbLivroAlugado);
            this.tabAluguel.Controls.Add(this.label20);
            this.tabAluguel.Controls.Add(this.cmbPessoa);
            this.tabAluguel.Controls.Add(this.label19);
            this.tabAluguel.Controls.Add(this.textBox1);
            this.tabAluguel.Controls.Add(this.label18);
            this.tabAluguel.Controls.Add(this.label17);
            this.tabAluguel.Location = new System.Drawing.Point(4, 24);
            this.tabAluguel.Name = "tabAluguel";
            this.tabAluguel.Padding = new System.Windows.Forms.Padding(3);
            this.tabAluguel.Size = new System.Drawing.Size(791, 321);
            this.tabAluguel.TabIndex = 3;
            this.tabAluguel.Text = "Alugueis";
            this.tabAluguel.UseVisualStyleBackColor = true;
            // 
            // btnSalvarAluguel
            // 
            this.btnSalvarAluguel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvarAluguel.BackColor = System.Drawing.Color.LightGreen;
            this.btnSalvarAluguel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarAluguel.ForeColor = System.Drawing.Color.Black;
            this.btnSalvarAluguel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalvarAluguel.Location = new System.Drawing.Point(245, 148);
            this.btnSalvarAluguel.Name = "btnSalvarAluguel";
            this.btnSalvarAluguel.Size = new System.Drawing.Size(115, 47);
            this.btnSalvarAluguel.TabIndex = 29;
            this.btnSalvarAluguel.Text = "Cadastrar";
            this.btnSalvarAluguel.UseCompatibleTextRendering = true;
            this.btnSalvarAluguel.UseVisualStyleBackColor = false;
            // 
            // btnCancelarA
            // 
            this.btnCancelarA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarA.BackColor = System.Drawing.Color.Red;
            this.btnCancelarA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarA.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarA.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarA.Location = new System.Drawing.Point(383, 148);
            this.btnCancelarA.Name = "btnCancelarA";
            this.btnCancelarA.Size = new System.Drawing.Size(115, 47);
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
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox2.Location = new System.Drawing.Point(187, 113);
            this.maskedTextBox2.Mask = "00/00/0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(173, 29);
            this.maskedTextBox2.TabIndex = 25;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(8, 113);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(173, 29);
            this.maskedTextBox1.TabIndex = 24;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
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
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(383, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 29);
            this.textBox1.TabIndex = 8;
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
            // tabRanking
            // 
            this.tabRanking.Controls.Add(this.label25);
            this.tabRanking.Controls.Add(this.dataGridView2);
            this.tabRanking.Location = new System.Drawing.Point(4, 24);
            this.tabRanking.Name = "tabRanking";
            this.tabRanking.Padding = new System.Windows.Forms.Padding(3);
            this.tabRanking.Size = new System.Drawing.Size(791, 321);
            this.tabRanking.TabIndex = 4;
            this.tabRanking.Text = "Livros mais alugados";
            this.tabRanking.UseVisualStyleBackColor = true;
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Location = new System.Drawing.Point(6, 36);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.RowTemplate.Height = 25;
            this.dgvPessoas.Size = new System.Drawing.Size(779, 271);
            this.dgvPessoas.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(779, 271);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(779, 271);
            this.dataGridView2.TabIndex = 3;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(8, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(339, 30);
            this.label25.TabIndex = 4;
            this.label25.Text = "Ranking de Livros mais Alugados";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPessoas.ResumeLayout(false);
            this.tabPessoas.PerformLayout();
            this.tabPessoasCadastradas.ResumeLayout(false);
            this.tabPessoasCadastradas.PerformLayout();
            this.tabLivros.ResumeLayout(false);
            this.tabLivros.PerformLayout();
            this.tabLivrosCadastrados.ResumeLayout(false);
            this.tabLivrosCadastrados.PerformLayout();
            this.tabAluguel.ResumeLayout(false);
            this.tabAluguel.PerformLayout();
            this.tabRanking.ResumeLayout(false);
            this.tabRanking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInicio;
        private System.Windows.Forms.TabPage tabPessoas;
        private System.Windows.Forms.TabPage tabLivros;
        private System.Windows.Forms.TabPage tabAluguel;
        private System.Windows.Forms.TabPage tabRanking;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtDtnasc;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDataEntrada;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDescricaoLivro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox cmbLivroAlugado;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbPessoa;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tabPessoasCadastradas;
        private System.Windows.Forms.TabPage tabLivrosCadastrados;
        private System.Windows.Forms.Button btnSalvarPessoa;
        private System.Windows.Forms.Button btnCancelarCP;
        private System.Windows.Forms.Button btnCancelarCL;
        private System.Windows.Forms.Button btnSalvarLivro;
        private System.Windows.Forms.Button btnSalvarAluguel;
        private System.Windows.Forms.Button btnCancelarA;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

