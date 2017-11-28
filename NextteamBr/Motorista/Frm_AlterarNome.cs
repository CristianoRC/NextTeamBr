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
    public partial class Frm_AlterarNome : Form
    {
        int IDUsuario;
        public Frm_AlterarNome(int id)
        {
            InitializeComponent();
            IDUsuario = id;
        }

        private void Btm_Alterar_Click(object sender, EventArgs e)
        {
            MotoristaService.AletrarNome(IDUsuario, txt_Nome.Text);

            MessageBox.Show("Nome alterado com suceso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Dispose();
        }
    }
}
