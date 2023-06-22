namespace TCC_CasaDeApoio.Registrar
{
    partial class RegistrarRemedio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarRemedio));
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.txtID_Remedio = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblRegistrar_Remedios = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dttmpckValidade = new System.Windows.Forms.DateTimePicker();
            this.pctrbxImagem = new System.Windows.Forms.PictureBox();
            this.lblObrigatorio = new System.Windows.Forms.Label();
            this.cbxPeso = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMarca.Location = new System.Drawing.Point(176, 196);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(186, 20);
            this.txtMarca.TabIndex = 61;
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMarca_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(82, 158);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 20);
            this.lblNome.TabIndex = 60;
            this.lblNome.Text = "Nome*:";
            // 
            // lblValidade
            // 
            this.lblValidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblValidade.AutoSize = true;
            this.lblValidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblValidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.Location = new System.Drawing.Point(478, 158);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(91, 20);
            this.lblValidade.TabIndex = 59;
            this.lblValidade.Text = "Validade*:";
            // 
            // txtID_Remedio
            // 
            this.txtID_Remedio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID_Remedio.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID_Remedio.Enabled = false;
            this.txtID_Remedio.Location = new System.Drawing.Point(176, 116);
            this.txtID_Remedio.Name = "txtID_Remedio";
            this.txtID_Remedio.ReadOnly = true;
            this.txtID_Remedio.Size = new System.Drawing.Size(186, 20);
            this.txtID_Remedio.TabIndex = 58;
            this.txtID_Remedio.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(79, 116);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 57;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstoque.Location = new System.Drawing.Point(617, 198);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(105, 20);
            this.txtEstoque.TabIndex = 56;
            this.txtEstoque.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEstoque_KeyDown);
            this.txtEstoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEstoque_KeyPress);
            // 
            // lblEstoque
            // 
            this.lblEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoque.Location = new System.Drawing.Point(481, 198);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(88, 20);
            this.lblEstoque.TabIndex = 55;
            this.lblEstoque.Text = "Estoque*:";
            // 
            // lblPeso
            // 
            this.lblPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(444, 237);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(125, 20);
            this.lblPeso.TabIndex = 53;
            this.lblPeso.Text = "Tipo de Peso*:";
            // 
            // lblRegistrar_Remedios
            // 
            this.lblRegistrar_Remedios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistrar_Remedios.AutoSize = true;
            this.lblRegistrar_Remedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblRegistrar_Remedios.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar_Remedios.Location = new System.Drawing.Point(216, 9);
            this.lblRegistrar_Remedios.Name = "lblRegistrar_Remedios";
            this.lblRegistrar_Remedios.Size = new System.Drawing.Size(350, 37);
            this.lblRegistrar_Remedios.TabIndex = 52;
            this.lblRegistrar_Remedios.Text = "Registro de Remédios";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUnidade.Location = new System.Drawing.Point(176, 235);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(105, 20);
            this.txtUnidade.TabIndex = 50;
            this.txtUnidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUnidade_KeyDown);
            this.txtUnidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUnidade_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(176, 157);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 49;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNome_KeyDown);
            // 
            // lblUnidade
            // 
            this.lblUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidade.Location = new System.Drawing.Point(61, 235);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(88, 20);
            this.lblUnidade.TabIndex = 48;
            this.lblUnidade.Text = "Unidade*:";
            // 
            // lblMarca
            // 
            this.lblMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(86, 194);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(63, 20);
            this.lblMarca.TabIndex = 47;
            this.lblMarca.Text = "Marca:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(437, 366);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 52);
            this.btnLimpar.TabIndex = 68;
            this.btnLimpar.Text = "Limpar Item Selecionado";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(233, 366);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 52);
            this.btnRegistrar.TabIndex = 65;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dttmpckValidade
            // 
            this.dttmpckValidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dttmpckValidade.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckValidade.Location = new System.Drawing.Point(617, 158);
            this.dttmpckValidade.Name = "dttmpckValidade";
            this.dttmpckValidade.Size = new System.Drawing.Size(105, 20);
            this.dttmpckValidade.TabIndex = 69;
            this.dttmpckValidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DttmpckValidade_KeyDown);
            // 
            // pctrbxImagem
            // 
            this.pctrbxImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbxImagem.Image = global::TCC_CasaDeApoio.Properties.Resources.WallpapaerCasaDeApoio;
            this.pctrbxImagem.Location = new System.Drawing.Point(0, 0);
            this.pctrbxImagem.Name = "pctrbxImagem";
            this.pctrbxImagem.Size = new System.Drawing.Size(800, 450);
            this.pctrbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem.TabIndex = 80;
            this.pctrbxImagem.TabStop = false;
            // 
            // lblObrigatorio
            // 
            this.lblObrigatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObrigatorio.AutoSize = true;
            this.lblObrigatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrigatorio.Location = new System.Drawing.Point(551, 310);
            this.lblObrigatorio.Name = "lblObrigatorio";
            this.lblObrigatorio.Size = new System.Drawing.Size(171, 20);
            this.lblObrigatorio.TabIndex = 84;
            this.lblObrigatorio.Text = "*Campo Obrigatório.";
            // 
            // cbxPeso
            // 
            this.cbxPeso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxPeso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPeso.FormattingEnabled = true;
            this.cbxPeso.Items.AddRange(new object[] {
            "Gramas (G)",
            "Mililitros (ML)",
            "Inteiro"});
            this.cbxPeso.Location = new System.Drawing.Point(617, 237);
            this.cbxPeso.Name = "cbxPeso";
            this.cbxPeso.Size = new System.Drawing.Size(105, 21);
            this.cbxPeso.TabIndex = 85;
            this.cbxPeso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxPeso_KeyDown);
            // 
            // RegistrarRemedio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxPeso);
            this.Controls.Add(this.lblObrigatorio);
            this.Controls.Add(this.dttmpckValidade);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.txtID_Remedio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblRegistrar_Remedios);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.pctrbxImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarRemedio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Remédios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarRemedio_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.TextBox txtID_Remedio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblRegistrar_Remedios;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dttmpckValidade;
        private System.Windows.Forms.PictureBox pctrbxImagem;
        private System.Windows.Forms.Label lblObrigatorio;
        private System.Windows.Forms.ComboBox cbxPeso;
    }
}