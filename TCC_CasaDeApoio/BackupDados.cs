using Casa.DAL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace TCC_CasaDeApoio
{
    public partial class BackupDados : Form
    {
        Thread tg;
        SqlConnection con = new SqlConnection(TCC_CasaDeApoio.Properties.Settings.Default.CasaDeApoioNossoLarConnectionString);
        public BackupDados()
        {
            InitializeComponent();

            lblBackup.Parent = pctrbxImagem;
            lblBackup.BackColor = Color.Transparent;

            lblImportar.Parent = pctrbxImagem;
            lblImportar.BackColor = Color.Transparent;

            lblExportar.Parent = pctrbxImagem;
            lblExportar.BackColor = Color.Transparent;
        }

        private void BackupDados_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Menu)
                {
                    form.Show();
                    break;
                }

                tg = new Thread(AbrirFormAntigo);
                tg.SetApartmentState(ApartmentState.STA);
                tg.Start();
            }
        }

        private void AbrirFormAntigo()
        {
            Application.Run(new Menu());
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja realmente Exportar o Backup?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    DirectoryInfo dInfo = new DirectoryInfo(txtExportar.Text);
                    DirectorySecurity dSecurity = dInfo.GetAccessControl();
                    dSecurity.AddAccessRule(new FileSystemAccessRule(new SecurityIdentifier(WellKnownSidType.WorldSid, null), FileSystemRights.FullControl, InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
                    dInfo.SetAccessControl(dSecurity);

                    string cmd = "BACKUP DATABASE CasaDeApoioNossoLar TO DISK='" + txtExportar.Text + "\\" + "Backup" + " " + DateTime.Now.ToString("dd-MM-yyyy HH'h 'mm'm 'ss's'") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, con))
                    {
                        if (con.State != ConnectionState.Open)
                        {
                            con.Open();
                        }

                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("A Exportação do Backup foi concluída com sucesso!");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja realmente Importar o Backup?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (con.State != ConnectionState.Open)
                {
                    try
                    {
                        string banco = "CREATE DATABASE CasaDeApoioNossoLar";
                        string sql = "ALTER DATABASE CasaDeApoioNossoLar SET MULTI_USER WITH ROLLBACK IMMEDIATE;";
                        sql += "RESTORE DATABASE CasaDeApoioNossoLar FROM DISK ='" + txtImportar.Text + "' WITH REPLACE;";

                        SqlConnection con = new SqlConnection(@"Server = DESKTOP-B18N686; Initial Catalog=Master; Integrated Security=True");
                        SqlCommand cmd1 = new SqlCommand(banco, con);
                        SqlCommand cmd2 = new SqlCommand(sql, con);

                        con.Open();

                        cmd1.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("A Importação do Backup foi concluída com sucesso!");
                        con.Close();
                        con.Dispose();
                    }

                    catch (Exception) when (txtImportar.Text != "")
                    {
                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = Dados.StringDeConexao;
                        SqlCommand cmd = new SqlCommand();

                        cmd.Connection = con;

                        con.Open();

                        string sqlStmt1 = string.Format("ALTER DATABASE CasaDeApoioNossoLar SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                        SqlCommand im1 = new SqlCommand(sqlStmt1, con);
                        im1.ExecuteNonQuery();

                        string sqlStmt2 = "USE MASTER RESTORE DATABASE CasaDeApoioNossoLar FROM DISK='" + txtImportar.Text + "'WITH REPLACE;";
                        SqlCommand im2 = new SqlCommand(sqlStmt2, con);
                        im2.ExecuteNonQuery();

                        string sqlStmt3 = string.Format("ALTER DATABASE CasaDeApoioNossoLar SET MULTI_USER");
                        SqlCommand im3 = new SqlCommand(sqlStmt3, con);
                        im3.ExecuteNonQuery();

                        MessageBox.Show("A Importação do Backup foi concluída com sucesso!");
                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnProcurar_Exportar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtExportar.Text = dlg.SelectedPath;
                btnExportar.Enabled = true;
            }
        }

        private void btnProcurar_Importar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Arquivos Backup (*.bak)|*.bak";
            dlg.Title = "Importar Backup";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtImportar.Text = dlg.FileName;
                btnImportar.Enabled = true;
            }
        }
    }
}
