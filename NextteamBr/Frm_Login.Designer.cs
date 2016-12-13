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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Lbl_Versao = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // Txt_Login
            // 
            this.Txt_Login.Location = new System.Drawing.Point(75, 43);
            this.Txt_Login.Name = "Txt_Login";
            this.Txt_Login.Size = new System.Drawing.Size(264, 20);
            this.Txt_Login.TabIndex = 2;
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.Location = new System.Drawing.Point(75, 107);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.Size = new System.Drawing.Size(264, 20);
            this.Txt_Senha.TabIndex = 3;
            this.Txt_Senha.UseSystemPasswordChar = true;
            // 
            // Btm_Logar
            // 
            this.Btm_Logar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_Logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Logar.Location = new System.Drawing.Point(75, 187);
            this.Btm_Logar.Name = "Btm_Logar";
            this.Btm_Logar.Size = new System.Drawing.Size(122, 34);
            this.Btm_Logar.TabIndex = 4;
            this.Btm_Logar.Text = "Logar";
            this.Btm_Logar.UseVisualStyleBackColor = true;
            this.Btm_Logar.Click += new System.EventHandler(this.Btm_Logar_Click);
            // 
            // Btm_Sair
            // 
            this.Btm_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btm_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Sair.Location = new System.Drawing.Point(217, 187);
            this.Btm_Sair.Name = "Btm_Sair";
            this.Btm_Sair.Size = new System.Drawing.Size(122, 34);
            this.Btm_Sair.TabIndex = 5;
            this.Btm_Sair.Text = "Sair";
            this.Btm_Sair.UseVisualStyleBackColor = true;
            this.Btm_Sair.Click += new System.EventHandler(this.Btm_Sair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NextteamBr.Properties.Resources.client;
            this.pictureBox1.Location = new System.Drawing.Point(385, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 237);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Lbl_Versao});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(647, 22);
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
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(647, 265);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btm_Sair);
            this.Controls.Add(this.Btm_Logar);
            this.Controls.Add(this.Txt_Senha);
            this.Controls.Add(this.Txt_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Next TeamBr";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Lbl_Versao;
    }
}