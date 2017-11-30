namespace NextteamBr.PainelAdministraivo
{
    partial class Frm_ResetarRanking
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
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.btn_Zerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(57, 22);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(213, 20);
            this.txt_Senha.TabIndex = 0;
            this.txt_Senha.UseSystemPasswordChar = true;
            // 
            // btn_Zerar
            // 
            this.btn_Zerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Zerar.Location = new System.Drawing.Point(293, 21);
            this.btn_Zerar.Name = "btn_Zerar";
            this.btn_Zerar.Size = new System.Drawing.Size(105, 23);
            this.btn_Zerar.TabIndex = 1;
            this.btn_Zerar.Text = "Zerar ranking";
            this.btn_Zerar.UseVisualStyleBackColor = true;
            this.btn_Zerar.Click += new System.EventHandler(this.btn_Zerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Senha";
            // 
            // Frm_ResetarRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 66);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Zerar);
            this.Controls.Add(this.txt_Senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_ResetarRanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resetar Ranking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_Zerar;
        private System.Windows.Forms.Label label1;
    }
}