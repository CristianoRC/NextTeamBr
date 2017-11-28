namespace NextteamBr
{
    partial class Frm_RedefinirSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RedefinirSenha));
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_confirmacao = new System.Windows.Forms.TextBox();
            this.Btn_Redefinir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(101, 13);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(238, 20);
            this.txt_senha.TabIndex = 0;
            this.txt_senha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nova Senha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirme a senha:";
            // 
            // txt_confirmacao
            // 
            this.txt_confirmacao.Location = new System.Drawing.Point(101, 50);
            this.txt_confirmacao.Name = "txt_confirmacao";
            this.txt_confirmacao.Size = new System.Drawing.Size(238, 20);
            this.txt_confirmacao.TabIndex = 3;
            this.txt_confirmacao.UseSystemPasswordChar = true;
            // 
            // Btn_Redefinir
            // 
            this.Btn_Redefinir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Redefinir.Location = new System.Drawing.Point(122, 93);
            this.Btn_Redefinir.Name = "Btn_Redefinir";
            this.Btn_Redefinir.Size = new System.Drawing.Size(197, 23);
            this.Btn_Redefinir.TabIndex = 5;
            this.Btn_Redefinir.Text = "Redefinir senha";
            this.Btn_Redefinir.UseVisualStyleBackColor = true;
            this.Btn_Redefinir.Click += new System.EventHandler(this.Btn_Redefinir_Click);
            // 
            // Frm_RedefinirSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 128);
            this.Controls.Add(this.Btn_Redefinir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_confirmacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RedefinirSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Redefinir senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_confirmacao;
        private System.Windows.Forms.Button Btn_Redefinir;
    }
}