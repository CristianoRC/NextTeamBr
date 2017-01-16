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
            this.TimerAvisoSonoro = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_InfoCarga = new System.Windows.Forms.Label();
            this.Lbl_Destino = new System.Windows.Forms.Label();
            this.Lbl_Partida = new System.Windows.Forms.Label();
            this.pictureSom = new System.Windows.Forms.PictureBox();
            this.PicCarga = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarga)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTs3
            // 
            this.timerTs3.Interval = 25000;
            this.timerTs3.Tick += new System.EventHandler(this.TimerTs3_Tick);
            // 
            // TimerAvisoSonoro
            // 
            this.TimerAvisoSonoro.Enabled = true;
            this.TimerAvisoSonoro.Interval = 2000;
            this.TimerAvisoSonoro.Tick += new System.EventHandler(this.TimerAvisoSonoro_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::NextteamBr.Properties.Resources.Fundo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.Lbl_InfoCarga);
            this.panel1.Controls.Add(this.Lbl_Destino);
            this.panel1.Controls.Add(this.Lbl_Partida);
            this.panel1.Controls.Add(this.pictureSom);
            this.panel1.Controls.Add(this.PicCarga);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 300);
            this.panel1.TabIndex = 12;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // Lbl_InfoCarga
            // 
            this.Lbl_InfoCarga.AutoSize = true;
            this.Lbl_InfoCarga.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_InfoCarga.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_InfoCarga.ForeColor = System.Drawing.Color.White;
            this.Lbl_InfoCarga.Location = new System.Drawing.Point(428, 161);
            this.Lbl_InfoCarga.Name = "Lbl_InfoCarga";
            this.Lbl_InfoCarga.Size = new System.Drawing.Size(0, 23);
            this.Lbl_InfoCarga.TabIndex = 16;
            // 
            // Lbl_Destino
            // 
            this.Lbl_Destino.AutoSize = true;
            this.Lbl_Destino.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Destino.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Destino.Location = new System.Drawing.Point(425, 109);
            this.Lbl_Destino.Name = "Lbl_Destino";
            this.Lbl_Destino.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Destino.TabIndex = 14;
            // 
            // Lbl_Partida
            // 
            this.Lbl_Partida.AutoSize = true;
            this.Lbl_Partida.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Partida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Partida.Location = new System.Drawing.Point(424, 68);
            this.Lbl_Partida.Name = "Lbl_Partida";
            this.Lbl_Partida.Size = new System.Drawing.Size(0, 19);
            this.Lbl_Partida.TabIndex = 13;
            // 
            // pictureSom
            // 
            this.pictureSom.BackColor = System.Drawing.Color.Transparent;
            this.pictureSom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureSom.Image = global::NextteamBr.Properties.Resources.Medium_Volume_50;
            this.pictureSom.Location = new System.Drawing.Point(696, 252);
            this.pictureSom.Name = "pictureSom";
            this.pictureSom.Size = new System.Drawing.Size(38, 28);
            this.pictureSom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSom.TabIndex = 12;
            this.pictureSom.TabStop = false;
            this.pictureSom.Click += new System.EventHandler(this.pictureSom_Click);
            // 
            // PicCarga
            // 
            this.PicCarga.BackColor = System.Drawing.Color.Transparent;
            this.PicCarga.Image = global::NextteamBr.Properties.Resources.Carregado;
            this.PicCarga.Location = new System.Drawing.Point(417, 150);
            this.PicCarga.Name = "PicCarga";
            this.PicCarga.Size = new System.Drawing.Size(307, 96);
            this.PicCarga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicCarga.TabIndex = 15;
            this.PicCarga.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(749, 300);
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
            ((System.ComponentModel.ISupportInitialize)(this.PicCarga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureSom;
        private System.Windows.Forms.Timer timerTs3;
        private System.Windows.Forms.Label Lbl_Destino;
        private System.Windows.Forms.Label Lbl_Partida;
        private System.Windows.Forms.Timer TimerAvisoSonoro;
        private System.Windows.Forms.PictureBox PicCarga;
        private System.Windows.Forms.Label Lbl_InfoCarga;
    }
}