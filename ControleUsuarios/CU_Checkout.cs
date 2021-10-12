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
    public partial class CU_Checkout : UserControl
    {

        BD bd = new BD();
        String query;


        public CU_Checkout()
        {
            InitializeComponent();
        }

        private static CU_Checkout _instance;
        public static CU_Checkout Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CU_Checkout();
                return _instance;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            query = "select * from quartos";
            DataSet ds = bd.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
