namespace TCC_CasaDeApoio.Registrar
{
    partial class RegistrarAlimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarAlimento));
            this.lblRegistrar_Alimentos = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.txtID_Alimento = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dttmpckValidade = new System.Windows.Forms.DateTimePicker();
            this.pctrbxImagem = new System.Windows.Forms.PictureBox();
            this.lblObrigatorio = new System.Windows.Forms.Label();
            this.cbxPeso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrar_Alimentos
            // 
            this.lblRegistrar_Alimentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistrar_Alimentos.AutoSize = true;
            this.lblRegistrar_Alimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblRegistrar_Alimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar_Alimentos.Location = new System.Drawing.Point(226, 9);
            this.lblRegistrar_Alimentos.Name = "lblRegistrar_Alimentos";
            this.lblRegistrar_Alimentos.Size = new System.Drawing.Size(350, 37);
            this.lblRegistrar_Alimentos.TabIndex = 33;
            this.lblRegistrar_Alimentos.Text = "Registro de Alimentos";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnidade.Location = new System.Drawing.Point(179, 231);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(105, 20);
            this.txtUnidade.TabIndex = 31;
            this.txtUnidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUnidade_KeyDown);
            this.txtUnidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUnidade_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(179, 153);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 30;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNome_KeyDown);
            // 
            // lblUnidade
            // 
            this.lblUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(63, 231);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(88, 20);
            this.lblUnidade.TabIndex = 28;
            this.lblUnidade.Text = "Unidade*:";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(88, 193);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 20);
            this.lblMarca.TabIndex = 27;
            this.lblMarca.Text = "Marca:";
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(454, 232);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(125, 20);
            this.lblPeso.TabIndex = 34;
            this.lblPeso.Text = "Tipo de Peso*:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstoque.Location = new System.Drawing.Point(606, 191);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(105, 20);
            this.txtEstoque.TabIndex = 37;
            this.txtEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEstoque_KeyDown);
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEstoque_KeyPress);
            // 
            // lblEstoque
            // 
            this.lblEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(491, 193);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(88, 20);
            this.lblEstoque.TabIndex = 36;
            this.lblEstoque.Text = "Estoque*:";
            // 
            // txtID_Alimento
            // 
            this.txtID_Alimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID_Alimento.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID_Alimento.Enabled = false;
            this.txtID_Alimento.Location = new System.Drawing.Point(179, 116);
            this.txtID_Alimento.Name = "txtID_Alimento";
            this.txtID_Alimento.ReadOnly = true;
            this.txtID_Alimento.Size = new System.Drawing.Size(186, 20);
            this.txtID_Alimento.TabIndex = 41;
            this.txtID_Alimento.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(81, 114);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 40;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // lblValidade
            // 
            this.lblValidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidade.AutoSize = true;
            this.lblValidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(488, 153);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(91, 20);
            this.lblValidade.TabIndex = 42;
            this.lblValidade.Text = "Validade*:";
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.Location = new System.Drawing.Point(179, 193);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(186, 20);
            this.txtMarca.TabIndex = 45;
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMarca_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(84, 153);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 20);
            this.lblNome.TabIndex = 44;
            this.lblNome.Text = "Nome*:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(245, 366);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 52);
            this.btnRegistrar.TabIndex = 47;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(450, 366);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 52);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Text = "Limpar Item Selecionado";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dttmpckValidade
            // 
            this.dttmpckValidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dttmpckValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckValidade.Location = new System.Drawing.Point(606, 153);
            this.dttmpckValidade.Name = "dttmpckValidade";
            this.dttmpckValidade.Size = new System.Drawing.Size(105, 20);
            this.dttmpckValidade.TabIndex = 51;
            this.dttmpckValidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dttmpckValidade_KeyDown);
            // 
            // pctrbxImagem
            // 
            this.pctrbxImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbxImagem.Image = global::TCC_CasaDeApoio.Properties.Resources.WallpapaerCasaDeApoio;
            this.pctrbxImagem.Location = new System.Drawing.Point(0, 0);
            this.pctrbxImagem.Name = "pctrbxImagem";
            this.pctrbxImagem.Size = new System.Drawing.Size(800, 450);
            this.pctrbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem.TabIndex = 52;
            this.pctrbxImagem.TabStop = false;
            // 
            // lblObrigatorio
            // 
            this.lblObrigatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObrigatorio.AutoSize = true;
            this.lblObrigatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrigatorio.Location = new System.Drawing.Point(540, 306);
            this.lblObrigatorio.Name = "lblObrigatorio";
            this.lblObrigatorio.Size = new System.Drawing.Size(171, 20);
            this.lblObrigatorio.TabIndex = 82;
            this.lblObrigatorio.Text = "*Campo Obrigatório.";
            // 
            // cbxPeso
            // 
            this.cbxPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeso.FormattingEnabled = true;
            this.cbxPeso.Items.AddRange(new object[] {
            "Quilogramas (KG)",
            "Gramas (G)",
            "Litros (L)",
            "Inteiro"});
            this.cbxPeso.Location = new System.Drawing.Point(606, 231);
            this.cbxPeso.Name = "cbxPeso";
            this.cbxPeso.Size = new System.Drawing.Size(105, 21);
            this.cbxPeso.TabIndex = 83;
            this.cbxPeso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPeso_KeyDown);
            // 
            // RegistrarAlimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxPeso);
            this.Controls.Add(this.lblObrigatorio);
            this.Controls.Add(this.dttmpckValidade);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.txtID_Alimento);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblRegistrar_Alimentos);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.pctrbxImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarAlimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Alimentos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarAlimento_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrar_Alimentos;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.TextBox txtID_Alimento;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DateTimePicker dttmpckValidade;
        private System.Windows.Forms.PictureBox pctrbxImagem;
        private System.Windows.Forms.Label lblObrigatorio;
        private System.Windows.Forms.ComboBox cbxPeso;
    }
}