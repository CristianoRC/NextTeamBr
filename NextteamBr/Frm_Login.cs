﻿using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btm_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btm_Logar_Click(object sender, EventArgs e)
        {
            //LoginTrue -- Login e senha OK
            //LoginFalse -- Login errado
            //LoginIncorrect  -- Senha errada
            //LoginInativo --Não ativo

            if (!String.IsNullOrWhiteSpace(Txt_Login.Text) && !String.IsNullOrWhiteSpace(Txt_Senha.Text))
            {
                string SenhaCriptografada = Regex.Replace(Txt_Senha.Text, "[^0-9a-zA-Z]+", ""); //Remove os caracteres epeciais.

                SenhaCriptografada = Ferramentas.getMD5Hash(SenhaCriptografada);

                Usuario uso = new Usuario(Txt_Login.Text, SenhaCriptografada);

                string resultado = ControllerUsuario.Logar(uso);

                if (resultado.Contains("LoginTrue"))
                {
                    ControllerUsuario.SalvarUltimoLogin(Txt_Login.Text);
                    int id;
                    string[] linha = resultado.Split(';');
                    id = Convert.ToInt32(linha[1]);
                    ChamarFormularioDeEscolha(id);
                }
                else
                {
                    switch (resultado)
                    {
                        case "LoginFalse":
                            MessageBox.Show("Login inválido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "LoginIncorrect":
                            MessageBox.Show("Senha inválida!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "LoginInativo":
                            MessageBox.Show("Seu usuário ainda não foi ativado, entre em contato com um dos administradores", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ControllerUsuario.SalvarUltimoLogin(Txt_Login.Text);
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira seu login e senha!", "Alterta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void ChamarFormularioDeEscolha(int resultado)
        {
            Frm_Escolha frm_Escolha = new Frm_Escolha(resultado);
            this.Visible = false;
            frm_Escolha.ShowDialog();
            this.Dispose();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            Lbl_Versao.Text = "Versão: " + Application.ProductVersion;

            string Resultado = ControleVersao.VerificarAtualizacoes();

            if (Resultado.Contains("Erro ao tentar fazer a requisição:"))
            {
                MessageBox.Show("Verifique a sua conexão, para poder continuar utilizando o software", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Btm_Logar.Enabled = false;
            }
            else if (Resultado != String.Empty && !Resultado.Contains("Erro ao tentar fazer a requisição:"))
            {
                MessageBox.Show("Atualize o seu Software para poder continuar Utilizando!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btm_Logar.Enabled = false;
                Process.Start(Resultado);
            }

            Txt_Login.Text = ControllerUsuario.ObterUltimoLogin();
        }
    }
}
