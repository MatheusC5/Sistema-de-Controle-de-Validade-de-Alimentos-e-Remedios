namespace TCC_CasaDeApoio.Visualizar
{
    partial class VisualizarProntuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarProntuario));
            this.pctrbxImagem1 = new System.Windows.Forms.PictureBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.txtAlterar_ID_Prontuario = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnPesquisar_Idosos = new System.Windows.Forms.Button();
            this.txtPesquisar_Idosos = new System.Windows.Forms.TextBox();
            this.pctrbxImagem2 = new System.Windows.Forms.PictureBox();
            this.dtgrdvwProntuarios = new System.Windows.Forms.DataGridView();
            this.prontuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casaDeApoioNossoLarDataSetProntuarios = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetProntuarios();
            this.lblVisualizar_Prontuarios = new System.Windows.Forms.Label();
            this.lblEnfermidade = new System.Windows.Forms.Label();
            this.lblIdoso = new System.Windows.Forms.Label();
            this.cbxAlterar_Idosos = new System.Windows.Forms.ComboBox();
            this.lblRemedio = new System.Windows.Forms.Label();
            this.cbxAlterar_Remedios = new System.Windows.Forms.ComboBox();
            this.lblAlimento = new System.Windows.Forms.Label();
            this.cbxAlterar_Alimentos = new System.Windows.Forms.ComboBox();
            this.txtAlterar_Enfermidades = new System.Windows.Forms.TextBox();
            this.btnLimpar_Prontuario = new System.Windows.Forms.Button();
            this.btnAlterar_Prontuario = new System.Windows.Forms.Button();
            this.txtAlterar_ID_Alimento = new System.Windows.Forms.TextBox();
            this.txtAlterar_ID_Remedio = new System.Windows.Forms.TextBox();
            this.txtAlterar_ID_Idoso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxOpcoes = new System.Windows.Forms.GroupBox();
            this.rdbtnAlterar_Nao = new System.Windows.Forms.RadioButton();
            this.rdbtnAlterar_Sim = new System.Windows.Forms.RadioButton();
            this.lblPossui = new System.Windows.Forms.Label();
            this.lblCódigo_Idoso = new System.Windows.Forms.Label();
            this.lblCódigo_Remedio = new System.Windows.Forms.Label();
            this.lblCódigo_Alimento = new System.Windows.Forms.Label();
            this.lblObservações = new System.Windows.Forms.Label();
            this.lblPrescricao = new System.Windows.Forms.Label();
            this.lblData_Uso = new System.Windows.Forms.Label();
            this.lblData_Criacao = new System.Windows.Forms.Label();
            this.txtAlterar_Prescricao_Observacoes = new System.Windows.Forms.TextBox();
            this.dttmpckAlterar_Data_Criacao = new System.Windows.Forms.DateTimePicker();
            this.btnGerar_Relatorio_PDF = new System.Windows.Forms.Button();
            this.btnProcurar_Salvar_Relatorio = new System.Windows.Forms.Button();
            this.txtRelatorio_PDF = new System.Windows.Forms.TextBox();
            this.dttmpckAlterar_Data_Uso = new System.Windows.Forms.DateTimePicker();
            this.prontuariosTableAdapter = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetProntuariosTableAdapters.ProntuariosTableAdapter();
            this.iDProntuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idososDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enfermidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alimentosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remediosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUsoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescricaoObservacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDIdosoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAlimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDRemedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwProntuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prontuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetProntuarios)).BeginInit();
            this.grpbxOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctrbxImagem1
            // 
            this.pctrbxImagem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbxImagem1.Image = global::TCC_CasaDeApoio.Properties.Resources.WallpapaerCasaDeApoio;
            this.pctrbxImagem1.Location = new System.Drawing.Point(0, 0);
            this.pctrbxImagem1.Name = "pctrbxImagem1";
            this.pctrbxImagem1.Size = new System.Drawing.Size(1296, 676);
            this.pctrbxImagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem1.TabIndex = 0;
            this.pctrbxImagem1.TabStop = false;
            // 
            // lblEditar
            // 
            this.lblEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditar.AutoSize = true;
            this.lblEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.Location = new System.Drawing.Point(560, 385);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(162, 20);
            this.lblEditar.TabIndex = 192;
            this.lblEditar.Text = "acima para editá-lo";
            // 
            // lblSelecione
            // 
            this.lblSelecione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(508, 365);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(265, 20);
            this.lblSelecione.TabIndex = 191;
            this.lblSelecione.Text = "Selecione um Prontuário na tela";
            // 
            // txtAlterar_ID_Prontuario
            // 
            this.txtAlterar_ID_Prontuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_ID_Prontuario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAlterar_ID_Prontuario.Enabled = false;
            this.txtAlterar_ID_Prontuario.Location = new System.Drawing.Point(1154, 367);
            this.txtAlterar_ID_Prontuario.Name = "txtAlterar_ID_Prontuario";
            this.txtAlterar_ID_Prontuario.ReadOnly = true;
            this.txtAlterar_ID_Prontuario.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_ID_Prontuario.TabIndex = 187;
            this.txtAlterar_ID_Prontuario.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(1055, 365);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 186;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // btnPesquisar_Idosos
            // 
            this.btnPesquisar_Idosos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPesquisar_Idosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar_Idosos.Location = new System.Drawing.Point(1121, 49);
            this.btnPesquisar_Idosos.Name = "btnPesquisar_Idosos";
            this.btnPesquisar_Idosos.Size = new System.Drawing.Size(159, 50);
            this.btnPesquisar_Idosos.TabIndex = 176;
            this.btnPesquisar_Idosos.Text = "Pesquisar Idosos";
            this.btnPesquisar_Idosos.UseVisualStyleBackColor = true;
            this.btnPesquisar_Idosos.Click += new System.EventHandler(this.btnPesquisar_Idosos_Click);
            // 
            // txtPesquisar_Idosos
            // 
            this.txtPesquisar_Idosos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPesquisar_Idosos.Location = new System.Drawing.Point(846, 66);
            this.txtPesquisar_Idosos.Name = "txtPesquisar_Idosos";
            this.txtPesquisar_Idosos.Size = new System.Drawing.Size(269, 20);
            this.txtPesquisar_Idosos.TabIndex = 175;
            this.txtPesquisar_Idosos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_Idosos_KeyDown);
            // 
            // pctrbxImagem2
            // 
            this.pctrbxImagem2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrbxImagem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pctrbxImagem2.Image = global::TCC_CasaDeApoio.Properties.Resources.bordaPreta;
            this.pctrbxImagem2.Location = new System.Drawing.Point(17, 354);
            this.pctrbxImagem2.Name = "pctrbxImagem2";
            this.pctrbxImagem2.Size = new System.Drawing.Size(1263, 316);
            this.pctrbxImagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem2.TabIndex = 177;
            this.pctrbxImagem2.TabStop = false;
            // 
            // dtgrdvwProntuarios
            // 
            this.dtgrdvwProntuarios.AllowUserToAddRows = false;
            this.dtgrdvwProntuarios.AllowUserToDeleteRows = false;
            this.dtgrdvwProntuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrdvwProntuarios.AutoGenerateColumns = false;
            this.dtgrdvwProntuarios.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvwProntuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvwProntuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwProntuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProntuarioDataGridViewTextBoxColumn,
            this.idososDataGridViewTextBoxColumn,
            this.enfermidadesDataGridViewTextBoxColumn,
            this.alimentosDataGridViewTextBoxColumn,
            this.remediosDataGridViewTextBoxColumn,
            this.dataCriacaoDataGridViewTextBoxColumn,
            this.dataUsoDataGridViewTextBoxColumn,
            this.prescricaoObservacoesDataGridViewTextBoxColumn,
            this.iDIdosoDataGridViewTextBoxColumn,
            this.iDAlimentoDataGridViewTextBoxColumn,
            this.iDRemedioDataGridViewTextBoxColumn});
            this.dtgrdvwProntuarios.DataSource = this.prontuariosBindingSource;
            this.dtgrdvwProntuarios.Location = new System.Drawing.Point(17, 105);
            this.dtgrdvwProntuarios.Name = "dtgrdvwProntuarios";
            this.dtgrdvwProntuarios.ReadOnly = true;
            this.dtgrdvwProntuarios.RowHeadersVisible = false;
            this.dtgrdvwProntuarios.Size = new System.Drawing.Size(1263, 243);
            this.dtgrdvwProntuarios.TabIndex = 174;
            this.dtgrdvwProntuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvwProntuarios_CellClick);
            // 
            // prontuariosBindingSource
            // 
            this.prontuariosBindingSource.DataMember = "Prontuarios";
            this.prontuariosBindingSource.DataSource = this.casaDeApoioNossoLarDataSetProntuarios;
            // 
            // casaDeApoioNossoLarDataSetProntuarios
            // 
            this.casaDeApoioNossoLarDataSetProntuarios.DataSetName = "CasaDeApoioNossoLarDataSetProntuarios";
            this.casaDeApoioNossoLarDataSetProntuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblVisualizar_Prontuarios
            // 
            this.lblVisualizar_Prontuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVisualizar_Prontuarios.AutoSize = true;
            this.lblVisualizar_Prontuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblVisualizar_Prontuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizar_Prontuarios.Location = new System.Drawing.Point(467, 9);
            this.lblVisualizar_Prontuarios.Name = "lblVisualizar_Prontuarios";
            this.lblVisualizar_Prontuarios.Size = new System.Drawing.Size(353, 37);
            this.lblVisualizar_Prontuarios.TabIndex = 173;
            this.lblVisualizar_Prontuarios.Text = "Visualizar Prontuários";
            // 
            // lblEnfermidade
            // 
            this.lblEnfermidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEnfermidade.AutoSize = true;
            this.lblEnfermidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEnfermidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnfermidade.Location = new System.Drawing.Point(199, 508);
            this.lblEnfermidade.Name = "lblEnfermidade";
            this.lblEnfermidade.Size = new System.Drawing.Size(116, 20);
            this.lblEnfermidade.TabIndex = 181;
            this.lblEnfermidade.Text = "Enfermidade:";
            // 
            // lblIdoso
            // 
            this.lblIdoso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdoso.AutoSize = true;
            this.lblIdoso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblIdoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdoso.Location = new System.Drawing.Point(232, 410);
            this.lblIdoso.Name = "lblIdoso";
            this.lblIdoso.Size = new System.Drawing.Size(59, 20);
            this.lblIdoso.TabIndex = 178;
            this.lblIdoso.Text = "Idoso:";
            // 
            // cbxAlterar_Idosos
            // 
            this.cbxAlterar_Idosos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAlterar_Idosos.DisplayMember = "Nome";
            this.cbxAlterar_Idosos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlterar_Idosos.FormattingEnabled = true;
            this.cbxAlterar_Idosos.Location = new System.Drawing.Point(356, 412);
            this.cbxAlterar_Idosos.Name = "cbxAlterar_Idosos";
            this.cbxAlterar_Idosos.Size = new System.Drawing.Size(186, 21);
            this.cbxAlterar_Idosos.TabIndex = 199;
            this.cbxAlterar_Idosos.ValueMember = "ID_Idoso";
            this.cbxAlterar_Idosos.Click += new System.EventHandler(this.cbxAlterar_Excluir_Idosos_Click);
            // 
            // lblRemedio
            // 
            this.lblRemedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRemedio.AutoSize = true;
            this.lblRemedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblRemedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemedio.Location = new System.Drawing.Point(637, 458);
            this.lblRemedio.Name = "lblRemedio";
            this.lblRemedio.Size = new System.Drawing.Size(85, 20);
            this.lblRemedio.TabIndex = 180;
            this.lblRemedio.Text = "Remédio:";
            // 
            // cbxAlterar_Remedios
            // 
            this.cbxAlterar_Remedios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAlterar_Remedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.cbxAlterar_Remedios.DisplayMember = "Nome";
            this.cbxAlterar_Remedios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlterar_Remedios.Enabled = false;
            this.cbxAlterar_Remedios.FormattingEnabled = true;
            this.cbxAlterar_Remedios.Location = new System.Drawing.Point(763, 458);
            this.cbxAlterar_Remedios.Name = "cbxAlterar_Remedios";
            this.cbxAlterar_Remedios.Size = new System.Drawing.Size(186, 21);
            this.cbxAlterar_Remedios.TabIndex = 201;
            this.cbxAlterar_Remedios.ValueMember = "ID_Remedio";
            this.cbxAlterar_Remedios.Click += new System.EventHandler(this.cbxAlterar_Excluir_Remedios_Click);
            // 
            // lblAlimento
            // 
            this.lblAlimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAlimento.AutoSize = true;
            this.lblAlimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlimento.Location = new System.Drawing.Point(207, 550);
            this.lblAlimento.Name = "lblAlimento";
            this.lblAlimento.Size = new System.Drawing.Size(84, 20);
            this.lblAlimento.TabIndex = 179;
            this.lblAlimento.Text = "Alimento:";
            // 
            // cbxAlterar_Alimentos
            // 
            this.cbxAlterar_Alimentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAlterar_Alimentos.DisplayMember = "Nome";
            this.cbxAlterar_Alimentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlterar_Alimentos.FormattingEnabled = true;
            this.cbxAlterar_Alimentos.Location = new System.Drawing.Point(356, 549);
            this.cbxAlterar_Alimentos.Name = "cbxAlterar_Alimentos";
            this.cbxAlterar_Alimentos.Size = new System.Drawing.Size(186, 21);
            this.cbxAlterar_Alimentos.TabIndex = 200;
            this.cbxAlterar_Alimentos.ValueMember = "ID_Alimento";
            this.cbxAlterar_Alimentos.Click += new System.EventHandler(this.cbxAlterar_Excluir_Alimentos_Click);
            // 
            // txtAlterar_Enfermidades
            // 
            this.txtAlterar_Enfermidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Enfermidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtAlterar_Enfermidades.Enabled = false;
            this.txtAlterar_Enfermidades.Location = new System.Drawing.Point(356, 510);
            this.txtAlterar_Enfermidades.Name = "txtAlterar_Enfermidades";
            this.txtAlterar_Enfermidades.Size = new System.Drawing.Size(244, 20);
            this.txtAlterar_Enfermidades.TabIndex = 183;
            // 
            // btnLimpar_Prontuario
            // 
            this.btnLimpar_Prontuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar_Prontuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar_Prontuario.Location = new System.Drawing.Point(685, 598);
            this.btnLimpar_Prontuario.Name = "btnLimpar_Prontuario";
            this.btnLimpar_Prontuario.Size = new System.Drawing.Size(135, 50);
            this.btnLimpar_Prontuario.TabIndex = 202;
            this.btnLimpar_Prontuario.Text = "Limpar Item Selecionado";
            this.btnLimpar_Prontuario.UseVisualStyleBackColor = true;
            this.btnLimpar_Prontuario.Click += new System.EventHandler(this.btnLimpar_Prontuario_Click);
            // 
            // btnAlterar_Prontuario
            // 
            this.btnAlterar_Prontuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar_Prontuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar_Prontuario.Location = new System.Drawing.Point(450, 597);
            this.btnAlterar_Prontuario.Name = "btnAlterar_Prontuario";
            this.btnAlterar_Prontuario.Size = new System.Drawing.Size(135, 51);
            this.btnAlterar_Prontuario.TabIndex = 203;
            this.btnAlterar_Prontuario.Text = "Alterar";
            this.btnAlterar_Prontuario.UseVisualStyleBackColor = true;
            this.btnAlterar_Prontuario.Click += new System.EventHandler(this.btnAlterar_Prontuario_Click);
            // 
            // txtAlterar_ID_Alimento
            // 
            this.txtAlterar_ID_Alimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_ID_Alimento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAlterar_ID_Alimento.Enabled = false;
            this.txtAlterar_ID_Alimento.Location = new System.Drawing.Point(1154, 427);
            this.txtAlterar_ID_Alimento.Name = "txtAlterar_ID_Alimento";
            this.txtAlterar_ID_Alimento.ReadOnly = true;
            this.txtAlterar_ID_Alimento.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_ID_Alimento.TabIndex = 204;
            this.txtAlterar_ID_Alimento.Visible = false;
            // 
            // txtAlterar_ID_Remedio
            // 
            this.txtAlterar_ID_Remedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_ID_Remedio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAlterar_ID_Remedio.Enabled = false;
            this.txtAlterar_ID_Remedio.Location = new System.Drawing.Point(1154, 457);
            this.txtAlterar_ID_Remedio.Name = "txtAlterar_ID_Remedio";
            this.txtAlterar_ID_Remedio.ReadOnly = true;
            this.txtAlterar_ID_Remedio.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_ID_Remedio.TabIndex = 205;
            this.txtAlterar_ID_Remedio.Visible = false;
            // 
            // txtAlterar_ID_Idoso
            // 
            this.txtAlterar_ID_Idoso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_ID_Idoso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAlterar_ID_Idoso.Enabled = false;
            this.txtAlterar_ID_Idoso.Location = new System.Drawing.Point(1154, 398);
            this.txtAlterar_ID_Idoso.Name = "txtAlterar_ID_Idoso";
            this.txtAlterar_ID_Idoso.ReadOnly = true;
            this.txtAlterar_ID_Idoso.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_ID_Idoso.TabIndex = 206;
            this.txtAlterar_ID_Idoso.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 209;
            this.label1.Text = "O Idoso possui";
            // 
            // grpbxOpcoes
            // 
            this.grpbxOpcoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpbxOpcoes.Controls.Add(this.rdbtnAlterar_Nao);
            this.grpbxOpcoes.Controls.Add(this.rdbtnAlterar_Sim);
            this.grpbxOpcoes.Location = new System.Drawing.Point(356, 455);
            this.grpbxOpcoes.Name = "grpbxOpcoes";
            this.grpbxOpcoes.Size = new System.Drawing.Size(186, 40);
            this.grpbxOpcoes.TabIndex = 208;
            this.grpbxOpcoes.TabStop = false;
            // 
            // rdbtnAlterar_Nao
            // 
            this.rdbtnAlterar_Nao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnAlterar_Nao.AutoSize = true;
            this.rdbtnAlterar_Nao.Checked = true;
            this.rdbtnAlterar_Nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnAlterar_Nao.Location = new System.Drawing.Point(108, 10);
            this.rdbtnAlterar_Nao.Name = "rdbtnAlterar_Nao";
            this.rdbtnAlterar_Nao.Size = new System.Drawing.Size(59, 24);
            this.rdbtnAlterar_Nao.TabIndex = 1;
            this.rdbtnAlterar_Nao.TabStop = true;
            this.rdbtnAlterar_Nao.Text = "Não";
            this.rdbtnAlterar_Nao.UseVisualStyleBackColor = true;
            this.rdbtnAlterar_Nao.CheckedChanged += new System.EventHandler(this.rdbtnAlterar_Nao_CheckedChanged);
            // 
            // rdbtnAlterar_Sim
            // 
            this.rdbtnAlterar_Sim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbtnAlterar_Sim.AutoSize = true;
            this.rdbtnAlterar_Sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnAlterar_Sim.Location = new System.Drawing.Point(22, 10);
            this.rdbtnAlterar_Sim.Name = "rdbtnAlterar_Sim";
            this.rdbtnAlterar_Sim.Size = new System.Drawing.Size(57, 24);
            this.rdbtnAlterar_Sim.TabIndex = 0;
            this.rdbtnAlterar_Sim.Text = "Sim";
            this.rdbtnAlterar_Sim.UseVisualStyleBackColor = true;
            this.rdbtnAlterar_Sim.CheckedChanged += new System.EventHandler(this.rdbtnAlterar_Sim_CheckedChanged);
            // 
            // lblPossui
            // 
            this.lblPossui.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPossui.AutoSize = true;
            this.lblPossui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblPossui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPossui.Location = new System.Drawing.Point(199, 475);
            this.lblPossui.Name = "lblPossui";
            this.lblPossui.Size = new System.Drawing.Size(121, 20);
            this.lblPossui.TabIndex = 207;
            this.lblPossui.Text = "Enfermidade?";
            // 
            // lblCódigo_Idoso
            // 
            this.lblCódigo_Idoso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCódigo_Idoso.AutoSize = true;
            this.lblCódigo_Idoso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCódigo_Idoso.Enabled = false;
            this.lblCódigo_Idoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo_Idoso.Location = new System.Drawing.Point(980, 398);
            this.lblCódigo_Idoso.Name = "lblCódigo_Idoso";
            this.lblCódigo_Idoso.Size = new System.Drawing.Size(145, 20);
            this.lblCódigo_Idoso.TabIndex = 210;
            this.lblCódigo_Idoso.Text = "Código do Idoso:";
            this.lblCódigo_Idoso.Visible = false;
            // 
            // lblCódigo_Remedio
            // 
            this.lblCódigo_Remedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCódigo_Remedio.AutoSize = true;
            this.lblCódigo_Remedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCódigo_Remedio.Enabled = false;
            this.lblCódigo_Remedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo_Remedio.Location = new System.Drawing.Point(955, 457);
            this.lblCódigo_Remedio.Name = "lblCódigo_Remedio";
            this.lblCódigo_Remedio.Size = new System.Drawing.Size(166, 20);
            this.lblCódigo_Remedio.TabIndex = 211;
            this.lblCódigo_Remedio.Text = "Código do Remédio";
            this.lblCódigo_Remedio.Visible = false;
            // 
            // lblCódigo_Alimento
            // 
            this.lblCódigo_Alimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCódigo_Alimento.AutoSize = true;
            this.lblCódigo_Alimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCódigo_Alimento.Enabled = false;
            this.lblCódigo_Alimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCódigo_Alimento.Location = new System.Drawing.Point(955, 427);
            this.lblCódigo_Alimento.Name = "lblCódigo_Alimento";
            this.lblCódigo_Alimento.Size = new System.Drawing.Size(170, 20);
            this.lblCódigo_Alimento.TabIndex = 212;
            this.lblCódigo_Alimento.Text = "Código do Alimento:";
            this.lblCódigo_Alimento.Visible = false;
            // 
            // lblObservações
            // 
            this.lblObservações.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObservações.AutoSize = true;
            this.lblObservações.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblObservações.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservações.Location = new System.Drawing.Point(620, 550);
            this.lblObservações.Name = "lblObservações";
            this.lblObservações.Size = new System.Drawing.Size(118, 20);
            this.lblObservações.TabIndex = 219;
            this.lblObservações.Text = "Observações:";
            // 
            // lblPrescricao
            // 
            this.lblPrescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPrescricao.AutoSize = true;
            this.lblPrescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblPrescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrescricao.Location = new System.Drawing.Point(620, 530);
            this.lblPrescricao.Name = "lblPrescricao";
            this.lblPrescricao.Size = new System.Drawing.Size(118, 20);
            this.lblPrescricao.TabIndex = 218;
            this.lblPrescricao.Text = "Prescrição ou";
            // 
            // lblData_Uso
            // 
            this.lblData_Uso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData_Uso.AutoSize = true;
            this.lblData_Uso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblData_Uso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData_Uso.Location = new System.Drawing.Point(623, 498);
            this.lblData_Uso.Name = "lblData_Uso";
            this.lblData_Uso.Size = new System.Drawing.Size(115, 20);
            this.lblData_Uso.TabIndex = 217;
            this.lblData_Uso.Text = "Data de Uso:";
            // 
            // lblData_Criacao
            // 
            this.lblData_Criacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData_Criacao.AutoSize = true;
            this.lblData_Criacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblData_Criacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData_Criacao.Location = new System.Drawing.Point(980, 488);
            this.lblData_Criacao.Name = "lblData_Criacao";
            this.lblData_Criacao.Size = new System.Drawing.Size(144, 20);
            this.lblData_Criacao.TabIndex = 216;
            this.lblData_Criacao.Text = "Data de Criacao:";
            this.lblData_Criacao.Visible = false;
            // 
            // txtAlterar_Prescricao_Observacoes
            // 
            this.txtAlterar_Prescricao_Observacoes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Prescricao_Observacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.txtAlterar_Prescricao_Observacoes.Enabled = false;
            this.txtAlterar_Prescricao_Observacoes.Location = new System.Drawing.Point(763, 549);
            this.txtAlterar_Prescricao_Observacoes.Name = "txtAlterar_Prescricao_Observacoes";
            this.txtAlterar_Prescricao_Observacoes.Size = new System.Drawing.Size(266, 20);
            this.txtAlterar_Prescricao_Observacoes.TabIndex = 215;
            // 
            // dttmpckAlterar_Data_Criacao
            // 
            this.dttmpckAlterar_Data_Criacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dttmpckAlterar_Data_Criacao.Enabled = false;
            this.dttmpckAlterar_Data_Criacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckAlterar_Data_Criacao.Location = new System.Drawing.Point(1154, 488);
            this.dttmpckAlterar_Data_Criacao.Name = "dttmpckAlterar_Data_Criacao";
            this.dttmpckAlterar_Data_Criacao.Size = new System.Drawing.Size(105, 20);
            this.dttmpckAlterar_Data_Criacao.TabIndex = 213;
            this.dttmpckAlterar_Data_Criacao.Visible = false;
            // 
            // btnGerar_Relatorio_PDF
            // 
            this.btnGerar_Relatorio_PDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerar_Relatorio_PDF.Enabled = false;
            this.btnGerar_Relatorio_PDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar_Relatorio_PDF.Location = new System.Drawing.Point(236, 35);
            this.btnGerar_Relatorio_PDF.Name = "btnGerar_Relatorio_PDF";
            this.btnGerar_Relatorio_PDF.Size = new System.Drawing.Size(158, 39);
            this.btnGerar_Relatorio_PDF.TabIndex = 225;
            this.btnGerar_Relatorio_PDF.Text = "Gerar Relatório dos Prontuários em PDF";
            this.btnGerar_Relatorio_PDF.UseVisualStyleBackColor = true;
            this.btnGerar_Relatorio_PDF.Click += new System.EventHandler(this.btnGerar_Relatorio_PDF_Click);
            // 
            // btnProcurar_Salvar_Relatorio
            // 
            this.btnProcurar_Salvar_Relatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProcurar_Salvar_Relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar_Salvar_Relatorio.Location = new System.Drawing.Point(17, 35);
            this.btnProcurar_Salvar_Relatorio.Name = "btnProcurar_Salvar_Relatorio";
            this.btnProcurar_Salvar_Relatorio.Size = new System.Drawing.Size(158, 39);
            this.btnProcurar_Salvar_Relatorio.TabIndex = 224;
            this.btnProcurar_Salvar_Relatorio.Text = "Procurar local para salvar o Relatório";
            this.btnProcurar_Salvar_Relatorio.UseVisualStyleBackColor = true;
            this.btnProcurar_Salvar_Relatorio.Click += new System.EventHandler(this.btnProcurar_Salvar_Relatorio_Click);
            // 
            // txtRelatorio_PDF
            // 
            this.txtRelatorio_PDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRelatorio_PDF.Enabled = false;
            this.txtRelatorio_PDF.Location = new System.Drawing.Point(17, 80);
            this.txtRelatorio_PDF.Name = "txtRelatorio_PDF";
            this.txtRelatorio_PDF.Size = new System.Drawing.Size(633, 20);
            this.txtRelatorio_PDF.TabIndex = 223;
            // 
            // dttmpckAlterar_Data_Uso
            // 
            this.dttmpckAlterar_Data_Uso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckAlterar_Data_Uso.Location = new System.Drawing.Point(801, 498);
            this.dttmpckAlterar_Data_Uso.Name = "dttmpckAlterar_Data_Uso";
            this.dttmpckAlterar_Data_Uso.Size = new System.Drawing.Size(105, 20);
            this.dttmpckAlterar_Data_Uso.TabIndex = 226;
            // 
            // prontuariosTableAdapter
            // 
            this.prontuariosTableAdapter.ClearBeforeFill = true;
            // 
            // iDProntuarioDataGridViewTextBoxColumn
            // 
            this.iDProntuarioDataGridViewTextBoxColumn.DataPropertyName = "ID_Prontuario";
            this.iDProntuarioDataGridViewTextBoxColumn.HeaderText = "Código do Prontuário";
            this.iDProntuarioDataGridViewTextBoxColumn.Name = "iDProntuarioDataGridViewTextBoxColumn";
            this.iDProntuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDProntuarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDProntuarioDataGridViewTextBoxColumn.Width = 120;
            // 
            // idososDataGridViewTextBoxColumn
            // 
            this.idososDataGridViewTextBoxColumn.DataPropertyName = "Idosos";
            this.idososDataGridViewTextBoxColumn.HeaderText = "Idosos";
            this.idososDataGridViewTextBoxColumn.Name = "idososDataGridViewTextBoxColumn";
            this.idososDataGridViewTextBoxColumn.ReadOnly = true;
            this.idososDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.idososDataGridViewTextBoxColumn.Width = 300;
            // 
            // enfermidadesDataGridViewTextBoxColumn
            // 
            this.enfermidadesDataGridViewTextBoxColumn.DataPropertyName = "Enfermidades";
            this.enfermidadesDataGridViewTextBoxColumn.HeaderText = "Enfermidades";
            this.enfermidadesDataGridViewTextBoxColumn.Name = "enfermidadesDataGridViewTextBoxColumn";
            this.enfermidadesDataGridViewTextBoxColumn.ReadOnly = true;
            this.enfermidadesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.enfermidadesDataGridViewTextBoxColumn.Width = 300;
            // 
            // alimentosDataGridViewTextBoxColumn
            // 
            this.alimentosDataGridViewTextBoxColumn.DataPropertyName = "Alimentos";
            this.alimentosDataGridViewTextBoxColumn.HeaderText = "Alimentos";
            this.alimentosDataGridViewTextBoxColumn.Name = "alimentosDataGridViewTextBoxColumn";
            this.alimentosDataGridViewTextBoxColumn.ReadOnly = true;
            this.alimentosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.alimentosDataGridViewTextBoxColumn.Width = 300;
            // 
            // remediosDataGridViewTextBoxColumn
            // 
            this.remediosDataGridViewTextBoxColumn.DataPropertyName = "Remedios";
            this.remediosDataGridViewTextBoxColumn.HeaderText = "Remédios";
            this.remediosDataGridViewTextBoxColumn.Name = "remediosDataGridViewTextBoxColumn";
            this.remediosDataGridViewTextBoxColumn.ReadOnly = true;
            this.remediosDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.remediosDataGridViewTextBoxColumn.Width = 300;
            // 
            // dataCriacaoDataGridViewTextBoxColumn
            // 
            this.dataCriacaoDataGridViewTextBoxColumn.DataPropertyName = "Data_Criacao";
            this.dataCriacaoDataGridViewTextBoxColumn.HeaderText = "Data de Criação";
            this.dataCriacaoDataGridViewTextBoxColumn.Name = "dataCriacaoDataGridViewTextBoxColumn";
            this.dataCriacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataCriacaoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataUsoDataGridViewTextBoxColumn
            // 
            this.dataUsoDataGridViewTextBoxColumn.DataPropertyName = "Data_Uso";
            this.dataUsoDataGridViewTextBoxColumn.HeaderText = "Data de Uso";
            this.dataUsoDataGridViewTextBoxColumn.Name = "dataUsoDataGridViewTextBoxColumn";
            this.dataUsoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataUsoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // prescricaoObservacoesDataGridViewTextBoxColumn
            // 
            this.prescricaoObservacoesDataGridViewTextBoxColumn.DataPropertyName = "Prescricao_Observacoes";
            this.prescricaoObservacoesDataGridViewTextBoxColumn.HeaderText = "Prescrição ou Observações";
            this.prescricaoObservacoesDataGridViewTextBoxColumn.Name = "prescricaoObservacoesDataGridViewTextBoxColumn";
            this.prescricaoObservacoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.prescricaoObservacoesDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.prescricaoObservacoesDataGridViewTextBoxColumn.Width = 400;
            // 
            // iDIdosoDataGridViewTextBoxColumn
            // 
            this.iDIdosoDataGridViewTextBoxColumn.DataPropertyName = "ID_Idoso";
            this.iDIdosoDataGridViewTextBoxColumn.HeaderText = "Código do Idoso";
            this.iDIdosoDataGridViewTextBoxColumn.Name = "iDIdosoDataGridViewTextBoxColumn";
            this.iDIdosoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDIdosoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDIdosoDataGridViewTextBoxColumn.Width = 110;
            // 
            // iDAlimentoDataGridViewTextBoxColumn
            // 
            this.iDAlimentoDataGridViewTextBoxColumn.DataPropertyName = "ID_Alimento";
            this.iDAlimentoDataGridViewTextBoxColumn.HeaderText = "Código do Alimento";
            this.iDAlimentoDataGridViewTextBoxColumn.Name = "iDAlimentoDataGridViewTextBoxColumn";
            this.iDAlimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAlimentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDAlimentoDataGridViewTextBoxColumn.Width = 110;
            // 
            // iDRemedioDataGridViewTextBoxColumn
            // 
            this.iDRemedioDataGridViewTextBoxColumn.DataPropertyName = "ID_Remedio";
            this.iDRemedioDataGridViewTextBoxColumn.HeaderText = "Código do Remédio";
            this.iDRemedioDataGridViewTextBoxColumn.Name = "iDRemedioDataGridViewTextBoxColumn";
            this.iDRemedioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRemedioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDRemedioDataGridViewTextBoxColumn.Width = 110;
            // 
            // VisualizarProntuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1296, 676);
            this.Controls.Add(this.dttmpckAlterar_Data_Uso);
            this.Controls.Add(this.btnGerar_Relatorio_PDF);
            this.Controls.Add(this.btnProcurar_Salvar_Relatorio);
            this.Controls.Add(this.txtRelatorio_PDF);
            this.Controls.Add(this.lblObservações);
            this.Controls.Add(this.lblPrescricao);
            this.Controls.Add(this.lblData_Uso);
            this.Controls.Add(this.lblData_Criacao);
            this.Controls.Add(this.txtAlterar_Prescricao_Observacoes);
            this.Controls.Add(this.dttmpckAlterar_Data_Criacao);
            this.Controls.Add(this.lblCódigo_Alimento);
            this.Controls.Add(this.lblCódigo_Remedio);
            this.Controls.Add(this.lblCódigo_Idoso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpbxOpcoes);
            this.Controls.Add(this.lblPossui);
            this.Controls.Add(this.txtAlterar_ID_Idoso);
            this.Controls.Add(this.txtAlterar_ID_Remedio);
            this.Controls.Add(this.txtAlterar_ID_Alimento);
            this.Controls.Add(this.btnAlterar_Prontuario);
            this.Controls.Add(this.btnLimpar_Prontuario);
            this.Controls.Add(this.cbxAlterar_Remedios);
            this.Controls.Add(this.cbxAlterar_Alimentos);
            this.Controls.Add(this.cbxAlterar_Idosos);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.txtAlterar_ID_Prontuario);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblEnfermidade);
            this.Controls.Add(this.lblRemedio);
            this.Controls.Add(this.lblAlimento);
            this.Controls.Add(this.txtAlterar_Enfermidades);
            this.Controls.Add(this.lblIdoso);
            this.Controls.Add(this.btnPesquisar_Idosos);
            this.Controls.Add(this.txtPesquisar_Idosos);
            this.Controls.Add(this.pctrbxImagem2);
            this.Controls.Add(this.dtgrdvwProntuarios);
            this.Controls.Add(this.lblVisualizar_Prontuarios);
            this.Controls.Add(this.pctrbxImagem1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarProntuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Prontuários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisualizarEnfermidade_FormClosing);
            this.Load += new System.EventHandler(this.VisualizarProntuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwProntuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prontuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetProntuarios)).EndInit();
            this.grpbxOpcoes.ResumeLayout(false);
            this.grpbxOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxImagem1;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.TextBox txtAlterar_ID_Prontuario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnPesquisar_Idosos;
        private System.Windows.Forms.TextBox txtPesquisar_Idosos;
        private System.Windows.Forms.PictureBox pctrbxImagem2;
        private System.Windows.Forms.DataGridView dtgrdvwProntuarios;
        private System.Windows.Forms.Label lblVisualizar_Prontuarios;
        private System.Windows.Forms.Label lblEnfermidade;
        private System.Windows.Forms.Label lblIdoso;
        private System.Windows.Forms.ComboBox cbxAlterar_Idosos;
        private System.Windows.Forms.Label lblRemedio;
        private System.Windows.Forms.ComboBox cbxAlterar_Remedios;
        private System.Windows.Forms.Label lblAlimento;
        private System.Windows.Forms.ComboBox cbxAlterar_Alimentos;
        private System.Windows.Forms.TextBox txtAlterar_Enfermidades;
        private System.Windows.Forms.Button btnLimpar_Prontuario;
        private System.Windows.Forms.Button btnAlterar_Prontuario;
        private System.Windows.Forms.TextBox txtAlterar_ID_Alimento;
        private System.Windows.Forms.TextBox txtAlterar_ID_Remedio;
        private System.Windows.Forms.TextBox txtAlterar_ID_Idoso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbxOpcoes;
        private System.Windows.Forms.RadioButton rdbtnAlterar_Nao;
        private System.Windows.Forms.RadioButton rdbtnAlterar_Sim;
        private System.Windows.Forms.Label lblPossui;
        private System.Windows.Forms.Label lblCódigo_Idoso;
        private System.Windows.Forms.Label lblCódigo_Remedio;
        private System.Windows.Forms.Label lblCódigo_Alimento;
        private System.Windows.Forms.Label lblObservações;
        private System.Windows.Forms.Label lblPrescricao;
        private System.Windows.Forms.Label lblData_Uso;
        private System.Windows.Forms.Label lblData_Criacao;
        private System.Windows.Forms.TextBox txtAlterar_Prescricao_Observacoes;
        private System.Windows.Forms.DateTimePicker dttmpckAlterar_Data_Criacao;
        private System.Windows.Forms.Button btnGerar_Relatorio_PDF;
        private System.Windows.Forms.Button btnProcurar_Salvar_Relatorio;
        private System.Windows.Forms.TextBox txtRelatorio_PDF;
        private System.Windows.Forms.DateTimePicker dttmpckAlterar_Data_Uso;
        private CasaDeApoioNossoLarDataSetProntuarios casaDeApoioNossoLarDataSetProntuarios;
        private System.Windows.Forms.BindingSource prontuariosBindingSource;
        private CasaDeApoioNossoLarDataSetProntuariosTableAdapters.ProntuariosTableAdapter prontuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProntuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idososDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enfermidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alimentosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remediosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCriacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataUsoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescricaoObservacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDIdosoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRemedioDataGridViewTextBoxColumn;
    }
}