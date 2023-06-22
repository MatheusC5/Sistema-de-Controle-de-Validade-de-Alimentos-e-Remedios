using Casa.DAL;
using Casa.Modelos;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TCC_CasaDeApoio.Visualizar
{
    public partial class VisualizarAlimento : Form
    {
        Thread tg;
        int indexRow;
        private bool btnDentro_Validade_Clicked = false;
        private bool btnFora_Validade_Clicked = false;

        public VisualizarAlimento()
        {
            InitializeComponent();

            lblVisualizar_Alimentos.Parent = pctrbxImagem1;
            lblVisualizar_Alimentos.BackColor = Color.Transparent;

            lblValidade_Alimentos.Parent = pctrbxImagem1;
            lblValidade_Alimentos.BackColor = Color.Transparent;
        }

        private void VisualizarAlimento_FormClosing(object sender, FormClosingEventArgs e)
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

        public void AtualizarGrid()
        {
            try
            {
                txtAlterar_Excluir_ID_Alimento.Text = dtgrdvwAlimentos[0, dtgrdvwAlimentos.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Nome.Text = dtgrdvwAlimentos[1, dtgrdvwAlimentos.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Marca.Text = dtgrdvwAlimentos[2, dtgrdvwAlimentos.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Unidade.Text = dtgrdvwAlimentos[3, dtgrdvwAlimentos.CurrentRow.Index].Value.ToString();
                dttmpckAlterar_Excluir_Validade.Text = dtgrdvwAlimentos[4, dtgrdvwAlimentos.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Estoque.Text = dtgrdvwAlimentos[5, dtgrdvwAlimentos.CurrentRow.Index].Value.ToString();
                cbxAlterar_Excluir_Peso.Text = dtgrdvwAlimentos[6, dtgrdvwAlimentos.CurrentRow.Index].Value.ToString();
            }

            catch
            {
                txtAlterar_Excluir_ID_Alimento.Text = "";
                txtAlterar_Excluir_Nome.Text = "";
                txtAlterar_Excluir_Marca.Text = "";
                txtAlterar_Excluir_Unidade.Text = "";
                dttmpckAlterar_Excluir_Validade.Text = "";
                txtAlterar_Excluir_Estoque.Text = "";
                cbxAlterar_Excluir_Peso.Text = "";
            }
        }

        private void VisualizarAlimento_Load(object sender, EventArgs e)
        {
            this.alimentosTableAdapter.Fill(this.casaDeApoioNossoLarDataSetAlimentos.Alimentos);

            if (this.casaDeApoioNossoLarDataSetAlimentos.Alimentos.Count == 0)
            {
                this.dtgrdvwAlimentos.DataSource = null;
            }

            dtgrdvwAlimentos.AllowUserToAddRows = false;

            AtualizarGrid();

            this.dtgrdvwAlimentos.Columns[0].Visible = false;

            if (txtAlterar_Excluir_Estoque.Text.Contains(",000") && cbxAlterar_Excluir_Peso.Text == "Inteiro")
            {
                txtAlterar_Excluir_Estoque.Text = txtAlterar_Excluir_Estoque.Text.Substring(0, txtAlterar_Excluir_Estoque.Text.Length - 4);
            }
        }

        private void btnDentro_Validade_Click(object sender, EventArgs e)
        {
            btnDentro_Validade_Clicked = true;
            btnFora_Validade_Clicked = false;

            AlimentoDAL obj = new AlimentoDAL();
            dtgrdvwAlimentos.DataSource = obj.DentroValidade();

            txtAlterar_Excluir_ID_Alimento.Clear();
            txtAlterar_Excluir_Nome.Clear();
            txtAlterar_Excluir_Marca.Clear();
            txtAlterar_Excluir_Unidade.Clear();
            dttmpckAlterar_Excluir_Validade.Value = DateTime.Now;
            txtAlterar_Excluir_Estoque.Clear();
            cbxAlterar_Excluir_Peso.Text = null;
        }

        private void btnFora_Validade_Click(object sender, EventArgs e)
        {
            btnFora_Validade_Clicked = true;
            btnDentro_Validade_Clicked = false;

            AlimentoDAL obj = new AlimentoDAL();
            dtgrdvwAlimentos.DataSource = obj.ForaValidade();

            txtAlterar_Excluir_ID_Alimento.Clear();
            txtAlterar_Excluir_Nome.Clear();
            txtAlterar_Excluir_Marca.Clear();
            txtAlterar_Excluir_Unidade.Clear();
            dttmpckAlterar_Excluir_Validade.Value = DateTime.Now;
            txtAlterar_Excluir_Estoque.Clear();
            cbxAlterar_Excluir_Peso.Text = null;
        }

        private void btnAlterar_Alimento_Click(object sender, EventArgs e)
        {
            if (txtAlterar_Excluir_ID_Alimento.Text.Length == 0)
            {
                MessageBox.Show("Um Alimento deve ser selecionado para alteração!", "Não Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Alimento.Text.Length > 0 && txtAlterar_Excluir_Nome.Text == "" && txtAlterar_Excluir_Marca.Text == "" &&
                    txtAlterar_Excluir_Unidade.Text == "" && txtAlterar_Excluir_Estoque.Text == "" && string.IsNullOrEmpty(cbxAlterar_Excluir_Peso.Text))
            {
                MessageBox.Show("Informe os dados para alterar o Alimento!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Alimento.Text.Length > 0 && txtAlterar_Excluir_Nome.Text == "")
            {
                MessageBox.Show("O Nome do Alimento é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Alimento.Text.Length > 0 && txtAlterar_Excluir_Unidade.Text == "")
            {
                MessageBox.Show("A Unidade do Alimento é obrigatória!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Alimento.Text.Length > 0 && txtAlterar_Excluir_Estoque.Text == "")
            {
                MessageBox.Show("O Estoque do Alimento é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Alimento.Text.Length > 0 && string.IsNullOrEmpty(cbxAlterar_Excluir_Peso.Text))
            {
                MessageBox.Show("Selecione o tipo de Peso do Alimento!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Alimento.Text.Length > 0 && txtAlterar_Excluir_Estoque.Text.Contains(",") && cbxAlterar_Excluir_Peso.Text == "Inteiro")
            {
                MessageBox.Show("O tipo de Peso Inteiro do Alimento não pode conter , no Estoque!", "Dados Imcompatíveis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Confirmar a Alteração do Alimento?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    if (txtAlterar_Excluir_Nome.Text != "" && txtAlterar_Excluir_Marca.Text == "" && txtAlterar_Excluir_Unidade.Text != ""
                        && txtAlterar_Excluir_Estoque.Text != "" && cbxAlterar_Excluir_Peso.Text != "")
                    {
                        AlimentoInformation alimento = new AlimentoInformation();
                        alimento.ID_Alimento = int.Parse(txtAlterar_Excluir_ID_Alimento.Text);
                        alimento.Nome = txtAlterar_Excluir_Nome.Text;
                        alimento.Unidade = int.Parse(txtAlterar_Excluir_Unidade.Text);
                        alimento.Validade = dttmpckAlterar_Excluir_Validade.Value;
                        alimento.Estoque = decimal.Parse(txtAlterar_Excluir_Estoque.Text);
                        alimento.Peso = cbxAlterar_Excluir_Peso.Text;

                        AlimentoDAL obj = new AlimentoDAL();
                        obj.AlterarSemMarca(alimento);

                        MessageBox.Show("O Alimento foi alterado com sucesso! Iremos atualizar o Sistema.");
                    }

                    else if (txtAlterar_Excluir_Nome.Text != "" && txtAlterar_Excluir_Marca.Text != "" && txtAlterar_Excluir_Unidade.Text != ""
                        && txtAlterar_Excluir_Estoque.Text != "" && cbxAlterar_Excluir_Peso.Text != "")
                    {
                        AlimentoInformation alimento = new AlimentoInformation();
                        alimento.ID_Alimento = int.Parse(txtAlterar_Excluir_ID_Alimento.Text);
                        alimento.Nome = txtAlterar_Excluir_Nome.Text;
                        alimento.Marca = txtAlterar_Excluir_Marca.Text;
                        alimento.Unidade = int.Parse(txtAlterar_Excluir_Unidade.Text);
                        alimento.Validade = dttmpckAlterar_Excluir_Validade.Value;
                        alimento.Estoque = decimal.Parse(txtAlterar_Excluir_Estoque.Text);
                        alimento.Peso = cbxAlterar_Excluir_Peso.Text;

                        AlimentoDAL obj = new AlimentoDAL();
                        obj.Alterar(alimento);

                        MessageBox.Show("O Alimento foi alterado com sucesso! Iremos atualizar o Sistema.");
                    }                 
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

                AtualizarGrid();

                this.alimentosTableAdapter.Fill(this.casaDeApoioNossoLarDataSetAlimentos.Alimentos);

                dtgrdvwAlimentos.Update();
                dtgrdvwAlimentos.Refresh();

                if (btnDentro_Validade_Clicked == true)
                {
                    btnFora_Validade_Clicked = false;

                    AlimentoDAL ob = new AlimentoDAL();
                    dtgrdvwAlimentos.DataSource = ob.DentroValidade();
                }

                else if (btnFora_Validade_Clicked == true)
                {
                    btnDentro_Validade_Clicked = false;

                    AlimentoDAL ob = new AlimentoDAL();
                    dtgrdvwAlimentos.DataSource = ob.ForaValidade();
                }

                txtAlterar_Excluir_ID_Alimento.Clear();
                txtAlterar_Excluir_Nome.Clear();
                txtAlterar_Excluir_Marca.Clear();
                txtAlterar_Excluir_Unidade.Clear();
                dttmpckAlterar_Excluir_Validade.Value = DateTime.Now;
                txtAlterar_Excluir_Estoque.Clear();
                cbxAlterar_Excluir_Peso.Text = null;
            }
        }

        private void btnLimpar_Alimento_Click(object sender, EventArgs e)
        {
            if (txtAlterar_Excluir_Nome.Text != "" && txtAlterar_Excluir_Nome.SelectedText != "")
            {
                txtAlterar_Excluir_Nome.Clear();
                txtAlterar_Excluir_Nome.Focus();
            }

            else if (txtAlterar_Excluir_Marca.Text != "" && txtAlterar_Excluir_Marca.SelectedText != "")
            {
                txtAlterar_Excluir_Marca.Clear();
                txtAlterar_Excluir_Marca.Focus();
            }

            else if (txtAlterar_Excluir_Unidade.Text != null && txtAlterar_Excluir_Unidade.SelectedText != "")
            {
                txtAlterar_Excluir_Unidade.Clear();
                txtAlterar_Excluir_Unidade.Focus();
            }

            else if (txtAlterar_Excluir_Estoque != null && txtAlterar_Excluir_Estoque.SelectedText != "")
            {
                txtAlterar_Excluir_Estoque.Clear();
                txtAlterar_Excluir_Estoque.Focus();
            }
        }

        private void btnExcluir_Alimento_Click(object sender, EventArgs e)
        {
            if (txtAlterar_Excluir_ID_Alimento.Text.Length == 0)
            {
                MessageBox.Show("Um Alimento deve ser selecionado antes da exclusão!", "Não Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Confirmar a exclusão do Alimento?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    int codigo = Convert.ToInt32(txtAlterar_Excluir_ID_Alimento.Text);

                    AlimentoDAL obj = new AlimentoDAL();
                    obj.Excluir(codigo);

                    MessageBox.Show("O Alimento foi excluído com sucesso! Iremos atualizar o Sistema.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AtualizarGrid();

                this.alimentosTableAdapter.Fill(this.casaDeApoioNossoLarDataSetAlimentos.Alimentos);

                dtgrdvwAlimentos.Update();
                dtgrdvwAlimentos.Refresh();

                if (btnDentro_Validade_Clicked == true)
                {
                    btnFora_Validade_Clicked = false;

                    AlimentoDAL ob = new AlimentoDAL();
                    dtgrdvwAlimentos.DataSource = ob.DentroValidade();
                }

                else if (btnFora_Validade_Clicked == true)
                {
                    btnDentro_Validade_Clicked = false;

                    AlimentoDAL ob = new AlimentoDAL();
                    dtgrdvwAlimentos.DataSource = ob.ForaValidade();
                }

                txtAlterar_Excluir_ID_Alimento.Clear();
                txtAlterar_Excluir_Nome.Clear();
                txtAlterar_Excluir_Marca.Clear();
                txtAlterar_Excluir_Unidade.Clear();
                dttmpckAlterar_Excluir_Validade.Value = DateTime.Now;
                txtAlterar_Excluir_Estoque.Clear();
                cbxAlterar_Excluir_Peso.Text = null;
            }
        }

        private void dtgrdvwAlimentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;

            if (indexRow < -1 || indexRow < 0) return;

            DataGridViewRow row = dtgrdvwAlimentos.Rows[indexRow];

            txtAlterar_Excluir_ID_Alimento.Text = row.Cells[0].Value.ToString();
            txtAlterar_Excluir_Nome.Text = row.Cells[1].Value.ToString();
            txtAlterar_Excluir_Marca.Text = row.Cells[2].Value.ToString();
            txtAlterar_Excluir_Unidade.Text = row.Cells[3].Value.ToString(); 
            dttmpckAlterar_Excluir_Validade.Text = row.Cells[4].Value.ToString();
            txtAlterar_Excluir_Estoque.Text = row.Cells[5].Value.ToString();
            cbxAlterar_Excluir_Peso.Text = row.Cells[6].Value.ToString();

            if (txtAlterar_Excluir_Estoque.Text.Contains(",000") && cbxAlterar_Excluir_Peso.Text == "Inteiro")
            {
                txtAlterar_Excluir_Estoque.Text = txtAlterar_Excluir_Estoque.Text.Substring(0, txtAlterar_Excluir_Estoque.Text.Length - 4);
            }
        }

        private void txtAlterar_Excluir_Nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtAlterar_Excluir_Nome.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Nome.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtAlterar_Excluir_Nome.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Marca.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAlterar_Excluir_Marca_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtAlterar_Excluir_Marca.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Unidade.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtAlterar_Excluir_Marca.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Unidade.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAlterar_Excluir_Unidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtAlterar_Excluir_Unidade.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Unidade.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtAlterar_Excluir_Unidade.Text != "" && e.KeyCode == Keys.Enter)
            {
                dttmpckAlterar_Excluir_Validade.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dttmpckAlterar_Excluir_Validade_KeyDown(object sender, KeyEventArgs e)
        {
            if (dttmpckAlterar_Excluir_Validade.Text == "" && e.KeyCode == Keys.Enter)
            {
                dttmpckAlterar_Excluir_Validade.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (dttmpckAlterar_Excluir_Validade.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Estoque.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAlterar_Excluir_Estoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtAlterar_Excluir_Estoque.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Estoque.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtAlterar_Excluir_Estoque.Text != "" && e.KeyCode == Keys.Enter)
            {
                cbxAlterar_Excluir_Peso.Focus();
                cbxAlterar_Excluir_Peso.DroppedDown = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAlterar_Excluir_Unidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAlterar_Excluir_Estoque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
            {

            }

            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void cbxAlterar_Excluir_Peso_KeyDown(object sender, KeyEventArgs e)
        {
            if (cbxAlterar_Excluir_Peso.Text == "" && e.KeyCode == Keys.Enter)
            {
                cbxAlterar_Excluir_Peso.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (cbxAlterar_Excluir_Peso.Text != "" && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAlterar_Alimento.PerformClick();
            }
        }
    }
}
