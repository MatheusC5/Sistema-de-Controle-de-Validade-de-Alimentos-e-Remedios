using Casa.DAL;
using Casa.Modelos;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TCC_CasaDeApoio.Visualizar
{
    public partial class VisualizarIdoso : Form
    {
        Thread tg;
        int indexRow;

        public VisualizarIdoso()
        {
            InitializeComponent();

            lblVisualizar_Idosos.Parent = pctrbxImagem1;
            lblVisualizar_Idosos.BackColor = Color.Transparent;
        }

        private void VisualizarIdoso_FormClosing(object sender, FormClosingEventArgs e)
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
            IdosoDAL obj = new IdosoDAL();
            dtgrdvwIdosos.DataSource = obj.Pesquisar(txtPesquisar_Idosos.Text);
            try
            {
                txtAlterar_Excluir_ID_Idoso.Text = dtgrdvwIdosos[0, dtgrdvwIdosos.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Nome.Text = dtgrdvwIdosos[1, dtgrdvwIdosos.CurrentRow.Index].Value.ToString();
                dttmpckAlterar_Excluir_Data_Nascimento.Text = dtgrdvwIdosos[2, dtgrdvwIdosos.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Endereco_Responsavel.Text = dtgrdvwIdosos[3, dtgrdvwIdosos.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Telefone_Responsavel.Text = dtgrdvwIdosos[4, dtgrdvwIdosos.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Celular_Responsavel.Text = dtgrdvwIdosos[5, dtgrdvwIdosos.CurrentRow.Index].Value.ToString();
                txtAlterar_Excluir_Telefone_Emergencia.Text = dtgrdvwIdosos[6, dtgrdvwIdosos.CurrentRow.Index].Value.ToString();
            }

            catch
            {
                txtAlterar_Excluir_ID_Idoso.Text = "";
                txtAlterar_Excluir_Nome.Text = "";
                dttmpckAlterar_Excluir_Data_Nascimento.Text = "";
                txtAlterar_Excluir_Endereco_Responsavel.Text = "";
                txtAlterar_Excluir_Telefone_Responsavel.Text = "";
                txtAlterar_Excluir_Celular_Responsavel.Text = "";
                txtAlterar_Excluir_Telefone_Emergencia.Text = "";
            }
        }

        private void VisualizarIdoso_Load(object sender, EventArgs e)
        {
            this.idososTableAdapter.Fill(this.casaDeApoioNossoLarDataSetIdosos.Idosos);

            if (this.casaDeApoioNossoLarDataSetIdosos.Idosos.Count == 0)
            {
                this.dtgrdvwIdosos.DataSource = null;
            }

            dtgrdvwIdosos.AllowUserToAddRows = false;

            AtualizarGrid();

            this.dtgrdvwIdosos.Columns[0].Visible = false;
        }

        private void btnPesquisar_Idosos_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnAlterar_Idoso_Click(object sender, EventArgs e)
        {
            if (txtAlterar_Excluir_ID_Idoso.Text.Length == 0)
            {
                MessageBox.Show("Um Idoso deve ser selecionado para alteração!", "Não Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Idoso.Text.Length > 0 && txtAlterar_Excluir_Nome.Text == "" && txtAlterar_Excluir_Endereco_Responsavel.Text == "" &&
                    txtAlterar_Excluir_Telefone_Responsavel.Text == "(  )     -")
            {
                MessageBox.Show("Informe os dados para Alterar o Idoso!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Idoso.Text.Length > 0 && txtAlterar_Excluir_Nome.Text == "")
            {
                MessageBox.Show("O Nome do Idoso é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Idoso.Text.Length > 0 && txtAlterar_Excluir_Endereco_Responsavel.Text == "")
            {
                MessageBox.Show("O Endereço do Responsável do Idoso é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_Excluir_ID_Idoso.Text.Length > 0 && txtAlterar_Excluir_Telefone_Responsavel.Text == "(  )     -")
            {
                MessageBox.Show("O Telefone do Responsável do Idoso é obrigatório!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Confirmar a Alteração do Idoso?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    IdosoInformation idoso = new IdosoInformation();
                    idoso.ID_Idoso = int.Parse(txtAlterar_Excluir_ID_Idoso.Text);
                    idoso.Nome = txtAlterar_Excluir_Nome.Text;
                    idoso.Data_Nascimento = dttmpckAlterar_Excluir_Data_Nascimento.Value;
                    idoso.Endereco_Responsavel = txtAlterar_Excluir_Endereco_Responsavel.Text;
                    idoso.Telefone_Responsavel = txtAlterar_Excluir_Telefone_Responsavel.Text;
                    idoso.Celular_Responsavel = txtAlterar_Excluir_Celular_Responsavel.Text;
                    idoso.Telefone_Emergencia = txtAlterar_Excluir_Telefone_Emergencia.Text;

                    IdosoDAL obj = new IdosoDAL();
                    obj.Alterar(idoso);

                    MessageBox.Show("O Idoso foi alterado com sucesso! Iremos atualizar o Sistema.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

                AtualizarGrid();

                this.idososTableAdapter.Fill(this.casaDeApoioNossoLarDataSetIdosos.Idosos);

                dtgrdvwIdosos.Update();
                dtgrdvwIdosos.Refresh();

                txtAlterar_Excluir_ID_Idoso.Clear();
                txtAlterar_Excluir_Nome.Clear();
                dttmpckAlterar_Excluir_Data_Nascimento.Value = new DateTime(1900, 01, 01);
                txtAlterar_Excluir_Endereco_Responsavel.Clear();
                txtAlterar_Excluir_Telefone_Responsavel.Clear();
                txtAlterar_Excluir_Celular_Responsavel.Clear();
                txtAlterar_Excluir_Telefone_Emergencia.Clear();
            }
        }

        private void btnLimpar_Idoso_Click(object sender, EventArgs e)
        {
            if (txtPesquisar_Idosos.Text != null && txtPesquisar_Idosos.SelectedText != "")
            {
                txtPesquisar_Idosos.Clear();
                txtPesquisar_Idosos.Focus();
            }

            else if (txtAlterar_Excluir_Nome.Text != "" && txtAlterar_Excluir_Nome.SelectedText != "")
            {
                txtAlterar_Excluir_Nome.Clear();
                txtAlterar_Excluir_Nome.Focus();
            }

            else if (txtAlterar_Excluir_Endereco_Responsavel.Text != "" && txtAlterar_Excluir_Endereco_Responsavel.SelectedText != "")
            {
                txtAlterar_Excluir_Endereco_Responsavel.Clear();
                txtAlterar_Excluir_Endereco_Responsavel.Focus();
            }

            else if (txtAlterar_Excluir_Telefone_Responsavel.Text != null && txtAlterar_Excluir_Telefone_Responsavel.SelectedText != "")
            {
                txtAlterar_Excluir_Telefone_Responsavel.Clear();
            }

            else if (txtAlterar_Excluir_Celular_Responsavel.Text != null && txtAlterar_Excluir_Celular_Responsavel.SelectedText != "")
            {
                txtAlterar_Excluir_Celular_Responsavel.Clear();
            }

            else if (txtAlterar_Excluir_Telefone_Emergencia.Text != null && txtAlterar_Excluir_Telefone_Emergencia.SelectedText != "")
            {
                txtAlterar_Excluir_Telefone_Emergencia.Clear();
            }
        }

        private void btnExcluir_Idoso_Click(object sender, EventArgs e)
        {
            if (txtAlterar_Excluir_ID_Idoso.Text.Length == 0)
            {
                MessageBox.Show("Um Idoso deve ser selecionado antes da exclusão!", "Não Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Confirmar a exclusão do Idoso?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    int codigo = Convert.ToInt32(txtAlterar_Excluir_ID_Idoso.Text);

                    IdosoDAL obj = new IdosoDAL();
                    obj.Excluir(codigo);

                    MessageBox.Show("O Idoso foi excluído com sucesso! Iremos atualizar o Sistema.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                AtualizarGrid();

                this.idososTableAdapter.Fill(this.casaDeApoioNossoLarDataSetIdosos.Idosos);

                dtgrdvwIdosos.Update();
                dtgrdvwIdosos.Refresh();

                txtAlterar_Excluir_ID_Idoso.Clear();
                txtAlterar_Excluir_Nome.Clear();
                dttmpckAlterar_Excluir_Data_Nascimento.Value = new DateTime(1900, 01, 01);
                txtAlterar_Excluir_Endereco_Responsavel.Clear();
                txtAlterar_Excluir_Telefone_Responsavel.Clear();
                txtAlterar_Excluir_Celular_Responsavel.Clear();
                txtAlterar_Excluir_Telefone_Emergencia.Clear();
            }
        }

        private void dtgrdvwIdosos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;

            if (indexRow < -1 || indexRow < 0) return;

            DataGridViewRow row = dtgrdvwIdosos.Rows[indexRow];

            txtAlterar_Excluir_ID_Idoso.Text = row.Cells[0].Value.ToString();
            txtAlterar_Excluir_Nome.Text = row.Cells[1].Value.ToString();
            dttmpckAlterar_Excluir_Data_Nascimento.Text = row.Cells[2].Value.ToString();
            txtAlterar_Excluir_Endereco_Responsavel.Text = row.Cells[3].Value.ToString();
            txtAlterar_Excluir_Telefone_Responsavel.Text = row.Cells[4].Value.ToString();
            txtAlterar_Excluir_Celular_Responsavel.Text = row.Cells[5].Value.ToString();
            txtAlterar_Excluir_Telefone_Emergencia.Text = row.Cells[6].Value.ToString();
        }

        private void txtPesquisar_Idosos_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPesquisar_Idosos.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtPesquisar_Idosos.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtPesquisar_Idosos.Text != "" && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnPesquisar_Idosos.PerformClick();
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
                dttmpckAlterar_Excluir_Data_Nascimento.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void dttmpckAlterar_Excluir_Data_Nascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (dttmpckAlterar_Excluir_Data_Nascimento.Text == "" && e.KeyCode == Keys.Enter)
            {
                dttmpckAlterar_Excluir_Data_Nascimento.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (dttmpckAlterar_Excluir_Data_Nascimento.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Endereco_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAlterar_Excluir_Endereco_Responsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtAlterar_Excluir_Endereco_Responsavel.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Endereco_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtAlterar_Excluir_Endereco_Responsavel.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Telefone_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAlterar_Excluir_Telefone_Responsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtAlterar_Excluir_Telefone_Responsavel.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Telefone_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtAlterar_Excluir_Telefone_Responsavel.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Celular_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAlterar_Excluir_Celular_Responsavel_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtAlterar_Excluir_Celular_Responsavel.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Celular_Responsavel.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtAlterar_Excluir_Celular_Responsavel.Text != "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Telefone_Emergencia.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtAlterar_Excluir_Telefone_Emergencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtAlterar_Excluir_Telefone_Emergencia.Text == "" && e.KeyCode == Keys.Enter)
            {
                txtAlterar_Excluir_Telefone_Emergencia.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            else if (txtAlterar_Excluir_Telefone_Emergencia.Text != "" && e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnAlterar_Idoso.PerformClick();
            }
        }
    }
}
