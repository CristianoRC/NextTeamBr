using System;
using System.Windows.Forms;
using Ets2SdkClient;
using System.Threading;

namespace NextteamBr
{
    public partial class Frm_Principal : Form
    {
        public Ets2SdkTelemetry Telemetria;
        bool executarAudio = true;
        bool cargaEntregue = false;
        bool informacoesFinaisObtidas = false;
        bool ObterInformacoesIniciais = false;
        Double v_OdometroInical;
        String Login;
        Frete informacoesFrete = new Frete();


        public Ets2SdkTelemetry Telemetry;

        public Frm_Principal(String p_Login)
        {
            InitializeComponent();

            Login = p_Login;

            Telemetry = new Ets2SdkTelemetry();
            Telemetry.Data += Telemetry_Data;

            Telemetry.JobFinished += TelemetryOnJobFinished;
            Telemetry.JobStarted += TelemetryOnJobStarted;

            if (Telemetry.Error != null)
            {
                Lbl_i.Text =
                    "General info:\r\nFailed to open memory map " + Telemetry.Map +
                        " - on some systems you need to run the client (this app) with elevated permissions, because e.g. you're running Steam/ETS2 with elevated permissions as well. .NET reported the following Exception:\r\n" +
                        Telemetry.Error.Message + "\r\n\r\nStacktrace:\r\n" + Telemetry.Error.StackTrace;
            }
        }

        #region Infomações Telemetria

        private void TelemetryOnJobStarted(object sender, EventArgs e)
        {
            ObterInformacoesIniciais = true;

            if (executarAudio)
            {
                ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Conectada);

                cargaEntregue = false;
                informacoesFinaisObtidas = false;
            }
        }

        private void TelemetryOnJobFinished(object sender, EventArgs args)
        {
            if (cargaEntregue)
            {
                informacoesFrete.DataFinalFrete = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                informacoesFrete.LoginMotorista = Login;
                informacoesFrete.KmRodado = Convert.ToDouble(informacoesFrete.KmRodado.ToString("0.00"));
                informacoesFrete.Dano = Convert.ToDouble(informacoesFrete.Dano.ToString("0.00"));
                informacoesFrete.Pontuacao = Convert.ToDouble(informacoesFrete.Pontuacao.ToString("0.00"));

                if (ControllerFrete.SalvarFrete(informacoesFrete))
                {
                    if (executarAudio)
                    {
                        ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Entregue);
                    }
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao tentar salvar sua carga!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

                #region Informações da tela

                Lbl_CidadeInicial.Text = data.Job.CitySource.ToString();
                Lbl_CidadeDestino.Text = data.Job.CityDestination.ToString();
                Lbl_EmpresaInicial.Text = data.Job.CompanySource.ToString();
                Lbl_EmpresaDestino.Text = data.Job.CompanyDestination.ToString();

                Lbl_Cambio.Text = Convert.ToInt16(data.Drivetrain.Gear).ToString();
                Lbl_KMH.Text = Convert.ToInt16(data.Drivetrain.SpeedKmh).ToString();
                Lbl_KMRegistrado.Text = data.Drivetrain.TruckOdometer.ToString("0.0");
                Lbl_RPM.Text = data.Drivetrain.EngineRpm.ToString("0.0");
                #endregion
                #region

                if (ObterInformacoesIniciais)
                {
                    v_OdometroInical = data.Drivetrain.TruckOdometer;
                    informacoesFrete.CidadeInicial = data.Job.CitySource.ToString();
                    informacoesFrete.CidadeDestino = data.Job.CityDestination.ToString();
                    informacoesFrete.Carga = String.Format("{0} {1}t", data.Job.TrailerName.ToString(), (data.Job.Mass / 1000).ToString());
                    ObterInformacoesIniciais = false;
                }

                if ((informacoesFinaisObtidas == false) && data.Job.NavigationDistanceLeft < 1500 && data.Job.NavigationDistanceLeft > 800)
                {
                    informacoesFrete.Dano = data.Damage.WearTrailer;
                    informacoesFrete.KmRodado = data.Drivetrain.TruckOdometer - v_OdometroInical;
                    informacoesFrete.Pontuacao = Ferramentas.CalcularPontuacao(informacoesFrete.KmRodado, informacoesFrete.Dano);

                    cargaEntregue = true;
                    informacoesFinaisObtidas = true;
                }

                #endregion
            }
            catch (Exception)
            {

            }
        }

        #endregion

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

        private void timerTs3_Tick(object sender, EventArgs e)
        {
            if (!Ferramentas.VerificarTeamSpeak())
            {
                ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Ts3);
                Thread.Sleep(12000);
                Application.Exit();
            }
        }
    }
}
