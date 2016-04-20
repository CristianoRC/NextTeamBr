using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_Config : Form
    {
        public Frm_Config()
        {
            InitializeComponent();
        }

        private void radioSemLimites_CheckedChanged(object sender, EventArgs e)
        {
            ControleVelocidade.SalvarVelocidade("0");
        }

        private void radioNoventa_CheckedChanged(object sender, EventArgs e)
        {
            ControleVelocidade.SalvarVelocidade("90");
        }

        private void radioCem_CheckedChanged(object sender, EventArgs e)
        {
            ControleVelocidade.SalvarVelocidade("100");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            ControleVelocidade.SalvarVelocidade("110");
        }
    }
}
