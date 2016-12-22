namespace NextteamBr
{
	partial class Frm_Principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.timerTs3 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_Destino = new System.Windows.Forms.Label();
            this.Lbl_Partida = new System.Windows.Forms.Label();
            this.pictureSom = new System.Windows.Forms.PictureBox();
            this.Lbl_RPM = new System.Windows.Forms.Label();
            this.Lbl_Cambio = new System.Windows.Forms.Label();
            this.Lbl_KMH = new System.Windows.Forms.Label();
            this.Lbl_KMRegistrado = new System.Windows.Forms.Label();
            this.timerVelocidade = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSom)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTs3
            // 
            this.timerTs3.Interval = 25000;
            this.timerTs3.Tick += new System.EventHandler(this.timerTs3_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Lbl_Destino);
            this.panel1.Controls.Add(this.Lbl_Partida);
            this.panel1.Controls.Add(this.pictureSom);
            this.panel1.Controls.Add(this.Lbl_RPM);
            this.panel1.Controls.Add(this.Lbl_Cambio);
            this.panel1.Controls.Add(this.Lbl_KMH);
            this.panel1.Controls.Add(this.Lbl_KMRegistrado);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 273);
            this.panel1.TabIndex = 12;
            // 
            // Lbl_Destino
            // 
            this.Lbl_Destino.AutoSize = true;
            this.Lbl_Destino.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Destino.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Destino.Location = new System.Drawing.Point(35, 230);
            this.Lbl_Destino.Name = "Lbl_Destino";
            this.Lbl_Destino.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Destino.TabIndex = 14;
            // 
            // Lbl_Partida
            // 
            this.Lbl_Partida.AutoSize = true;
            this.Lbl_Partida.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Partida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Partida.Location = new System.Drawing.Point(34, 171);
            this.Lbl_Partida.Name = "Lbl_Partida";
            this.Lbl_Partida.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Partida.TabIndex = 13;
            // 
            // pictureSom
            // 
            this.pictureSom.BackColor = System.Drawing.Color.Transparent;
            this.pictureSom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSom.Image = global::NextteamBr.Properties.Resources.Medium_Volume_50;
            this.pictureSom.Location = new System.Drawing.Point(559, 219);
            this.pictureSom.Name = "pictureSom";
            this.pictureSom.Size = new System.Drawing.Size(53, 38);
            this.pictureSom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSom.TabIndex = 12;
            this.pictureSom.TabStop = false;
            this.pictureSom.Click += new System.EventHandler(this.pictureSom_Click);
            // 
            // Lbl_RPM
            // 
            this.Lbl_RPM.AutoSize = true;
            this.Lbl_RPM.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_RPM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RPM.Location = new System.Drawing.Point(181, 36);
            this.Lbl_RPM.Name = "Lbl_RPM";
            this.Lbl_RPM.Size = new System.Drawing.Size(25, 19);
            this.Lbl_RPM.TabIndex = 2;
            this.Lbl_RPM.Text = "00";
            // 
            // Lbl_Cambio
            // 
            this.Lbl_Cambio.AutoSize = true;
            this.Lbl_Cambio.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cambio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cambio.Location = new System.Drawing.Point(40, 36);
            this.Lbl_Cambio.Name = "Lbl_Cambio";
            this.Lbl_Cambio.Size = new System.Drawing.Size(25, 19);
            this.Lbl_Cambio.TabIndex = 0;
            this.Lbl_Cambio.Text = "00";
            // 
            // Lbl_KMH
            // 
            this.Lbl_KMH.AutoSize = true;
            this.Lbl_KMH.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_KMH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KMH.Location = new System.Drawing.Point(112, 36);
            this.Lbl_KMH.Name = "Lbl_KMH";
            this.Lbl_KMH.Size = new System.Drawing.Size(25, 19);
            this.Lbl_KMH.TabIndex = 1;
            this.Lbl_KMH.Text = "00";
            // 
            // Lbl_KMRegistrado
            // 
            this.Lbl_KMRegistrado.AutoSize = true;
            this.Lbl_KMRegistrado.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_KMRegistrado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KMRegistrado.Location = new System.Drawing.Point(40, 101);
            this.Lbl_KMRegistrado.Name = "Lbl_KMRegistrado";
            this.Lbl_KMRegistrado.Size = new System.Drawing.Size(25, 19);
            this.Lbl_KMRegistrado.TabIndex = 3;
            this.Lbl_KMRegistrado.Text = "00";
            // 
            // timerVelocidade
            // 
            this.timerVelocidade.Interval = 10000;
            this.timerVelocidade.Tick += new System.EventHandler(this.timerVelocidade_Tick);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(619, 269);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogBook NextTeamBr";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSom)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Lbl_Cambio;
		private System.Windows.Forms.Label Lbl_KMH;
		private System.Windows.Forms.Label Lbl_RPM;
		private System.Windows.Forms.Label Lbl_KMRegistrado;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureSom;
        private System.Windows.Forms.Timer timerTs3;
        private System.Windows.Forms.Label Lbl_Destino;
        private System.Windows.Forms.Label Lbl_Partida;
        private System.Windows.Forms.Timer timerVelocidade;
    }
}