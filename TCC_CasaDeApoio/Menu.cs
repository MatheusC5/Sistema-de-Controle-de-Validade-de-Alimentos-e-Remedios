using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TCC_CasaDeApoio.Registrar;
using TCC_CasaDeApoio.Visualizar;

namespace TCC_CasaDeApoio
{
    public partial class Menu : Form
    {
        Thread tg;

        public Menu()
        {
            InitializeComponent();
            mnPrincipal.Renderer = new ToolStripProfessionalRenderer(new CoresMenu());

            lblHora.Parent = pctrbxImagem;
            lblHora.BackColor = Color.Transparent;

            pctrbxImagem2.Parent = pctrbxImagem;
            pctrbxImagem2.BackColor = Color.Transparent;

            lblCasa_Apoio.Parent = pctrbxImagem;
            lblCasa_Apoio.BackColor = Color.Transparent;

            lblRua.Parent = pctrbxImagem;
            lblRua.BackColor = Color.Transparent;

            lblJardim.Parent = pctrbxImagem;
            lblJardim.BackColor = Color.Transparent;

            pctrbxImagem3.Parent = pctrbxImagem;
            pctrbxImagem3.BackColor = Color.Transparent;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            if (DateTime.Now.Hour < 12)
            {
                lblHora.Text = "Olá Senhor Júlio, bom dia!";
            }

            else if (DateTime.Now.Hour < 18)
            {
                lblHora.Text = "Olá Senhor Júlio, boa tarde!";
            }

            else
            {
                lblHora.Text = "Olá Senhor Júlio, boa noite!";
            }
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente encerrar esta sessão?", "Encerrar Sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            
            if (dialogo == DialogResult.Yes)
            {
                //Application.ExitThread(); //este fecha de vez o programa
                this.Hide();
                tg = new Thread(AbriFormAntigo);
                tg.SetApartmentState(ApartmentState.STA);
                tg.Start();
            }

            else if (dialogo == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public class CoresMenu : ProfessionalColorTable
        {
            public override Color ToolStripDropDownBackground
            {
                get
                {
                    return ColorTranslator.FromHtml("#20d6d0");
                }
            }

            public override Color ImageMarginGradientBegin
            {
                get
                {
                    return ColorTranslator.FromHtml("#20d6d0");
                }
            }

            public override Color MenuBorder
            {
                get
                {
                    return Color.Black;
                }
            }

            public override Color MenuItemBorder
            {
                get
                {
                    return Color.Transparent;
                }
            }


            public override Color MenuItemSelected
            {
                get
                {
                    return ColorTranslator.FromHtml("#197be3");
                }
            }

            public override Color MenuStripGradientBegin
            {
                get
                {
                    return ColorTranslator.FromHtml("#20d6d0");
                }
            }

            public override Color MenuStripGradientEnd
            {
                get
                {
                    return ColorTranslator.FromHtml("#20d6d0");
                }
            }

            public override Color MenuItemSelectedGradientBegin
            {
                get
                {
                    return ColorTranslator.FromHtml("#0ecc8d");
                }
            }

            public override Color MenuItemSelectedGradientEnd
            {
                get
                {
                    return ColorTranslator.FromHtml("#0ecc8d");
                }
            }

            public override Color MenuItemPressedGradientBegin
            {
                get
                {
                    return ColorTranslator.FromHtml("#0e64cc");
                }
            }

            public override Color MenuItemPressedGradientEnd
            {
                get
                {
                    return ColorTranslator.FromHtml("#0e64cc");
                }
            }
        }

        private void AbriFormAntigo()
        {
            Application.Run(new Login());
        }

        private void tlstpRegIdo_Click(object sender, EventArgs e)
        {
            bool abrir = false;
            foreach (Form Menu in this.MdiChildren)
            {
                if (Menu is Form)
                {
                    Menu.BringToFront();
                    abrir = true;
                }
            }

            if (!abrir)
            {
                this.Hide();
                RegistrarIdoso idoso = new RegistrarIdoso();
                idoso.Show();
            }
        }

        private void tlstpRegAli_Click(object sender, EventArgs e)
        {
            bool abrir = false;
            foreach (Form Menu in this.MdiChildren)
            {
                if (Menu is Form)
                {
                    Menu.BringToFront();
                    abrir = true;
                }
            }

            if (!abrir)
            {
                this.Hide();
                RegistrarAlimento alimento = new RegistrarAlimento();
                alimento.Show();
            }
        }

        private void tlstpVisuIdo_Click(object sender, EventArgs e)
        {
            bool abrir = false;
            foreach (Form Menu in this.MdiChildren)
            {
                if (Menu is Form)
                {
                    Menu.BringToFront();
                    abrir = true;
                }
            }

            if (!abrir)
            {
                this.Hide();
                VisualizarIdoso vidoso = new VisualizarIdoso();
                vidoso.Show();
            }
        }

        private void tlstpVisuAli_Click(object sender, EventArgs e)
        {
            bool abrir = false;
            foreach (Form Menu in this.MdiChildren)
            {
                if (Menu is Form)
                {
                    Menu.BringToFront();
                    abrir = true;
                }
            }

            if (!abrir)
            {
                this.Hide();
                VisualizarAlimento valimento = new VisualizarAlimento();
                valimento.Show();
            }
        }

        private void tlstpRegRem_Click(object sender, EventArgs e)
        {
            bool abrir = false;
            foreach (Form Menu in this.MdiChildren)
            {
                if (Menu is Form)
                {
                    Menu.BringToFront();
                    abrir = true;
                }
            }

            if (!abrir)
            {
                this.Hide();
                RegistrarRemedio remedio = new RegistrarRemedio();
                remedio.Show();
            }
        }

        private void tlstpRegPro_Click(object sender, EventArgs e)
        {
            bool abrir = false;
            foreach (Form Menu in this.MdiChildren)
            {
                if (Menu is Form)
                {
                    Menu.BringToFront();
                    abrir = true;
                }
            }

            if (!abrir)
            {
                this.Hide();
                RegistrarProntuario prontuario = new RegistrarProntuario();
                prontuario.Show();
            }
        }

        private void tlstpVisuRem_Click(object sender, EventArgs e)
        {
            bool abrir = false;
            foreach (Form Menu in this.MdiChildren)
            {
                if (Menu is Form)
                {
                    Menu.BringToFront();
                    abrir = true;
                }
            }

            if (!abrir)
            {
                this.Hide();
                VisualizarRemedio vremedio = new VisualizarRemedio();
                vremedio.Show();
            }
        }

        private void tlstpVisuPro_Click(object sender, EventArgs e)
        {
            bool abrir = false;
            foreach (Form Menu in this.MdiChildren)
            {
                if (Menu is Form)
                {
                    Menu.BringToFront();
                    abrir = true;
                }
            }

            if (!abrir)
            {
                this.Hide();
                VisualizarProntuario prontuario = new VisualizarProntuario();
                prontuario.Show();
            }
        }

        private void TlstpAtuEst_Click(object sender, EventArgs e)
        {
            bool abrir = false;
            foreach (Form Menu in this.MdiChildren)
            {
                if (Menu is Form)
                {
                    Menu.BringToFront();
                    abrir = true;
                }
            }

            if (!abrir)
            {
                this.Hide();
                RegistrarAtualizacao_Estoque estoque = new RegistrarAtualizacao_Estoque();
                estoque.Show();
            }
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            FormWindowState LastWindowState = FormWindowState.Minimized;

            if (WindowState != LastWindowState)
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    var margin = registrarToolStripMenuItem.Margin;
                    margin.Left = 400;
                    registrarToolStripMenuItem.Margin = margin;
                }

                if (WindowState == FormWindowState.Normal)
                {
                    var margin = registrarToolStripMenuItem.Margin;
                    margin.Left = 150;
                    registrarToolStripMenuItem.Margin = margin;
                }
            }
        }

        private void tlstpBckp_Click(object sender, EventArgs e)
        {
            bool abrir = false;
            foreach (Form Menu in this.MdiChildren)
            {
                if (Menu is Form)
                {
                    Menu.BringToFront();
                    abrir = true;
                }
            }

            if (!abrir)
            {
                this.Hide();
                BackupDados backup = new BackupDados();
                backup.Show();
            }
        }

        private void tlstpMnlUsr_Click(object sender, EventArgs e)
        {
            string manual = "Manual do Usuário.pdf";
            System.Diagnostics.Process.Start(manual);
        }
    }
}
