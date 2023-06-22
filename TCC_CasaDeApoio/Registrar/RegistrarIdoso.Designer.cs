namespace TCC_CasaDeApoio.Registrar
{
    partial class RegistrarIdoso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarIdoso));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblData_Nascimento = new System.Windows.Forms.Label();
            this.lblRegistrar_Idosos = new System.Windows.Forms.Label();
            this.txtID_Idoso = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dttmpckData_Nascimento = new System.Windows.Forms.DateTimePicker();
            this.lblEndereco_Responsavel = new System.Windows.Forms.Label();
            this.txtEndereco_Responsavel = new System.Windows.Forms.TextBox();
            this.pctrbxImagem = new System.Windows.Forms.PictureBox();
            this.txtTelefone_Responsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular_Responsavel = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone_Responsavel = new System.Windows.Forms.Label();
            this.lblCelular_Responsavel = new System.Windows.Forms.Label();
            this.lblTelefone_Emergencia = new System.Windows.Forms.Label();
            this.txtTelefone_Emergencia = new System.Windows.Forms.MaskedTextBox();
            this.lblObrigatorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.Location = new System.Drawing.Point(334, 132);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(186, 20);
            this.txtNome.TabIndex = 4;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNome_KeyDown);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(244, 132);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 20);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome*:";
            // 
            // lblData_Nascimento
            // 
            this.lblData_Nascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData_Nascimento.AutoSize = true;
            this.lblData_Nascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblData_Nascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData_Nascimento.Location = new System.Drawing.Point(127, 169);
            this.lblData_Nascimento.Name = "lblData_Nascimento";
            this.lblData_Nascimento.Size = new System.Drawing.Size(184, 20);
            this.lblData_Nascimento.TabIndex = 16;
            this.lblData_Nascimento.Text = "Data de Nascimento*:";
            // 
            // lblRegistrar_Idosos
            // 
            this.lblRegistrar_Idosos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegistrar_Idosos.AutoSize = true;
            this.lblRegistrar_Idosos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblRegistrar_Idosos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar_Idosos.Location = new System.Drawing.Point(262, 9);
            this.lblRegistrar_Idosos.Name = "lblRegistrar_Idosos";
            this.lblRegistrar_Idosos.Size = new System.Drawing.Size(300, 37);
            this.lblRegistrar_Idosos.TabIndex = 17;
            this.lblRegistrar_Idosos.Text = "Registro de Idosos";
            // 
            // txtID_Idoso
            // 
            this.txtID_Idoso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID_Idoso.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID_Idoso.Enabled = false;
            this.txtID_Idoso.Location = new System.Drawing.Point(334, 93);
            this.txtID_Idoso.Name = "txtID_Idoso";
            this.txtID_Idoso.ReadOnly = true;
            this.txtID_Idoso.Size = new System.Drawing.Size(186, 20);
            this.txtID_Idoso.TabIndex = 60;
            this.txtID_Idoso.Visible = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(241, 93);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(70, 20);
            this.lblCodigo.TabIndex = 59;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(433, 415);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 52);
            this.btnLimpar.TabIndex = 64;
            this.btnLimpar.Text = "Limpar Item Selecionado";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(238, 415);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(129, 52);
            this.btnRegistrar.TabIndex = 61;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dttmpckData_Nascimento
            // 
            this.dttmpckData_Nascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dttmpckData_Nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmpckData_Nascimento.Location = new System.Drawing.Point(334, 169);
            this.dttmpckData_Nascimento.Name = "dttmpckData_Nascimento";
            this.dttmpckData_Nascimento.Size = new System.Drawing.Size(105, 20);
            this.dttmpckData_Nascimento.TabIndex = 65;
            this.dttmpckData_Nascimento.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dttmpckData_Nascimento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DttmpckData_Nascimento_KeyDown);
            // 
            // lblEndereco_Responsavel
            // 
            this.lblEndereco_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEndereco_Responsavel.AutoSize = true;
            this.lblEndereco_Responsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblEndereco_Responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco_Responsavel.Location = new System.Drawing.Point(80, 209);
            this.lblEndereco_Responsavel.Name = "lblEndereco_Responsavel";
            this.lblEndereco_Responsavel.Size = new System.Drawing.Size(231, 20);
            this.lblEndereco_Responsavel.TabIndex = 66;
            this.lblEndereco_Responsavel.Text = "Endereço do Responsável*:";
            // 
            // txtEndereco_Responsavel
            // 
            this.txtEndereco_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEndereco_Responsavel.Location = new System.Drawing.Point(334, 209);
            this.txtEndereco_Responsavel.Name = "txtEndereco_Responsavel";
            this.txtEndereco_Responsavel.Size = new System.Drawing.Size(389, 20);
            this.txtEndereco_Responsavel.TabIndex = 67;
            this.txtEndereco_Responsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEndereco_Responsavel_KeyDown);
            // 
            // pctrbxImagem
            // 
            this.pctrbxImagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pctrbxImagem.Image = global::TCC_CasaDeApoio.Properties.Resources.WallpapaerCasaDeApoio;
            this.pctrbxImagem.Location = new System.Drawing.Point(0, 0);
            this.pctrbxImagem.Name = "pctrbxImagem";
            this.pctrbxImagem.Size = new System.Drawing.Size(800, 493);
            this.pctrbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem.TabIndex = 71;
            this.pctrbxImagem.TabStop = false;
            // 
            // txtTelefone_Responsavel
            // 
            this.txtTelefone_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone_Responsavel.Location = new System.Drawing.Point(334, 247);
            this.txtTelefone_Responsavel.Mask = "(00) 0000-0000";
            this.txtTelefone_Responsavel.Name = "txtTelefone_Responsavel";
            this.txtTelefone_Responsavel.Size = new System.Drawing.Size(105, 20);
            this.txtTelefone_Responsavel.TabIndex = 73;
            this.txtTelefone_Responsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTelefone_Responsavel_KeyDown);
            // 
            // txtCelular_Responsavel
            // 
            this.txtCelular_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCelular_Responsavel.Location = new System.Drawing.Point(334, 282);
            this.txtCelular_Responsavel.Mask = "(00) 00000-0000";
            this.txtCelular_Responsavel.Name = "txtCelular_Responsavel";
            this.txtCelular_Responsavel.Size = new System.Drawing.Size(105, 20);
            this.txtCelular_Responsavel.TabIndex = 74;
            this.txtCelular_Responsavel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCelular_Responsavel_KeyDown);
            // 
            // lblTelefone_Responsavel
            // 
            this.lblTelefone_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone_Responsavel.AutoSize = true;
            this.lblTelefone_Responsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblTelefone_Responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone_Responsavel.Location = new System.Drawing.Point(87, 247);
            this.lblTelefone_Responsavel.Name = "lblTelefone_Responsavel";
            this.lblTelefone_Responsavel.Size = new System.Drawing.Size(224, 20);
            this.lblTelefone_Responsavel.TabIndex = 76;
            this.lblTelefone_Responsavel.Text = "Telefone do Responsável*:";
            // 
            // lblCelular_Responsavel
            // 
            this.lblCelular_Responsavel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCelular_Responsavel.AutoSize = true;
            this.lblCelular_Responsavel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblCelular_Responsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular_Responsavel.Location = new System.Drawing.Point(108, 282);
            this.lblCelular_Responsavel.Name = "lblCelular_Responsavel";
            this.lblCelular_Responsavel.Size = new System.Drawing.Size(203, 20);
            this.lblCelular_Responsavel.TabIndex = 77;
            this.lblCelular_Responsavel.Text = "Celular do Responsável:";
            // 
            // lblTelefone_Emergencia
            // 
            this.lblTelefone_Emergencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelefone_Emergencia.AutoSize = true;
            this.lblTelefone_Emergencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblTelefone_Emergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone_Emergencia.Location = new System.Drawing.Point(102, 323);
            this.lblTelefone_Emergencia.Name = "lblTelefone_Emergencia";
            this.lblTelefone_Emergencia.Size = new System.Drawing.Size(209, 20);
            this.lblTelefone_Emergencia.TabIndex = 79;
            this.lblTelefone_Emergencia.Text = "Telefone de Emergência:";
            // 
            // txtTelefone_Emergencia
            // 
            this.txtTelefone_Emergencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelefone_Emergencia.Location = new System.Drawing.Point(334, 323);
            this.txtTelefone_Emergencia.Mask = "(00) 0000-0000";
            this.txtTelefone_Emergencia.Name = "txtTelefone_Emergencia";
            this.txtTelefone_Emergencia.Size = new System.Drawing.Size(105, 20);
            this.txtTelefone_Emergencia.TabIndex = 78;
            this.txtTelefone_Emergencia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTelefone_Emergencia_KeyDown);
            // 
            // lblObrigatorio
            // 
            this.lblObrigatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblObrigatorio.AutoSize = true;
            this.lblObrigatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lblObrigatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObrigatorio.Location = new System.Drawing.Point(552, 350);
            this.lblObrigatorio.Name = "lblObrigatorio";
            this.lblObrigatorio.Size = new System.Drawing.Size(171, 20);
            this.lblObrigatorio.TabIndex = 81;
            this.lblObrigatorio.Text = "*Campo Obrigatório.";
            // 
            // RegistrarIdoso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.lblObrigatorio);
            this.Controls.Add(this.lblTelefone_Emergencia);
            this.Controls.Add(this.txtTelefone_Emergencia);
            this.Controls.Add(this.lblCelular_Responsavel);
            this.Controls.Add(this.lblTelefone_Responsavel);
            this.Controls.Add(this.txtCelular_Responsavel);
            this.Controls.Add(this.txtTelefone_Responsavel);
            this.Controls.Add(this.txtEndereco_Responsavel);
            this.Controls.Add(this.lblEndereco_Responsavel);
            this.Controls.Add(this.dttmpckData_Nascimento);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtID_Idoso);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblRegistrar_Idosos);
            this.Controls.Add(this.lblData_Nascimento);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pctrbxImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarIdoso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Idosos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarIdoso_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblData_Nascimento;
        private System.Windows.Forms.Label lblRegistrar_Idosos;
        private System.Windows.Forms.TextBox txtID_Idoso;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dttmpckData_Nascimento;
        private System.Windows.Forms.Label lblEndereco_Responsavel;
        private System.Windows.Forms.TextBox txtEndereco_Responsavel;
        private System.Windows.Forms.PictureBox pctrbxImagem;
        private System.Windows.Forms.MaskedTextBox txtTelefone_Responsavel;
        private System.Windows.Forms.MaskedTextBox txtCelular_Responsavel;
        private System.Windows.Forms.Label lblTelefone_Responsavel;
        private System.Windows.Forms.Label lblCelular_Responsavel;
        private System.Windows.Forms.Label lblTelefone_Emergencia;
        private System.Windows.Forms.MaskedTextBox txtTelefone_Emergencia;
        private System.Windows.Forms.Label lblObrigatorio;
    }
}