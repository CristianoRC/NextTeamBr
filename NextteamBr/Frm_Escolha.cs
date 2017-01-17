using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_Escolha : Form
    {
        int IdUsuario;
        public Frm_Escolha(int p_id)
        {
            InitializeComponent();

            IdUsuario = p_id;
        }

        private void Btm_LogBook_Click(object sender, EventArgs e)
        {
            Frm_Principal frm_Principal = new Frm_Principal(IdUsuario);
            this.Visible = false;
            frm_Principal.ShowDialog();
            this.Dispose();
        }
    }
}
