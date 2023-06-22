using Casa.DAL;
using Casa.Modelos;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TCC_CasaDeApoio.Registrar
{
    public partial class RegistrarIdoso : Form
    {
        Thread tg;

        public RegistrarIdoso()
        {
            InitializeComponent();

            lblRegistrar_Idosos.Parent = pctrbxImagem;
            lblRegistrar_Idosos.BackColor = Color.Transparent;

            lblCodigo.Parent = pctrbxImagem;
            lblCodigo.BackColor = Color.Transparent;

            lblNome.Parent = pctrbxImagem;
            lblNome.BackColor = Color.Transparent;

            lblData_Nascimento.Parent = pctrbxImagem;
            lblData_Nascimento.BackColor = Color.Transparent;

            lblEndereco_Responsavel.Parent = pctrbxImagem;
            lblEndereco_Responsavel.BackColor = Color.Transparent;

            lblTelefone_Responsavel.Parent = pctrbxImagem;
            lblTelefone_Responsavel.BackColor = Color.Transparent;

            lblCelular_Responsavel.Parent = pctrbxImagem;
            lblCelular_Responsavel.BackColor = Color.Transparent;

            lblTelefone_Emergencia.Parent = pctrbxImagem;
            lblTelefone_Emergencia.BackColor = Color.Transparent;

            lblObrigatorio.Parent = pctrbxImagem;
            lblObrigatorio.BackColor = Color.Transparent;
        }

        private void RegistrarIdoso_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "" && txtNome.SelectedText != "")
            {
                txtNome.Clear();
                txtNome.Focus();
            }

            else if (txtEndereco_Responsavel.Text != "" && txtEndereco_Responsavel.SelectedText != "")
            {
                txtEndereco_Responsavel.Clear();
                txtEndereco_Responsavel.Focus();
            }

            else if (txtTelefone_Responsavel.Text != null && txtTelefone_Responsavel.SelectedText != "")
            {
                txtTelefone_Responsavel.Clear();
            }

            else if (txtCelular_Responsavel.Text != null && txtCelular_Responsavel.SelectedText != "")
            {
                txtCelular_Responsavel.Clear();
            }

            else if (txtTelefone_Emergencia.Text != null && txtTelefone_Emergencia.SelectedText != "")
            {
                txtTelefone_Emergencia.Clear();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtEndereco_Responsavel.Text == "" && txtTelefone_Responsavel.Text == "(  )     -")
            {
                MessageBox.Show("Informe os dados para registrar o Idoso!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtNome.Text == "")
            {
                MessageBox.Show("O Nome do Idoso é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtEndereco_Responsavel.Text == "")
            {
                MessageBox.Show("O Endereço do Responsável do Idoso é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtTelefone_Responsavel.Text == "(  )     -")
            {
                MessageBox.Show("O Telefone do Responsável do Idoso é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Deseja realmente registrar o Idoso?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    IdosoInformation idoso = new IdosoInformation();
                    idoso.Nome = txtNome.Text;
                    idoso.Data_Nascimento = dttmpckData_Nascimento.Value;
                    idoso.Endereco_Responsavel = txtEndereco_Responsavel.Text;
                    idoso.Telefone_Responsavel = txtTelefone_Responsavel.Text;
                    idoso.Celular_Responsavel = txtCelular_Responsavel.Text;
                    idoso.Telefone_Emergencia = txtTelefone_Emergencia.Text;

                    IdosoDAL obj = new IdosoDAL();
                    obj.Incluir(idoso);

                    MessageBox.Show("O Idoso foi incluído com sucesso!");

                    txtID_Idoso.Text = Convert.ToString(idoso.ID_Idoso);

                    RegistrarIdoso MesmoForm = new RegistrarIdoso();
                    this.Hide();
                    MesmoForm.ShowDialog();
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void TxtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNome.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtNome.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtNome.Text != "" && e.KeyCode == Keys.Enter)
            {
                dttmpckData_Nascimento.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DttmpckData_Nascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (dttmpckData_Nascimento.Text == "" && e.KeyCode == Keys.Enter)
            {
                dttmpckData_Nascimento.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (dttmpckData_Nascimento.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtEndereco_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtEndereco_Responsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtEndereco_Responsavel.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtEndereco_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtEndereco_Responsavel.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtTelefone_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtTelefone_Responsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTelefone_Responsavel.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtTelefone_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtTelefone_Responsavel.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtCelular_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtCelular_Responsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCelular_Responsavel.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtCelular_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtCelular_Responsavel.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtTelefone_Emergencia.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtTelefone_Emergencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtTelefone_Emergencia.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtTelefone_Emergencia.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtTelefone_Emergencia.Text != "" && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnRegistrar.PerformClick();
            }
        }
    }
}