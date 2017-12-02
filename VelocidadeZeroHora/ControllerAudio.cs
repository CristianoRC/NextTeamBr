using System;
using System.Media;

namespace VelocidadeZeroHora
{
    public static class ControllerAudio
    {
        public static void ExecutarAudio(int audio)
        {
            switch (audio)
            {
                case 1:

                    SoundPlayer Velocidade = new SoundPlayer(Properties.Resources._1);
                    Velocidade.Play();

                    break;
                case 2:

                    SoundPlayer bip = new SoundPlayer(Properties.Resources._2);
                    bip.Play();

                    break;
                case 3:
                    SoundPlayer bips = new SoundPlayer(Properties.Resources._3);
                    bips.Play();
                    break;
            }
        }
    }
}
