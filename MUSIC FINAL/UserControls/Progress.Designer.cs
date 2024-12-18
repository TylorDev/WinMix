namespace MUSIC_FINAL.UserControls
{
    partial class Progress
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Table_Progress = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Sld_Progress = new MUSIC_FINAL.UserControls.Slider();
            this.Lbl_Progress = new MUSIC_FINAL.UserControls.Label();
            this.Lbl_Duration = new MUSIC_FINAL.UserControls.Label();
            this.Table_Progress.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_Progress
            // 
            this.Table_Progress.ColumnCount = 3;
            this.Table_Progress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_Progress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Progress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_Progress.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.Table_Progress.Controls.Add(this.Lbl_Progress, 0, 0);
            this.Table_Progress.Controls.Add(this.Lbl_Duration, 2, 0);
            this.Table_Progress.Dock = System.Windows.Forms.DockStyle.Top;
            this.Table_Progress.Location = new System.Drawing.Point(0, 0);
            this.Table_Progress.Name = "Table_Progress";
            this.Table_Progress.RowCount = 1;
            this.Table_Progress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Progress.Size = new System.Drawing.Size(847, 25);
            this.Table_Progress.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.Sld_Progress, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(71, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(706, 19);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // Sld_Progress
            // 
            this.Sld_Progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sld_Progress.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sld_Progress.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Sld_Progress.Location = new System.Drawing.Point(0, 4);
            this.Sld_Progress.Margin = new System.Windows.Forms.Padding(0);
            this.Sld_Progress.MaxValue = 200;
            this.Sld_Progress.Name = "Sld_Progress";
            this.Sld_Progress.Size = new System.Drawing.Size(706, 10);
            this.Sld_Progress.TabIndex = 15;
            this.Sld_Progress.Value = 0D;
            this.Sld_Progress.Clicked += new System.EventHandler(this.Sld_Progress_Clicked);
            // 
            // Lbl_Progress
            // 
            this.Lbl_Progress.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Progress.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Progress.BordeSize = 0;
            this.Lbl_Progress.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Lbl_Progress.FontWeight = System.Drawing.FontStyle.Bold;
            this.Lbl_Progress.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Progress.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Progress.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Progress.Name = "Lbl_Progress";
            this.Lbl_Progress.Size = new System.Drawing.Size(68, 25);
            this.Lbl_Progress.TabIndex = 12;
            this.Lbl_Progress.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Progress.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_Progress.Texto = "00:05";
            // 
            // Lbl_Duration
            // 
            this.Lbl_Duration.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Duration.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Duration.BordeSize = 0;
            this.Lbl_Duration.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Lbl_Duration.FontWeight = System.Drawing.FontStyle.Bold;
            this.Lbl_Duration.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Duration.Location = new System.Drawing.Point(780, 0);
            this.Lbl_Duration.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Duration.Name = "Lbl_Duration";
            this.Lbl_Duration.Size = new System.Drawing.Size(67, 20);
            this.Lbl_Duration.TabIndex = 11;
            this.Lbl_Duration.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_Duration.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_Duration.Texto = "04:45";
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Table_Progress);
            this.Name = "Progress";
            this.Size = new System.Drawing.Size(847, 27);
            this.Table_Progress.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table_Progress;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public Slider Sld_Progress;
        public Label Lbl_Progress;
        public Label Lbl_Duration;
    }
}
