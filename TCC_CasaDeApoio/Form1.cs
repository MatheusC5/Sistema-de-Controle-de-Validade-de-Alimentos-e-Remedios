using System;
using System.Drawing;
using System.Windows.Forms;

namespace TCC_CasaDeApoio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblCarregando.Parent = pictureBox1;
            lblCarregando.BackColor = Color.Transparent;

            lblPorcentagem.Parent = pictureBox1;
            lblPorcentagem.BackColor = Color.Transparent;
        }

        int i = 0;

        private void tmrTempoLoad_Tick(object sender, EventArgs e)
        {
            lblPorcentagem.Text = i + "" + "%" + " Concluído";
            i = i = i + 2;

            if (prgsProgresso.Value < 102)
            {
                prgsProgresso.Value = prgsProgresso.Value + 2;
            }
            else if (prgsProgresso.Value == 102)
            {
                this.Hide();

                tmrTempoLoad.Enabled = false;

                Login login = new Login();

                login.ShowDialog();

                var logar = Application.OpenForms["login"];

                if (logar == null)
                {
                    this.Close();
                }
            }
        }
    }
}
