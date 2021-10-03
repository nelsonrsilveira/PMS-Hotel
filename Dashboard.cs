using HM.ControleUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CU_AddQuarto1.Controls.Contains(CU_AddQuarto.Instance))
            {
                CU_AddQuarto1.Controls.Add(CU_AddQuarto.Instance);
                CU_AddQuarto.Instance.Dock = DockStyle.Fill;
                CU_AddQuarto.Instance.BringToFront();
            }
            else
                CU_AddQuarto.Instance.BringToFront();
            CU_AddQuarto1.Visible = true;
            CU_AddQuarto1.BringToFront();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            PainelSeletor.Left = btnRegistro.Left;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            PainelSeletor.Left = btnCheckOut.Left;
        }

        private void btnDetalhesHospede_Click(object sender, EventArgs e)
        {
            PainelSeletor.Left = btnDetalhesHospede.Left;
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            PainelSeletor.Left = btnFuncionario.Left;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            CU_AddQuarto1.Visible = false;
        }
    }
}
