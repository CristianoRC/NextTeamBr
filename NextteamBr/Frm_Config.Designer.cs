namespace NextteamBr
{
    partial class Frm_Config
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioCem = new System.Windows.Forms.RadioButton();
            this.radioNoventa = new System.Windows.Forms.RadioButton();
            this.radioSemLimites = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioCem);
            this.groupBox1.Controls.Add(this.radioNoventa);
            this.groupBox1.Controls.Add(this.radioSemLimites);
            this.groupBox1.Location = new System.Drawing.Point(6, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Velocidade Maxima";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(12, 187);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(75, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "110 KM/H";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioCem
            // 
            this.radioCem.AutoSize = true;
            this.radioCem.Location = new System.Drawing.Point(12, 135);
            this.radioCem.Name = "radioCem";
            this.radioCem.Size = new System.Drawing.Size(75, 17);
            this.radioCem.TabIndex = 2;
            this.radioCem.TabStop = true;
            this.radioCem.Text = "100 KM/H";
            this.radioCem.UseVisualStyleBackColor = true;
            this.radioCem.CheckedChanged += new System.EventHandler(this.radioCem_CheckedChanged);
            // 
            // radioNoventa
            // 
            this.radioNoventa.AutoSize = true;
            this.radioNoventa.Location = new System.Drawing.Point(12, 83);
            this.radioNoventa.Name = "radioNoventa";
            this.radioNoventa.Size = new System.Drawing.Size(69, 17);
            this.radioNoventa.TabIndex = 1;
            this.radioNoventa.TabStop = true;
            this.radioNoventa.Text = "90 KM/H";
            this.radioNoventa.UseVisualStyleBackColor = true;
            this.radioNoventa.CheckedChanged += new System.EventHandler(this.radioNoventa_CheckedChanged);
            // 
            // radioSemLimites
            // 
            this.radioSemLimites.AutoSize = true;
            this.radioSemLimites.Location = new System.Drawing.Point(12, 31);
            this.radioSemLimites.Name = "radioSemLimites";
            this.radioSemLimites.Size = new System.Drawing.Size(81, 17);
            this.radioSemLimites.TabIndex = 0;
            this.radioSemLimites.TabStop = true;
            this.radioSemLimites.Text = "Sem Limites";
            this.radioSemLimites.UseVisualStyleBackColor = true;
            this.radioSemLimites.CheckedChanged += new System.EventHandler(this.radioSemLimites_CheckedChanged);
            // 
            // Frm_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 235);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Velocidade Maxima";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioCem;
        private System.Windows.Forms.RadioButton radioNoventa;
        private System.Windows.Forms.RadioButton radioSemLimites;
    }
}