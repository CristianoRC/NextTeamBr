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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_i = new System.Windows.Forms.Label();
            this.pictureSom = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Lbl_RPM = new System.Windows.Forms.Label();
            this.Lbl_Cambio = new System.Windows.Forms.Label();
            this.Lbl_KMH = new System.Windows.Forms.Label();
            this.Lbl_EmpresaDestino = new System.Windows.Forms.Label();
            this.Lbl_CidadeDestino = new System.Windows.Forms.Label();
            this.Lbl_KMRegistrado = new System.Windows.Forms.Label();
            this.Lbl_EmpresaInicial = new System.Windows.Forms.Label();
            this.Lbl_CidadeInicial = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSom)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Log Book NextTeamBr";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::NextteamBr.Properties.Resources.Faixa_Fundo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Lbl_i);
            this.panel2.Controls.Add(this.pictureSom);
            this.panel2.Location = new System.Drawing.Point(0, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 88);
            this.panel2.TabIndex = 13;
            // 
            // Lbl_i
            // 
            this.Lbl_i.AutoSize = true;
            this.Lbl_i.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_i.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_i.Location = new System.Drawing.Point(30, 43);
            this.Lbl_i.Name = "Lbl_i";
            this.Lbl_i.Size = new System.Drawing.Size(0, 19);
            this.Lbl_i.TabIndex = 9;
            // 
            // pictureSom
            // 
            this.pictureSom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSom.Image = global::NextteamBr.Properties.Resources.Medium_Volume_50;
            this.pictureSom.Location = new System.Drawing.Point(542, 24);
            this.pictureSom.Name = "pictureSom";
            this.pictureSom.Size = new System.Drawing.Size(53, 38);
            this.pictureSom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSom.TabIndex = 12;
            this.pictureSom.TabStop = false;
            this.pictureSom.Click += new System.EventHandler(this.pictureSom_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.Lbl_RPM);
            this.panel1.Controls.Add(this.Lbl_Cambio);
            this.panel1.Controls.Add(this.Lbl_KMH);
            this.panel1.Controls.Add(this.Lbl_EmpresaDestino);
            this.panel1.Controls.Add(this.Lbl_CidadeDestino);
            this.panel1.Controls.Add(this.Lbl_KMRegistrado);
            this.panel1.Controls.Add(this.Lbl_EmpresaInicial);
            this.panel1.Controls.Add(this.Lbl_CidadeInicial);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 216);
            this.panel1.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 194);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(599, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Lbl_RPM
            // 
            this.Lbl_RPM.AutoSize = true;
            this.Lbl_RPM.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_RPM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_RPM.Location = new System.Drawing.Point(147, 47);
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
            this.Lbl_Cambio.Location = new System.Drawing.Point(30, 47);
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
            this.Lbl_KMH.Location = new System.Drawing.Point(89, 47);
            this.Lbl_KMH.Name = "Lbl_KMH";
            this.Lbl_KMH.Size = new System.Drawing.Size(25, 19);
            this.Lbl_KMH.TabIndex = 1;
            this.Lbl_KMH.Text = "00";
            // 
            // Lbl_EmpresaDestino
            // 
            this.Lbl_EmpresaDestino.AutoSize = true;
            this.Lbl_EmpresaDestino.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_EmpresaDestino.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EmpresaDestino.Location = new System.Drawing.Point(457, 128);
            this.Lbl_EmpresaDestino.Name = "Lbl_EmpresaDestino";
            this.Lbl_EmpresaDestino.Size = new System.Drawing.Size(0, 15);
            this.Lbl_EmpresaDestino.TabIndex = 7;
            // 
            // Lbl_CidadeDestino
            // 
            this.Lbl_CidadeDestino.AutoSize = true;
            this.Lbl_CidadeDestino.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CidadeDestino.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CidadeDestino.Location = new System.Drawing.Point(457, 105);
            this.Lbl_CidadeDestino.Name = "Lbl_CidadeDestino";
            this.Lbl_CidadeDestino.Size = new System.Drawing.Size(0, 15);
            this.Lbl_CidadeDestino.TabIndex = 6;
            // 
            // Lbl_KMRegistrado
            // 
            this.Lbl_KMRegistrado.AutoSize = true;
            this.Lbl_KMRegistrado.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_KMRegistrado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_KMRegistrado.Location = new System.Drawing.Point(30, 100);
            this.Lbl_KMRegistrado.Name = "Lbl_KMRegistrado";
            this.Lbl_KMRegistrado.Size = new System.Drawing.Size(25, 19);
            this.Lbl_KMRegistrado.TabIndex = 3;
            this.Lbl_KMRegistrado.Text = "00";
            // 
            // Lbl_EmpresaInicial
            // 
            this.Lbl_EmpresaInicial.AutoSize = true;
            this.Lbl_EmpresaInicial.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_EmpresaInicial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EmpresaInicial.Location = new System.Drawing.Point(259, 129);
            this.Lbl_EmpresaInicial.Name = "Lbl_EmpresaInicial";
            this.Lbl_EmpresaInicial.Size = new System.Drawing.Size(0, 15);
            this.Lbl_EmpresaInicial.TabIndex = 5;
            // 
            // Lbl_CidadeInicial
            // 
            this.Lbl_CidadeInicial.AutoSize = true;
            this.Lbl_CidadeInicial.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_CidadeInicial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CidadeInicial.Location = new System.Drawing.Point(259, 106);
            this.Lbl_CidadeInicial.Name = "Lbl_CidadeInicial";
            this.Lbl_CidadeInicial.Size = new System.Drawing.Size(0, 15);
            this.Lbl_CidadeInicial.TabIndex = 4;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(599, 225);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogBook NextTeamBr";
            this.Resize += new System.EventHandler(this.Frm_Principal_Resize);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label Lbl_Cambio;
		private System.Windows.Forms.Label Lbl_KMH;
		private System.Windows.Forms.Label Lbl_RPM;
		private System.Windows.Forms.Label Lbl_KMRegistrado;
		private System.Windows.Forms.Label Lbl_CidadeInicial;
		private System.Windows.Forms.Label Lbl_EmpresaInicial;
		private System.Windows.Forms.Label Lbl_CidadeDestino;
		private System.Windows.Forms.Label Lbl_EmpresaDestino;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureSom;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.Label Lbl_i;
    }
}