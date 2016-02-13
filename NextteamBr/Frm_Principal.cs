using System;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace NextteamBr
{
    public partial class Frm_Principal : Form
    {
        bool inicioViajem = false;
        bool CargaIntregue = false;
        bool VerificarDistanciaLocalDeEntrega = true;
        bool Som3KMExecutado = false;
        Frete InformacoesFrete = new Frete();
        RootObject informacoesGame = ControllerTelemetry.ConvertJSON();


        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {

            Btm_FreteCancelado.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_CidadeInicial.Text = informacoesGame.job.sourceCity;
            Lbl_CidadeDestino.Text = informacoesGame.job.destinationCity;
            Lbl_EmpresaInicial.Text = informacoesGame.job.sourceCompany;
            Lbl_EmpresaDestino.Text = informacoesGame.job.destinationCompany;

            Lbl_Cambio.Text = Convert.ToInt16(informacoesGame.truck.gear).ToString();
            Lbl_KMH.Text = Convert.ToInt16(informacoesGame.truck.speed).ToString();
            Lbl_KMRegistrado.Text = informacoesGame.truck.odometer.ToString("0.0");
            Lbl_RPM.Text = informacoesGame.truck.engineRpm.ToString("0.0");


            VerificarDanoDaCarga();
            VerificarCargaConectada();
            VerificarDistanciaEntrega();
            VerificarCargaEntregue();

        }

        private void Btm_FreteCancelado_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ferramentas.ZerarInformacoes(); //Fecha o servidor(API)
        }

        private void Btm_IniciarViagem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            timer1.Start();

            Btm_IniciarViagem.Enabled = false;
            Btm_FreteCancelado.Enabled = true;

            Process processo = new Process();

            processo.StartInfo.FileName = @"server\Ets2Telemetry.exe";
            processo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processo.Start();
        }



        private void VerificarDanoDaCarga()
        {
            if (informacoesGame.trailer.wear > InformacoesFrete.Dano)
            {
                InformacoesFrete.Dano = informacoesGame.trailer.wear;

                SoundPlayer Dano = new SoundPlayer(Properties.Resources.Colisao);
                Dano.Play();
            }
            else
            {
                InformacoesFrete.Dano = informacoesGame.trailer.wear;
            }
        }

        private void VerificarCargaConectada()
        {
            //Verificando se carga esta conectada e se estiver desabilita essa estrutura de controle.

            if (inicioViajem == false)
            {
                if (informacoesGame.trailer.attached == true)
                {
                    inicioViajem = true;

                    SoundPlayer Inicio = new SoundPlayer(Properties.Resources.CarregadoComSucesso);
                    Inicio.Play();

                    Btm_FreteCancelado.Enabled = true;

                    InformacoesFrete.DistanciaInicial = informacoesGame.truck.odometer;
                    InformacoesFrete.Dano = informacoesGame.trailer.wear;
                }
            }
        }

        private void VerificarDistanciaEntrega()
        {
            //Ele fica verificando a distancia de entrega até chegar aos 5KM faltando.
            if (VerificarDistanciaLocalDeEntrega)
            {
                if (Som3KMExecutado == false)
                {
                    if (informacoesGame.navigation.estimatedDistance <= 5000 && informacoesGame.navigation.estimatedDistance >= 2000) //2000 esta apenas usado para viajens pequenas.
                    {
                        VerificarDistanciaLocalDeEntrega = false;

                        SoundPlayer Entregue = new SoundPlayer(Properties.Resources.EstaProximo);
                        Entregue.Play();

                        Som3KMExecutado = true;
                    }
                }
            }
        }

        private void VerificarCargaEntregue()
        {
            //Se ele estiver mais perto do que 3 km da empresa ele verifica se esta a menos de 100 m para dar o aviso de carga finalizada

            if (VerificarDistanciaLocalDeEntrega == false)//Passa se estiver abaixo dos 3 km
            {

                if (CargaIntregue == false)
                {
                    if (informacoesGame.navigation.estimatedDistance <= 90 && informacoesGame.navigation.estimatedDistance >= 10)
                    {
                        SoundPlayer Entregue = new SoundPlayer(Properties.Resources.CargaEntregue);
                        Entregue.Play();

                        CargaIntregue = true;

                        InformacoesFrete.DistanciaFinal = informacoesGame.truck.odometer;
                    }
                }
            }
        }
    }
}
