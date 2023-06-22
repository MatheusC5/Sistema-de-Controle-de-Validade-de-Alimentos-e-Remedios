namespace TCC_CasaDeApoio.Visualizar
{
    partial class VisualizarAlimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarAlimento));
            this.pctrbxImagem1 = new System.Windows.Forms.PictureBox();
            this.lblValidade_Alimentos = new System.Windows.Forms.Label();
            this.btnFora_Validade = new System.Windows.Forms.Button();
            this.btnDentro_Validade = new System.Windows.Forms.Button();
            this.lblVisualizar_Alimentos = new System.Windows.Forms.Label();
            this.btnAlterar_Alimento = new System.Windows.Forms.Button();
            this.btnLimpar_Alimento = new System.Windows.Forms.Button();
            this.btnExcluir_Alimento = new System.Windows.Forms.Button();
            this.lblEditar_Excluir = new System.Windows.Forms.Label();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.dttmpckAlterar_Excluir_Validade = new System.Windows.Forms.DateTimePicker();
            this.txtAlterar_Excluir_Marca = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.txtAlterar_Excluir_ID_Alimento = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtAlterar_Excluir_Estoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtAlterar_Excluir_Unidade = new System.Windows.Forms.TextBox();
            this.txtAlterar_Excluir_Nome = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.pctrbxImagem2 = new System.Windows.Forms.PictureBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.dtgrdvwAlimentos = new System.Windows.Forms.DataGridView();
            this.alimentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casaDeApoioNossoLarDataSetAlimentos = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetAlimentos();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxAlterar_Excluir_Peso = new System.Windows.Forms.ComboBox();
            this.alimentosTableAdapter = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetAlimentosTableAdapters.AlimentosTableAdapter();
            this.iDAlimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwAlimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetAlimentos)).BeginInit();
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
            // lblValidade_Alimentos
            // 
            this.lblValidade_Alimentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidade_Alimentos.AutoSize = true;
            this.lblValidade_Alimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade_Alimentos.Location = new System.Drawing.Point(349, 73);
            this.lblValidade_Alimentos.Name = "lblValidade_Alimentos";
            this.lblValidade_Alimentos.Size = new System.Drawing.Size(205, 20);
            this.lblValidade_Alimentos.TabIndex = 131;
            this.lblValidade_Alimentos.Text = "Validade Dos Alimentos:";
            // 
            // btnFora_Validade
            // 
            this.btnFora_Validade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFora_Validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFora_Validade.Location = new System.Drawing.Point(721, 56);
            this.btnFora_Validade.Name = "btnFora_Validade";
            this.btnFora_Validade.Size = new System.Drawing.Size(103, 54);
            this.btnFora_Validade.TabIndex = 130;
            this.btnFora_Validade.Text = "Fora da Validade";
            this.btnFora_Validade.UseVisualStyleBackColor = true;
            this.btnFora_Validade.Click += new System.EventHandler(this.btnFora_Validade_Click);
            // 
            // btnDentro_Validade
            // 
            this.btnDentro_Validade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDentro_Validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDentro_Validade.Location = new System.Drawing.Point(585, 56);
            this.btnDentro_Validade.Name = "btnDentro_Validade";
            this.btnDentro_Validade.Size = new System.Drawing.Size(103, 54);
            this.btnDentro_Validade.TabIndex = 129;
            this.btnDentro_Validade.Text = "Dentro da Validade";
            this.btnDentro_Validade.UseVisualStyleBackColor = true;
            this.btnDentro_Validade.Click += new System.EventHandler(this.btnDentro_Validade_Click);
            // 
            // lblVisualizar_Alimentos
            // 
            this.lblVisualizar_Alimentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVisualizar_Alimentos.AutoSize = true;
            this.lblVisualizar_Alimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizar_Alimentos.Location = new System.Drawing.Point(484, 9);
            this.lblVisualizar_Alimentos.Name = "lblVisualizar_Alimentos";
            this.lblVisualizar_Alimentos.Size = new System.Drawing.Size(327, 37);
            this.lblVisualizar_Alimentos.TabIndex = 128;
            this.lblVisualizar_Alimentos.Text = "Visualizar Alimentos";
            // 
            // btnAlterar_Alimento
            // 
            this.btnAlterar_Alimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar_Alimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar_Alimento.Location = new System.Drawing.Point(360, 598);
            this.btnAlterar_Alimento.Name = "btnAlterar_Alimento";
            this.btnAlterar_Alimento.Size = new System.Drawing.Size(135, 51);
            this.btnAlterar_Alimento.TabIndex = 125;
            this.btnAlterar_Alimento.Text = "Alterar";
            this.btnAlterar_Alimento.UseVisualStyleBackColor = true;
            this.btnAlterar_Alimento.Click += new System.EventHandler(this.btnAlterar_Alimento_Click);
            // 
            // btnLimpar_Alimento
            // 
            this.btnLimpar_Alimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar_Alimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar_Alimento.Location = new System.Drawing.Point(585, 598);
            this.btnLimpar_Alimento.Name = "btnLimpar_Alimento";
            this.btnLimpar_Alimento.Size = new System.Drawing.Size(135, 50);
            this.btnLimpar_Alimento.TabIndex = 127;
            this.btnLimpar_Alimento.Text = "Limpar Item Selecionado";
            this.btnLimpar_Alimento.UseVisualStyleBackColor = true;
            this.btnLimpar_Alimento.Click += new System.EventHandler(this.btnLimpar_Alimento_Click);
            // 
            // btnExcluir_Alimento
            // 
            this.btnExcluir_Alimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir_Alimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir_Alimento.Location = new System.Drawing.Point(803, 597);
            this.btnExcluir_Alimento.Name = "btnExcluir_Alimento";
            this.btnExcluir_Alimento.Size = new System.Drawing.Size(135, 51);
            this.btnExcluir_Alimento.TabIndex = 126;
            this.btnExcluir_Alimento.Text = "Excluir";
            this.btnExcluir_Alimento.UseVisualStyleBackColor = true;
            this.btnExcluir_Alimento.Click += new System.EventHandler(this.btnExcluir_Alimento_Click);
            // 
            // lblEditar_Excluir
            // 
            this.lblEditar_Excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditar_Excluir.AutoSize = true;
            this.lblEditar_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEditar_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar_Excluir.Location = new System.Drawing.Point(530, 395);
            this.lblEditar_Excluir.Name = "lblEditar_Excluir";
            this.lblEditar_Excluir.Size = new System.Drawing.Size(205, 20);
            this.lblEditar_Excluir.TabIndex = 124;
            this.lblEditar_Excluir.Text = "para editá-lo ou excluí-lo";
            // 
            // lblSelecione
            // 
            this.lblSelecione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(487, 375);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(304, 20);
            this.lblSelecione.TabIndex = 123;
            this.lblSelecione.Text = "Selecione um Alimento na tela acima";
            // 
            // dttmpckAlterar_Excluir_Validade
            // 
            this.dttmpckAlterar_Excluir_Validade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dttmpckAlterar_Excluir_Validade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckAlterar_Excluir_Validade.Location = new System.Drawing.Point(820, 471);
            this.dttmpckAlterar_Excluir_Validade.Name = "dttmpckAlterar_Excluir_Validade";
            this.dttmpckAlterar_Excluir_Validade.Size = new System.Drawing.Size(105, 20);
            this.dttmpckAlterar_Excluir_Validade.TabIndex = 122;
            this.dttmpckAlterar_Excluir_Validade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dttmpckAlterar_Excluir_Validade_KeyDown);
            // 
            // txtAlterar_Excluir_Marca
            // 
            this.txtAlterar_Excluir_Marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Marca.Location = new System.Drawing.Point(390, 513);
            this.txtAlterar_Excluir_Marca.Name = "txtAlterar_Excluir_Marca";
            this.txtAlterar_Excluir_Marca.Size = new System.Drawing.Size(186, 20);
            this.txtAlterar_Excluir_Marca.TabIndex = 121;
            this.txtAlterar_Excluir_Marca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Marca_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(292, 471);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 120;
            this.lblNome.Text = "Nome:";
            // 
            // lblValidade
            // 
            this.lblValidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidade.AutoSize = true;
            this.lblValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(705, 471);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(84, 20);
            this.lblValidade.TabIndex = 119;
            this.lblValidade.Text = "Validade:";
            // 
            // txtAlterar_Excluir_ID_Alimento
            // 
            this.txtAlterar_Excluir_ID_Alimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_ID_Alimento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAlterar_Excluir_ID_Alimento.Enabled = false;
            this.txtAlterar_Excluir_ID_Alimento.Location = new System.Drawing.Point(390, 430);
            this.txtAlterar_Excluir_ID_Alimento.Name = "txtAlterar_Excluir_ID_Alimento";
            this.txtAlterar_Excluir_ID_Alimento.ReadOnly = true;
            this.txtAlterar_Excluir_ID_Alimento.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_Excluir_ID_Alimento.TabIndex = 118;
            this.txtAlterar_Excluir_ID_Alimento.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(292, 430);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 117;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // txtAlterar_Excluir_Estoque
            // 
            this.txtAlterar_Excluir_Estoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Estoque.Location = new System.Drawing.Point(820, 515);
            this.txtAlterar_Excluir_Estoque.Name = "txtAlterar_Excluir_Estoque";
            this.txtAlterar_Excluir_Estoque.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_Excluir_Estoque.TabIndex = 116;
            this.txtAlterar_Excluir_Estoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Estoque_KeyDown);
            this.txtAlterar_Excluir_Estoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlterar_Excluir_Estoque_KeyPress);
            // 
            // lblEstoque
            // 
            this.lblEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(705, 513);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(81, 20);
            this.lblEstoque.TabIndex = 115;
            this.lblEstoque.Text = "Estoque:";
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(717, 553);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(54, 20);
            this.lblPeso.TabIndex = 113;
            this.lblPeso.Text = "Peso:";
            // 
            // txtAlterar_Excluir_Unidade
            // 
            this.txtAlterar_Excluir_Unidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Unidade.Location = new System.Drawing.Point(390, 553);
            this.txtAlterar_Excluir_Unidade.Name = "txtAlterar_Excluir_Unidade";
            this.txtAlterar_Excluir_Unidade.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_Excluir_Unidade.TabIndex = 112;
            this.txtAlterar_Excluir_Unidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Unidade_KeyDown);
            this.txtAlterar_Excluir_Unidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlterar_Excluir_Unidade_KeyPress);
            // 
            // txtAlterar_Excluir_Nome
            // 
            this.txtAlterar_Excluir_Nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Nome.Location = new System.Drawing.Point(390, 471);
            this.txtAlterar_Excluir_Nome.Name = "txtAlterar_Excluir_Nome";
            this.txtAlterar_Excluir_Nome.Size = new System.Drawing.Size(186, 20);
            this.txtAlterar_Excluir_Nome.TabIndex = 111;
            this.txtAlterar_Excluir_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Nome_KeyDown);
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(289, 513);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 20);
            this.lblMarca.TabIndex = 109;
            this.lblMarca.Text = "Marca:";
            // 
            // pctrbxImagem2
            // 
            this.pctrbxImagem2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrbxImagem2.Image = global::TCC_CasaDeApoio.Properties.Resources.bordaPreta;
            this.pctrbxImagem2.Location = new System.Drawing.Point(12, 360);
            this.pctrbxImagem2.Name = "pctrbxImagem2";
            this.pctrbxImagem2.Size = new System.Drawing.Size(1263, 307);
            this.pctrbxImagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem2.TabIndex = 108;
            this.pctrbxImagem2.TabStop = false;
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(271, 547);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(81, 20);
            this.lblUnidade.TabIndex = 110;
            this.lblUnidade.Text = "Unidade:";
            // 
            // dtgrdvwAlimentos
            // 
            this.dtgrdvwAlimentos.AllowUserToAddRows = false;
            this.dtgrdvwAlimentos.AllowUserToDeleteRows = false;
            this.dtgrdvwAlimentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrdvwAlimentos.AutoGenerateColumns = false;
            this.dtgrdvwAlimentos.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvwAlimentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvwAlimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwAlimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDAlimentoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.validadeDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn});
            this.dtgrdvwAlimentos.DataSource = this.alimentosBindingSource;
            this.dtgrdvwAlimentos.GridColor = System.Drawing.Color.MediumTurquoise;
            this.dtgrdvwAlimentos.Location = new System.Drawing.Point(12, 116);
            this.dtgrdvwAlimentos.Name = "dtgrdvwAlimentos";
            this.dtgrdvwAlimentos.ReadOnly = true;
            this.dtgrdvwAlimentos.RowHeadersVisible = false;
            this.dtgrdvwAlimentos.Size = new System.Drawing.Size(1263, 238);
            this.dtgrdvwAlimentos.TabIndex = 132;
            this.dtgrdvwAlimentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvwAlimentos_CellClick);
            // 
            // alimentosBindingSource
            // 
            this.alimentosBindingSource.DataMember = "Alimentos";
            this.alimentosBindingSource.DataSource = this.casaDeApoioNossoLarDataSetAlimentos;
            // 
            // casaDeApoioNossoLarDataSetAlimentos
            // 
            this.casaDeApoioNossoLarDataSetAlimentos.DataSetName = "CasaDeApoioNossoLarDataSetAlimentos";
            this.casaDeApoioNossoLarDataSetAlimentos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Unidade:";
            // 
            // cbxAlterar_Excluir_Peso
            // 
            this.cbxAlterar_Excluir_Peso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAlterar_Excluir_Peso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlterar_Excluir_Peso.FormattingEnabled = true;
            this.cbxAlterar_Excluir_Peso.Items.AddRange(new object[] {
            "Quilogramas (KG)",
            "Gramas (G)",
            "Litros (L)",
            "Inteiro"});
            this.cbxAlterar_Excluir_Peso.Location = new System.Drawing.Point(820, 555);
            this.cbxAlterar_Excluir_Peso.Name = "cbxAlterar_Excluir_Peso";
            this.cbxAlterar_Excluir_Peso.Size = new System.Drawing.Size(105, 21);
            this.cbxAlterar_Excluir_Peso.TabIndex = 134;
            this.cbxAlterar_Excluir_Peso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxAlterar_Excluir_Peso_KeyDown);
            // 
            // alimentosTableAdapter
            // 
            this.alimentosTableAdapter.ClearBeforeFill = true;
            // 
            // iDAlimentoDataGridViewTextBoxColumn
            // 
            this.iDAlimentoDataGridViewTextBoxColumn.DataPropertyName = "ID_Alimento";
            this.iDAlimentoDataGridViewTextBoxColumn.HeaderText = "Código do Alimento";
            this.iDAlimentoDataGridViewTextBoxColumn.Name = "iDAlimentoDataGridViewTextBoxColumn";
            this.iDAlimentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDAlimentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDAlimentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeDataGridViewTextBoxColumn.Width = 355;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.marcaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.marcaDataGridViewTextBoxColumn.Width = 355;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.unidadeDataGridViewTextBoxColumn.Width = 150;
            // 
            // validadeDataGridViewTextBoxColumn
            // 
            this.validadeDataGridViewTextBoxColumn.DataPropertyName = "Validade";
            this.validadeDataGridViewTextBoxColumn.HeaderText = "Validade";
            this.validadeDataGridViewTextBoxColumn.Name = "validadeDataGridViewTextBoxColumn";
            this.validadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.validadeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estoqueDataGridViewTextBoxColumn.Width = 150;
            // 
            // pesoDataGridViewTextBoxColumn
            // 
            this.pesoDataGridViewTextBoxColumn.DataPropertyName = "Peso";
            this.pesoDataGridViewTextBoxColumn.HeaderText = "Peso";
            this.pesoDataGridViewTextBoxColumn.Name = "pesoDataGridViewTextBoxColumn";
            this.pesoDataGridViewTextBoxColumn.ReadOnly = true;
            this.pesoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pesoDataGridViewTextBoxColumn.Width = 150;
            // 
            // VisualizarAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1296, 679);
            this.Controls.Add(this.cbxAlterar_Excluir_Peso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgrdvwAlimentos);
            this.Controls.Add(this.lblValidade_Alimentos);
            this.Controls.Add(this.btnFora_Validade);
            this.Controls.Add(this.btnDentro_Validade);
            this.Controls.Add(this.lblVisualizar_Alimentos);
            this.Controls.Add(this.btnAlterar_Alimento);
            this.Controls.Add(this.btnLimpar_Alimento);
            this.Controls.Add(this.btnExcluir_Alimento);
            this.Controls.Add(this.lblEditar_Excluir);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.dttmpckAlterar_Excluir_Validade);
            this.Controls.Add(this.txtAlterar_Excluir_Marca);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.txtAlterar_Excluir_ID_Alimento);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtAlterar_Excluir_Estoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtAlterar_Excluir_Unidade);
            this.Controls.Add(this.txtAlterar_Excluir_Nome);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.pctrbxImagem2);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.pctrbxImagem1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Alimentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisualizarAlimento_FormClosing);
            this.Load += new System.EventHandler(this.VisualizarAlimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwAlimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alimentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetAlimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblValidade_Alimentos;
        private System.Windows.Forms.Button btnFora_Validade;
        private System.Windows.Forms.Button btnDentro_Validade;
        private System.Windows.Forms.Label lblVisualizar_Alimentos;
        private System.Windows.Forms.Button btnAlterar_Alimento;
        private System.Windows.Forms.Button btnLimpar_Alimento;
        private System.Windows.Forms.Button btnExcluir_Alimento;
        private System.Windows.Forms.Label lblEditar_Excluir;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.DateTimePicker dttmpckAlterar_Excluir_Validade;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_Marca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_ID_Alimento;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_Estoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_Unidade;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_Nome;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.PictureBox pctrbxImagem2;
        private System.Windows.Forms.PictureBox pctrbxImagem1;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.DataGridView dtgrdvwAlimentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxAlterar_Excluir_Peso;
        private CasaDeApoioNossoLarDataSetAlimentos casaDeApoioNossoLarDataSetAlimentos;
        private System.Windows.Forms.BindingSource alimentosBindingSource;
        private CasaDeApoioNossoLarDataSetAlimentosTableAdapters.AlimentosTableAdapter alimentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAlimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
    }
}