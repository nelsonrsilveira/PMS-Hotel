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
            if (CU_AddQuarto1.Controls.Contains(CU_AddQuarto.Instance))             //INSTANCIEI A TELA ADICIONAR QUARTO
            {
                CU_AddQuarto1.Controls.Add(CU_AddQuarto.Instance);
                CU_AddQuarto.Instance.Dock = DockStyle.Fill;
                CU_AddQuarto.Instance.BringToFront();
            }
            else { 
                CU_AddQuarto.Instance.BringToFront();
                CU_AddQuarto1.Visible = true;
                CU_AddQuarto1.BringToFront();
            }
            PainelSeletor.Left = btnAdicionarQuarto.Left;           //PAINEL QUE ACOMPANHA CADA BOTÃO SELECIONADO
        }


        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;               //BOTÃO "MINIMIZAR"
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();                                             //BOTÃO "EXCLUIR"
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            

            if (cU_Registro2.Controls.Contains(CU_Registro.Instance))           //INSTANCIEI A TELA REGISTRO
            {
                cU_Registro2.Controls.Add(CU_Registro.Instance);
                CU_Registro.Instance.Dock = DockStyle.Fill;
                CU_Registro.Instance.BringToFront();
            }
            else { 
                CU_Registro.Instance.BringToFront();
                cU_Registro2.Visible = true;
                cU_Registro2.BringToFront();
            }

            PainelSeletor.Left = btnRegistro.Left;              //PAINEL QUE ACOMPANHA CADA BOTÃO SELECIONADO
            
        }


        private void btnCheckOut_Click(object sender, EventArgs e)                      
        {
            if (CU_Checkout1.Controls.Contains(CU_Checkout.Instance))           //INSTANCIEI A TELA CHECKOUT
       {
                CU_Checkout1.Controls.Add(CU_Checkout.Instance);
                CU_Checkout.Instance.Dock = DockStyle.Fill;
                CU_Checkout.Instance.BringToFront();
            }
            else
            {
                CU_Checkout.Instance.BringToFront();
                CU_Checkout1.Visible = true;
                CU_Checkout1.BringToFront();
            }

            PainelSeletor.Left = btnCheckOut.Left;                          //PAINEL QUE ACOMPANHA CADA BOTÃO SELECIONADO
            
        }

        private void btnDetalhesHospede_Click(object sender, EventArgs e)
        {
            if (CU_DetalhesHospede2.Controls.Contains(CU_DetalhesHospede.Instance))                 //INSTANCIEI A TELA DETALHES HÓSPEDE
            {
                CU_DetalhesHospede2.Controls.Add(CU_DetalhesHospede.Instance);
                CU_DetalhesHospede.Instance.Dock = DockStyle.Fill;
                CU_DetalhesHospede.Instance.BringToFront();
            }
            else
            {
                CU_DetalhesHospede.Instance.BringToFront();
                CU_DetalhesHospede2.Visible = true;
                CU_DetalhesHospede2.BringToFront();
            }

            PainelSeletor.Left = btnDetalhesHospede.Left;               //PAINEL QUE ACOMPANHA CADA BOTÃO SELECIONADO
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            if (CU_Funcionario1.Controls.Contains(CU_Funcionario.Instance))         //INSTANCIEI A TELA FUNCIONARIO
            {
                CU_Funcionario1.Controls.Add(CU_Funcionario.Instance);
                CU_Funcionario.Instance.Dock = DockStyle.Fill;
                CU_Funcionario.Instance.BringToFront();
            }
            else
            {
                CU_Funcionario.Instance.BringToFront();
                CU_Funcionario1.Visible = true;
                CU_Funcionario1.BringToFront();
            }

            PainelSeletor.Left = btnFuncionario.Left;                   //PAINEL QUE ACOMPANHA CADA BOTÃO SELECIONADO
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cU_AddQuarto3.Visible = false;
            btnAdicionarQuarto.PerformClick();
            CU_Registro.Instance.Visible = false; //cU_AddQuarto3
        }

        private void CU_AddQuarto1_Load(object sender, EventArgs e)
        {

        }

        private void CU_Registro1_Load(object sender, EventArgs e)
        {

        }

        private void cU_AddQuarto3_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            PainelSeletor.Left = btnCancelar.Left;
            PainelSeletor.Left = btnCancelar.Left;

            if (CU_Cancelar1.Controls.Contains(CU_DetalhesHospede.Instance))                 //INSTANCIEI A TELA CANCELAR HOSPEDE
            {
                CU_Cancelar1.Controls.Add(CU_DetalhesHospede.Instance);
                CU_Cancelar.Instance.Dock = DockStyle.Fill;
                CU_Cancelar.Instance.BringToFront();
            }
            else
            {
                CU_Cancelar.Instance.BringToFront();
                CU_Cancelar1.Visible = true;
                CU_Cancelar1.BringToFront();
            }
            
        }

        private void PainelSeletor_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
