namespace NextteamBr
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Login = new System.Windows.Forms.TextBox();
            this.Txt_Senha = new System.Windows.Forms.TextBox();
            this.Btm_Logar = new System.Windows.Forms.Button();
            this.Btm_Sair = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Lbl_Versao = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(67, 63);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(264, 20);
            this.Txt_Login.TabIndex = 2;
            this.Txt_Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Login_KeyPress);
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(67, 127);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(264, 20);
            this.Txt_Senha.TabIndex = 3;
            this.Txt_Senha.UseSystemPasswordChar = true;
            this.Txt_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Senha_KeyPress);
            // 
            // Btm_Logar
            // 
            this.Btm_Logar.BackColor = System.Drawing.Color.Transparent;
            this.Btm_Logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_Logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Logar.Location = new System.Drawing.Point(67, 172);
            this.Btm_Logar.Name = "Btm_Logar";
            this.Btm_Logar.Size = new System.Drawing.Size(122, 34);
            this.Btm_Logar.TabIndex = 4;
            this.Btm_Logar.Text = "Logar";
            this.Btm_Logar.UseVisualStyleBackColor = false;
            this.Btm_Logar.Click += new System.EventHandler(this.Btm_Logar_Click);
            // 
            // Btm_Sair
            // 
            this.Btm_Sair.BackColor = System.Drawing.Color.Transparent;
            this.Btm_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Sair.Location = new System.Drawing.Point(209, 172);
            this.Btm_Sair.Name = "Btm_Sair";
            this.Btm_Sair.Size = new System.Drawing.Size(122, 34);
            this.Btm_Sair.TabIndex = 5;
            this.Btm_Sair.Text = "Sair";
            this.Btm_Sair.UseVisualStyleBackColor = false;
            this.Btm_Sair.Click += new System.EventHandler(this.Btm_Sair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_Versao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 323);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Lbl_Versao
            // 
            this.Lbl_Versao.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Versao.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Versao.Name = "Lbl_Versao";
            this.Lbl_Versao.Size = new System.Drawing.Size(58, 17);
            this.Lbl_Versao.Text = "Versão : 1.0.0";
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cadastrar.Location = new System.Drawing.Point(67, 225);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(264, 29);
            this.btn_Cadastrar.TabIndex = 7;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::NextteamBr.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(651, 345);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Btm_Sair);
            this.Controls.Add(this.Btm_Logar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zero Hora Virtual";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Login;
        private System.Windows.Forms.TextBox Txt_Senha;
        private System.Windows.Forms.Button Btm_Logar;
        private System.Windows.Forms.Button Btm_Sair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Versao;
        private System.Windows.Forms.Button btn_Cadastrar;
    }
}