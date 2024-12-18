namespace MUSIC_FINAL.UserControls
{
    partial class Controls
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mediaButtons1 = new MUSIC_FINAL.UserControls.MediaButtons();
            this.musicData1 = new MUSIC_FINAL.UserControls.MusicData();
            this.progress1 = new MUSIC_FINAL.UserControls.Progress();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mediaButtons1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.musicData1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(977, 97);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // mediaButtons1
            // 
            this.mediaButtons1.BackColor = System.Drawing.Color.Transparent;
            this.mediaButtons1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.mediaButtons1.Location = new System.Drawing.Point(0, 0);
            this.mediaButtons1.Margin = new System.Windows.Forms.Padding(0);
            this.mediaButtons1.Name = "mediaButtons1";
            this.mediaButtons1.Size = new System.Drawing.Size(260, 97);
            this.mediaButtons1.TabIndex = 15;
            // 
            // musicData1
            // 
            this.musicData1.BackColor = System.Drawing.Color.Transparent;
            this.musicData1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicData1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.musicData1.Location = new System.Drawing.Point(260, 0);
            this.musicData1.Margin = new System.Windows.Forms.Padding(0);
            this.musicData1.Name = "musicData1";
            this.musicData1.Size = new System.Drawing.Size(717, 97);
            this.musicData1.TabIndex = 16;
            // 
            // progress1
            // 
            this.progress1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress1.Location = new System.Drawing.Point(0, 0);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(977, 27);
            this.progress1.TabIndex = 17;
            // 
            // Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.progress1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(0, 120);
            this.Name = "Controls";
            this.Size = new System.Drawing.Size(977, 120);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MediaButtons mediaButtons1;
        private MusicData musicData1;
        private Progress progress1;
    }
}
