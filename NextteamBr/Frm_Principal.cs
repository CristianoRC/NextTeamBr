using System;
using System.Windows.Forms;
using Ets2SdkClient;

namespace NextteamBr
{
	public partial class Frm_Principal : Form
	{

		public Ets2SdkTelemetry Telemetria;

		//uint NumeroDeMultas = 0;
		bool executarAudio = true;
		bool ObterInformacoesIniciais = false;
		bool ObterInformacoesFinais = false;
		Frete informacoesFrete = new Frete();
		Odometro informacoesOdometro = new Odometro();

		public Frm_Principal()
		{
			InitializeComponent();

			Telemetria = new Ets2SdkTelemetry();
			Telemetria.Data += Telemetry_Data;

			Telemetria.JobFinished += TelemetryOnJobFinished;
			Telemetria.JobStarted += TelemetryOnJobStarted;

			if (Telemetria.Error != null)
			{
				MessageBox.Show(
					"General info:\r\nFailed to open memory map " + Telemetria.Map +
						" - on some systems you need to run the client (this app) with elevated permissions, because e.g. you're running Steam/ETS2 with elevated permissions as well. .NET reported the following Exception:\r\n" +
					Telemetria.Error.Message + "\r\n\r\nStacktrace:\r\n" + Telemetria.Error.StackTrace);
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
			ObterInformacoesFinais = true;

			if (executarAudio)
			{
				ControllerAudio.ExecutarAudio(ControllerAudio.Audios.Entregue);
			}

			informacoesFrete.KmRodado = informacoesOdometro.ObterKilometroRodados();

			MessageBox.Show(String.Format("{0}, {1}, {2}, {3}", informacoesFrete.KmRodado, informacoesFrete.Carga,
										  informacoesFrete.CidadeInicial, informacoesFrete.CidadeDestino));
		}

		private void Telemetry_Data(Ets2Telemetry InformacoesTelemetria, bool updated)
		{
			try
			{
				if (this.InvokeRequired)
				{
					this.Invoke(new TelemetryData(Telemetry_Data), new object[2] { InformacoesTelemetria, updated });
					return;
				}

				#region Informações da tela

				Lbl_CidadeInicial.Text = InformacoesTelemetria.Job.CitySource.ToString();
				Lbl_CidadeDestino.Text = InformacoesTelemetria.Job.CityDestination.ToString();
				Lbl_EmpresaInicial.Text = InformacoesTelemetria.Job.CompanySource.ToString();
				Lbl_EmpresaDestino.Text = InformacoesTelemetria.Job.CompanyDestination.ToString();

				Lbl_Cambio.Text = Convert.ToInt16(InformacoesTelemetria.Drivetrain.Gear).ToString();
				Lbl_KMH.Text = Convert.ToInt16(InformacoesTelemetria.Drivetrain.SpeedKmh).ToString();
				Lbl_KMRegistrado.Text = InformacoesTelemetria.Drivetrain.TruckOdometer.ToString("0.0");
				Lbl_RPM.Text = InformacoesTelemetria.Drivetrain.EngineRpm.ToString("0.0");
				#endregion

				#region Variaveis

				if (ObterInformacoesIniciais)
				{
					informacoesOdometro.ValorInicial = InformacoesTelemetria.Drivetrain.TruckOdometer;

					informacoesFrete.CidadeInicial = InformacoesTelemetria.Job.CitySource.ToString();
					informacoesFrete.CidadeDestino = InformacoesTelemetria.Job.CityDestination.ToString();
					informacoesFrete.Carga = InformacoesTelemetria.Job.TrailerName.ToString();

					ObterInformacoesIniciais = false;
				}
				else if (ObterInformacoesFinais)
				{
					informacoesOdometro.ValorAtual = InformacoesTelemetria.Drivetrain.TruckOdometer;

					ObterInformacoesFinais = false;
				}
				#endregion
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
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

		private void VerificarDanoDaCarga()
		{
			/*
            if (informacoesGame.trailer.wear > informacoesFrete.Dano)
            {
                informacoesFrete.Dano = (informacoesGame.trailer.wear + 0.08);

                if (executarAudio)
                {
                    ControllerAudio.ExecutarAudio("Dano");
                }
            }
            */
		}

		private void VerificarCargaConectada()
		{
			/*
            timerLimitVelocidade.Start();

            if (inicioViajem == false)
            {
                if (informacoesGame.trailer.attached == true && informacoesGame.navigation.estimatedDistance > 300)
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
            */
		}

		private void VerificarDistanciaEntrega()
		{
			/*
			if (verificarDistanciaLocalDeEntrega)
            {
                if (som5KMExecutado == false)
                {
                    if (informacoesGame.navigation.estimatedDistance <= 20000 && informacoesGame.navigation.estimatedDistance >= 19000) //2000 esta apenas usado para pequenas distancias..
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
            */
		}

		private void VerificarCargaEntregue()
		{
			/*
            if (informacoesGame.navigation.estimatedDistance <= 90 && informacoesGame.navigation.estimatedDistance >= 10)
            {
                if (executarAudio)
                {
                    ControllerAudio.ExecutarAudio("Entregue");
                }

                informacoesFrete.DistanciaFinal = informacoesGame.truck.odometer;

                informacoesFrete.KmRodado = informacoesFrete.DistanciaFinal - informacoesFrete.DistanciaInicial;

                informacoesFrete.KmRodado -= NumeroDeMultas * 1000;

                informacoesFrete.DataFinalFrete = DateTime.Now;

                SalvarCarga();

                timerLimitVelocidade.Stop();
            }
            */
		}

		private void VerificarVelocidade()
		{
			/*
			if (informacoesGame.truck.speed > informacoesGame.navigation.speedLimit)
            {
                if (informacoesGame.truck.speed > ControleVelocidade.VelocidadeMaxima())
                {
                    NumeroDeMultas++;
                }
            }
            */
		}

		private void SalvarCarga()
		{

			/*ControllerFrete.SalvarFrete(informacoesFrete, informacoesGame);

            inicioViajem = false;
            verificarDistanciaLocalDeEntrega = true;
            som5KMExecutado = false;*/
		}

		private void timerLimitVelocidade_Tick(object sender, EventArgs e)
		{
			VerificarVelocidade();
		}
	}
}
