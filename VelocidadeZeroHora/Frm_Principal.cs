using System;
using System.Windows.Forms;
using Ets2SdkClient;
using System.Threading;
using System.IO;

namespace VelocidadeZeroHora
{
    public partial class Frm_Principal : Form
    {
        public Ets2SdkTelemetry Telemetry;
        double VelocidadeAtual = 0;
        int audioID = 1;

        public Frm_Principal()
        {
            InitializeComponent();

            Telemetry = new Ets2SdkTelemetry();
            Telemetry.Data += Telemetry_Data;


            if (Telemetry.Error != null)
            {
                MessageBox.Show(
                    "General info:\r\nFailed to open memory map " + Telemetry.Map +
                    " - on some systems you need to run the client (this app) " +
                    "with elevated permissions, because e.g. you're running Steam/ETS2 with elevated permissions as well. .NET reported the following Exception:\r\n" +
                    Telemetry.Error.Message + "\r\n\r\nStacktrace:\r\n" + Telemetry.Error.StackTrace);
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

                VelocidadeAtual = data.Drivetrain.SpeedKmh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Erro: {0}", ex.Message), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimerAvisoSonoro_Tick(object sender, EventArgs e)
        {
            if (VelocidadeAtual > Convert.ToDouble(txt_velocidade.Text))
            {
                ControllerAudio.ExecutarAudio(audioID);
            }
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            ControllerAudio.ExecutarAudio(1);
            audioID = 1;
        }

        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            ControllerAudio.ExecutarAudio(2);
            audioID = 2;
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            ControllerAudio.ExecutarAudio(3);
            audioID = 3;
        }
    }
}