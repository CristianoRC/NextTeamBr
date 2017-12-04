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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioAnual = new System.Windows.Forms.RadioButton();
            this.radioMes = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataFretes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataFretes
            // 
            this.dataFretes.AllowUserToAddRows = false;
            this.dataFretes.AllowUserToDeleteRows = false;
            this.dataFretes.AllowUserToOrderColumns = true;
            this.dataFretes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataFretes.Location = new System.Drawing.Point(0, 52);
            this.dataFretes.Name = "dataFretes";
            this.dataFretes.ReadOnly = true;
            this.dataFretes.Size = new System.Drawing.Size(778, 452);
            this.dataFretes.TabIndex = 4;
            this.dataFretes.SelectionChanged += new System.EventHandler(this.dataFretes_SelectionChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioAnual);
            this.groupBox1.Controls.Add(this.radioMes);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 44);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ranking";
            // 
            // radioAnual
            // 
            this.radioAnual.AutoSize = true;
            this.radioAnual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioAnual.Location = new System.Drawing.Point(95, 19);
            this.radioAnual.Name = "radioAnual";
            this.radioAnual.Size = new System.Drawing.Size(51, 17);
            this.radioAnual.TabIndex = 5;
            this.radioAnual.Text = "Anual";
            this.radioAnual.UseVisualStyleBackColor = true;
            this.radioAnual.Click += new System.EventHandler(this.radioAnual_Click);
            // 
            // radioMes
            // 
            this.radioMes.AutoSize = true;
            this.radioMes.Checked = true;
            this.radioMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioMes.Location = new System.Drawing.Point(6, 19);
            this.radioMes.Name = "radioMes";
            this.radioMes.Size = new System.Drawing.Size(58, 17);
            this.radioMes.TabIndex = 4;
            this.radioMes.TabStop = true;
            this.radioMes.Text = "Mensal";
            this.radioMes.UseVisualStyleBackColor = true;
            this.radioMes.Click += new System.EventHandler(this.radioMes_Click);
            // 
            // Frm_RankingMotoristas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataFretes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RankingMotoristas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ranking motoristas";
            this.Load += new System.EventHandler(this.Frm_RankingMotoristas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataFretes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataFretes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioAnual;
        private System.Windows.Forms.RadioButton radioMes;
    }
}