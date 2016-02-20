﻿using System;
using System.Media;

namespace NextteamBr
{
    public static class ControllerAudio
    {
        public static void ExecutarAudio(String Aviso)
        {


            switch (Aviso)
            {
                case "Dano":

                    SoundPlayer Dano = new SoundPlayer(Properties.Resources.Colisao);
                    Dano.Play();

                    break;
                case "Conectada":

                    SoundPlayer Inicio = new SoundPlayer(Properties.Resources.CarregadoComSucesso);
                    Inicio.Play();

                    break;
                case "Distancia":


                    SoundPlayer Entregue = new SoundPlayer(Properties.Resources.EstaProximo);
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