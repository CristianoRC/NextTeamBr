using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace NextteamBr
{
    public partial class Frm_Principal : Form
    {
        bool inicioViajem = false;
        bool cargaIntregue = false;
        bool verificarDistanciaLocalDeEntrega = true;
        bool som5KMExecutado = false;
        bool executarAudio = true;
        Frete informacoesFrete = new Frete();
        RootObject informacoesGame;

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            IniciarServidor();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            informacoesGame = ControllerTelemetry.ConvertJSON();

            Lbl_CidadeInicial.Text = informacoesGame.job.sourceCity;
            Lbl_CidadeDestino.Text = informacoesGame.job.destinationCity;
            Lbl_EmpresaInicial.Text = informacoesGame.job.sourceCompany;
            Lbl_EmpresaDestino.Text = informacoesGame.job.destinationCompany;

            Lbl_Cambio.Text = Convert.ToInt16(informacoesGame.truck.gear).ToString();
            Lbl_KMH.Text = Convert.ToInt16(informacoesGame.truck.speed).ToString();
            Lbl_KMRegistrado.Text = informacoesGame.truck.odometer.ToString("0.0");
            Lbl_RPM.Text = informacoesGame.truck.engineRpm.ToString("0.0");

            VerificarCargaConectada();
            VerificarCargaEntregue();
            VerificarDanoDaCarga();
            VerificarDistanciaEntrega();

        }

        private void Btm_FreteCancelado_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ferramentas.ZerarInformacoes(); //Fecha o servidor(API)
        }

        private void Btm_Iniciar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            timer1.Start();

            Btm_FreteCancelado.Enabled = true;
            Btm_Iniciar.Enabled = false;
        }


        private void VerificarDanoDaCarga()
        {
            if (informacoesGame.trailer.wear > informacoesFrete.Dano)
            {
                informacoesFrete.Dano = informacoesGame.trailer.wear;

                if (executarAudio)
                {
                    ControllerAudio.ExecutarAudio("Dano");
                }
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

                    if (executarAudio)
                    {
                        ControllerAudio.ExecutarAudio("Conectada");
                    }

                    Btm_FreteCancelado.Enabled = true;

                    informacoesFrete.DistanciaInicial = informacoesGame.truck.odometer;
                    informacoesFrete.Dano = informacoesGame.trailer.wear;
                }
            }
        }

        private void VerificarDistanciaEntrega()
        {
            //Ele fica verificando a distancia de entrega até chegar aos 5KM faltando.
            if (verificarDistanciaLocalDeEntrega)
            {
                if (som5KMExecutado == false)
                {
                    if (informacoesGame.navigation.estimatedDistance <= 5000 && informacoesGame.navigation.estimatedDistance >= 2000) //2000 esta apenas usado para viajens pequenas.
                    {
                        verificarDistanciaLocalDeEntrega = false;

                        if (executarAudio)
                        {
                            ControllerAudio.ExecutarAudio("Distancia");
                        }

                        som5KMExecutado = true;
                    }
                }
            }
        }

        private void VerificarCargaEntregue()
        {
            //Se ele estiver mais perto do que 3 km da empresa ele verifica se esta a menos de 100 m para dar o aviso de carga finalizada

            if (cargaIntregue == false)
            {
                if (informacoesGame.navigation.estimatedDistance <= 90 && informacoesGame.navigation.estimatedDistance >= 10)
                {
                    if (executarAudio)
                    {
                        ControllerAudio.ExecutarAudio("Entregue");
                    }


                    cargaIntregue = true;

                    informacoesFrete.DistanciaFinal = informacoesGame.truck.odometer;

                    informacoesFrete.KmRodado = informacoesFrete.DistanciaFinal - informacoesFrete.DistanciaInicial;

                    informacoesFrete.DataFinalFrete = DateTime.Now;

                    ControllerFrete.SalvarFrete(informacoesFrete);


                    Thread.Sleep(12000); //Fazedo a aplicação parar por 6 segundos ates de reiniciar para que o audio de carga finalizada seja executado.

                    Application.Restart();
                }
            }
        }

        private void IniciarServidor()
        {
            Process processo = new Process();

            processo.StartInfo.FileName = @"server\Ets2Telemetry.exe";
            processo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processo.Start();

            Thread.Sleep(3000);
        }

        private void pictureSom_Click(object sender, EventArgs e)
        {
            if (executarAudio)
            {
                executarAudio = false;

                pictureSom.Image = NextteamBr.Properties.Resources.Mute_50;
            }
            else
            {
                executarAudio = true;

                pictureSom.Image = NextteamBr.Properties.Resources.Medium_Volume_50;
            }
        }
    }
}
