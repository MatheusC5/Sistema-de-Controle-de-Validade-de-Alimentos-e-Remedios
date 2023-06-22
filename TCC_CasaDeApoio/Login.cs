using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TCC_CasaDeApoio
{
    public partial class Login : Form
    {
        Thread th;

        public Login()
        {
            InitializeComponent();

            lblUsuario.Parent = pictureBox1;
            lblUsuario.BackColor = Color.Transparent;

            lblSenha.Parent = pictureBox1;
            lblSenha.BackColor = Color.Transparent;

            pctrBxImagem.Parent = pictureBox1;
            pctrBxImagem.BackColor = Color.Transparent;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Preencha o Usuário e a Senha corretamente!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtUsuario.Text == "" && txtSenha.Text != "")
            {
                MessageBox.Show("Preencha o Usuário corretamente!", "Campo Usuário Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtUsuario.Text != "" && txtSenha.Text == "")
            {
                MessageBox.Show("Preencha a Senha corretamente!", "Campo Senha Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtUsuario.Text == "Júlio" && txtSenha.Text == "casadeapoio")
            {
                this.Close();
                th = new Thread(opennewform);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

            else if (txtUsuario.Text != "Júlio" && txtSenha.Text != "casadeapoio")
            {
                MessageBox.Show("Insira o Usuário e a Senha corretamente!", "Usuário e Senha Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtUsuario.Text == "Júlio" && txtSenha.Text != "casadeapoio")
            {
                MessageBox.Show("Insira a Senha corretamente!", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtUsuario.Text != "Júlio" && txtSenha.Text == "casadeapoio")
            {
                MessageBox.Show("Insira o Usuário corretamente!", "Usuário Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void opennewform()
        {
            Application.Run(new Menu());
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Deseja realmente encerrar esta sessão?", "Encerrar Sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dialogo == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtUsuario.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtUsuario.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true; 
            }

            else if (txtUsuario.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true; 
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "" && e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Preencha o Usuário e a Senha corretamente!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtSenha.Text == "" && e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Preencha a Senha corretamente!", "Campo Senha Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtUsuario.Text != "" && txtSenha.Text != "" && e.KeyCode == Keys.Enter)
            {              
                e.SuppressKeyPress = true;
                btnEntrar.PerformClick();
            }

            else if (txtUsuario.Text != "Júlio" && txtSenha.Text != "admin" && e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Insira o Usuário e a Senha corretamente!", "Dados Incorretos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtUsuario.Text == "Júlio" && txtSenha.Text != "casadeapoio" && e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Insira a Senha corretamente!", "Senha Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtUsuario.Text == "" && txtSenha.Text == "casadeapoio" && e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Preencha o Usuário corretamente!", "Campo Usuário Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtUsuario.Text != "Júlio" && txtSenha.Text == "casadeapoio" && e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Insira o Usuário corretamente!", "Usuário Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
