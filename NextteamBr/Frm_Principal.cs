using System;
using System.Windows.Forms;
using Ets2SdkClient;

namespace NextteamBr
{
    public partial class Frm_Principal : Form
    {

        public Ets2SdkTelemetry Telemetria;

        bool executarAudio = true;
        bool ObterInformacoesIniciais = false;
        double VelocidadeAtual;
        Double v_OdometroFinal;
        Double v_OdometroInical;
        Frete informacoesFrete = new Frete();

        public Ets2SdkTelemetry Telemetry;

        public Frm_Principal()
        {
            InitializeComponent();

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
            }

        }

        private void TelemetryOnJobFinished(object sender, EventArgs args)
        {
            if (executarAudio)
            {
                ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Entregue);
            }

            informacoesFrete.KmRodado = v_OdometroFinal - v_OdometroInical;
            informacoesFrete.Pontuacao = Ferramentas.CalcularPontuacao(informacoesFrete.KmRodado, informacoesFrete.Dano);
            informacoesFrete.DataFinalFrete = DateTime.Now;

            MessageBox.Show(ControllerFrete.SalvarFrete(informacoesFrete));
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

                #region Variaveis

                if (ObterInformacoesIniciais)
                {
                    v_OdometroInical = data.Drivetrain.TruckOdometer;
                    informacoesFrete.CidadeInicial = data.Job.CitySource.ToString();
                    informacoesFrete.CidadeDestino = data.Job.CityDestination.ToString();
                    informacoesFrete.Carga = data.Job.TrailerName.ToString();
                    ObterInformacoesIniciais = false;
                }

                v_OdometroFinal = data.Drivetrain.TruckOdometer;
                informacoesFrete.Dano = data.Damage.WearTrailer;

                #endregion

                VelocidadeAtual = data.Drivetrain.SpeedKmh;
            }
            catch (Exception e)
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
        private void Frm_Principal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.Visible = true;
                this.ShowInTaskbar = false;
            }
        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.ShowInTaskbar = false;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
