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
using System.Data.SQLite;

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
        }  
    }
}
