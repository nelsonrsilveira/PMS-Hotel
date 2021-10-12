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
    public partial class CU_DetalhesHospede : UserControl
    {
        private static CU_DetalhesHospede _instance;
        public static CU_DetalhesHospede Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CU_DetalhesHospede();
                return _instance;
            }
        }

        public CU_DetalhesHospede()
        {
            InitializeComponent();
        }

        private void CU_DetalhesHospede_Load(object sender, EventArgs e)
        {

        }
    }
}
