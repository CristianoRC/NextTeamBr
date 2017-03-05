namespace NextteamBr
{
    partial class Frm_Escolha
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
        /// Required method for Designer support  do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Escolha));
            this.Btm_JobSync = new System.Windows.Forms.Button();
            this.Btm_LogBook = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // Btm_JobSync
            // 
            this.Btm_JobSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_JobSync.Image = global::NextteamBr.Properties.Resources.Connection_Sync_100;
            this.Btm_JobSync.Location = new System.Drawing.Point(12, 12);
            this.Btm_JobSync.Name = "Btm_JobSync";
            this.Btm_JobSync.Size = new System.Drawing.Size(204, 183);
            this.Btm_JobSync.TabIndex = 0;
            this.toolTip1.SetToolTip(this.Btm_JobSync, "Job Sync");
            this.Btm_JobSync.UseVisualStyleBackColor = true;
            this.Btm_JobSync.Click += new System.EventHandler(this.Btm_JobSync_Click);
            // 
            // Btm_LogBook
            // 
            this.Btm_LogBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btm_LogBook.Image = global::NextteamBr.Properties.Resources.Address_Book_100;
            this.Btm_LogBook.Location = new System.Drawing.Point(312, 12);
            this.Btm_LogBook.Name = "Btm_LogBook";
            this.Btm_LogBook.Size = new System.Drawing.Size(204, 183);
            this.Btm_LogBook.TabIndex = 1;
            this.toolTip1.SetToolTip(this.Btm_LogBook, "LogBook Eletrônico");
            this.Btm_LogBook.UseVisualStyleBackColor = true;
            this.Btm_LogBook.Click += new System.EventHandler(this.Btm_LogBook_Click);
            // 
            // Frm_Escolha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(533, 207);
            this.Controls.Add(this.Btm_LogBook);
            this.Controls.Add(this.Btm_JobSync);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Escolha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextTeamBr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btm_JobSync;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Btm_LogBook;
    }
}