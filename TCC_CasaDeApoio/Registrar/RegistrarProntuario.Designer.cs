namespace TCC_CasaDeApoio.Registrar
{
    partial class RegistrarProntuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarProntuario));
            this.lblRemedios = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbxIdosos = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtID_Prontuario = new System.Windows.Forms.TextBox();
            this.lblRegistrar_Prontuarios = new System.Windows.Forms.Label();
            this.lblAlimentos = new System.Windows.Forms.Label();
            this.lblIdosos = new System.Windows.Forms.Label();
            this.lblPossui = new System.Windows.Forms.Label();
            this.grpbxOpcoes = new System.Windows.Forms.GroupBox();
            this.rdbtnNao = new System.Windows.Forms.RadioButton();
            this.rdbtnSim = new System.Windows.Forms.RadioButton();
            this.lblIdoso = new System.Windows.Forms.Label();
            this.txtEnfermidades = new System.Windows.Forms.TextBox();
            this.cbxAlimentos = new System.Windows.Forms.ComboBox();
            this.cbxRemedios = new System.Windows.Forms.ComboBox();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblEnfermidades = new System.Windows.Forms.Label();
            this.pctrbxImagem = new System.Windows.Forms.PictureBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnExcluir_Lista = new System.Windows.Forms.Button();
            this.btnEditar_Lista = new System.Windows.Forms.Button();
            this.lblRegistroConcluido = new System.Windows.Forms.Label();
            this.dtgrdvwLista = new System.Windows.Forms.DataGridView();
            this.Nome_Idosos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enfermidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alimentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remedios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Uso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prescricao_Observacoes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Idoso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Alimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Remedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar_Lista = new System.Windows.Forms.Button();
            this.lblObrigatorio = new System.Windows.Forms.Label();
            this.txtPrescricao_Observacoes = new System.Windows.Forms.TextBox();
            this.lblData_Criacao = new System.Windows.Forms.Label();
            this.lblData_Uso = new System.Windows.Forms.Label();
            this.lblPrescricao = new System.Windows.Forms.Label();
            this.lblObservações = new System.Windows.Forms.Label();
            this.dttmpckData_Criacao = new System.Windows.Forms.DateTimePicker();
            this.dttmpckData_Uso = new System.Windows.Forms.DateTimePicker();
            this.grpbxOpcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwLista)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemedios
            // 
            this.lblRemedios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemedios.AutoSize = true;
            this.lblRemedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblRemedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemedios.Location = new System.Drawing.Point(34, 288);
            this.lblRemedios.Name = "lblRemedios";
            this.lblRemedios.Size = new System.Drawing.Size(94, 20);
            this.lblRemedios.TabIndex = 74;
            this.lblRemedios.Text = "Remédios:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(558, 542);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 52);
            this.btnLimpar.TabIndex = 69;
            this.btnLimpar.Text = "Limpar Item Selecionado";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(360, 542);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 52);
            this.btnRegistrar.TabIndex = 68;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // cbxIdosos
            // 
            this.cbxIdosos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxIdosos.DisplayMember = "Nome";
            this.cbxIdosos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdosos.FormattingEnabled = true;
            this.cbxIdosos.Location = new System.Drawing.Point(170, 113);
            this.cbxIdosos.Name = "cbxIdosos";
            this.cbxIdosos.Size = new System.Drawing.Size(186, 21);
            this.cbxIdosos.TabIndex = 66;
            this.cbxIdosos.ValueMember = "ID_Idoso";
            this.cbxIdosos.Click += new System.EventHandler(this.CbxIdosos_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(45, 76);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 63;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // txtID_Prontuario
            // 
            this.txtID_Prontuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID_Prontuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID_Prontuario.Enabled = false;
            this.txtID_Prontuario.Location = new System.Drawing.Point(170, 76);
            this.txtID_Prontuario.Name = "txtID_Prontuario";
            this.txtID_Prontuario.Size = new System.Drawing.Size(186, 20);
            this.txtID_Prontuario.TabIndex = 62;
            this.txtID_Prontuario.Visible = false;
            // 
            // lblRegistrar_Prontuarios
            // 
            this.lblRegistrar_Prontuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistrar_Prontuarios.AutoSize = true;
            this.lblRegistrar_Prontuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblRegistrar_Prontuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar_Prontuarios.Location = new System.Drawing.Point(343, 9);
            this.lblRegistrar_Prontuarios.Name = "lblRegistrar_Prontuarios";
            this.lblRegistrar_Prontuarios.Size = new System.Drawing.Size(344, 33);
            this.lblRegistrar_Prontuarios.TabIndex = 61;
            this.lblRegistrar_Prontuarios.Text = "Registro de Prontuários";
            // 
            // lblAlimentos
            // 
            this.lblAlimentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlimentos.AutoSize = true;
            this.lblAlimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimentos.Location = new System.Drawing.Point(28, 250);
            this.lblAlimentos.Name = "lblAlimentos";
            this.lblAlimentos.Size = new System.Drawing.Size(100, 20);
            this.lblAlimentos.TabIndex = 58;
            this.lblAlimentos.Text = "Alimentos*:";
            // 
            // lblIdosos
            // 
            this.lblIdosos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdosos.AutoSize = true;
            this.lblIdosos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblIdosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdosos.Location = new System.Drawing.Point(40, 111);
            this.lblIdosos.Name = "lblIdosos";
            this.lblIdosos.Size = new System.Drawing.Size(75, 20);
            this.lblIdosos.TabIndex = 57;
            this.lblIdosos.Text = "Idosos*:";
            // 
            // lblPossui
            // 
            this.lblPossui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPossui.AutoSize = true;
            this.lblPossui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblPossui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossui.Location = new System.Drawing.Point(11, 173);
            this.lblPossui.Name = "lblPossui";
            this.lblPossui.Size = new System.Drawing.Size(121, 20);
            this.lblPossui.TabIndex = 80;
            this.lblPossui.Text = "Enfermidade?";
            // 
            // grpbxOpcoes
            // 
            this.grpbxOpcoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbxOpcoes.Controls.Add(this.rdbtnNao);
            this.grpbxOpcoes.Controls.Add(this.rdbtnSim);
            this.grpbxOpcoes.Location = new System.Drawing.Point(170, 153);
            this.grpbxOpcoes.Name = "grpbxOpcoes";
            this.grpbxOpcoes.Size = new System.Drawing.Size(186, 40);
            this.grpbxOpcoes.TabIndex = 81;
            this.grpbxOpcoes.TabStop = false;
            // 
            // rdbtnNao
            // 
            this.rdbtnNao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnNao.AutoSize = true;
            this.rdbtnNao.Checked = true;
            this.rdbtnNao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnNao.Location = new System.Drawing.Point(108, 10);
            this.rdbtnNao.Name = "rdbtnNao";
            this.rdbtnNao.Size = new System.Drawing.Size(59, 24);
            this.rdbtnNao.TabIndex = 1;
            this.rdbtnNao.TabStop = true;
            this.rdbtnNao.Text = "Não";
            this.rdbtnNao.UseVisualStyleBackColor = true;
            this.rdbtnNao.CheckedChanged += new System.EventHandler(this.RdbtnNao_CheckedChanged);
            // 
            // rdbtnSim
            // 
            this.rdbtnSim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnSim.AutoSize = true;
            this.rdbtnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSim.Location = new System.Drawing.Point(22, 10);
            this.rdbtnSim.Name = "rdbtnSim";
            this.rdbtnSim.Size = new System.Drawing.Size(57, 24);
            this.rdbtnSim.TabIndex = 0;
            this.rdbtnSim.Text = "Sim";
            this.rdbtnSim.UseVisualStyleBackColor = true;
            this.rdbtnSim.CheckedChanged += new System.EventHandler(this.RdbtnSim_CheckedChanged);
            // 
            // lblIdoso
            // 
            this.lblIdoso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdoso.AutoSize = true;
            this.lblIdoso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblIdoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdoso.Location = new System.Drawing.Point(10, 153);
            this.lblIdoso.Name = "lblIdoso";
            this.lblIdoso.Size = new System.Drawing.Size(136, 20);
            this.lblIdoso.TabIndex = 82;
            this.lblIdoso.Text = "O Idoso possui*";
            // 
            // txtEnfermidades
            // 
            this.txtEnfermidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEnfermidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtEnfermidades.Enabled = false;
            this.txtEnfermidades.Location = new System.Drawing.Point(170, 211);
            this.txtEnfermidades.Name = "txtEnfermidades";
            this.txtEnfermidades.Size = new System.Drawing.Size(266, 20);
            this.txtEnfermidades.TabIndex = 84;
            // 
            // cbxAlimentos
            // 
            this.cbxAlimentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAlimentos.DisplayMember = "Nome";
            this.cbxAlimentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlimentos.FormattingEnabled = true;
            this.cbxAlimentos.Location = new System.Drawing.Point(170, 250);
            this.cbxAlimentos.Name = "cbxAlimentos";
            this.cbxAlimentos.Size = new System.Drawing.Size(186, 21);
            this.cbxAlimentos.TabIndex = 85;
            this.cbxAlimentos.ValueMember = "ID_Alimento";
            this.cbxAlimentos.Click += new System.EventHandler(this.CbxAlimentos_Click);
            // 
            // cbxRemedios
            // 
            this.cbxRemedios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxRemedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.cbxRemedios.DisplayMember = "Nome";
            this.cbxRemedios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRemedios.Enabled = false;
            this.cbxRemedios.FormattingEnabled = true;
            this.cbxRemedios.Location = new System.Drawing.Point(170, 290);
            this.cbxRemedios.Name = "cbxRemedios";
            this.cbxRemedios.Size = new System.Drawing.Size(186, 21);
            this.cbxRemedios.TabIndex = 86;
            this.cbxRemedios.ValueMember = "ID_Remedio";
            this.cbxRemedios.Click += new System.EventHandler(this.CbxRemedios_Click);
            // 
            // lblLista
            // 
            this.lblLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLista.AutoSize = true;
            this.lblLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(713, 83);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(63, 25);
            this.lblLista.TabIndex = 146;
            this.lblLista.Text = "Lista";
            // 
            // lblEnfermidades
            // 
            this.lblEnfermidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnfermidades.AutoSize = true;
            this.lblEnfermidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEnfermidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermidades.Location = new System.Drawing.Point(17, 209);
            this.lblEnfermidades.Name = "lblEnfermidades";
            this.lblEnfermidades.Size = new System.Drawing.Size(125, 20);
            this.lblEnfermidades.TabIndex = 149;
            this.lblEnfermidades.Text = "Enfermidades:";
            // 
            // pctrbxImagem
            // 
            this.pctrbxImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrbxImagem.BackColor = System.Drawing.SystemColors.Control;
            this.pctrbxImagem.Image = global::TCC_CasaDeApoio.Properties.Resources.WallpapaerCasaDeApoio;
            this.pctrbxImagem.Location = new System.Drawing.Point(0, 0);
            this.pctrbxImagem.Name = "pctrbxImagem";
            this.pctrbxImagem.Size = new System.Drawing.Size(1060, 623);
            this.pctrbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem.TabIndex = 83;
            this.pctrbxImagem.TabStop = false;
            // 
            // btnLista
            // 
            this.btnLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLista.BackColor = System.Drawing.SystemColors.Control;
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(24, 445);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(122, 48);
            this.btnLista.TabIndex = 137;
            this.btnLista.Text = "Adicionar a Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.BtnLista_Click);
            // 
            // btnExcluir_Lista
            // 
            this.btnExcluir_Lista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir_Lista.BackColor = System.Drawing.SystemColors.Control;
            this.btnExcluir_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir_Lista.Location = new System.Drawing.Point(314, 445);
            this.btnExcluir_Lista.Name = "btnExcluir_Lista";
            this.btnExcluir_Lista.Size = new System.Drawing.Size(122, 48);
            this.btnExcluir_Lista.TabIndex = 138;
            this.btnExcluir_Lista.Text = "Excluir da Lista";
            this.btnExcluir_Lista.UseVisualStyleBackColor = false;
            this.btnExcluir_Lista.Click += new System.EventHandler(this.BtnExcluir_Lista_Click);
            // 
            // btnEditar_Lista
            // 
            this.btnEditar_Lista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar_Lista.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditar_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar_Lista.Location = new System.Drawing.Point(170, 445);
            this.btnEditar_Lista.Name = "btnEditar_Lista";
            this.btnEditar_Lista.Size = new System.Drawing.Size(122, 48);
            this.btnEditar_Lista.TabIndex = 150;
            this.btnEditar_Lista.Text = "Editar da Lista";
            this.btnEditar_Lista.UseVisualStyleBackColor = false;
            this.btnEditar_Lista.Click += new System.EventHandler(this.BtnEditar_Lista_Click);
            // 
            // lblRegistroConcluido
            // 
            this.lblRegistroConcluido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistroConcluido.AutoSize = true;
            this.lblRegistroConcluido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblRegistroConcluido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistroConcluido.Location = new System.Drawing.Point(19, 505);
            this.lblRegistroConcluido.Name = "lblRegistroConcluido";
            this.lblRegistroConcluido.Size = new System.Drawing.Size(417, 25);
            this.lblRegistroConcluido.TabIndex = 151;
            this.lblRegistroConcluido.Text = "Prontuário(s) incluído(s) com sucesso!";
            this.lblRegistroConcluido.Visible = false;
            // 
            // dtgrdvwLista
            // 
            this.dtgrdvwLista.AllowUserToAddRows = false;
            this.dtgrdvwLista.AllowUserToDeleteRows = false;
            this.dtgrdvwLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrdvwLista.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvwLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvwLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome_Idosos,
            this.Enfermidades,
            this.Alimentos,
            this.Remedios,
            this.Data_Criacao,
            this.Data_Uso,
            this.Prescricao_Observacoes,
            this.ID_Idoso,
            this.ID_Alimento,
            this.ID_Remedio});
            this.dtgrdvwLista.Location = new System.Drawing.Point(455, 111);
            this.dtgrdvwLista.Name = "dtgrdvwLista";
            this.dtgrdvwLista.ReadOnly = true;
            this.dtgrdvwLista.RowHeadersVisible = false;
            this.dtgrdvwLista.Size = new System.Drawing.Size(593, 419);
            this.dtgrdvwLista.TabIndex = 152;
            this.dtgrdvwLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvwLista_CellContentClick);
            // 
            // Nome_Idosos
            // 
            this.Nome_Idosos.HeaderText = "Nome dos Idosos";
            this.Nome_Idosos.Name = "Nome_Idosos";
            this.Nome_Idosos.ReadOnly = true;
            this.Nome_Idosos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nome_Idosos.Width = 148;
            // 
            // Enfermidades
            // 
            this.Enfermidades.HeaderText = "Enfermidades";
            this.Enfermidades.Name = "Enfermidades";
            this.Enfermidades.ReadOnly = true;
            this.Enfermidades.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Enfermidades.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Enfermidades.Width = 147;
            // 
            // Alimentos
            // 
            this.Alimentos.HeaderText = "Alimentos";
            this.Alimentos.Name = "Alimentos";
            this.Alimentos.ReadOnly = true;
            this.Alimentos.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Alimentos.Width = 148;
            // 
            // Remedios
            // 
            this.Remedios.HeaderText = "Remédios";
            this.Remedios.Name = "Remedios";
            this.Remedios.ReadOnly = true;
            this.Remedios.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Remedios.Width = 147;
            // 
            // Data_Criacao
            // 
            this.Data_Criacao.HeaderText = "Data de Criação";
            this.Data_Criacao.Name = "Data_Criacao";
            this.Data_Criacao.ReadOnly = true;
            this.Data_Criacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Data_Uso
            // 
            this.Data_Uso.HeaderText = "Data de Uso";
            this.Data_Uso.Name = "Data_Uso";
            this.Data_Uso.ReadOnly = true;
            this.Data_Uso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Prescricao_Observacoes
            // 
            this.Prescricao_Observacoes.HeaderText = "Prescrição ou Observações";
            this.Prescricao_Observacoes.Name = "Prescricao_Observacoes";
            this.Prescricao_Observacoes.ReadOnly = true;
            this.Prescricao_Observacoes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Prescricao_Observacoes.Width = 300;
            // 
            // ID_Idoso
            // 
            this.ID_Idoso.HeaderText = "Código do Idoso";
            this.ID_Idoso.Name = "ID_Idoso";
            this.ID_Idoso.ReadOnly = true;
            this.ID_Idoso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_Idoso.Width = 115;
            // 
            // ID_Alimento
            // 
            this.ID_Alimento.HeaderText = "Código do Alimento";
            this.ID_Alimento.Name = "ID_Alimento";
            this.ID_Alimento.ReadOnly = true;
            this.ID_Alimento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_Alimento.Width = 115;
            // 
            // ID_Remedio
            // 
            this.ID_Remedio.HeaderText = "Código do Remédio";
            this.ID_Remedio.Name = "ID_Remedio";
            this.ID_Remedio.ReadOnly = true;
            this.ID_Remedio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID_Remedio.Width = 115;
            // 
            // btnPesquisar_Lista
            // 
            this.btnPesquisar_Lista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar_Lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar_Lista.Location = new System.Drawing.Point(899, 60);
            this.btnPesquisar_Lista.Name = "btnPesquisar_Lista";
            this.btnPesquisar_Lista.Size = new System.Drawing.Size(149, 48);
            this.btnPesquisar_Lista.TabIndex = 154;
            this.btnPesquisar_Lista.Text = "Pesquisar Idosos na Lista";
            this.btnPesquisar_Lista.UseVisualStyleBackColor = true;
            this.btnPesquisar_Lista.Click += new System.EventHandler(this.BtnPesquisar_Lista_Click);
            // 
            // lblObrigatorio
            // 
            this.lblObrigatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObrigatorio.AutoSize = true;
            this.lblObrigatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrigatorio.Location = new System.Drawing.Point(139, 558);
            this.lblObrigatorio.Name = "lblObrigatorio";
            this.lblObrigatorio.Size = new System.Drawing.Size(171, 20);
            this.lblObrigatorio.TabIndex = 157;
            this.lblObrigatorio.Text = "*Campo Obrigatório.";
            // 
            // txtPrescricao_Observacoes
            // 
            this.txtPrescricao_Observacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrescricao_Observacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtPrescricao_Observacoes.Enabled = false;
            this.txtPrescricao_Observacoes.Location = new System.Drawing.Point(170, 402);
            this.txtPrescricao_Observacoes.Name = "txtPrescricao_Observacoes";
            this.txtPrescricao_Observacoes.Size = new System.Drawing.Size(266, 20);
            this.txtPrescricao_Observacoes.TabIndex = 160;
            // 
            // lblData_Criacao
            // 
            this.lblData_Criacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData_Criacao.AutoSize = true;
            this.lblData_Criacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblData_Criacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData_Criacao.Location = new System.Drawing.Point(10, 321);
            this.lblData_Criacao.Name = "lblData_Criacao";
            this.lblData_Criacao.Size = new System.Drawing.Size(151, 20);
            this.lblData_Criacao.TabIndex = 161;
            this.lblData_Criacao.Text = "Data de Criacao*:";
            // 
            // lblData_Uso
            // 
            this.lblData_Uso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData_Uso.AutoSize = true;
            this.lblData_Uso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblData_Uso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData_Uso.Location = new System.Drawing.Point(28, 356);
            this.lblData_Uso.Name = "lblData_Uso";
            this.lblData_Uso.Size = new System.Drawing.Size(122, 20);
            this.lblData_Uso.TabIndex = 162;
            this.lblData_Uso.Text = "Data de Uso*:";
            // 
            // lblPrescricao
            // 
            this.lblPrescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrescricao.AutoSize = true;
            this.lblPrescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescricao.Location = new System.Drawing.Point(28, 391);
            this.lblPrescricao.Name = "lblPrescricao";
            this.lblPrescricao.Size = new System.Drawing.Size(118, 20);
            this.lblPrescricao.TabIndex = 163;
            this.lblPrescricao.Text = "Prescrição ou";
            // 
            // lblObservações
            // 
            this.lblObservações.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservações.AutoSize = true;
            this.lblObservações.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblObservações.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservações.Location = new System.Drawing.Point(28, 411);
            this.lblObservações.Name = "lblObservações";
            this.lblObservações.Size = new System.Drawing.Size(118, 20);
            this.lblObservações.TabIndex = 164;
            this.lblObservações.Text = "Observações:";
            // 
            // dttmpckData_Criacao
            // 
            this.dttmpckData_Criacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dttmpckData_Criacao.Enabled = false;
            this.dttmpckData_Criacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckData_Criacao.Location = new System.Drawing.Point(215, 321);
            this.dttmpckData_Criacao.Name = "dttmpckData_Criacao";
            this.dttmpckData_Criacao.Size = new System.Drawing.Size(105, 20);
            this.dttmpckData_Criacao.TabIndex = 165;
            // 
            // dttmpckData_Uso
            // 
            this.dttmpckData_Uso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dttmpckData_Uso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckData_Uso.Location = new System.Drawing.Point(215, 356);
            this.dttmpckData_Uso.Name = "dttmpckData_Uso";
            this.dttmpckData_Uso.Size = new System.Drawing.Size(105, 20);
            this.dttmpckData_Uso.TabIndex = 166;
            // 
            // RegistrarProntuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1060, 623);
            this.Controls.Add(this.dttmpckData_Uso);
            this.Controls.Add(this.dttmpckData_Criacao);
            this.Controls.Add(this.lblObservações);
            this.Controls.Add(this.lblPrescricao);
            this.Controls.Add(this.lblData_Uso);
            this.Controls.Add(this.lblData_Criacao);
            this.Controls.Add(this.txtPrescricao_Observacoes);
            this.Controls.Add(this.lblObrigatorio);
            this.Controls.Add(this.btnPesquisar_Lista);
            this.Controls.Add(this.dtgrdvwLista);
            this.Controls.Add(this.lblRegistroConcluido);
            this.Controls.Add(this.btnEditar_Lista);
            this.Controls.Add(this.lblEnfermidades);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.btnExcluir_Lista);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.cbxRemedios);
            this.Controls.Add(this.cbxAlimentos);
            this.Controls.Add(this.txtEnfermidades);
            this.Controls.Add(this.lblIdoso);
            this.Controls.Add(this.grpbxOpcoes);
            this.Controls.Add(this.lblPossui);
            this.Controls.Add(this.lblRemedios);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbxIdosos);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtID_Prontuario);
            this.Controls.Add(this.lblRegistrar_Prontuarios);
            this.Controls.Add(this.lblAlimentos);
            this.Controls.Add(this.lblIdosos);
            this.Controls.Add(this.pctrbxImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarProntuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Prontuários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarProntuario_FormClosing);
            this.Load += new System.EventHandler(this.RegistrarProntuario_Load);
            this.grpbxOpcoes.ResumeLayout(false);
            this.grpbxOpcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRemedios;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbxIdosos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtID_Prontuario;
        private System.Windows.Forms.Label lblRegistrar_Prontuarios;
        private System.Windows.Forms.Label lblAlimentos;
        private System.Windows.Forms.Label lblIdosos;
        private System.Windows.Forms.Label lblPossui;
        private System.Windows.Forms.GroupBox grpbxOpcoes;
        private System.Windows.Forms.RadioButton rdbtnNao;
        private System.Windows.Forms.RadioButton rdbtnSim;
        private System.Windows.Forms.Label lblIdoso;
        private System.Windows.Forms.TextBox txtEnfermidades;
        private System.Windows.Forms.ComboBox cbxAlimentos;
        private System.Windows.Forms.ComboBox cbxRemedios;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblEnfermidades;
        private System.Windows.Forms.PictureBox pctrbxImagem;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnExcluir_Lista;
        private System.Windows.Forms.Button btnEditar_Lista;
        private System.Windows.Forms.Label lblRegistroConcluido;
        private System.Windows.Forms.DataGridView dtgrdvwLista;
        private System.Windows.Forms.Button btnPesquisar_Lista;
        private System.Windows.Forms.Label lblObrigatorio;
        private System.Windows.Forms.TextBox txtPrescricao_Observacoes;
        private System.Windows.Forms.Label lblData_Criacao;
        private System.Windows.Forms.Label lblData_Uso;
        private System.Windows.Forms.Label lblPrescricao;
        private System.Windows.Forms.Label lblObservações;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Idosos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Enfermidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remedios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Uso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prescricao_Observacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Idoso;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Alimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Remedio;
        private System.Windows.Forms.DateTimePicker dttmpckData_Criacao;
        private System.Windows.Forms.DateTimePicker dttmpckData_Uso;
    }
}