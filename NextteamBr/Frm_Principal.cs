using System;
using System.Windows.Forms;
using Ets2SdkClient;
using System.Threading;
using System.IO;

namespace NextteamBr
{
    public partial class Frm_Principal : Form
    {
        //Variáveis de controle
        bool executarAudio = true;
        bool cargaEntregue = false;
        bool ObterInformacoesIniciais = false;
        bool PlanoDeFundo = false;

        String IDCarreta = String.Empty;
        String IDCarretaInicio = String.Empty;

        int ControleVelocidade = 0;
        int IDMotorista;
        float VelocidadeAtual = 0;
        double v_OdometroInical;

        Frete informacoesFrete = new Frete();
        ControleDeMultas controleDeMultas = new ControleDeMultas();

        public Ets2SdkTelemetry Telemetry;

        public Frm_Principal(int p_IDmotorista)
        {
            InitializeComponent();

            IDMotorista = p_IDmotorista;

            Telemetry = new Ets2SdkTelemetry();
            Telemetry.Data += Telemetry_Data;

            //Telemetry.JobFinished += TelemetryOnJobFinished;
            Telemetry.JobStarted += TelemetryOnJobStarted;

            if (Telemetry.Error != null)
            {
                MessageBox.Show(
                    "General info:\r\nFailed to open memory map " + Telemetry.Map +
                    " - on some systems you need to run the client (this app) " +
                    "with elevated permissions, because e.g. you're running Steam/ETS2 with elevated permissions as well. .NET reported the following Exception:\r\n" +
                    Telemetry.Error.Message + "\r\n\r\nStacktrace:\r\n" + Telemetry.Error.StackTrace);
            }
        }

        #region Infomações Telemetria

        private void TelemetryOnJobStarted(object sender, EventArgs e)
        {
            IniciarFrete();
        }

        private void Telemetry_Data(Ets2Telemetry data, bool updated)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new TelemetryData(Telemetry_Data), new object[2] { data, updated });
                    return;
                }

                VelocidadeAtual = data.Drivetrain.SpeedKmh;
                IDCarreta = data.Job.TrailerId;

                //Informações Iniciais
                if (ObterInformacoesIniciais)
                {
                    v_OdometroInical = data.Drivetrain.TruckOdometer;
                    informacoesFrete.CidadeInicial = data.Job.CitySource.ToString();
                    informacoesFrete.CidadeDestino = data.Job.CityDestination.ToString();
                    informacoesFrete.Carga = String.Format("{0} {1}t", data.Job.TrailerName.ToString(), (data.Job.Mass / 1000).ToString());
                    ObterInformacoesIniciais = false;
                    timerTs3.Enabled = true;
                    IDCarretaInicio = data.Job.TrailerId;

                    Lbl_Destino.Text = data.Job.CityDestination;
                    Lbl_Partida.Text = data.Job.CitySource;
                    Lbl_InfoCarga.Text = informacoesFrete.Carga;

                    SetarIconeDasEmpresas(data.Job.CompanySource, data.Job.CompanyDestination);
                }

                //Informações Finais
                if (data.Job.TrailerAttached && (cargaEntregue == false) && data.Job.NavigationDistanceLeft < 80 && data.Job.NavigationDistanceLeft >= 10)
                {
                    informacoesFrete.KmRodado = data.Drivetrain.TruckOdometer - v_OdometroInical;
                    informacoesFrete.IdMotorista = IDMotorista;
                    informacoesFrete.Pontuacao = Ferramentas.CalcularPontuacao(informacoesFrete.KmRodado, Convert.ToDouble(data.Damage.WearTrailer), controleDeMultas.ObterNumeroDeMultas());
                    informacoesFrete.Dano = data.Damage.WearTrailer * 100;
                    informacoesFrete.Pontuacao = Math.Round(informacoesFrete.Pontuacao, 1);
                    informacoesFrete.DataFinalFrete = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    informacoesFrete.ListaDeMultas = controleDeMultas.ObterListaDeMultas();

                    cargaEntregue = true;
                    FinaliziarFrete();

                    Lbl_Destino.Text = String.Empty;
                    Lbl_Partida.Text = String.Empty;
                    Lbl_InfoCarga.Text = String.Empty;
                }


                //Controle imagem do caminhao carregado ou descarregado
                if (data.Job.TrailerAttached)
                {
                    Lbl_InfoCarga.Visible = true;
                    PicCarga.Image = Properties.Resources.Carregado;
                }
                else
                {
                    Lbl_InfoCarga.Visible = false;
                    PicCarga.Image = Properties.Resources.Descarregado;
                }

                Lbl_InfoGame.Text = String.Format("Velocidade {0} km/h  Distância {1} km",
                    VelocidadeAtual.ToString("0"), (data.Job.NavigationDistanceLeft / 1000).ToString("0"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Erro: {0}", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void FinaliziarFrete()
        {
            if (cargaEntregue)
            {
                if (ControllerFrete.SalvarFrete(informacoesFrete))
                {
                    if (executarAudio)
                    {
                        ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Entregue);
                    }

                    Thread.Sleep(2000);
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar salvar sua carga!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            timerTs3.Enabled = true;
            VelocidadeAtual = 0;
            IDCarreta = String.Empty;
            cargaEntregue = true;
            Pic_EmpresaDestino.Image = null;
            Pic_EmrpesaPartida.Image = null;
        }

        private void IniciarFrete()
        {
            //Verifica se é a mesma carga ou se não há cargas.
            if (IDCarreta == String.Empty || IDCarreta != IDCarretaInicio)
            {
                if (Ferramentas.VerificarETS2MP() == false)
                {
                    ControllerAudio.ExecutarAudio(ControllerAudio.Audios.MP);
                    Thread.Sleep(12000);
                    Application.Exit();
                }
                else
                {
                    if (executarAudio)
                    {
                        ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Conectada);
                    }
                    controleDeMultas.LimparListaDeMultas();
                    ObterInformacoesIniciais = true;
                    cargaEntregue = false;
                }
            }
        }

        private void Multar()
        {
            int VelocidadeTemp = 0;
            Multa multaBase = new Multa();

            VelocidadeTemp = Convert.ToInt32(Math.Round(VelocidadeAtual, 1));

            if (VelocidadeTemp < 100)
            {
                VelocidadeTemp = 103;
            }

            multaBase.IDMotorista = IDMotorista;
            multaBase.DataDaMulta = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            multaBase.Velocidade = VelocidadeTemp;
            controleDeMultas.AdicionarNovaMulta(multaBase);

            Thread.Sleep(1000);

            ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Velocidade);

            Thread.Sleep(1000);

            TimerAvisoSonoro.Enabled = true;
        }

        private void SetarIconeDasEmpresas(string p_EmpresaPartida, string p_EmpresaDestino)
        {
            String CaminhoDasImagens = String.Format(@"{0}\Empresas", Application.StartupPath);
            String CaminhoImgPartida = String.Format(@"{0}\{1}.png", CaminhoDasImagens, p_EmpresaPartida.Trim().ToLower());
            String CaminhoImgDestino = String.Format(@"{0}\{1}.png", CaminhoDasImagens, p_EmpresaDestino.Trim().ToLower());

            if (File.Exists(CaminhoImgPartida))
            {
                Pic_EmrpesaPartida.ImageLocation = CaminhoImgPartida;
            }

            if (File.Exists(CaminhoImgDestino))
            {
                Pic_EmpresaDestino.ImageLocation = CaminhoImgDestino;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (PlanoDeFundo)
            {
                panel1.BackgroundImage = Properties.Resources.Fundo2;

                PlanoDeFundo = false;
            }
            else
            {
                panel1.BackgroundImage = Properties.Resources.Fundo1;

                PlanoDeFundo = true;
            }
        }

        private void pictureSom_Click(object sender, EventArgs e)
        {
            if (executarAudio)
            {
                executarAudio = false;

                pictureSom.Image = Properties.Resources.Mute_50;
            }
            else
            {
                executarAudio = true;

                pictureSom.Image = Properties.Resources.Medium_Volume_50;
            }
        }

        private void TimerTs3_Tick(object sender, EventArgs e)
        {
            if (!Ferramentas.VerificarTeamSpeak())
            {
                ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Ts3);
                Thread.Sleep(15000);
                Application.Exit();
            }
        }

        private void TimerAvisoSonoro_Tick(object sender, EventArgs e)
        {
            if (VelocidadeAtual > 100)
            {
                ControleVelocidade++;

                ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Bip);
            }
            else
            {
                ControleVelocidade = 0;
            }

            if (ControleVelocidade >= 5)
            {
                ControleVelocidade = 0;

                Multar();
            }
        }
    }
}