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
    }
}
