namespace MUSIC_FINAL.UserControls
{
    partial class SongList
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
            this.Flw_Queue = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Flw_Queue
            // 
            this.Flw_Queue.AutoScroll = true;
            this.Flw_Queue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Flw_Queue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flw_Queue.ForeColor = System.Drawing.Color.Yellow;
            this.Flw_Queue.Location = new System.Drawing.Point(0, 0);
            this.Flw_Queue.Margin = new System.Windows.Forms.Padding(0);
            this.Flw_Queue.Name = "Flw_Queue";
            this.Flw_Queue.Size = new System.Drawing.Size(399, 500);
            this.Flw_Queue.TabIndex = 0;
            // 
            // SongList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.Flw_Queue);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SongList";
            this.Size = new System.Drawing.Size(399, 500);
        
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flw_Queue;
    }
}
