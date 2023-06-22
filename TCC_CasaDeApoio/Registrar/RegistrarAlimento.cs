using Casa.DAL;
using Casa.Modelos;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TCC_CasaDeApoio.Registrar
{
    public partial class RegistrarAlimento : Form
    {
        Thread tg;

        public RegistrarAlimento()
        {
            InitializeComponent();

            lblRegistrar_Alimentos.Parent = pctrbxImagem;
            lblRegistrar_Alimentos.BackColor = Color.Transparent;

            lblCodigo.Parent = pctrbxImagem;
            lblCodigo.BackColor = Color.Transparent;

            lblNome.Parent = pctrbxImagem;
            lblNome.BackColor = Color.Transparent;

            lblMarca.Parent = pctrbxImagem;
            lblMarca.BackColor = Color.Transparent;

            lblUnidade.Parent = pctrbxImagem;
            lblUnidade.BackColor = Color.Transparent;

            lblValidade.Parent = pctrbxImagem;
            lblValidade.BackColor = Color.Transparent;

            lblEstoque.Parent = pctrbxImagem;
            lblEstoque.BackColor = Color.Transparent;

            lblPeso.Parent = pctrbxImagem;
            lblPeso.BackColor = Color.Transparent;

            lblObrigatorio.Parent = pctrbxImagem;
            lblObrigatorio.BackColor = Color.Transparent;
        }

        private void RegistrarAlimento_FormClosing(object sender, FormClosingEventArgs e)
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

            else if (txtMarca.Text != "" && txtMarca.SelectedText != "")
            {
                txtMarca.Clear();
                txtMarca.Focus();
            }

            else if (txtUnidade.Text != "" && txtUnidade.SelectedText != "")
            {
                txtUnidade.Clear();
                txtUnidade.Focus();
            }

            else if (txtEstoque.Text != "" && txtEstoque.SelectedText != "")
            {
                txtEstoque.Clear();
                txtEstoque.Focus();
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNome.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtNome.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtNome.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtMarca.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtMarca.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtUnidade.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtMarca.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtUnidade.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtUnidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtUnidade.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtUnidade.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtUnidade.Text != "" && e.KeyCode == Keys.Enter)
            {
                dttmpckValidade.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dttmpckValidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (dttmpckValidade.Text == "" && e.KeyCode == Keys.Enter)
            {
                dttmpckValidade.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (dttmpckValidade.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtEstoque.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtEstoque.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtEstoque.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtEstoque.Text != "" && e.KeyCode == Keys.Enter)
            {
                cbxPeso.Focus();
                cbxPeso.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtMarca.Text == "" && txtUnidade.Text == "" && txtEstoque.Text == "" &&
                string.IsNullOrEmpty(cbxPeso.Text))
            {
                MessageBox.Show("Informe os dados para registrar o Alimento!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtNome.Text == "")
            {
                MessageBox.Show("O Nome do Alimento é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtUnidade.Text == "")
            {
                MessageBox.Show("A Unidade do Alimento é obrigatória!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtEstoque.Text == "")
            {
                MessageBox.Show("O Estoque do Alimento é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty(cbxPeso.Text))
            {
                MessageBox.Show("Selecione o tipo de Peso do Alimento!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtEstoque.Text.Contains(",") && cbxPeso.Text == "Inteiro")
            {
                MessageBox.Show("O tipo de Peso Inteiro do Alimento não pode conter , no Estoque!", "Dados Imcompatíveis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Deseja realmente registrar o Alimento?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    if (txtNome.Text != "" && txtMarca.Text == "" && txtUnidade.Text != ""
                        && txtEstoque.Text != "" && cbxPeso.Text != "")
                    {
                        AlimentoInformation alimento = new AlimentoInformation();
                        alimento.Nome = txtNome.Text;
                        alimento.Unidade = int.Parse(txtUnidade.Text);
                        alimento.Validade = dttmpckValidade.Value;
                        alimento.Estoque = Convert.ToDecimal(txtEstoque.Text);
                        alimento.Peso = cbxPeso.Text;

                        AlimentoDAL obj = new AlimentoDAL();
                        obj.IncluirSemMarca(alimento);

                        MessageBox.Show("O Alimento foi incluído com sucesso!");

                        txtID_Alimento.Text = Convert.ToString(alimento.ID_Alimento);
                    }

                    else if (txtNome.Text != "" && txtMarca.Text != "" && txtUnidade.Text != ""
                        && txtEstoque.Text != "" && cbxPeso.Text != "")
                    {
                        AlimentoInformation alimento = new AlimentoInformation();
                        alimento.Nome = txtNome.Text;
                        alimento.Marca = txtMarca.Text;
                        alimento.Unidade = int.Parse(txtUnidade.Text);
                        alimento.Validade = dttmpckValidade.Value;
                        alimento.Estoque = Convert.ToDecimal(txtEstoque.Text);
                        alimento.Peso = cbxPeso.Text;

                        AlimentoDAL obj = new AlimentoDAL();
                        obj.Incluir(alimento);

                        MessageBox.Show("O Alimento foi incluído com sucesso!");

                        txtID_Alimento.Text = Convert.ToString(alimento.ID_Alimento);
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

                RegistrarAlimento MesmoForm = new RegistrarAlimento();
                this.Hide();
                MesmoForm.ShowDialog();
                this.Close();
            }
        }
        private void TxtUnidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtEstoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
            {

            }

            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbxPeso_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbxPeso.Text == "" && e.KeyCode == Keys.Enter)
            {
                cbxPeso.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (cbxPeso.Text != "" && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnRegistrar.PerformClick();
            }
        }
    }
}