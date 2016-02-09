using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Ets2SdkClient;

namespace NextteamBr
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
        }

        //Refazer esse código quando estiver pronto
        private void timer1_Tick(object sender, EventArgs e)
        {
            ControllerTelemetry.GerarInformacoes();

            RootObject informacoesGame = ControllerTelemetry.ConvertJSON();

            Lbl_CidadeInicial.Text = informacoesGame.job.sourceCity;
            Lbl_CidadeDestino.Text = informacoesGame.job.destinationCity;
            Lbl_EmpresaInicial.Text = informacoesGame.job.sourceCompany;
            Lbl_EmpresaDestino.Text = informacoesGame.job.destinationCompany;

            Lbl_Cambio.Text = Convert.ToInt16(informacoesGame.truck.gear).ToString();
            Lbl_KMH.Text = Convert.ToInt16(informacoesGame.truck.speed).ToString();
            Lbl_KMRegistrado.Text = informacoesGame.truck.odometer.ToString("0.0");
            Lbl_RPM.Text = informacoesGame.truck.engineRpm.ToString("0.0");





            Ferramentas.VerificarDistancia(informacoesGame.navigation.estimatedDistance);
        }

        private void Btm_FreteCancelado_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Btm_IniciarViagem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            timer1.Start();
        }
    }
}
