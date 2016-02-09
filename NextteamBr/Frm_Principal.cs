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

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            Btm_IniciarViagem.Enabled = true;
            Btm_FreteCancelado.Enabled = false;
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


            //TODO:Transformar todos os ifs em métodos.

           
            //Verificando se carga esta conectada e se estiver desabilita essa estrutura de controle.

            if (inicioViajem == false)
            {
                if (informacoesGame.trailer.attached == true)
                {
                    inicioViajem = true;

                    SoundPlayer Inicio = new SoundPlayer(Properties.Resources.CarregadoComSucesso);
                    Inicio.Play();
                }
            }
           
            //Ele fica verificando a distancia de entrega até chegar aos 3KM faltando.
            if (VerificarDistanciaLocalDeEntrega)
            {
                if (Ferramentas.VerificarDistanciaEntrega(informacoesGame.navigation.estimatedDistance))
                {
                    VerificarDistanciaLocalDeEntrega = false;
                }
            }


            //Se ele estiver mais perto do que 3 km da empresa ele verifica se esta a menos de 100 m para dar o aviso de carga finalizada
            if(VerificarDistanciaLocalDeEntrega == false)
            {
                if (Ferramentas.EntrouNaEmpresa(informacoesGame.navigation.estimatedDistance))
                {
                    CargaIntregue = true;

                    SoundPlayer Entregue = new SoundPlayer(Properties.Resources.CargaEntregue);
                    Entregue.Play();

                    //TODO:Código para salvar informações no arquivo final aqui.
                }
            }

            if (CargaIntregue)
            {
                Application.Restart();
            }
        }

        private void Btm_FreteCancelado_Click(object sender, EventArgs e)
        {
            Ferramentas.ZerarInformacoes();
            Application.Restart();
        }

        private void Btm_IniciarViagem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            timer1.Start();

            Btm_IniciarViagem.Enabled = false;
            Btm_FreteCancelado.Enabled = true;

            Process.Start(@"server\Ets2Telemetry.exe");
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ferramentas.ZerarInformacoes();
        }
    }
}
