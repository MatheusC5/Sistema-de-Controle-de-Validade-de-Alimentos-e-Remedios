using Casa.BLL;
using Casa.DAL;
using Casa.Modelos;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TCC_CasaDeApoio.Registrar
{
    public partial class RegistrarAtualizacao_Estoque : Form
    {
        Thread tg;

        public RegistrarAtualizacao_Estoque()
        {
            InitializeComponent();

            lblRegistrar_Atualizacao_Estoque.Parent = pctrbxImagem;
            lblRegistrar_Atualizacao_Estoque.BackColor = Color.Transparent;

            lblCodigo.Parent = pctrbxImagem;
            lblCodigo.BackColor = Color.Transparent;

            lblAlimento.Parent = pctrbxImagem;
            lblAlimento.BackColor = Color.Transparent;

            lblRemedio.Parent = pctrbxImagem;
            lblRemedio.BackColor = Color.Transparent;

            lblQTD_Alimento.Parent = pctrbxImagem;
            lblQTD_Alimento.BackColor = Color.Transparent;

            lblQTD_Remedio.Parent = pctrbxImagem;
            lblQTD_Remedio.BackColor = Color.Transparent;
        }

        private void RegistrarAtualizacao_Estoque_FormClosing(object sender, FormClosingEventArgs e)
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
            if (txtQTD_Alimento.Text != "" && txtQTD_Alimento.SelectedText != "")
            {
                txtQTD_Alimento.Clear();
                txtQTD_Alimento.Focus();
            }

            else if (txtQTD_Remedio.Text != "" && txtQTD_Remedio.SelectedText != "")
            {
                txtQTD_Remedio.Clear();
                txtQTD_Remedio.Focus();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtQTD_Alimento.Text == "" && txtQTD_Remedio.Text == "")
            {
                MessageBox.Show("Informe uma quantidade do Alimento e Remédio para atualizar o Estoque!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (string.IsNullOrEmpty(cbxAlimento.Text) && string.IsNullOrEmpty(cbxRemedio.Text))
            {
                MessageBox.Show("Selecione um Alimento e Remédio!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }        

            else if (MessageBox.Show(this, "Deseja realmente atualizar o Estoque?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    if (cbxAlimento.Text != "" && txtQTD_Alimento.Text != "" && cbxRemedio.Text != "" && txtQTD_Remedio.Text == "" ||
                        cbxAlimento.Text != "" && txtQTD_Alimento.Text != "" && cbxRemedio.Text == "" && txtQTD_Remedio.Text != "" ||
                        cbxAlimento.Text != "" && txtQTD_Alimento.Text != "" && cbxRemedio.Text == "" && txtQTD_Remedio.Text == "")
                    {
                        EstoqueInformation estoquealimento = new EstoqueInformation();
                        estoquealimento.Alimentos = cbxAlimento.Text;
                        estoquealimento.Quantidade_Alimentos = Convert.ToDecimal(txtQTD_Alimento.Text);
                        estoquealimento.ID_Alimento = (int)cbxAlimento.SelectedValue;

                        EstoqueBLL obj = new EstoqueBLL();
                        obj.IncluirAlimento(estoquealimento);

                        MessageBox.Show("A atualização do Estoque foi concluída com sucesso!");

                        txtID_Atualizar_Estoque.Text = Convert.ToString(estoquealimento.ID_Atualizar_Estoque);
                    }

                    else if (cbxRemedio.Text != "" && txtQTD_Remedio.Text != "" && cbxAlimento.Text != "" && txtQTD_Alimento.Text == "" ||
                            cbxRemedio.Text != "" && txtQTD_Remedio.Text != "" && cbxAlimento.Text == "" && txtQTD_Alimento.Text != "" ||
                            cbxRemedio.Text != "" && txtQTD_Remedio.Text != "" && cbxAlimento.Text == "" && txtQTD_Alimento.Text == "")
                    {
                        EstoqueInformation estoqueremedio = new EstoqueInformation();
                        estoqueremedio.Remedios = cbxRemedio.Text;
                        estoqueremedio.Quantidade_Remedios = Convert.ToDecimal(txtQTD_Remedio.Text);
                        estoqueremedio.ID_Remedio = (int)cbxRemedio.SelectedValue;

                        EstoqueBLL obj = new EstoqueBLL();
                        obj.IncluirRemedio(estoqueremedio);

                        MessageBox.Show("A atualização do Estoque foi concluída com sucesso!");

                        txtID_Atualizar_Estoque.Text = Convert.ToString(estoqueremedio.ID_Atualizar_Estoque);
                    }

                    else
                    {
                        EstoqueInformation estoque = new EstoqueInformation();
                        estoque.Alimentos = cbxAlimento.Text;
                        estoque.ID_Alimento = (int)cbxAlimento.SelectedValue;
                        estoque.Quantidade_Alimentos = Convert.ToDecimal(txtQTD_Alimento.Text);
                        estoque.Remedios = cbxRemedio.Text;
                        estoque.ID_Remedio = (int)cbxRemedio.SelectedValue;
                        estoque.Quantidade_Remedios = Convert.ToDecimal(txtQTD_Remedio.Text);

                        EstoqueBLL obj = new EstoqueBLL();
                        obj.Incluir(estoque);

                        MessageBox.Show("A atualização do Estoque foi concluída com sucesso!");

                        txtID_Atualizar_Estoque.Text = Convert.ToString(estoque.ID_Atualizar_Estoque);
                    }

                    SqlConnection cn1 = new SqlConnection();
                    cn1.ConnectionString = Dados.StringDeConexao;
                    cn1.Open();

                    SqlDataAdapter da1 = new SqlDataAdapter("select Estoque, Peso from Alimentos where Nome='" + cbxAlimento.Text + "' ", cn1);

                    DataTable alimentosBindingSource = new DataTable();
                    da1.Fill(alimentosBindingSource);
                    cn1.Close();
                    dtgrdvwAlimentos.DataSource = alimentosBindingSource;

                    SqlConnection cn2 = new SqlConnection();
                    cn2.ConnectionString = Dados.StringDeConexao;
                    cn2.Open();

                    SqlDataAdapter da2 = new SqlDataAdapter("select Estoque, Peso from Remedios where Nome='" + cbxRemedio.Text + "' ", cn2);

                    DataTable remediosBindingSource = new DataTable();
                    da2.Fill(remediosBindingSource);
                    cn2.Close();
                    dtgrdvwRemedios.DataSource = remediosBindingSource;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

                txtID_Atualizar_Estoque.Clear();
                txtQTD_Alimento.Clear();
                txtQTD_Remedio.Clear();
            }
        }

        private void TxtQTD_Alimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < dtgrdvwAlimentos.Rows.Count; i++)
            {
                if (dtgrdvwAlimentos.Rows[i].Cells[1].Value.ToString() == "Inteiro")
                {
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                }

                if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
                {

                }

                else
                {
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                }
            }
        }

        private void TxtQTD_Remedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            for (int i = 0; i < dtgrdvwRemedios.Rows.Count; i++)
            {
                if (dtgrdvwRemedios.Rows[i].Cells[1].Value.ToString() == "Inteiro")
                {
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                }

                if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
                {

                }

                else
                {
                    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
                }
            }
        }

        private void CbxAlimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbxAlimento.Text == "" && e.KeyCode == Keys.Enter)
            {
                cbxAlimento.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (cbxAlimento.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtQTD_Alimento.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtQTD_Alimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtQTD_Alimento.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtQTD_Alimento.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtQTD_Alimento.Text != "" && e.KeyCode == Keys.Enter)
            {
                cbxRemedio.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void CbxRemedio_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbxRemedio.Text == "" && e.KeyCode == Keys.Enter)
            {
                cbxRemedio.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (cbxRemedio.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtQTD_Remedio.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void TxtQTD_Remedio_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtQTD_Remedio.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtQTD_Remedio.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtQTD_Remedio.Text != "" && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnRegistrar.PerformClick();
            }
        }

        private void CbxAlimento_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxAlimento.Text))
            {
                MessageBox.Show("Não existe nenhum Alimento registrado." + "\nRegistre um Alimento na Tela Registrar Alimentos!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

            }
        }

        private void CbxRemedio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxRemedio.Text))
            {
                MessageBox.Show("Não existe nenhum Remédio registrado." + "\nRegistre um Remédio na Tela Registrar Remédios!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

            }
        }

        private void RegistrarAtualizacao_Estoque_Load(object sender, EventArgs e)
        {
            this.alimentosTableAdapter.Fill(this.casaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos.Alimentos);

            if (this.casaDeApoioNossoLarDataSetAtualizarEstoqueAlimentos.Alimentos.Count == 0)
            {
                this.dtgrdvwAlimentos.DataSource = null;
            }

            this.remediosTableAdapter.Fill(this.casaDeApoioNossoLarDataSetAtualizarEstoqueRemedios.Remedios);

            if (this.casaDeApoioNossoLarDataSetAtualizarEstoqueRemedios.Remedios.Count == 0)
            {
                this.dtgrdvwRemedios.DataSource = null;
            }

            EstoqueBLL obj = new EstoqueBLL();
            cbxAlimento.DataSource = obj.ListaDeAlimentos;
            cbxRemedio.DataSource = obj.ListaDeRemedios;
        }

        private void cbxAlimento_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn1 = new SqlConnection();
            cn1.ConnectionString = Dados.StringDeConexao;
            cn1.Open();

            SqlDataAdapter da1 = new SqlDataAdapter("select Estoque, Peso from Alimentos where Nome='" + cbxAlimento.Text + "' ", cn1);

            DataTable alimentosBindingSource = new DataTable();
            da1.Fill(alimentosBindingSource);
            cn1.Close();
            dtgrdvwAlimentos.DataSource = alimentosBindingSource;

            for (int i = 0; i < dtgrdvwAlimentos.Rows.Count; i++)
            {
                if (txtQTD_Alimento.Text.Contains(",") && dtgrdvwAlimentos.Rows[i].Cells[1].Value.ToString() == "Inteiro")
                {
                    txtQTD_Alimento.Clear();
                }
            }
        }

        private void cbxRemedio_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn2 = new SqlConnection();
            cn2.ConnectionString = Dados.StringDeConexao;
            cn2.Open();

            SqlDataAdapter da2 = new SqlDataAdapter("select Estoque, Peso from Remedios where Nome='" + cbxRemedio.Text + "' ", cn2);

            DataTable remediosBindingSource = new DataTable();
            da2.Fill(remediosBindingSource);
            cn2.Close();
            dtgrdvwRemedios.DataSource = remediosBindingSource;

            for (int i = 0; i < dtgrdvwRemedios.Rows.Count; i++)
            {
                if (txtQTD_Remedio.Text.Contains(",") && dtgrdvwRemedios.Rows[i].Cells[1].Value.ToString() == "Inteiro")
                {
                    txtQTD_Remedio.Clear();
                }
            }
        }
    }
}
