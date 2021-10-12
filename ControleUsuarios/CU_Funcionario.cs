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
    public partial class CU_Funcionario : UserControl
    {
        private static CU_Funcionario _instance;
        public static CU_Funcionario Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CU_Funcionario();
                return _instance;
            }
        }

        public CU_Funcionario()
        {
            InitializeComponent();
        }

        private void CU_Funcionario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
