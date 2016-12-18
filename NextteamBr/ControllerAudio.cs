using System;
using System.Media;

namespace NextteamBr
{
    public static class ControllerAudio
    {
        public enum Audios
        {
            Dano,
            Conectada,
            Cancelada,
            Entregue,
            Ts3,
            MP
        };

        public static void ExecutarAudio(Audios TipoDeAviso)
        {
            switch (TipoDeAviso.ToString())
            {
                case "MP":

                    SoundPlayer MP = new SoundPlayer(Properties.Resources.MP);
                    MP.Play();
                    break;
                case "Ts3":

                    SoundPlayer ts = new SoundPlayer(Properties.Resources.Ts3);
                    ts.Play();               
                    break;
                case "Dano":

                    SoundPlayer Dano = new SoundPlayer(Properties.Resources.Colisao);
                    Dano.Play();

                    break;
                case "Conectada":

                    SoundPlayer Inicio = new SoundPlayer(Properties.Resources.CarregadoComSucesso);
                    Inicio.Play();

                    break;
                case "Cancelada":


                    SoundPlayer Entregue = new SoundPlayer(Properties.Resources.Cancelada);
                    Entregue.Play();

                    break;
                case "Entregue":

                    SoundPlayer Finalizada = new SoundPlayer(Properties.Resources.CargaEntregue);
                    Finalizada.Play();

                    break;
            }
        }
    }
}
