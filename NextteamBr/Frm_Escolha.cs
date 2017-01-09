using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SincronizadorDeCargas;

namespace NextteamBr
{
    public partial class Frm_Escolha : Form
    {

        private int IDUsuaro;

        public Frm_Escolha(int p_IDusuario)
        {
            InitializeComponent();

            IDUsuaro = p_IDusuario;
        }

        private void ChamarFormularioLogBook(int resultado)
        {
            Frm_Principal frm_LogBook = new Frm_Principal(resultado);
            this.Visible = false;
            frm_LogBook.ShowDialog();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChamarFormularioLogBook(IDUsuaro);
        }

        private void Btm_JobSync_Click(object sender, EventArgs e)
        {
            Frm_Sincronizador frm_sinc = new Frm_Sincronizador();
            this.Visible = false;
            frm_sinc.ShowDialog();
            this.Dispose();
        }
    }
}
