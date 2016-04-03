using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_InfoMotorista : Form
    {
        public Frm_InfoMotorista()
        {
            InitializeComponent();
        }

        private void Frm_InfoMotorista_Load(object sender, EventArgs e)
        {
            if (File.Exists("Motorista.png"))
            {
                Pic_Motorista.ImageLocation = "Motorista.png";
            }

            CarregarInformacoes();
        }

        private void Btm_LocalizarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All files (*.*)|*.*|*.jpg|*.jpg|*.bmp|*.bmp|*.gif|*.gif|*.png|*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists("Motorista.png"))
                {
                    Pic_Motorista.Image = null;
                    File.Delete("Motorista.png");
                }

                File.Move(openFileDialog1.FileName, "Motorista.png");

                Pic_Motorista.ImageLocation = "Motorista.png";
            }
        }

        private void Btm_SalvarInfo_Click(object sender, EventArgs e)
        {
            SalvarInformacoes();
        }

        private void SalvarInformacoes()
        {
            ControleDB BancoDeDados = new ControleDB();

            try
            {
                BancoDeDados.Conexao.Open();
                BancoDeDados.Conexao.Execute("DELET * FROM Motorista");
                BancoDeDados.Conexao.Execute($"Insert into Motorista(NomeCompleto, IdMotorista, Empresa) Values('{Txt_Nome.Text}','{Txt_Codigo.Text}','{Txt_Empresa.Text}')");

                MessageBox.Show($"Olá {Txt_Nome.Text}, as informações foram atualizadas com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ocorreu um erro {exc.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BancoDeDados.Conexao.Close();
        }

        private void CarregarInformacoes()
        {
            ControleDB BancoDeDados = new ControleDB();

            try
            {
                BancoDeDados.Conexao.Open();
                DataTable Resultado = BancoDeDados.Conexao.Query("select * from Motorista", "Motorista");

                foreach (DataRow r in Resultado.Rows)
                {
                    foreach (DataColumn c in Resultado.Columns)
                        Txt_Codigo.Text = c.ToString();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show($"Ocorreu um erro {exc.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            BancoDeDados.Conexao.Open();
        }
    }
}
