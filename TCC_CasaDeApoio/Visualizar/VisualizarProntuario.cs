using Casa.DAL;
using Casa.Modelos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace TCC_CasaDeApoio.Visualizar
{
    public partial class VisualizarProntuario : Form
    {
        Thread tg;
        int indexRow;

        public VisualizarProntuario()
        {
            InitializeComponent();

            lblVisualizar_Prontuarios.Parent = pctrbxImagem1;
            lblVisualizar_Prontuarios.BackColor = Color.Transparent;
        }

        private void VisualizarEnfermidade_FormClosing(object sender, FormClosingEventArgs e)
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
            ProntuarioDAL obj = new ProntuarioDAL();
            dtgrdvwProntuarios.DataSource = obj.PesquisarProntuario(txtPesquisar_Idosos.Text);
            try
            {
                txtAlterar_ID_Prontuario.Text = dtgrdvwProntuarios[0, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
                cbxAlterar_Idosos.Text = dtgrdvwProntuarios[1, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
                txtAlterar_Enfermidades.Text = dtgrdvwProntuarios[2, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
                cbxAlterar_Alimentos.Text = dtgrdvwProntuarios[3, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
                cbxAlterar_Remedios.Text = dtgrdvwProntuarios[4, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
                dttmpckAlterar_Data_Criacao.Text = dtgrdvwProntuarios[5, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
                dttmpckAlterar_Data_Uso.Text = dtgrdvwProntuarios[6, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
                txtAlterar_Prescricao_Observacoes.Text = dtgrdvwProntuarios[7, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
                txtAlterar_ID_Idoso.Text = dtgrdvwProntuarios[8, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
                txtAlterar_ID_Alimento.Text = dtgrdvwProntuarios[9, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
                txtAlterar_ID_Remedio.Text = dtgrdvwProntuarios[10, dtgrdvwProntuarios.CurrentRow.Index].Value.ToString();
            }

            catch
            {
                txtAlterar_ID_Prontuario.Text = "";
                cbxAlterar_Idosos.Text = "";
                txtAlterar_Enfermidades.Text = "";
                cbxAlterar_Alimentos.Text = "";
                cbxAlterar_Remedios.Text = "";
                dttmpckAlterar_Data_Criacao.Text = "";
                dttmpckAlterar_Data_Uso.Text = "";
                txtAlterar_Prescricao_Observacoes.Text = "";
                txtAlterar_ID_Idoso.Text = "";
                txtAlterar_ID_Alimento.Text = "";
                txtAlterar_ID_Remedio.Text = "";
            }
        }

        private void VisualizarProntuario_Load(object sender, EventArgs e)
        {
            this.prontuariosTableAdapter.Fill(this.casaDeApoioNossoLarDataSetProntuarios.Prontuarios);

            if (this.casaDeApoioNossoLarDataSetProntuarios.Prontuarios.Count == 0)
            {
                this.dtgrdvwProntuarios.DataSource = null;
                btnProcurar_Salvar_Relatorio.Enabled = false;
                btnGerar_Relatorio_PDF.Enabled = false;
            }

            dtgrdvwProntuarios.AllowUserToAddRows = false;

            AtualizarGrid();

            this.dtgrdvwProntuarios.Columns[0].Visible = false;
            this.dtgrdvwProntuarios.Columns[8].Visible = false;
            this.dtgrdvwProntuarios.Columns[9].Visible = false;
            this.dtgrdvwProntuarios.Columns[10].Visible = false;

            ProntuarioDAL obj = new ProntuarioDAL();
            cbxAlterar_Idosos.DataSource = obj.ListaDeIdosos;
            cbxAlterar_Alimentos.DataSource = obj.ListaDeAlimentos;
            cbxAlterar_Remedios.DataSource = obj.ListaDeRemedios;
        }

        private void dtgrdvwProntuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;

            if (indexRow < -1 || indexRow < 0) return;

            DataGridViewRow row = dtgrdvwProntuarios.Rows[indexRow];

            txtAlterar_ID_Prontuario.Text = row.Cells[0].Value.ToString();
            cbxAlterar_Idosos.Text = row.Cells[1].Value.ToString();
            txtAlterar_Enfermidades.Text = row.Cells[2].Value.ToString();
            cbxAlterar_Alimentos.Text = row.Cells[3].Value.ToString();
            cbxAlterar_Remedios.Text = row.Cells[4].Value.ToString();
            dttmpckAlterar_Data_Criacao.Text = row.Cells[5].Value.ToString();
            dttmpckAlterar_Data_Uso.Text = row.Cells[6].Value.ToString();
            txtAlterar_Prescricao_Observacoes.Text = row.Cells[7].Value.ToString();
            txtAlterar_ID_Idoso.Text = row.Cells[8].Value.ToString();
            txtAlterar_ID_Alimento.Text = row.Cells[9].Value.ToString();
            txtAlterar_ID_Remedio.Text = row.Cells[10].Value.ToString();
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

        private void btnPesquisar_Idosos_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnAlterar_Prontuario_Click(object sender, EventArgs e)
        {
            if (txtAlterar_ID_Prontuario.Text.Length == 0)
            {
                MessageBox.Show("Um Prontuário deve ser selecionado para alteração!", "Não Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_ID_Prontuario.Text.Length > 0 && rdbtnAlterar_Sim.Checked == true && string.IsNullOrEmpty(cbxAlterar_Idosos.Text) ||
                     txtAlterar_ID_Prontuario.Text.Length > 0 && rdbtnAlterar_Nao.Checked == true && string.IsNullOrEmpty(cbxAlterar_Idosos.Text))
            {
                MessageBox.Show("O Nome do Idoso é obrigatório para alterar!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_ID_Prontuario.Text.Length > 0 && rdbtnAlterar_Sim.Checked == true && txtAlterar_Enfermidades.Text == "")
            {
                MessageBox.Show("Informe uma Enfermidade para alterar!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_ID_Prontuario.Text.Length > 0 && rdbtnAlterar_Sim.Checked == true && string.IsNullOrEmpty(cbxAlterar_Alimentos.Text) ||
                     txtAlterar_ID_Prontuario.Text.Length > 0 && rdbtnAlterar_Nao.Checked == true && string.IsNullOrEmpty(cbxAlterar_Alimentos.Text))
            {
                MessageBox.Show("O Nome do Alimento é obrigatório para alterar!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (txtAlterar_ID_Prontuario.Text.Length > 0 && rdbtnAlterar_Sim.Checked == true && string.IsNullOrEmpty(cbxAlterar_Remedios.Text))
            {
                MessageBox.Show("Selecione um Remédio para alterar!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Confirmar a Alteração do Prontuário?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    if (rdbtnAlterar_Nao.Checked == true && cbxAlterar_Idosos.Text != "" && cbxAlterar_Alimentos.Text != "")
                    {
                        ProntuarioInformation prontuario = new ProntuarioInformation();
                        prontuario.ID_Prontuario = int.Parse(txtAlterar_ID_Prontuario.Text);
                        prontuario.Idosos = cbxAlterar_Idosos.Text;
                        prontuario.Alimentos = cbxAlterar_Alimentos.Text;
                        prontuario.Data_Criacao = dttmpckAlterar_Data_Criacao.Value;
                        prontuario.Data_Uso = dttmpckAlterar_Data_Uso.Value;
                        prontuario.ID_Idoso = (int)cbxAlterar_Idosos.SelectedValue;
                        prontuario.ID_Alimento = (int)cbxAlterar_Alimentos.SelectedValue;

                        ProntuarioDAL obj = new ProntuarioDAL();
                        obj.AlterarAlimento(prontuario);

                        MessageBox.Show("O Prontuário foi alterado com sucesso! Iremos atualizar o Sistema.");
                    }

                    else if (rdbtnAlterar_Sim.Checked == true && cbxAlterar_Idosos.Text != "" && txtAlterar_Enfermidades.Text != "" &&
                        cbxAlterar_Alimentos.Text != "" && cbxAlterar_Remedios.Text != "" && txtAlterar_Prescricao_Observacoes.Text == "")
                    {
                        ProntuarioInformation prontuario = new ProntuarioInformation();
                        prontuario.ID_Prontuario = int.Parse(txtAlterar_ID_Prontuario.Text);
                        prontuario.Idosos = cbxAlterar_Idosos.Text;
                        prontuario.Enfermidades = txtAlterar_Enfermidades.Text;
                        prontuario.Alimentos = cbxAlterar_Alimentos.Text;
                        prontuario.Remedios = cbxAlterar_Remedios.Text;
                        prontuario.Data_Criacao = dttmpckAlterar_Data_Criacao.Value;
                        prontuario.Data_Uso = dttmpckAlterar_Data_Uso.Value;
                        prontuario.ID_Idoso = (int)cbxAlterar_Idosos.SelectedValue;
                        prontuario.ID_Alimento = (int)cbxAlterar_Alimentos.SelectedValue;
                        prontuario.ID_Remedio = (int)cbxAlterar_Remedios.SelectedValue;

                        ProntuarioDAL obj = new ProntuarioDAL();
                        obj.AlterarSemPrescricaoObservacoes(prontuario);

                        MessageBox.Show("O Prontuário foi alterado com sucesso! Iremos atualizar o Sistema.");
                    }

                    else if (rdbtnAlterar_Sim.Checked == true && cbxAlterar_Idosos.Text != "" && txtAlterar_Enfermidades.Text != "" &&
                        cbxAlterar_Alimentos.Text != "" && cbxAlterar_Remedios.Text != "" && txtAlterar_Prescricao_Observacoes.Text != "")
                    {
                        ProntuarioInformation prontuario = new ProntuarioInformation();
                        prontuario.ID_Prontuario = int.Parse(txtAlterar_ID_Prontuario.Text);
                        prontuario.Idosos = cbxAlterar_Idosos.Text;
                        prontuario.Enfermidades = txtAlterar_Enfermidades.Text;
                        prontuario.Alimentos = cbxAlterar_Alimentos.Text;
                        prontuario.Remedios = cbxAlterar_Remedios.Text;
                        prontuario.Data_Criacao = dttmpckAlterar_Data_Criacao.Value;
                        prontuario.Data_Uso = dttmpckAlterar_Data_Uso.Value;
                        prontuario.Prescricao_Observacoes = txtAlterar_Prescricao_Observacoes.Text;
                        prontuario.ID_Idoso = (int)cbxAlterar_Idosos.SelectedValue;
                        prontuario.ID_Alimento = (int)cbxAlterar_Alimentos.SelectedValue;
                        prontuario.ID_Remedio = (int)cbxAlterar_Remedios.SelectedValue;

                        ProntuarioDAL obj = new ProntuarioDAL();
                        obj.Alterar(prontuario);

                        MessageBox.Show("O Prontuário foi alterado com sucesso! Iremos atualizar o Sistema.");
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

                AtualizarGrid();

                this.prontuariosTableAdapter.Fill(this.casaDeApoioNossoLarDataSetProntuarios.Prontuarios);

                dtgrdvwProntuarios.Update();
                dtgrdvwProntuarios.Refresh();

                txtAlterar_ID_Prontuario.Clear();
                txtAlterar_Enfermidades.Clear();
                txtAlterar_Prescricao_Observacoes.Clear();
                dttmpckAlterar_Data_Criacao.Value = DateTime.Now;
                dttmpckAlterar_Data_Uso.Value = DateTime.Now;
            }
        }

        private void btnLimpar_Prontuario_Click(object sender, EventArgs e)
        {
            if (txtPesquisar_Idosos.Text != null && txtPesquisar_Idosos.SelectedText != "")
            {
                txtPesquisar_Idosos.Clear();
                txtPesquisar_Idosos.Focus();
            }

            if (txtAlterar_Prescricao_Observacoes.Text != null && txtAlterar_Prescricao_Observacoes.SelectedText != "")
            {
                txtAlterar_Prescricao_Observacoes.Clear();
                txtAlterar_Prescricao_Observacoes.Focus();
            }
        }

        private void cbxAlterar_Excluir_Idosos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxAlterar_Idosos.Text))
            {
                MessageBox.Show("Não existe nenhum Idoso registrado.\nRegistre um Idoso na Tela Registrar Idosos!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

            }
        }

        private void cbxAlterar_Excluir_Alimentos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxAlterar_Alimentos.Text))
            {
                MessageBox.Show("Não existe nenhum Alimento registrado.\nRegistre um Alimento na Tela Registrar Alimentos!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

            }
        }

        private void cbxAlterar_Excluir_Remedios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxAlterar_Remedios.Text))
            {
                MessageBox.Show("Não existe nenhum Remédio registrado.\nRegistre um Remédio na Tela Registrar Remédios!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

            }
        }

        private void rdbtnAlterar_Sim_CheckedChanged(object sender, EventArgs e)
        {
            txtAlterar_Enfermidades.Enabled = true;
            txtAlterar_Enfermidades.BackColor = Color.White;

            cbxAlterar_Remedios.Enabled = true;
            cbxAlterar_Remedios.BackColor = Color.White;

            txtAlterar_Prescricao_Observacoes.Enabled = true;
            txtAlterar_Prescricao_Observacoes.BackColor = Color.White;
        }

        private void rdbtnAlterar_Nao_CheckedChanged(object sender, EventArgs e)
        {
            txtAlterar_Enfermidades.Enabled = false;
            txtAlterar_Enfermidades.BackColor = ColorTranslator.FromHtml("#BCBCBC");

            cbxAlterar_Remedios.Enabled = false;
            cbxAlterar_Remedios.BackColor = ColorTranslator.FromHtml("#BCBCBC");

            txtAlterar_Prescricao_Observacoes.Enabled = false;
            txtAlterar_Prescricao_Observacoes.BackColor = ColorTranslator.FromHtml("#BCBCBC");
        }

        private void btnProcurar_Salvar_Relatorio_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtRelatorio_PDF.Text = dlg.SelectedPath;
                btnGerar_Relatorio_PDF.Enabled = true;
            }
        }

        private void btnGerar_Relatorio_PDF_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja realmente gerar o Relatório em PDF?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    PdfPTable pdflinhas = new PdfPTable(dtgrdvwProntuarios.Columns.Count);
                    pdflinhas.WidthPercentage = 102;
                    pdflinhas.HorizontalAlignment = Element.ALIGN_CENTER;

                    foreach (DataGridViewColumn column in dtgrdvwProntuarios.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                        pdflinhas.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dtgrdvwProntuarios.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            pdflinhas.AddCell(cell.Value.ToString());
                        }
                    }

                    using (FileStream relatorio = new FileStream(txtRelatorio_PDF.Text + "\\" + "Relatório dos Prontuários" + " " + DateTime.Now.ToString("dd-MM-yyyy HH'h 'mm'm 'ss's'") + ".pdf", FileMode.Create))
                    {
                        Document pdfrelatorio = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                        PdfWriter.GetInstance(pdfrelatorio, relatorio);
                        pdfrelatorio.Open();
                        pdfrelatorio.Add(pdflinhas);
                        pdfrelatorio.Close();
                    }

                    MessageBox.Show("O Relatório dos Prontuários em PDF foi criado com sucesso!");
                }

                catch (Exception)
                {
                    MessageBox.Show("Não foi possível gerar o Relatório dos Prontuários em PDF!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
