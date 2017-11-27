namespace NextteamBr
{
    partial class Frm_RankingMotoristas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RankingMotoristas));
            this.dataFretes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataFretes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataFretes
            // 
            this.dataFretes.AllowUserToAddRows = false;
            this.dataFretes.AllowUserToDeleteRows = false;
            this.dataFretes.AllowUserToOrderColumns = true;
            this.dataFretes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataFretes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataFretes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataFretes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataFretes.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataFretes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataFretes.Location = new System.Drawing.Point(0, 0);
            this.dataFretes.Name = "dataFretes";
            this.dataFretes.ReadOnly = true;
            this.dataFretes.Size = new System.Drawing.Size(481, 482);
            this.dataFretes.TabIndex = 4;
            this.dataFretes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataFretes_CellFormatting);
            this.dataFretes.SelectionChanged += new System.EventHandler(this.dataFretes_SelectionChanged);
            // 
            // Frm_RankingMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 482);
            this.Controls.Add(this.dataFretes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RankingMotoristas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking motoristas";
            this.Load += new System.EventHandler(this.Frm_RankingMotoristas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFretes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataFretes;
    }
}