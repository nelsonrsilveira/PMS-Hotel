using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HM.ControleUsuarios
{
    public partial class CU_AddQuarto : UserControl
    {
        BD bd = new BD();
        String query;

        private static CU_AddQuarto _instance;
        public static CU_AddQuarto Instance
        {
            get
            {
                if(_instance == null)
                    _instance = new CU_AddQuarto();
                    return _instance;
            }
        }

        public CU_AddQuarto()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CU_AddQuarto_Load(object sender, EventArgs e)
        {
            query = "select * from quartos";
            DataSet ds = bd.GetData(query);
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void btnAdicionarQuarto_Click(object sender, EventArgs e)
        {
            if(txtNumeroQuarto.Text != "" && txtTipoQuarto.Text != "" && txtTipoCama.Text != "" && txtPreco.Text != "")
            {
                String numeroquarto = txtNumeroQuarto.Text;
                String tipoquarto = txtTipoQuarto.Text;
                String tipocama = txtTipoCama.Text;
                Int64 preco = Int64.Parse(txtPreco.Text);

                query = "insert into quartos (numeroquarto, tipoquarto, tipocama, preco) values ('" + numeroquarto + "', '" + tipoquarto + "', '" + tipocama + "', '" +preco+"')";
                bd.setData(query, "Quarto Adicionado.");

                CU_AddQuarto_Load(this, null);
                Limpar();
            }
            else
            {
                MessageBox.Show("Preencha todos os Campos.", "Perigo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        public void Limpar()
        {
            txtNumeroQuarto.Clear();
            txtTipoQuarto.SelectedIndex = -1;
            txtTipoCama.SelectedIndex = -1;
            txtPreco.Clear();

        }
        private void CU_AddQuarto_Leave(object sender, EventArgs e)
        {
            Limpar();
        }

        private void CU_AddQuarto_Enter(object sender, EventArgs e)
        {
            CU_AddQuarto_Load(this, null);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
