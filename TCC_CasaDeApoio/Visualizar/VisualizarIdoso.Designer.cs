namespace TCC_CasaDeApoio.Visualizar
{
    partial class VisualizarIdoso
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarIdoso));
            this.pctrbxImagem1 = new System.Windows.Forms.PictureBox();
            this.btnAlterar_Idoso = new System.Windows.Forms.Button();
            this.btnPesquisar_Idosos = new System.Windows.Forms.Button();
            this.txtPesquisar_Idosos = new System.Windows.Forms.TextBox();
            this.lblVisualizar_Idosos = new System.Windows.Forms.Label();
            this.btnLimpar_Idoso = new System.Windows.Forms.Button();
            this.btnExcluir_Idoso = new System.Windows.Forms.Button();
            this.lblEditar_Excluir = new System.Windows.Forms.Label();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.lblTelefone_Emergencia = new System.Windows.Forms.Label();
            this.txtAlterar_Excluir_Telefone_Emergencia = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular_Responsavel = new System.Windows.Forms.Label();
            this.lblTelefone_Responsavel = new System.Windows.Forms.Label();
            this.txtAlterar_Excluir_Celular_Responsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtAlterar_Excluir_Endereco_Responsavel = new System.Windows.Forms.TextBox();
            this.lblEndereco_Responsavel = new System.Windows.Forms.Label();
            this.dttmpckAlterar_Excluir_Data_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.txtAlterar_Excluir_ID_Idoso = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblData_Nascimento = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtAlterar_Excluir_Nome = new System.Windows.Forms.TextBox();
            this.pctrbxImagem2 = new System.Windows.Forms.PictureBox();
            this.dtgrdvwIdosos = new System.Windows.Forms.DataGridView();
            this.idososBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casaDeApoioNossoLarDataSetIdosos = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetIdosos();
            this.txtAlterar_Excluir_Telefone_Responsavel = new System.Windows.Forms.MaskedTextBox();
            this.idososTableAdapter = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetIdososTableAdapters.IdososTableAdapter();
            this.iDIdosoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularResponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneEmergenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwIdosos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idososBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetIdosos)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxImagem1
            // 
            this.pctrbxImagem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbxImagem1.Image = global::TCC_CasaDeApoio.Properties.Resources.WallpapaerCasaDeApoio;
            this.pctrbxImagem1.Location = new System.Drawing.Point(0, 0);
            this.pctrbxImagem1.Name = "pctrbxImagem1";
            this.pctrbxImagem1.Size = new System.Drawing.Size(1296, 679);
            this.pctrbxImagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem1.TabIndex = 0;
            this.pctrbxImagem1.TabStop = false;
            // 
            // btnAlterar_Idoso
            // 
            this.btnAlterar_Idoso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar_Idoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar_Idoso.Location = new System.Drawing.Point(362, 592);
            this.btnAlterar_Idoso.Name = "btnAlterar_Idoso";
            this.btnAlterar_Idoso.Size = new System.Drawing.Size(135, 51);
            this.btnAlterar_Idoso.TabIndex = 119;
            this.btnAlterar_Idoso.Text = "Alterar";
            this.btnAlterar_Idoso.UseVisualStyleBackColor = true;
            this.btnAlterar_Idoso.Click += new System.EventHandler(this.btnAlterar_Idoso_Click);
            // 
            // btnPesquisar_Idosos
            // 
            this.btnPesquisar_Idosos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar_Idosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar_Idosos.Location = new System.Drawing.Point(717, 61);
            this.btnPesquisar_Idosos.Name = "btnPesquisar_Idosos";
            this.btnPesquisar_Idosos.Size = new System.Drawing.Size(159, 50);
            this.btnPesquisar_Idosos.TabIndex = 124;
            this.btnPesquisar_Idosos.Text = "Pesquisar Idosos";
            this.btnPesquisar_Idosos.UseVisualStyleBackColor = true;
            this.btnPesquisar_Idosos.Click += new System.EventHandler(this.btnPesquisar_Idosos_Click);
            // 
            // txtPesquisar_Idosos
            // 
            this.txtPesquisar_Idosos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar_Idosos.Location = new System.Drawing.Point(421, 78);
            this.txtPesquisar_Idosos.Name = "txtPesquisar_Idosos";
            this.txtPesquisar_Idosos.Size = new System.Drawing.Size(269, 20);
            this.txtPesquisar_Idosos.TabIndex = 123;
            this.txtPesquisar_Idosos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_Idosos_KeyDown);
            // 
            // lblVisualizar_Idosos
            // 
            this.lblVisualizar_Idosos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVisualizar_Idosos.AutoSize = true;
            this.lblVisualizar_Idosos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblVisualizar_Idosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizar_Idosos.Location = new System.Drawing.Point(495, 9);
            this.lblVisualizar_Idosos.Name = "lblVisualizar_Idosos";
            this.lblVisualizar_Idosos.Size = new System.Drawing.Size(277, 37);
            this.lblVisualizar_Idosos.TabIndex = 122;
            this.lblVisualizar_Idosos.Text = "Visualizar Idosos";
            // 
            // btnLimpar_Idoso
            // 
            this.btnLimpar_Idoso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar_Idoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar_Idoso.Location = new System.Drawing.Point(588, 593);
            this.btnLimpar_Idoso.Name = "btnLimpar_Idoso";
            this.btnLimpar_Idoso.Size = new System.Drawing.Size(135, 50);
            this.btnLimpar_Idoso.TabIndex = 121;
            this.btnLimpar_Idoso.Text = "Limpar Item Selecionado";
            this.btnLimpar_Idoso.UseVisualStyleBackColor = true;
            this.btnLimpar_Idoso.Click += new System.EventHandler(this.btnLimpar_Idoso_Click);
            // 
            // btnExcluir_Idoso
            // 
            this.btnExcluir_Idoso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir_Idoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir_Idoso.Location = new System.Drawing.Point(806, 593);
            this.btnExcluir_Idoso.Name = "btnExcluir_Idoso";
            this.btnExcluir_Idoso.Size = new System.Drawing.Size(135, 51);
            this.btnExcluir_Idoso.TabIndex = 120;
            this.btnExcluir_Idoso.Text = "Excluir";
            this.btnExcluir_Idoso.UseVisualStyleBackColor = true;
            this.btnExcluir_Idoso.Click += new System.EventHandler(this.btnExcluir_Idoso_Click);
            // 
            // lblEditar_Excluir
            // 
            this.lblEditar_Excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditar_Excluir.AutoSize = true;
            this.lblEditar_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEditar_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar_Excluir.Location = new System.Drawing.Point(553, 407);
            this.lblEditar_Excluir.Name = "lblEditar_Excluir";
            this.lblEditar_Excluir.Size = new System.Drawing.Size(205, 20);
            this.lblEditar_Excluir.TabIndex = 118;
            this.lblEditar_Excluir.Text = "para editá-lo ou excluí-lo";
            // 
            // lblSelecione
            // 
            this.lblSelecione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(521, 387);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(279, 20);
            this.lblSelecione.TabIndex = 117;
            this.lblSelecione.Text = "Selecione um Idoso na tela acima";
            // 
            // lblTelefone_Emergencia
            // 
            this.lblTelefone_Emergencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone_Emergencia.AutoSize = true;
            this.lblTelefone_Emergencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblTelefone_Emergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone_Emergencia.Location = new System.Drawing.Point(796, 541);
            this.lblTelefone_Emergencia.Name = "lblTelefone_Emergencia";
            this.lblTelefone_Emergencia.Size = new System.Drawing.Size(209, 20);
            this.lblTelefone_Emergencia.TabIndex = 116;
            this.lblTelefone_Emergencia.Text = "Telefone de Emergência:";
            // 
            // txtAlterar_Excluir_Telefone_Emergencia
            // 
            this.txtAlterar_Excluir_Telefone_Emergencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Telefone_Emergencia.Location = new System.Drawing.Point(1037, 543);
            this.txtAlterar_Excluir_Telefone_Emergencia.Mask = "(00) 0000-0000";
            this.txtAlterar_Excluir_Telefone_Emergencia.Name = "txtAlterar_Excluir_Telefone_Emergencia";
            this.txtAlterar_Excluir_Telefone_Emergencia.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_Excluir_Telefone_Emergencia.TabIndex = 115;
            this.txtAlterar_Excluir_Telefone_Emergencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Telefone_Emergencia_KeyDown);
            // 
            // lblCelular_Responsavel
            // 
            this.lblCelular_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCelular_Responsavel.AutoSize = true;
            this.lblCelular_Responsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCelular_Responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular_Responsavel.Location = new System.Drawing.Point(802, 507);
            this.lblCelular_Responsavel.Name = "lblCelular_Responsavel";
            this.lblCelular_Responsavel.Size = new System.Drawing.Size(203, 20);
            this.lblCelular_Responsavel.TabIndex = 114;
            this.lblCelular_Responsavel.Text = "Celular do Responsável:";
            // 
            // lblTelefone_Responsavel
            // 
            this.lblTelefone_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone_Responsavel.AutoSize = true;
            this.lblTelefone_Responsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblTelefone_Responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone_Responsavel.Location = new System.Drawing.Point(788, 473);
            this.lblTelefone_Responsavel.Name = "lblTelefone_Responsavel";
            this.lblTelefone_Responsavel.Size = new System.Drawing.Size(217, 20);
            this.lblTelefone_Responsavel.TabIndex = 113;
            this.lblTelefone_Responsavel.Text = "Telefone do Responsável:";
            // 
            // txtAlterar_Excluir_Celular_Responsavel
            // 
            this.txtAlterar_Excluir_Celular_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Celular_Responsavel.Location = new System.Drawing.Point(1037, 509);
            this.txtAlterar_Excluir_Celular_Responsavel.Mask = "(00) 00000-0000";
            this.txtAlterar_Excluir_Celular_Responsavel.Name = "txtAlterar_Excluir_Celular_Responsavel";
            this.txtAlterar_Excluir_Celular_Responsavel.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_Excluir_Celular_Responsavel.TabIndex = 112;
            this.txtAlterar_Excluir_Celular_Responsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Celular_Responsavel_KeyDown);
            // 
            // txtAlterar_Excluir_Endereco_Responsavel
            // 
            this.txtAlterar_Excluir_Endereco_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Endereco_Responsavel.Location = new System.Drawing.Point(392, 541);
            this.txtAlterar_Excluir_Endereco_Responsavel.Name = "txtAlterar_Excluir_Endereco_Responsavel";
            this.txtAlterar_Excluir_Endereco_Responsavel.Size = new System.Drawing.Size(389, 20);
            this.txtAlterar_Excluir_Endereco_Responsavel.TabIndex = 111;
            this.txtAlterar_Excluir_Endereco_Responsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Endereco_Responsavel_KeyDown);
            // 
            // lblEndereco_Responsavel
            // 
            this.lblEndereco_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndereco_Responsavel.AutoSize = true;
            this.lblEndereco_Responsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEndereco_Responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco_Responsavel.Location = new System.Drawing.Point(136, 543);
            this.lblEndereco_Responsavel.Name = "lblEndereco_Responsavel";
            this.lblEndereco_Responsavel.Size = new System.Drawing.Size(224, 20);
            this.lblEndereco_Responsavel.TabIndex = 110;
            this.lblEndereco_Responsavel.Text = "Endereço do Responsável:";
            // 
            // dttmpckAlterar_Excluir_Data_Nascimento
            // 
            this.dttmpckAlterar_Excluir_Data_Nascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dttmpckAlterar_Excluir_Data_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckAlterar_Excluir_Data_Nascimento.Location = new System.Drawing.Point(392, 506);
            this.dttmpckAlterar_Excluir_Data_Nascimento.Name = "dttmpckAlterar_Excluir_Data_Nascimento";
            this.dttmpckAlterar_Excluir_Data_Nascimento.Size = new System.Drawing.Size(105, 20);
            this.dttmpckAlterar_Excluir_Data_Nascimento.TabIndex = 109;
            this.dttmpckAlterar_Excluir_Data_Nascimento.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dttmpckAlterar_Excluir_Data_Nascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dttmpckAlterar_Excluir_Data_Nascimento_KeyDown);
            // 
            // txtAlterar_Excluir_ID_Idoso
            // 
            this.txtAlterar_Excluir_ID_Idoso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_ID_Idoso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAlterar_Excluir_ID_Idoso.Enabled = false;
            this.txtAlterar_Excluir_ID_Idoso.Location = new System.Drawing.Point(392, 441);
            this.txtAlterar_Excluir_ID_Idoso.Name = "txtAlterar_Excluir_ID_Idoso";
            this.txtAlterar_Excluir_ID_Idoso.ReadOnly = true;
            this.txtAlterar_Excluir_ID_Idoso.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_Excluir_ID_Idoso.TabIndex = 108;
            this.txtAlterar_Excluir_ID_Idoso.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(290, 441);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 107;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // lblData_Nascimento
            // 
            this.lblData_Nascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData_Nascimento.AutoSize = true;
            this.lblData_Nascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblData_Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData_Nascimento.Location = new System.Drawing.Point(183, 511);
            this.lblData_Nascimento.Name = "lblData_Nascimento";
            this.lblData_Nascimento.Size = new System.Drawing.Size(177, 20);
            this.lblData_Nascimento.TabIndex = 106;
            this.lblData_Nascimento.Text = "Data de Nascimento:";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(300, 475);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 105;
            this.lblNome.Text = "Nome:";
            // 
            // txtAlterar_Excluir_Nome
            // 
            this.txtAlterar_Excluir_Nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Nome.Location = new System.Drawing.Point(392, 473);
            this.txtAlterar_Excluir_Nome.Name = "txtAlterar_Excluir_Nome";
            this.txtAlterar_Excluir_Nome.Size = new System.Drawing.Size(269, 20);
            this.txtAlterar_Excluir_Nome.TabIndex = 104;
            this.txtAlterar_Excluir_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Nome_KeyDown);
            // 
            // pctrbxImagem2
            // 
            this.pctrbxImagem2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrbxImagem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pctrbxImagem2.Image = global::TCC_CasaDeApoio.Properties.Resources.bordaPreta;
            this.pctrbxImagem2.Location = new System.Drawing.Point(17, 377);
            this.pctrbxImagem2.Name = "pctrbxImagem2";
            this.pctrbxImagem2.Size = new System.Drawing.Size(1263, 290);
            this.pctrbxImagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem2.TabIndex = 103;
            this.pctrbxImagem2.TabStop = false;
            // 
            // dtgrdvwIdosos
            // 
            this.dtgrdvwIdosos.AllowUserToAddRows = false;
            this.dtgrdvwIdosos.AllowUserToDeleteRows = false;
            this.dtgrdvwIdosos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrdvwIdosos.AutoGenerateColumns = false;
            this.dtgrdvwIdosos.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvwIdosos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvwIdosos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwIdosos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDIdosoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.enderecoResponsavelDataGridViewTextBoxColumn,
            this.telefoneResponsavelDataGridViewTextBoxColumn,
            this.celularResponsavelDataGridViewTextBoxColumn,
            this.telefoneEmergenciaDataGridViewTextBoxColumn});
            this.dtgrdvwIdosos.DataSource = this.idososBindingSource;
            this.dtgrdvwIdosos.Location = new System.Drawing.Point(17, 118);
            this.dtgrdvwIdosos.Name = "dtgrdvwIdosos";
            this.dtgrdvwIdosos.ReadOnly = true;
            this.dtgrdvwIdosos.RowHeadersVisible = false;
            this.dtgrdvwIdosos.Size = new System.Drawing.Size(1263, 253);
            this.dtgrdvwIdosos.TabIndex = 102;
            this.dtgrdvwIdosos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvwIdosos_CellClick);
            // 
            // idososBindingSource
            // 
            this.idososBindingSource.DataMember = "Idosos";
            this.idososBindingSource.DataSource = this.casaDeApoioNossoLarDataSetIdosos;
            // 
            // casaDeApoioNossoLarDataSetIdosos
            // 
            this.casaDeApoioNossoLarDataSetIdosos.DataSetName = "CasaDeApoioNossoLarDataSetIdosos";
            this.casaDeApoioNossoLarDataSetIdosos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAlterar_Excluir_Telefone_Responsavel
            // 
            this.txtAlterar_Excluir_Telefone_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Telefone_Responsavel.Location = new System.Drawing.Point(1037, 473);
            this.txtAlterar_Excluir_Telefone_Responsavel.Mask = "(00) 0000-0000";
            this.txtAlterar_Excluir_Telefone_Responsavel.Name = "txtAlterar_Excluir_Telefone_Responsavel";
            this.txtAlterar_Excluir_Telefone_Responsavel.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_Excluir_Telefone_Responsavel.TabIndex = 125;
            this.txtAlterar_Excluir_Telefone_Responsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Telefone_Responsavel_KeyDown);
            // 
            // idososTableAdapter
            // 
            this.idososTableAdapter.ClearBeforeFill = true;
            // 
            // iDIdosoDataGridViewTextBoxColumn
            // 
            this.iDIdosoDataGridViewTextBoxColumn.DataPropertyName = "ID_Idoso";
            this.iDIdosoDataGridViewTextBoxColumn.HeaderText = "Código do Idoso";
            this.iDIdosoDataGridViewTextBoxColumn.Name = "iDIdosoDataGridViewTextBoxColumn";
            this.iDIdosoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDIdosoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDIdosoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeDataGridViewTextBoxColumn.Width = 430;
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "Data de Nascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            this.dataNascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNascimentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // enderecoResponsavelDataGridViewTextBoxColumn
            // 
            this.enderecoResponsavelDataGridViewTextBoxColumn.DataPropertyName = "Endereco_Responsavel";
            this.enderecoResponsavelDataGridViewTextBoxColumn.HeaderText = "Endereco do Responsável";
            this.enderecoResponsavelDataGridViewTextBoxColumn.Name = "enderecoResponsavelDataGridViewTextBoxColumn";
            this.enderecoResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoResponsavelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.enderecoResponsavelDataGridViewTextBoxColumn.Width = 430;
            // 
            // telefoneResponsavelDataGridViewTextBoxColumn
            // 
            this.telefoneResponsavelDataGridViewTextBoxColumn.DataPropertyName = "Telefone_Responsavel";
            this.telefoneResponsavelDataGridViewTextBoxColumn.HeaderText = "Telefone do Responsável";
            this.telefoneResponsavelDataGridViewTextBoxColumn.Name = "telefoneResponsavelDataGridViewTextBoxColumn";
            this.telefoneResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneResponsavelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // celularResponsavelDataGridViewTextBoxColumn
            // 
            this.celularResponsavelDataGridViewTextBoxColumn.DataPropertyName = "Celular_Responsavel";
            this.celularResponsavelDataGridViewTextBoxColumn.HeaderText = "Celular do Responsável";
            this.celularResponsavelDataGridViewTextBoxColumn.Name = "celularResponsavelDataGridViewTextBoxColumn";
            this.celularResponsavelDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularResponsavelDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // telefoneEmergenciaDataGridViewTextBoxColumn
            // 
            this.telefoneEmergenciaDataGridViewTextBoxColumn.DataPropertyName = "Telefone_Emergencia";
            this.telefoneEmergenciaDataGridViewTextBoxColumn.HeaderText = "Telefone de Emergência";
            this.telefoneEmergenciaDataGridViewTextBoxColumn.Name = "telefoneEmergenciaDataGridViewTextBoxColumn";
            this.telefoneEmergenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneEmergenciaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VisualizarIdoso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1296, 679);
            this.Controls.Add(this.txtAlterar_Excluir_Telefone_Responsavel);
            this.Controls.Add(this.btnAlterar_Idoso);
            this.Controls.Add(this.btnPesquisar_Idosos);
            this.Controls.Add(this.txtPesquisar_Idosos);
            this.Controls.Add(this.lblVisualizar_Idosos);
            this.Controls.Add(this.btnLimpar_Idoso);
            this.Controls.Add(this.btnExcluir_Idoso);
            this.Controls.Add(this.lblEditar_Excluir);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.lblTelefone_Emergencia);
            this.Controls.Add(this.txtAlterar_Excluir_Telefone_Emergencia);
            this.Controls.Add(this.lblCelular_Responsavel);
            this.Controls.Add(this.lblTelefone_Responsavel);
            this.Controls.Add(this.txtAlterar_Excluir_Celular_Responsavel);
            this.Controls.Add(this.txtAlterar_Excluir_Endereco_Responsavel);
            this.Controls.Add(this.lblEndereco_Responsavel);
            this.Controls.Add(this.dttmpckAlterar_Excluir_Data_Nascimento);
            this.Controls.Add(this.txtAlterar_Excluir_ID_Idoso);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblData_Nascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtAlterar_Excluir_Nome);
            this.Controls.Add(this.pctrbxImagem2);
            this.Controls.Add(this.dtgrdvwIdosos);
            this.Controls.Add(this.pctrbxImagem1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarIdoso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Idosos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisualizarIdoso_FormClosing);
            this.Load += new System.EventHandler(this.VisualizarIdoso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwIdosos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idososBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetIdosos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxImagem1;
        private System.Windows.Forms.Button btnAlterar_Idoso;
        private System.Windows.Forms.Button btnPesquisar_Idosos;
        private System.Windows.Forms.TextBox txtPesquisar_Idosos;
        private System.Windows.Forms.Label lblVisualizar_Idosos;
        private System.Windows.Forms.Button btnLimpar_Idoso;
        private System.Windows.Forms.Button btnExcluir_Idoso;
        private System.Windows.Forms.Label lblEditar_Excluir;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Label lblTelefone_Emergencia;
        private System.Windows.Forms.MaskedTextBox txtAlterar_Excluir_Telefone_Emergencia;
        private System.Windows.Forms.Label lblCelular_Responsavel;
        private System.Windows.Forms.Label lblTelefone_Responsavel;
        private System.Windows.Forms.MaskedTextBox txtAlterar_Excluir_Celular_Responsavel;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_Endereco_Responsavel;
        private System.Windows.Forms.Label lblEndereco_Responsavel;
        private System.Windows.Forms.DateTimePicker dttmpckAlterar_Excluir_Data_Nascimento;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_ID_Idoso;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblData_Nascimento;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_Nome;
        private System.Windows.Forms.PictureBox pctrbxImagem2;
        private System.Windows.Forms.DataGridView dtgrdvwIdosos;
        private System.Windows.Forms.MaskedTextBox txtAlterar_Excluir_Telefone_Responsavel;
        private CasaDeApoioNossoLarDataSetIdosos casaDeApoioNossoLarDataSetIdosos;
        private System.Windows.Forms.BindingSource idososBindingSource;
        private CasaDeApoioNossoLarDataSetIdososTableAdapters.IdososTableAdapter idososTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDIdosoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularResponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneEmergenciaDataGridViewTextBoxColumn;
    }
}