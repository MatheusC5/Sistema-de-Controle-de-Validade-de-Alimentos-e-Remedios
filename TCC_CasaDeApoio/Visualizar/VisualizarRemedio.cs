using Casa.DAL;
using Casa.Modelos;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace TCC_CasaDeApoio.Visualizar
{
    public partial class VisualizarRemedio : Form
    {
        Thread tg;
        int indexRow;
        private bool btnDentro_Validade_Clicked = false;
        private bool btnFora_Validade_Clicked = false;

        public VisualizarRemedio()
        {
            InitializeComponent();

            lblVisualizar_Remedios.Parent = pctrbxImagem1;
            lblVisualizar_Remedios.BackColor = Color.Transparent;

            lblValidade_Remedios.Parent = pctrbxImagem1;
            lblValidade_Remedios.BackColor = Color.Transparent;
        }

        private void VisualizarRemedio_FormClosing(object sender, FormClosingEventArgs e)
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
                txtAlterar_Excluir_ID_Remedio.Text = dtgrdvwRemedios[0, dtgrdvwRemedios.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Nome.Text = dtgrdvwRemedios[1, dtgrdvwRemedios.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Marca.Text = dtgrdvwRemedios[2, dtgrdvwRemedios.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Unidade.Text = dtgrdvwRemedios[3, dtgrdvwRemedios.CurrentRow.Index].Value.ToString();
                dttmpckAlterar_Excluir_Validade.Text = dtgrdvwRemedios[4, dtgrdvwRemedios.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Estoque.Text = dtgrdvwRemedios[5, dtgrdvwRemedios.CurrentRow.Index].Value.ToString();
                cbxAlterar_Excluir_Peso.Text = dtgrdvwRemedios[6, dtgrdvwRemedios.CurrentRow.Index].Value.ToString();
            }

            catch
            {
                txtAlterar_Excluir_ID_Remedio.Text = "";
                txtAlterar_Excluir_Nome.Text = "";
                txtAlterar_Excluir_Marca.Text = "";
                txtAlterar_Excluir_Unidade.Text = "";
                dttmpckAlterar_Excluir_Validade.Text = "";
                txtAlterar_Excluir_Estoque.Text = "";
                cbxAlterar_Excluir_Peso.Text = "";
            }
        }

        private void btnDentro_Validade_Click(object sender, EventArgs e)
        {
            btnDentro_Validade_Clicked = true;
            btnFora_Validade_Clicked = false;

            RemedioDAL obj = new RemedioDAL();
            dtgrdvwRemedios.DataSource = obj.DentroValidade();

            txtAlterar_Excluir_ID_Remedio.Clear();
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

            RemedioDAL obj = new RemedioDAL();
            dtgrdvwRemedios.DataSource = obj.ForaValidade();

            txtAlterar_Excluir_ID_Remedio.Clear();
            txtAlterar_Excluir_Nome.Clear();
            txtAlterar_Excluir_Marca.Clear();
            txtAlterar_Excluir_Unidade.Clear();
            dttmpckAlterar_Excluir_Validade.Value = DateTime.Now;
            txtAlterar_Excluir_Estoque.Clear();
            cbxAlterar_Excluir_Peso.Text = null;
        }

        private void btnAlterar_Remedio_Click(object sender, EventArgs e)
        {
            if (txtAlterar_Excluir_ID_Remedio.Text.Length == 0)
            {
                MessageBox.Show("Um Remédio deve ser selecionado para alteração!", "Não Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Remedio.Text.Length > 0 && txtAlterar_Excluir_Nome.Text == "" && txtAlterar_Excluir_Marca.Text == "" &&
                    txtAlterar_Excluir_Unidade.Text == "" && txtAlterar_Excluir_Estoque.Text == "" && string.IsNullOrEmpty(cbxAlterar_Excluir_Peso.Text))
            {
                MessageBox.Show("Informe os dados para alterar o Remédio!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Remedio.Text.Length > 0 && txtAlterar_Excluir_Nome.Text == "")
            {
                MessageBox.Show("O Nome do Remédio é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Remedio.Text.Length > 0 && txtAlterar_Excluir_Unidade.Text == "")
            {
                MessageBox.Show("A Unidade do Remédio é obrigatória!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Remedio.Text.Length > 0 && txtAlterar_Excluir_Estoque.Text == "")
            {
                MessageBox.Show("O Estoque do Remédio é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Remedio.Text.Length > 0 && string.IsNullOrEmpty(cbxAlterar_Excluir_Peso.Text))
            {
                MessageBox.Show("Selecione o tipo de Peso do Remédio!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Remedio.Text.Length > 0 && txtAlterar_Excluir_Estoque.Text.Contains(",") && cbxAlterar_Excluir_Peso.Text == "Inteiro")
            {
                MessageBox.Show("O tipo de Peso Inteiro do Remédio não pode conter , no Estoque!", "Dados Imcompatíveis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Confirmar a Alteração do Remédio?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    if (txtAlterar_Excluir_Nome.Text != "" && txtAlterar_Excluir_Marca.Text == "" && txtAlterar_Excluir_Unidade.Text != ""
                        && txtAlterar_Excluir_Estoque.Text != "" && cbxAlterar_Excluir_Peso.Text != "")
                    {
                        RemedioInformation remedio = new RemedioInformation();
                        remedio.ID_Remedio = int.Parse(txtAlterar_Excluir_ID_Remedio.Text);
                        remedio.Nome = txtAlterar_Excluir_Nome.Text;
                        remedio.Unidade = int.Parse(txtAlterar_Excluir_Unidade.Text);
                        remedio.Validade = dttmpckAlterar_Excluir_Validade.Value;
                        remedio.Estoque = decimal.Parse(txtAlterar_Excluir_Estoque.Text);
                        remedio.Peso = cbxAlterar_Excluir_Peso.Text;

                        RemedioDAL obj = new RemedioDAL();
                        obj.AlterarSemMarca(remedio);

                        MessageBox.Show("O Remédio foi alterado com sucesso! Iremos atualizar o Sistema.");
                    }

                    else if (txtAlterar_Excluir_Nome.Text != "" && txtAlterar_Excluir_Marca.Text != "" && txtAlterar_Excluir_Unidade.Text != ""
                        && txtAlterar_Excluir_Estoque.Text != "" && cbxAlterar_Excluir_Peso.Text != "")
                    {
                        RemedioInformation remedio = new RemedioInformation();
                        remedio.ID_Remedio = int.Parse(txtAlterar_Excluir_ID_Remedio.Text);
                        remedio.Nome = txtAlterar_Excluir_Nome.Text;
                        remedio.Marca = txtAlterar_Excluir_Marca.Text;
                        remedio.Unidade = int.Parse(txtAlterar_Excluir_Unidade.Text);
                        remedio.Validade = dttmpckAlterar_Excluir_Validade.Value;
                        remedio.Estoque = decimal.Parse(txtAlterar_Excluir_Estoque.Text);
                        remedio.Peso = cbxAlterar_Excluir_Peso.Text;

                        RemedioDAL obj = new RemedioDAL();
                        obj.Alterar(remedio);

                        MessageBox.Show("O Remédio foi alterado com sucesso! Iremos atualizar o Sistema.");
                    }         
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

                AtualizarGrid();

                this.remediosTableAdapter.Fill(this.casaDeApoioNossoLarDataSetRemedios.Remedios);

                dtgrdvwRemedios.Update();
                dtgrdvwRemedios.Refresh();

                if (btnDentro_Validade_Clicked == true)
                {
                    btnFora_Validade_Clicked = false;

                    RemedioDAL ob = new RemedioDAL();
                    dtgrdvwRemedios.DataSource = ob.DentroValidade();
                }

                else if (btnFora_Validade_Clicked == true)
                {
                    btnDentro_Validade_Clicked = false;

                    RemedioDAL ob = new RemedioDAL();
                    dtgrdvwRemedios.DataSource = ob.ForaValidade();
                }

                txtAlterar_Excluir_ID_Remedio.Clear();
                txtAlterar_Excluir_Nome.Clear();
                txtAlterar_Excluir_Marca.Clear();
                txtAlterar_Excluir_Unidade.Clear();
                dttmpckAlterar_Excluir_Validade.Value = DateTime.Now;
                txtAlterar_Excluir_Estoque.Clear();
                cbxAlterar_Excluir_Peso.Text = null;
            }             
        }

        private void btnLimpar_Remedio_Click(object sender, EventArgs e)
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

        private void btnExcluir_Remedio_Click(object sender, EventArgs e)
        {
            if (txtAlterar_Excluir_ID_Remedio.Text.Length == 0)
            {
                MessageBox.Show("Um Remédio deve ser selecionado antes da exclusão!", "Não Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Confirmar a exclusão do Remédio?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    int codigo = Convert.ToInt32(txtAlterar_Excluir_ID_Remedio.Text);

                    RemedioDAL obj = new RemedioDAL();
                    obj.Excluir(codigo);

                    MessageBox.Show("O Remédio foi excluído com sucesso! Iremos atualizar o Sistema.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AtualizarGrid();

                this.remediosTableAdapter.Fill(this.casaDeApoioNossoLarDataSetRemedios.Remedios);

                dtgrdvwRemedios.Update();
                dtgrdvwRemedios.Refresh();

                if (btnDentro_Validade_Clicked == true)
                {
                    btnFora_Validade_Clicked = false;

                    RemedioDAL ob = new RemedioDAL();
                    dtgrdvwRemedios.DataSource = ob.DentroValidade();
                }

                else if (btnFora_Validade_Clicked == true)
                {
                    btnDentro_Validade_Clicked = false;

                    RemedioDAL ob = new RemedioDAL();
                    dtgrdvwRemedios.DataSource = ob.ForaValidade();
                }

                txtAlterar_Excluir_ID_Remedio.Clear();
                txtAlterar_Excluir_Nome.Clear();
                txtAlterar_Excluir_Marca.Clear();
                txtAlterar_Excluir_Unidade.Clear();
                dttmpckAlterar_Excluir_Validade.Value = DateTime.Now;
                txtAlterar_Excluir_Estoque.Clear();
                cbxAlterar_Excluir_Peso.Text = null;
            }
        }

        private void dtgrdvwRemedios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;

            if (indexRow < -1 || indexRow < 0) return;

            DataGridViewRow row = dtgrdvwRemedios.Rows[indexRow];

            txtAlterar_Excluir_ID_Remedio.Text = row.Cells[0].Value.ToString();
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

        private void VisualizarRemedio_Load(object sender, EventArgs e)
        {
            this.remediosTableAdapter.Fill(this.casaDeApoioNossoLarDataSetRemedios.Remedios);

            if (this.casaDeApoioNossoLarDataSetRemedios.Remedios.Count == 0)
            {
                this.dtgrdvwRemedios.DataSource = null;
            }

            dtgrdvwRemedios.AllowUserToAddRows = false;

            AtualizarGrid();

            this.dtgrdvwRemedios.Columns[0].Visible = false;

            if (txtAlterar_Excluir_Estoque.Text.Contains(",000") && cbxAlterar_Excluir_Peso.Text == "Inteiro")
            {
                txtAlterar_Excluir_Estoque.Text = txtAlterar_Excluir_Estoque.Text.Substring(0, txtAlterar_Excluir_Estoque.Text.Length - 4);
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
                btnAlterar_Remedio.PerformClick();
            }
        }
    }
}
