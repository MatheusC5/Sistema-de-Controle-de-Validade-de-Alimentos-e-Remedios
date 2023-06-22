namespace TCC_CasaDeApoio
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.lblHora = new System.Windows.Forms.Label();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpRegIdo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpRegAli = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpRegRem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpRegPro = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpAtuEst = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpVisuIdo = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpVisuAli = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpVisuRem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpVisuPro = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpBckp = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlstpMnlUsr = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCasa_Apoio = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.pctrbxImagem2 = new System.Windows.Forms.PictureBox();
            this.pctrbxImagem3 = new System.Windows.Forms.PictureBox();
            this.pctrbxImagem = new System.Windows.Forms.PictureBox();
            this.lblJardim = new System.Windows.Forms.Label();
            this.mnPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(238, 218);
            this.lblHora.MinimumSize = new System.Drawing.Size(140, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(140, 31);
            this.lblHora.TabIndex = 1;
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.mnPrincipal.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.visualizarToolStripMenuItem,
            this.tlstpBckp,
            this.ajudaToolStripMenuItem});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(800, 45);
            this.mnPrincipal.TabIndex = 2;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstpRegIdo,
            this.tlstpRegAli,
            this.tlstpRegRem,
            this.tlstpRegPro,
            this.tlstpAtuEst});
            this.registrarToolStripMenuItem.Margin = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(133, 41);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // tlstpRegIdo
            // 
            this.tlstpRegIdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.tlstpRegIdo.Name = "tlstpRegIdo";
            this.tlstpRegIdo.Size = new System.Drawing.Size(370, 42);
            this.tlstpRegIdo.Text = "Idoso";
            this.tlstpRegIdo.Click += new System.EventHandler(this.tlstpRegIdo_Click);
            // 
            // tlstpRegAli
            // 
            this.tlstpRegAli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.tlstpRegAli.Name = "tlstpRegAli";
            this.tlstpRegAli.Size = new System.Drawing.Size(370, 42);
            this.tlstpRegAli.Text = "Alimento";
            this.tlstpRegAli.Click += new System.EventHandler(this.tlstpRegAli_Click);
            // 
            // tlstpRegRem
            // 
            this.tlstpRegRem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.tlstpRegRem.Name = "tlstpRegRem";
            this.tlstpRegRem.Size = new System.Drawing.Size(370, 42);
            this.tlstpRegRem.Text = "Remédio";
            this.tlstpRegRem.Click += new System.EventHandler(this.tlstpRegRem_Click);
            // 
            // tlstpRegPro
            // 
            this.tlstpRegPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.tlstpRegPro.Name = "tlstpRegPro";
            this.tlstpRegPro.Size = new System.Drawing.Size(370, 42);
            this.tlstpRegPro.Text = "Prontuário";
            this.tlstpRegPro.Click += new System.EventHandler(this.tlstpRegPro_Click);
            // 
            // tlstpAtuEst
            // 
            this.tlstpAtuEst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.tlstpAtuEst.Name = "tlstpAtuEst";
            this.tlstpAtuEst.Size = new System.Drawing.Size(370, 42);
            this.tlstpAtuEst.Text = "Atualização de Estoque";
            this.tlstpAtuEst.Click += new System.EventHandler(this.TlstpAtuEst_Click);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstpVisuIdo,
            this.tlstpVisuAli,
            this.tlstpVisuRem,
            this.tlstpVisuPro});
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(142, 41);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // tlstpVisuIdo
            // 
            this.tlstpVisuIdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.tlstpVisuIdo.Name = "tlstpVisuIdo";
            this.tlstpVisuIdo.Size = new System.Drawing.Size(230, 42);
            this.tlstpVisuIdo.Text = "Idosos";
            this.tlstpVisuIdo.Click += new System.EventHandler(this.tlstpVisuIdo_Click);
            // 
            // tlstpVisuAli
            // 
            this.tlstpVisuAli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.tlstpVisuAli.Name = "tlstpVisuAli";
            this.tlstpVisuAli.Size = new System.Drawing.Size(230, 42);
            this.tlstpVisuAli.Text = "Alimentos";
            this.tlstpVisuAli.Click += new System.EventHandler(this.tlstpVisuAli_Click);
            // 
            // tlstpVisuRem
            // 
            this.tlstpVisuRem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.tlstpVisuRem.Name = "tlstpVisuRem";
            this.tlstpVisuRem.Size = new System.Drawing.Size(230, 42);
            this.tlstpVisuRem.Text = "Remédios";
            this.tlstpVisuRem.Click += new System.EventHandler(this.tlstpVisuRem_Click);
            // 
            // tlstpVisuPro
            // 
            this.tlstpVisuPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.tlstpVisuPro.Name = "tlstpVisuPro";
            this.tlstpVisuPro.Size = new System.Drawing.Size(230, 42);
            this.tlstpVisuPro.Text = "Prontuários";
            this.tlstpVisuPro.Click += new System.EventHandler(this.tlstpVisuPro_Click);
            // 
            // tlstpBckp
            // 
            this.tlstpBckp.Name = "tlstpBckp";
            this.tlstpBckp.Size = new System.Drawing.Size(114, 41);
            this.tlstpBckp.Text = "Backup";
            this.tlstpBckp.Click += new System.EventHandler(this.tlstpBckp_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstpMnlUsr});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(98, 41);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // tlstpMnlUsr
            // 
            this.tlstpMnlUsr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(172)))), ((int)(((byte)(204)))));
            this.tlstpMnlUsr.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tlstpMnlUsr.Image = global::TCC_CasaDeApoio.Properties.Resources.question;
            this.tlstpMnlUsr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlstpMnlUsr.Name = "tlstpMnlUsr";
            this.tlstpMnlUsr.Size = new System.Drawing.Size(243, 46);
            this.tlstpMnlUsr.Text = "Manual do Usuário";
            this.tlstpMnlUsr.Click += new System.EventHandler(this.tlstpMnlUsr_Click);
            // 
            // lblCasa_Apoio
            // 
            this.lblCasa_Apoio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCasa_Apoio.AutoSize = true;
            this.lblCasa_Apoio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCasa_Apoio.Location = new System.Drawing.Point(591, 345);
            this.lblCasa_Apoio.Name = "lblCasa_Apoio";
            this.lblCasa_Apoio.Size = new System.Drawing.Size(195, 16);
            this.lblCasa_Apoio.TabIndex = 5;
            this.lblCasa_Apoio.Text = "Casa de Apoio Nosso Lar";
            // 
            // lblRua
            // 
            this.lblRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(598, 370);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(168, 16);
            this.lblRua.TabIndex = 7;
            this.lblRua.Text = "Rua Alameda das Tulípas,";
            // 
            // pctrbxImagem2
            // 
            this.pctrbxImagem2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrbxImagem2.Image = global::TCC_CasaDeApoio.Properties.Resources.LogoCACirular;
            this.pctrbxImagem2.Location = new System.Drawing.Point(513, 345);
            this.pctrbxImagem2.Name = "pctrbxImagem2";
            this.pctrbxImagem2.Size = new System.Drawing.Size(72, 71);
            this.pctrbxImagem2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem2.TabIndex = 6;
            this.pctrbxImagem2.TabStop = false;
            // 
            // pctrbxImagem3
            // 
            this.pctrbxImagem3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrbxImagem3.BackColor = System.Drawing.SystemColors.Control;
            this.pctrbxImagem3.Image = global::TCC_CasaDeApoio.Properties.Resources.bordaPreta;
            this.pctrbxImagem3.Location = new System.Drawing.Point(497, 329);
            this.pctrbxImagem3.Name = "pctrbxImagem3";
            this.pctrbxImagem3.Size = new System.Drawing.Size(291, 98);
            this.pctrbxImagem3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem3.TabIndex = 8;
            this.pctrbxImagem3.TabStop = false;
            // 
            // pctrbxImagem
            // 
            this.pctrbxImagem.BackColor = System.Drawing.SystemColors.Control;
            this.pctrbxImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbxImagem.Image = global::TCC_CasaDeApoio.Properties.Resources.WallpapaerCasaDeApoio;
            this.pctrbxImagem.Location = new System.Drawing.Point(0, 0);
            this.pctrbxImagem.Name = "pctrbxImagem";
            this.pctrbxImagem.Size = new System.Drawing.Size(800, 450);
            this.pctrbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem.TabIndex = 3;
            this.pctrbxImagem.TabStop = false;
            // 
            // lblJardim
            // 
            this.lblJardim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblJardim.AutoSize = true;
            this.lblJardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJardim.Location = new System.Drawing.Point(623, 394);
            this.lblJardim.Name = "lblJardim";
            this.lblJardim.Size = new System.Drawing.Size(120, 16);
            this.lblJardim.TabIndex = 9;
            this.lblJardim.Text = "263 - Jardim Simus";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnPrincipal);
            this.Controls.Add(this.lblJardim);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.pctrbxImagem2);
            this.Controls.Add(this.lblCasa_Apoio);
            this.Controls.Add(this.pctrbxImagem3);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.pctrbxImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlstpBckp;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlstpMnlUsr;
        private System.Windows.Forms.ToolStripMenuItem tlstpRegIdo;
        private System.Windows.Forms.ToolStripMenuItem tlstpRegAli;
        private System.Windows.Forms.ToolStripMenuItem tlstpRegRem;
        private System.Windows.Forms.ToolStripMenuItem tlstpRegPro;
        private System.Windows.Forms.ToolStripMenuItem tlstpVisuIdo;
        private System.Windows.Forms.ToolStripMenuItem tlstpVisuAli;
        private System.Windows.Forms.ToolStripMenuItem tlstpVisuRem;
        private System.Windows.Forms.ToolStripMenuItem tlstpVisuPro;
        private System.Windows.Forms.ToolStripMenuItem tlstpAtuEst;
        private System.Windows.Forms.PictureBox pctrbxImagem;
        private System.Windows.Forms.Label lblCasa_Apoio;
        private System.Windows.Forms.PictureBox pctrbxImagem2;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.PictureBox pctrbxImagem3;
        private System.Windows.Forms.Label lblJardim;
    }
}