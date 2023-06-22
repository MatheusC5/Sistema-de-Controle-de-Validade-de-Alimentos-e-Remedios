namespace TCC_CasaDeApoio
{
    partial class BackupDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupDados));
            this.lblBackup = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnProcurar_Exportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtExportar = new System.Windows.Forms.TextBox();
            this.txtImportar = new System.Windows.Forms.TextBox();
            this.lblImportar = new System.Windows.Forms.Label();
            this.lblExportar = new System.Windows.Forms.Label();
            this.pctrbxImagem = new System.Windows.Forms.PictureBox();
            this.btnProcurar_Importar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBackup
            // 
            this.lblBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBackup.AutoSize = true;
            this.lblBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackup.Location = new System.Drawing.Point(305, 9);
            this.lblBackup.Name = "lblBackup";
            this.lblBackup.Size = new System.Drawing.Size(130, 37);
            this.lblBackup.TabIndex = 19;
            this.lblBackup.Text = "Backup";
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportar.Enabled = false;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(415, 146);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(158, 47);
            this.btnExportar.TabIndex = 18;
            this.btnExportar.Text = "Exportar Backup";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnProcurar_Exportar
            // 
            this.btnProcurar_Exportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProcurar_Exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar_Exportar.Location = new System.Drawing.Point(206, 146);
            this.btnProcurar_Exportar.Name = "btnProcurar_Exportar";
            this.btnProcurar_Exportar.Size = new System.Drawing.Size(158, 47);
            this.btnProcurar_Exportar.TabIndex = 17;
            this.btnProcurar_Exportar.Text = "Procurar local para Exportar";
            this.btnProcurar_Exportar.UseVisualStyleBackColor = true;
            this.btnProcurar_Exportar.Click += new System.EventHandler(this.btnProcurar_Exportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImportar.Enabled = false;
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.Location = new System.Drawing.Point(415, 282);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(158, 47);
            this.btnImportar.TabIndex = 16;
            this.btnImportar.Text = "Importar Backup";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtExportar
            // 
            this.txtExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExportar.Enabled = false;
            this.txtExportar.Location = new System.Drawing.Point(94, 111);
            this.txtExportar.Name = "txtExportar";
            this.txtExportar.Size = new System.Drawing.Size(633, 20);
            this.txtExportar.TabIndex = 14;
            // 
            // txtImportar
            // 
            this.txtImportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtImportar.Enabled = false;
            this.txtImportar.Location = new System.Drawing.Point(94, 245);
            this.txtImportar.Name = "txtImportar";
            this.txtImportar.Size = new System.Drawing.Size(633, 20);
            this.txtImportar.TabIndex = 13;
            // 
            // lblImportar
            // 
            this.lblImportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblImportar.AutoSize = true;
            this.lblImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportar.Location = new System.Drawing.Point(7, 243);
            this.lblImportar.Name = "lblImportar";
            this.lblImportar.Size = new System.Drawing.Size(82, 20);
            this.lblImportar.TabIndex = 12;
            this.lblImportar.Text = "Importar:";
            // 
            // lblExportar
            // 
            this.lblExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExportar.AutoSize = true;
            this.lblExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExportar.Location = new System.Drawing.Point(7, 111);
            this.lblExportar.Name = "lblExportar";
            this.lblExportar.Size = new System.Drawing.Size(82, 20);
            this.lblExportar.TabIndex = 11;
            this.lblExportar.Text = "Exportar:";
            // 
            // pctrbxImagem
            // 
            this.pctrbxImagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrbxImagem.Image = global::TCC_CasaDeApoio.Properties.Resources.WallpapaerCasaDeApoio;
            this.pctrbxImagem.Location = new System.Drawing.Point(0, 0);
            this.pctrbxImagem.Name = "pctrbxImagem";
            this.pctrbxImagem.Size = new System.Drawing.Size(740, 381);
            this.pctrbxImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbxImagem.TabIndex = 10;
            this.pctrbxImagem.TabStop = false;
            // 
            // btnProcurar_Importar
            // 
            this.btnProcurar_Importar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProcurar_Importar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar_Importar.Location = new System.Drawing.Point(206, 283);
            this.btnProcurar_Importar.Name = "btnProcurar_Importar";
            this.btnProcurar_Importar.Size = new System.Drawing.Size(158, 47);
            this.btnProcurar_Importar.TabIndex = 20;
            this.btnProcurar_Importar.Text = "Procurar local para Importar";
            this.btnProcurar_Importar.UseVisualStyleBackColor = true;
            this.btnProcurar_Importar.Click += new System.EventHandler(this.btnProcurar_Importar_Click);
            // 
            // BackupDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(740, 381);
            this.Controls.Add(this.btnProcurar_Importar);
            this.Controls.Add(this.lblBackup);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnProcurar_Exportar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.txtExportar);
            this.Controls.Add(this.txtImportar);
            this.Controls.Add(this.lblImportar);
            this.Controls.Add(this.lblExportar);
            this.Controls.Add(this.pctrbxImagem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackupDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup dos Dados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BackupDados_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackup;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnProcurar_Exportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtExportar;
        private System.Windows.Forms.TextBox txtImportar;
        private System.Windows.Forms.Label lblImportar;
        private System.Windows.Forms.Label lblExportar;
        private System.Windows.Forms.PictureBox pctrbxImagem;
        private System.Windows.Forms.Button btnProcurar_Importar;
    }
}