using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace SincronizadorDeCargas
{
    public partial class Frm_Sincronizador : Form
    {
        public Frm_Sincronizador()
        {
            InitializeComponent();
        }

        private void Frm_Sincronizador_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Sincronizador_Load(object sender, EventArgs e)
        {
        }

        private void Btm_Sincronizar_Click(object sender, EventArgs e)
        {
            try
            {
                ControleArquivoGameSII.SalvarArquivoAtualizado();

                Lbl_Informacao.ForeColor = Color.Green;
                Lbl_Informacao.Text = "Sua frete foi sincronizado " + DateTime.Now;
            }
            catch (Exception ex)
            {
                Lbl_Informacao.Text = String.Empty;

                MessageBox.Show(@"Ocorreu um erro ao tentar sincronizar seu frete, verifique sua conexão." +
                                 "\nSe o problema persistir entre em contato com a administração\n Erro:" + ex.Message,
                                 "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
