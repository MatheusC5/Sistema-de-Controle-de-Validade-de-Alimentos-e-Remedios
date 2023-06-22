using Casa.DAL;
using Casa.Modelos;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace TCC_CasaDeApoio.Registrar
{
    public partial class RegistrarProntuario : Form
    {
        Thread tg;
        int indexRow;

        public RegistrarProntuario()
        {
            InitializeComponent();

            lblRegistrar_Prontuarios.Parent = pctrbxImagem;
            lblRegistrar_Prontuarios.BackColor = Color.Transparent;

            lblLista.Parent = pctrbxImagem;
            lblLista.BackColor = Color.Transparent;

            lblCodigo.Parent = pctrbxImagem;
            lblCodigo.BackColor = Color.Transparent;

            lblData_Criacao.Parent = pctrbxImagem;
            lblData_Criacao.BackColor = Color.Transparent;

            lblIdosos.Parent = pctrbxImagem;
            lblIdosos.BackColor = Color.Transparent;

            lblIdoso.Parent = pctrbxImagem;
            lblIdoso.BackColor = Color.Transparent;

            lblPossui.Parent = pctrbxImagem;
            lblPossui.BackColor = Color.Transparent;

            grpbxOpcoes.Parent = pctrbxImagem;
            grpbxOpcoes.BackColor = Color.Transparent;

            lblEnfermidades.Parent = pctrbxImagem;
            lblEnfermidades.BackColor = Color.Transparent;

            lblAlimentos.Parent = pctrbxImagem;
            lblAlimentos.BackColor = Color.Transparent;

            lblRemedios.Parent = pctrbxImagem;
            lblRemedios.BackColor = Color.Transparent;

            lblData_Uso.Parent = pctrbxImagem;
            lblData_Uso.BackColor = Color.Transparent;

            lblPrescricao.Parent = pctrbxImagem;
            lblPrescricao.BackColor = Color.Transparent;

            lblObservações.Parent = pctrbxImagem;
            lblObservações.BackColor = Color.Transparent;

            lblRegistroConcluido.Parent = pctrbxImagem;
            lblRegistroConcluido.BackColor = Color.Transparent;

            lblObrigatorio.Parent = pctrbxImagem;
            lblObrigatorio.BackColor = Color.Transparent;
        }

        private void RegistrarProntuario_FormClosing(object sender, FormClosingEventArgs e)
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

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            if (txtEnfermidades.Text != "" && txtEnfermidades.SelectedText != "")
            {
                txtEnfermidades.Clear();
                txtEnfermidades.Focus();
            }

            if (txtPrescricao_Observacoes.Text != "" && txtPrescricao_Observacoes.SelectedText != "")
            {
                txtPrescricao_Observacoes.Clear();
                txtPrescricao_Observacoes.Focus();
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (rdbtnSim.Checked == true && dtgrdvwLista.Rows.Count < 1 || rdbtnNao.Checked == true && dtgrdvwLista.Rows.Count < 1)
            {
                MessageBox.Show("Informe os dados para registrar o Prontuário!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show(this, "Deseja realmente registrar o Prontuário?", "Confirmar Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                for (int i = 0; i < dtgrdvwLista.Rows.Count; i++)
                {
                    try
                    {
                        if (dtgrdvwLista.Rows[i].Cells[1].Value.ToString() == "" && dtgrdvwLista.Rows[i].Cells[3].Value.ToString() == "" &&
                            dtgrdvwLista.Rows[i].Cells[6].Value.ToString() == "" && dtgrdvwLista.Rows[i].Cells[9].Value.ToString() == "")
                        {
                            ProntuarioInformation prontuario = new ProntuarioInformation();
                            prontuario.Idosos = dtgrdvwLista.Rows[i].Cells[0].Value.ToString();
                            prontuario.Alimentos = dtgrdvwLista.Rows[i].Cells[2].Value.ToString();
                            prontuario.Data_Criacao = Convert.ToDateTime(dtgrdvwLista.Rows[i].Cells[4].Value.ToString());
                            prontuario.Data_Uso = Convert.ToDateTime (dtgrdvwLista.Rows[i].Cells[5].Value.ToString());
                            prontuario.ID_Idoso = int.Parse(dtgrdvwLista.Rows[i].Cells[7].Value.ToString());
                            prontuario.ID_Alimento = int.Parse(dtgrdvwLista.Rows[i].Cells[8].Value.ToString());

                            ProntuarioDAL obj = new ProntuarioDAL();
                            obj.IncluirAlimento(prontuario);

                            lblRegistroConcluido.Visible = true;
                            var t = new Timer();
                            t.Interval = 4000;
                            t.Tick += (s, f) =>
                            {
                                lblRegistroConcluido.Hide();
                                t.Stop();
                            };
                            t.Start();

                            txtID_Prontuario.Text = Convert.ToString(prontuario.ID_Prontuario);
                        }

                        else if (dtgrdvwLista.Rows[i].Cells[1].Value.ToString() != "" && dtgrdvwLista.Rows[i].Cells[3].Value.ToString() != "" &&
                                dtgrdvwLista.Rows[i].Cells[6].Value.ToString() == "" && dtgrdvwLista.Rows[i].Cells[9].Value.ToString() != "")
                        {
                            ProntuarioInformation prontuario = new ProntuarioInformation();
                            prontuario.Idosos = dtgrdvwLista.Rows[i].Cells[0].Value.ToString();
                            prontuario.Enfermidades = dtgrdvwLista.Rows[i].Cells[1].Value.ToString();
                            prontuario.Alimentos = dtgrdvwLista.Rows[i].Cells[2].Value.ToString();
                            prontuario.Remedios = dtgrdvwLista.Rows[i].Cells[3].Value.ToString();
                            prontuario.Data_Criacao = Convert.ToDateTime(dtgrdvwLista.Rows[i].Cells[4].Value.ToString());
                            prontuario.Data_Uso = Convert.ToDateTime(dtgrdvwLista.Rows[i].Cells[5].Value.ToString());
                            prontuario.ID_Idoso = int.Parse(dtgrdvwLista.Rows[i].Cells[7].Value.ToString());
                            prontuario.ID_Alimento = int.Parse(dtgrdvwLista.Rows[i].Cells[8].Value.ToString());
                            prontuario.ID_Remedio = int.Parse(dtgrdvwLista.Rows[i].Cells[9].Value.ToString());

                            ProntuarioDAL obj = new ProntuarioDAL();
                            obj.IncluirSemPrescricaoObservacoes(prontuario);

                            lblRegistroConcluido.Visible = true;
                            var t = new Timer();
                            t.Interval = 4000;
                            t.Tick += (s, f) =>
                            {
                                lblRegistroConcluido.Hide();
                                t.Stop();
                            };
                            t.Start();

                            txtID_Prontuario.Text = Convert.ToString(prontuario.ID_Prontuario);
                        }

                        else if (dtgrdvwLista.Rows[i].Cells[1].Value.ToString() != "" && dtgrdvwLista.Rows[i].Cells[3].Value.ToString() != "" &&
                                dtgrdvwLista.Rows[i].Cells[6].Value.ToString() != "" && dtgrdvwLista.Rows[i].Cells[9].Value.ToString() != "")
                        {
                            ProntuarioInformation prontuario = new ProntuarioInformation();
                            prontuario.Idosos = dtgrdvwLista.Rows[i].Cells[0].Value.ToString();
                            prontuario.Enfermidades = dtgrdvwLista.Rows[i].Cells[1].Value.ToString();
                            prontuario.Alimentos = dtgrdvwLista.Rows[i].Cells[2].Value.ToString();
                            prontuario.Remedios = dtgrdvwLista.Rows[i].Cells[3].Value.ToString();
                            prontuario.Data_Criacao = Convert.ToDateTime(dtgrdvwLista.Rows[i].Cells[4].Value.ToString());
                            prontuario.Data_Uso = Convert.ToDateTime (dtgrdvwLista.Rows[i].Cells[5].Value.ToString());
                            prontuario.Prescricao_Observacoes = dtgrdvwLista.Rows[i].Cells[6].Value.ToString();
                            prontuario.ID_Idoso = int.Parse(dtgrdvwLista.Rows[i].Cells[7].Value.ToString());
                            prontuario.ID_Alimento = int.Parse(dtgrdvwLista.Rows[i].Cells[8].Value.ToString());
                            prontuario.ID_Remedio = int.Parse(dtgrdvwLista.Rows[i].Cells[9].Value.ToString());

                            ProntuarioDAL obj = new ProntuarioDAL();
                            obj.Incluir(prontuario);

                            lblRegistroConcluido.Visible = true;
                            var t = new Timer();
                            t.Interval = 4000;
                            t.Tick += (s, f) =>
                            {
                                lblRegistroConcluido.Hide();
                                t.Stop();
                            };
                            t.Start();

                            txtID_Prontuario.Text = Convert.ToString(prontuario.ID_Prontuario);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }

                dtgrdvwLista.Rows.Clear();
                txtEnfermidades.Clear();
                txtPrescricao_Observacoes.Clear();
                dttmpckData_Criacao.Value = DateTime.Now;
                dttmpckData_Uso.Value = DateTime.Now;
            }
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            if (rdbtnSim.Checked == true && string.IsNullOrEmpty(cbxIdosos.Text) && txtEnfermidades.Text == "" && 
                string.IsNullOrEmpty(cbxAlimentos.Text) && string.IsNullOrEmpty(cbxRemedios.Text) && txtPrescricao_Observacoes.Text == ""||
                rdbtnNao.Checked == true && string.IsNullOrEmpty(cbxIdosos.Text) && string.IsNullOrEmpty(cbxAlimentos.Text))
            {
                MessageBox.Show("Informe os dados para depois adicionar a Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (rdbtnSim.Checked == true && string.IsNullOrEmpty(cbxIdosos.Text) ||
                     rdbtnNao.Checked == true && string.IsNullOrEmpty(cbxIdosos.Text))
            {
                MessageBox.Show("Selecione um Idoso para adicionar a Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (rdbtnSim.Checked == true && txtEnfermidades.Text == "")
            {
                MessageBox.Show("Informe a Enfermidade para adicionar a Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (rdbtnSim.Checked == true && string.IsNullOrEmpty(cbxAlimentos.Text) ||
                     rdbtnNao.Checked == true && string.IsNullOrEmpty(cbxAlimentos.Text))
            {
                MessageBox.Show("Selecione um Alimento para adicionar a Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (rdbtnSim.Checked == true && string.IsNullOrEmpty(cbxRemedios.Text))
            {
                MessageBox.Show("Selecione um Remédio para adicionar a Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (rdbtnNao.Checked == true && cbxIdosos.Text != "" && cbxAlimentos.Text != "")
            {
                dtgrdvwLista.Rows.Add(cbxIdosos.Text, DBNull.Value, cbxAlimentos.Text, DBNull.Value, dttmpckData_Criacao.Value.ToShortDateString(), dttmpckData_Uso.Value.ToShortDateString(), DBNull.Value, (int)cbxIdosos.SelectedValue, (int)cbxAlimentos.SelectedValue, DBNull.Value);
            }

            else
            {
                dtgrdvwLista.Rows.Add(cbxIdosos.Text, txtEnfermidades.Text, cbxAlimentos.Text, cbxRemedios.Text, dttmpckData_Criacao.Value.ToShortDateString(), dttmpckData_Uso.Value.ToShortDateString(), txtPrescricao_Observacoes.Text, (int)cbxIdosos.SelectedValue, (int)cbxAlimentos.SelectedValue, (int)cbxRemedios.SelectedValue);
            }
        }

        private void BtnExcluir_Lista_Click(object sender, EventArgs e)
        {
            if (dtgrdvwLista.Rows.Count < 1)
            {
                MessageBox.Show("Informe os dados para depois excluir da Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                indexRow = dtgrdvwLista.CurrentCell.RowIndex;
                dtgrdvwLista.Rows.RemoveAt(indexRow);
            }
        }

        private void BtnEditar_Lista_Click(object sender, EventArgs e)
        {
            if (rdbtnSim.Checked == true && cbxIdosos.Text != "" && txtEnfermidades.Text != "" && cbxAlimentos.Text != "" && cbxRemedios.Text != ""
                && txtPrescricao_Observacoes.Text != "" && dtgrdvwLista.Rows.Count < 1 ||
                rdbtnNao.Checked == true && cbxIdosos.Text != "" && cbxAlimentos.Text != "" && dtgrdvwLista.Rows.Count < 1 ||
                rdbtnSim.Checked == true && string.IsNullOrEmpty(cbxIdosos.Text) && txtEnfermidades.Text == "" && string.IsNullOrEmpty(cbxAlimentos.Text)
                && string.IsNullOrEmpty(cbxRemedios.Text) && txtPrescricao_Observacoes.Text == "" && dtgrdvwLista.Rows.Count < 1 ||
                rdbtnNao.Checked == true && string.IsNullOrEmpty(cbxIdosos.Text) && string.IsNullOrEmpty(cbxAlimentos.Text)
                && dtgrdvwLista.Rows.Count < 1)
            {
                MessageBox.Show("Adicione os dados na Lista para depois editar a Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (rdbtnSim.Checked == true && string.IsNullOrEmpty(cbxIdosos.Text) && dtgrdvwLista.Rows.Count < 1 ||
                     rdbtnNao.Checked == true && string.IsNullOrEmpty(cbxIdosos.Text) && dtgrdvwLista.Rows.Count < 1)
            {
                MessageBox.Show("O Nome do Idoso é obrigatório para editar a Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (rdbtnSim.Checked == true && txtEnfermidades.Text == "")
            {
                MessageBox.Show("Informe uma Enfermidade para editar a Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (rdbtnSim.Checked == true && string.IsNullOrEmpty(cbxAlimentos.Text) && dtgrdvwLista.Rows.Count < 1 ||
                     rdbtnNao.Checked == true && string.IsNullOrEmpty(cbxAlimentos.Text) && dtgrdvwLista.Rows.Count < 1)
            {
                MessageBox.Show("O Nome do Alimento é obrigatório para editar a Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (rdbtnSim.Checked == true && string.IsNullOrEmpty(cbxRemedios.Text) && dtgrdvwLista.Rows.Count < 1)
            {
                MessageBox.Show("Selecione um Remédio para editar a Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (rdbtnNao.Checked == true && cbxIdosos.Text != "" && cbxAlimentos.Text != "")
            {
                dtgrdvwLista.CurrentRow.Cells[0].Value = cbxIdosos.Text.ToString();
                dtgrdvwLista.CurrentRow.Cells[1].Value = DBNull.Value.ToString();
                dtgrdvwLista.CurrentRow.Cells[2].Value = cbxAlimentos.Text.ToString();
                dtgrdvwLista.CurrentRow.Cells[3].Value = DBNull.Value.ToString();
                dtgrdvwLista.CurrentRow.Cells[4].Value = dttmpckData_Criacao.Value.ToShortDateString();
                dtgrdvwLista.CurrentRow.Cells[5].Value = dttmpckData_Uso.Value.ToShortDateString();
                dtgrdvwLista.CurrentRow.Cells[6].Value = DBNull.Value.ToString();
                dtgrdvwLista.CurrentRow.Cells[7].Value = (int)cbxIdosos.SelectedValue;
                dtgrdvwLista.CurrentRow.Cells[8].Value = (int)cbxAlimentos.SelectedValue;
                dtgrdvwLista.CurrentRow.Cells[9].Value = DBNull.Value;
            }

            else
            {
                dtgrdvwLista.CurrentRow.Cells[0].Value = cbxIdosos.Text.ToString();
                dtgrdvwLista.CurrentRow.Cells[1].Value = txtEnfermidades.Text.ToString();
                dtgrdvwLista.CurrentRow.Cells[2].Value = cbxAlimentos.Text.ToString();
                dtgrdvwLista.CurrentRow.Cells[3].Value = cbxRemedios.Text.ToString();
                dtgrdvwLista.CurrentRow.Cells[4].Value = dttmpckData_Criacao.Value.ToShortDateString();
                dtgrdvwLista.CurrentRow.Cells[5].Value = dttmpckData_Uso.Value.ToShortDateString();
                dtgrdvwLista.CurrentRow.Cells[6].Value = txtPrescricao_Observacoes.Text.ToString();
                dtgrdvwLista.CurrentRow.Cells[7].Value = (int)cbxIdosos.SelectedValue;
                dtgrdvwLista.CurrentRow.Cells[8].Value = (int)cbxAlimentos.SelectedValue;
                dtgrdvwLista.CurrentRow.Cells[9].Value = (int)cbxRemedios.SelectedValue;
            }
        }

        private void RdbtnSim_CheckedChanged(object sender, EventArgs e)
        {
            txtEnfermidades.Enabled = true;
            txtEnfermidades.BackColor = Color.White;

            cbxRemedios.Enabled = true;
            cbxRemedios.BackColor = Color.White;

            txtPrescricao_Observacoes.Enabled = true;
            txtPrescricao_Observacoes.BackColor = Color.White;
        }

        private void RdbtnNao_CheckedChanged(object sender, EventArgs e)
        {
            txtEnfermidades.Enabled = false;
            txtEnfermidades.BackColor = ColorTranslator.FromHtml("#BCBCBC");

            cbxRemedios.Enabled = false;
            cbxRemedios.BackColor = ColorTranslator.FromHtml("#BCBCBC");

            txtPrescricao_Observacoes.Enabled = false;
            txtPrescricao_Observacoes.BackColor = ColorTranslator.FromHtml("#BCBCBC");
        }

        private void CbxIdosos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxIdosos.Text))
            {
                MessageBox.Show("Não existe nenhum Idoso registrado.\nRegistre um Idoso na Tela Registrar Idosos!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

            }
        }

        private void CbxAlimentos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxAlimentos.Text))
            {
                MessageBox.Show("Não existe nenhum Alimento registrado.\nRegistre um Alimento na Tela Registrar Alimentos!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

            }
        }

        private void CbxRemedios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbxRemedios.Text))
            {
                MessageBox.Show("Não existe nenhum Remédio registrado.\nRegistre um Remédio na Tela Registrar Remédios!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

            }
        }

        private void BtnPesquisar_Lista_Click(object sender, EventArgs e)
        {
            if (cbxIdosos.Text != "" && dtgrdvwLista.Rows.Count < 1 || string.IsNullOrEmpty(cbxIdosos.Text) && dtgrdvwLista.Rows.Count < 1)
            {
                MessageBox.Show("Adicione os dados na Lista para depois pesquisar na Lista!", "Dados Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            for (int i = 0; i < dtgrdvwLista.SelectedRows.Count; i++) ;

            foreach (DataGridViewRow row in dtgrdvwLista.Rows)
            {
                if ((string)row.Cells[0].Value == cbxIdosos.Text)
                {
                    row.Selected = true;
                }

                else if ((string)row.Cells[0].Value == cbxIdosos.Text && dtgrdvwLista.SelectedRows.Count > 1)
                {
                    row.Selected = false;
                    row.Selected = true;
                }

                else
                {
                    row.Selected = false;
                }
            }
        }

        private void dtgrdvwLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            if (dtgrdvwLista.CurrentCell.ColumnIndex.Equals(3))
            {
                if (dtgrdvwLista.CurrentCell != null && dtgrdvwLista.CurrentCell.Value != null)
                {
                    indexRow = e.RowIndex;
                    DataGridViewRow row = dtgrdvwLista.Rows[indexRow];

                    cbxIdosos.Text = row.Cells[0].Value.ToString();
                    txtEnfermidades.Text = row.Cells[1].Value.ToString();
                    cbxAlimentos.Text = row.Cells[2].Value.ToString();
                    cbxRemedios.Text = row.Cells[3].Value.ToString();
                    dttmpckData_Criacao.Text = row.Cells[4].Value.ToString();
                    dttmpckData_Uso.Text = row.Cells[5].Value.ToString();
                    txtPrescricao_Observacoes.Text = row.Cells[6].Value.ToString();
                    cbxIdosos.SelectedValue = row.Cells[7].Value.ToString();
                    cbxAlimentos.SelectedValue = row.Cells[8].Value.ToString();
                    cbxRemedios.SelectedValue = row.Cells[9].Value.ToString();
                }
            }
        }

        private void RegistrarProntuario_Load(object sender, EventArgs e)
        {
            ProntuarioDAL obj = new ProntuarioDAL();
            cbxIdosos.DataSource = obj.ListaDeIdosos;
            cbxAlimentos.DataSource = obj.ListaDeAlimentos;
            cbxRemedios.DataSource = obj.ListaDeRemedios;
        }
    }
}