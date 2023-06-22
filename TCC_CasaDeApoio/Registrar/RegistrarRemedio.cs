using Casa.DAL;
using Casa.Modelos;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TCC_CasaDeApoio.Registrar
{
    public partial class RegistrarRemedio : Form
    {
        Thread tg;

        public RegistrarRemedio()
        {
            InitializeComponent();

            lblRegistrar_Remedios.Parent = pctrbxImagem;
            lblRegistrar_Remedios.BackColor = Color.Transparent;

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

        private void RegistrarRemedio_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" && txtMarca.Text == "" && txtUnidade.Text == "" && txtEstoque.Text == "" &&
                string.IsNullOrEmpty(cbxPeso.Text))
            {
                MessageBox.Show("Informe os dados para registrar o Remédio!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtNome.Text == "")
            {
                MessageBox.Show("O Nome do Remédio é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtUnidade.Text == "")
            {
                MessageBox.Show("A Unidade do Remédio é obrigatória!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtEstoque.Text == "")
            {
                MessageBox.Show("O Estoque do Remédio é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty(cbxPeso.Text))
            {
                MessageBox.Show("Selecione o tipo de Peso do Remédio!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtEstoque.Text.Contains(",") && cbxPeso.Text == "Inteiro")
            {
                MessageBox.Show("O tipo de Peso Inteiro do Remédio não pode conter , no Estoque!", "Dados Imcompatíveis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Deseja realmente registrar o Remédio?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    if (txtNome.Text != "" && txtMarca.Text == "" && txtUnidade.Text != ""
                        && txtEstoque.Text != "" && cbxPeso.Text != "")
                    {
                        RemedioInformation remedio = new RemedioInformation();
                        remedio.Nome = txtNome.Text;
                        remedio.Unidade = int.Parse(txtUnidade.Text);
                        remedio.Validade = dttmpckValidade.Value;
                        remedio.Estoque = Convert.ToDecimal(txtEstoque.Text);
                        remedio.Peso = cbxPeso.Text;

                        RemedioDAL obj = new RemedioDAL();
                        obj.IncluirSemMarca(remedio);

                        MessageBox.Show("O Remédio foi incluído com sucesso!");

                        txtID_Remedio.Text = Convert.ToString(remedio.ID_Remedio);
                    }

                    else if (txtNome.Text != "" && txtMarca.Text != "" && txtUnidade.Text != ""
                        && txtEstoque.Text != "" && cbxPeso.Text != "")
                    {
                        RemedioInformation remedio = new RemedioInformation();
                        remedio.Nome = txtNome.Text;
                        remedio.Marca = txtMarca.Text;
                        remedio.Unidade = int.Parse(txtUnidade.Text);
                        remedio.Validade = dttmpckValidade.Value;
                        remedio.Estoque = Convert.ToDecimal(txtEstoque.Text);
                        remedio.Peso = cbxPeso.Text;

                        RemedioDAL obj = new RemedioDAL();
                        obj.Incluir(remedio);

                        MessageBox.Show("O Remédio foi incluído com sucesso!");

                        txtID_Remedio.Text = Convert.ToString(remedio.ID_Remedio);
                    }   
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

                RegistrarRemedio MesmoForm = new RegistrarRemedio();
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
                txtMarca.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtMarca_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtUnidade_KeyDown(object sender, KeyEventArgs e)
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

        private void DttmpckValidade_KeyDown(object sender, KeyEventArgs e)
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

        private void TxtEstoque_KeyDown(object sender, KeyEventArgs e)
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