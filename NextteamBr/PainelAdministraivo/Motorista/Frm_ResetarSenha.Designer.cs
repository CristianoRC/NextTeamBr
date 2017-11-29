namespace NextteamBr.PainelAdministraivo
{
    partial class Frm_ResetarSenha
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
            this.Btm_Ativar = new System.Windows.Forms.Button();
            this.comboMotoristas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btm_Ativar
            // 
            this.Btm_Ativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_Ativar.Location = new System.Drawing.Point(379, 21);
            this.Btm_Ativar.Name = "Btm_Ativar";
            this.Btm_Ativar.Size = new System.Drawing.Size(111, 23);
            this.Btm_Ativar.TabIndex = 0;
            this.Btm_Ativar.Text = "Resetar senha";
            this.Btm_Ativar.UseVisualStyleBackColor = true;
            this.Btm_Ativar.Click += new System.EventHandler(this.Btm_Ativar_Click);
            // 
            // comboMotoristas
            // 
            this.comboMotoristas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMotoristas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboMotoristas.FormattingEnabled = true;
            this.comboMotoristas.Location = new System.Drawing.Point(68, 23);
            this.comboMotoristas.Name = "comboMotoristas";
            this.comboMotoristas.Size = new System.Drawing.Size(298, 21);
            this.comboMotoristas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motorista";
            // 
            // Frm_ResetarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 69);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboMotoristas);
            this.Controls.Add(this.Btm_Ativar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_ResetarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ativar Motorista";
            this.Load += new System.EventHandler(this.Frm_Ativar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btm_Ativar;
        private System.Windows.Forms.ComboBox comboMotoristas;
        private System.Windows.Forms.Label label1;
    }
}