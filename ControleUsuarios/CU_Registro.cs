using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HM.ControleUsuarios
{
    public partial class CU_Registro : UserControl
    {
        BD bd = new BD();
        String query;

        public CU_Registro()
        {
            InitializeComponent();
        }

        private void CU_Registro_Load(object sender, EventArgs e)
        {

        }
            private static CU_Registro _instance;
            public static CU_Registro Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CU_Registro();
                return _instance;
            }
        }
        
        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void setComboBox(String query, ComboBox combo)
        {
            MySqlDataReader sdr = bd.getForCombo(query);
            while (sdr.Read())
            {
                for(int i=0;i<sdr.FieldCount;i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
                sdr.Close();
            }
        }

        

        private void txtNumeroQuarto_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select numeroquarto from quartos where tipocama = '" + txtCama.Text +"' and tipoquarto = '" + txtTipoQuarto.Text;
            setComboBox(query, txtNumeroQuarto);
        }

        private void txtCama_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTipoQuarto.SelectedIndex = -1;
            txtNumeroQuarto.Items.Clear();
        }

        private void txtNumeroQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select preco, idquarto from quartos where numeroquarto = '" + txtNumeroQuarto.Text + "'";
            DataSet ds = bd.GetData(query);
            txtPreco.Text = ds.Tables[0].Rows[0][0].ToString();
        }
    }
    }

