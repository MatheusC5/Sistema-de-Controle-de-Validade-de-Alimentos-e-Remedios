namespace TCC_CasaDeApoio.Visualizar
{
    partial class VisualizarRemedio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarRemedio));
            this.pctrbxImagem1 = new System.Windows.Forms.PictureBox();
            this.lblEditar_Excluir = new System.Windows.Forms.Label();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.btnAlterar_Remedio = new System.Windows.Forms.Button();
            this.btnLimpar_Remedio = new System.Windows.Forms.Button();
            this.btnExcluir_Remedio = new System.Windows.Forms.Button();
            this.dttmpckAlterar_Excluir_Validade = new System.Windows.Forms.DateTimePicker();
            this.txtAlterar_Excluir_Marca = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.txtAlterar_Excluir_ID_Remedio = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtAlterar_Excluir_Estoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtAlterar_Excluir_Unidade = new System.Windows.Forms.TextBox();
            this.txtAlterar_Excluir_Nome = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblValidade_Remedios = new System.Windows.Forms.Label();
            this.btnFora_Validade = new System.Windows.Forms.Button();
            this.btnDentro_Validade = new System.Windows.Forms.Button();
            this.pctrbxImagem2 = new System.Windows.Forms.PictureBox();
            this.dtgrdvwRemedios = new System.Windows.Forms.DataGridView();
            this.remediosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casaDeApoioNossoLarDataSetRemedios = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetRemedios();
            this.lblVisualizar_Remedios = new System.Windows.Forms.Label();
            this.cbxAlterar_Excluir_Peso = new System.Windows.Forms.ComboBox();
            this.remediosTableAdapter = new TCC_CasaDeApoio.CasaDeApoioNossoLarDataSetRemediosTableAdapters.RemediosTableAdapter();
            this.iDRemedioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwRemedios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remediosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetRemedios)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrbxImagem1
            // 
            this.pctrbxImagem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbxImagem1.Image = global::TCC_CasaDeApoio.Properties.Resources.WallpapaerCasaDeApoio;
            this.pctrbxImagem1.Location = new System.Drawing.Point(0, 0);
            this.pctrbxImagem1.Name = "pctrbxImagem1";
            this.pctrbxImagem1.Size = new System.Drawing.Size(1296, 657);
            this.pctrbxImagem1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem1.TabIndex = 0;
            this.pctrbxImagem1.TabStop = false;
            // 
            // lblEditar_Excluir
            // 
            this.lblEditar_Excluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEditar_Excluir.AutoSize = true;
            this.lblEditar_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEditar_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar_Excluir.Location = new System.Drawing.Point(504, 366);
            this.lblEditar_Excluir.Name = "lblEditar_Excluir";
            this.lblEditar_Excluir.Size = new System.Drawing.Size(205, 20);
            this.lblEditar_Excluir.TabIndex = 201;
            this.lblEditar_Excluir.Text = "para editá-lo ou excluí-lo";
            // 
            // lblSelecione
            // 
            this.lblSelecione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(461, 346);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(305, 20);
            this.lblSelecione.TabIndex = 200;
            this.lblSelecione.Text = "Selecione um Remédio na tela acima";
            // 
            // btnAlterar_Remedio
            // 
            this.btnAlterar_Remedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlterar_Remedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar_Remedio.Location = new System.Drawing.Point(362, 575);
            this.btnAlterar_Remedio.Name = "btnAlterar_Remedio";
            this.btnAlterar_Remedio.Size = new System.Drawing.Size(135, 51);
            this.btnAlterar_Remedio.TabIndex = 197;
            this.btnAlterar_Remedio.Text = "Alterar";
            this.btnAlterar_Remedio.UseVisualStyleBackColor = true;
            this.btnAlterar_Remedio.Click += new System.EventHandler(this.btnAlterar_Remedio_Click);
            // 
            // btnLimpar_Remedio
            // 
            this.btnLimpar_Remedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar_Remedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar_Remedio.Location = new System.Drawing.Point(574, 576);
            this.btnLimpar_Remedio.Name = "btnLimpar_Remedio";
            this.btnLimpar_Remedio.Size = new System.Drawing.Size(135, 50);
            this.btnLimpar_Remedio.TabIndex = 199;
            this.btnLimpar_Remedio.Text = "Limpar Item Selecionado";
            this.btnLimpar_Remedio.UseVisualStyleBackColor = true;
            this.btnLimpar_Remedio.Click += new System.EventHandler(this.btnLimpar_Remedio_Click);
            // 
            // btnExcluir_Remedio
            // 
            this.btnExcluir_Remedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir_Remedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir_Remedio.Location = new System.Drawing.Point(788, 575);
            this.btnExcluir_Remedio.Name = "btnExcluir_Remedio";
            this.btnExcluir_Remedio.Size = new System.Drawing.Size(135, 51);
            this.btnExcluir_Remedio.TabIndex = 198;
            this.btnExcluir_Remedio.Text = "Excluir";
            this.btnExcluir_Remedio.UseVisualStyleBackColor = true;
            this.btnExcluir_Remedio.Click += new System.EventHandler(this.btnExcluir_Remedio_Click);
            // 
            // dttmpckAlterar_Excluir_Validade
            // 
            this.dttmpckAlterar_Excluir_Validade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dttmpckAlterar_Excluir_Validade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckAlterar_Excluir_Validade.Location = new System.Drawing.Point(818, 447);
            this.dttmpckAlterar_Excluir_Validade.Name = "dttmpckAlterar_Excluir_Validade";
            this.dttmpckAlterar_Excluir_Validade.Size = new System.Drawing.Size(105, 20);
            this.dttmpckAlterar_Excluir_Validade.TabIndex = 190;
            this.dttmpckAlterar_Excluir_Validade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dttmpckAlterar_Excluir_Validade_KeyDown);
            // 
            // txtAlterar_Excluir_Marca
            // 
            this.txtAlterar_Excluir_Marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Marca.Location = new System.Drawing.Point(406, 489);
            this.txtAlterar_Excluir_Marca.Name = "txtAlterar_Excluir_Marca";
            this.txtAlterar_Excluir_Marca.Size = new System.Drawing.Size(186, 20);
            this.txtAlterar_Excluir_Marca.TabIndex = 187;
            this.txtAlterar_Excluir_Marca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Marca_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(312, 447);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 186;
            this.lblNome.Text = "Nome:";
            // 
            // lblValidade
            // 
            this.lblValidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidade.AutoSize = true;
            this.lblValidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(712, 447);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(84, 20);
            this.lblValidade.TabIndex = 185;
            this.lblValidade.Text = "Validade:";
            // 
            // txtAlterar_Excluir_ID_Remedio
            // 
            this.txtAlterar_Excluir_ID_Remedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_ID_Remedio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtAlterar_Excluir_ID_Remedio.Enabled = false;
            this.txtAlterar_Excluir_ID_Remedio.Location = new System.Drawing.Point(406, 406);
            this.txtAlterar_Excluir_ID_Remedio.Name = "txtAlterar_Excluir_ID_Remedio";
            this.txtAlterar_Excluir_ID_Remedio.ReadOnly = true;
            this.txtAlterar_Excluir_ID_Remedio.Size = new System.Drawing.Size(85, 20);
            this.txtAlterar_Excluir_ID_Remedio.TabIndex = 184;
            this.txtAlterar_Excluir_ID_Remedio.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(302, 406);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 183;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // txtAlterar_Excluir_Estoque
            // 
            this.txtAlterar_Excluir_Estoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Estoque.Location = new System.Drawing.Point(818, 491);
            this.txtAlterar_Excluir_Estoque.Name = "txtAlterar_Excluir_Estoque";
            this.txtAlterar_Excluir_Estoque.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_Excluir_Estoque.TabIndex = 182;
            this.txtAlterar_Excluir_Estoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Estoque_KeyDown);
            this.txtAlterar_Excluir_Estoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlterar_Excluir_Estoque_KeyPress);
            // 
            // lblEstoque
            // 
            this.lblEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(715, 489);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(81, 20);
            this.lblEstoque.TabIndex = 181;
            this.lblEstoque.Text = "Estoque:";
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(726, 532);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(54, 20);
            this.lblPeso.TabIndex = 179;
            this.lblPeso.Text = "Peso:";
            // 
            // txtAlterar_Excluir_Unidade
            // 
            this.txtAlterar_Excluir_Unidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Unidade.Location = new System.Drawing.Point(406, 532);
            this.txtAlterar_Excluir_Unidade.Name = "txtAlterar_Excluir_Unidade";
            this.txtAlterar_Excluir_Unidade.Size = new System.Drawing.Size(105, 20);
            this.txtAlterar_Excluir_Unidade.TabIndex = 178;
            this.txtAlterar_Excluir_Unidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Unidade_KeyDown);
            this.txtAlterar_Excluir_Unidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlterar_Excluir_Unidade_KeyPress);
            // 
            // txtAlterar_Excluir_Nome
            // 
            this.txtAlterar_Excluir_Nome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAlterar_Excluir_Nome.Location = new System.Drawing.Point(406, 447);
            this.txtAlterar_Excluir_Nome.Name = "txtAlterar_Excluir_Nome";
            this.txtAlterar_Excluir_Nome.Size = new System.Drawing.Size(186, 20);
            this.txtAlterar_Excluir_Nome.TabIndex = 177;
            this.txtAlterar_Excluir_Nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAlterar_Excluir_Nome_KeyDown);
            // 
            // lblUnidade
            // 
            this.lblUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(291, 532);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(81, 20);
            this.lblUnidade.TabIndex = 176;
            this.lblUnidade.Text = "Unidade:";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(309, 489);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 20);
            this.lblMarca.TabIndex = 175;
            this.lblMarca.Text = "Marca:";
            // 
            // lblValidade_Remedios
            // 
            this.lblValidade_Remedios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidade_Remedios.AutoSize = true;
            this.lblValidade_Remedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblValidade_Remedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade_Remedios.Location = new System.Drawing.Point(343, 77);
            this.lblValidade_Remedios.Name = "lblValidade_Remedios";
            this.lblValidade_Remedios.Size = new System.Drawing.Size(206, 20);
            this.lblValidade_Remedios.TabIndex = 174;
            this.lblValidade_Remedios.Text = "Validade Dos Remédios:";
            // 
            // btnFora_Validade
            // 
            this.btnFora_Validade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFora_Validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFora_Validade.Location = new System.Drawing.Point(731, 60);
            this.btnFora_Validade.Name = "btnFora_Validade";
            this.btnFora_Validade.Size = new System.Drawing.Size(103, 54);
            this.btnFora_Validade.TabIndex = 173;
            this.btnFora_Validade.Text = "Fora da Validade";
            this.btnFora_Validade.UseVisualStyleBackColor = true;
            this.btnFora_Validade.Click += new System.EventHandler(this.btnFora_Validade_Click);
            // 
            // btnDentro_Validade
            // 
            this.btnDentro_Validade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDentro_Validade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDentro_Validade.Location = new System.Drawing.Point(590, 60);
            this.btnDentro_Validade.Name = "btnDentro_Validade";
            this.btnDentro_Validade.Size = new System.Drawing.Size(103, 54);
            this.btnDentro_Validade.TabIndex = 172;
            this.btnDentro_Validade.Text = "Dentro da Validade";
            this.btnDentro_Validade.UseVisualStyleBackColor = true;
            this.btnDentro_Validade.Click += new System.EventHandler(this.btnDentro_Validade_Click);
            // 
            // pctrbxImagem2
            // 
            this.pctrbxImagem2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrbxImagem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.pctrbxImagem2.Image = global::TCC_CasaDeApoio.Properties.Resources.bordaPreta;
            this.pctrbxImagem2.Location = new System.Drawing.Point(17, 337);
            this.pctrbxImagem2.Name = "pctrbxImagem2";
            this.pctrbxImagem2.Size = new System.Drawing.Size(1263, 313);
            this.pctrbxImagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem2.TabIndex = 171;
            this.pctrbxImagem2.TabStop = false;
            // 
            // dtgrdvwRemedios
            // 
            this.dtgrdvwRemedios.AllowUserToAddRows = false;
            this.dtgrdvwRemedios.AllowUserToDeleteRows = false;
            this.dtgrdvwRemedios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrdvwRemedios.AutoGenerateColumns = false;
            this.dtgrdvwRemedios.BackgroundColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdvwRemedios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrdvwRemedios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrdvwRemedios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRemedioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.validadeDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.pesoDataGridViewTextBoxColumn});
            this.dtgrdvwRemedios.DataSource = this.remediosBindingSource;
            this.dtgrdvwRemedios.Location = new System.Drawing.Point(17, 120);
            this.dtgrdvwRemedios.Name = "dtgrdvwRemedios";
            this.dtgrdvwRemedios.ReadOnly = true;
            this.dtgrdvwRemedios.RowHeadersVisible = false;
            this.dtgrdvwRemedios.Size = new System.Drawing.Size(1263, 211);
            this.dtgrdvwRemedios.TabIndex = 170;
            this.dtgrdvwRemedios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdvwRemedios_CellClick);
            // 
            // remediosBindingSource
            // 
            this.remediosBindingSource.DataMember = "Remedios";
            this.remediosBindingSource.DataSource = this.casaDeApoioNossoLarDataSetRemedios;
            // 
            // casaDeApoioNossoLarDataSetRemedios
            // 
            this.casaDeApoioNossoLarDataSetRemedios.DataSetName = "CasaDeApoioNossoLarDataSetRemedios";
            this.casaDeApoioNossoLarDataSetRemedios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblVisualizar_Remedios
            // 
            this.lblVisualizar_Remedios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVisualizar_Remedios.AutoSize = true;
            this.lblVisualizar_Remedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblVisualizar_Remedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualizar_Remedios.Location = new System.Drawing.Point(458, 9);
            this.lblVisualizar_Remedios.Name = "lblVisualizar_Remedios";
            this.lblVisualizar_Remedios.Size = new System.Drawing.Size(327, 37);
            this.lblVisualizar_Remedios.TabIndex = 169;
            this.lblVisualizar_Remedios.Text = "Visualizar Remédios";
            // 
            // cbxAlterar_Excluir_Peso
            // 
            this.cbxAlterar_Excluir_Peso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxAlterar_Excluir_Peso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlterar_Excluir_Peso.FormattingEnabled = true;
            this.cbxAlterar_Excluir_Peso.Items.AddRange(new object[] {
            "Gramas (G)",
            "Mililitros (ML)",
            "Inteiro"});
            this.cbxAlterar_Excluir_Peso.Location = new System.Drawing.Point(818, 534);
            this.cbxAlterar_Excluir_Peso.Name = "cbxAlterar_Excluir_Peso";
            this.cbxAlterar_Excluir_Peso.Size = new System.Drawing.Size(105, 21);
            this.cbxAlterar_Excluir_Peso.TabIndex = 202;
            this.cbxAlterar_Excluir_Peso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxAlterar_Excluir_Peso_KeyDown);
            // 
            // remediosTableAdapter
            // 
            this.remediosTableAdapter.ClearBeforeFill = true;
            // 
            // iDRemedioDataGridViewTextBoxColumn
            // 
            this.iDRemedioDataGridViewTextBoxColumn.DataPropertyName = "ID_Remedio";
            this.iDRemedioDataGridViewTextBoxColumn.HeaderText = "Código do Remédio";
            this.iDRemedioDataGridViewTextBoxColumn.Name = "iDRemedioDataGridViewTextBoxColumn";
            this.iDRemedioDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDRemedioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.iDRemedioDataGridViewTextBoxColumn.Width = 150;
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
            // VisualizarRemedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1296, 657);
            this.Controls.Add(this.cbxAlterar_Excluir_Peso);
            this.Controls.Add(this.lblEditar_Excluir);
            this.Controls.Add(this.lblSelecione);
            this.Controls.Add(this.btnAlterar_Remedio);
            this.Controls.Add(this.btnLimpar_Remedio);
            this.Controls.Add(this.btnExcluir_Remedio);
            this.Controls.Add(this.dttmpckAlterar_Excluir_Validade);
            this.Controls.Add(this.txtAlterar_Excluir_Marca);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.txtAlterar_Excluir_ID_Remedio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtAlterar_Excluir_Estoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.txtAlterar_Excluir_Unidade);
            this.Controls.Add(this.txtAlterar_Excluir_Nome);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblValidade_Remedios);
            this.Controls.Add(this.btnFora_Validade);
            this.Controls.Add(this.btnDentro_Validade);
            this.Controls.Add(this.pctrbxImagem2);
            this.Controls.Add(this.dtgrdvwRemedios);
            this.Controls.Add(this.lblVisualizar_Remedios);
            this.Controls.Add(this.pctrbxImagem1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarRemedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visualizar Remédios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VisualizarRemedio_FormClosing);
            this.Load += new System.EventHandler(this.VisualizarRemedio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdvwRemedios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remediosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casaDeApoioNossoLarDataSetRemedios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrbxImagem1;
        private System.Windows.Forms.Label lblEditar_Excluir;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.Button btnAlterar_Remedio;
        private System.Windows.Forms.Button btnLimpar_Remedio;
        private System.Windows.Forms.Button btnExcluir_Remedio;
        private System.Windows.Forms.DateTimePicker dttmpckAlterar_Excluir_Validade;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_Marca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_ID_Remedio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_Estoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_Unidade;
        private System.Windows.Forms.TextBox txtAlterar_Excluir_Nome;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblValidade_Remedios;
        private System.Windows.Forms.Button btnFora_Validade;
        private System.Windows.Forms.Button btnDentro_Validade;
        private System.Windows.Forms.PictureBox pctrbxImagem2;
        private System.Windows.Forms.DataGridView dtgrdvwRemedios;
        private System.Windows.Forms.Label lblVisualizar_Remedios;
        private System.Windows.Forms.ComboBox cbxAlterar_Excluir_Peso;
        private CasaDeApoioNossoLarDataSetRemedios casaDeApoioNossoLarDataSetRemedios;
        private System.Windows.Forms.BindingSource remediosBindingSource;
        private CasaDeApoioNossoLarDataSetRemediosTableAdapters.RemediosTableAdapter remediosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRemedioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesoDataGridViewTextBoxColumn;
    }
}