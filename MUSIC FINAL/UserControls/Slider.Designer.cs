namespace MUSIC_FINAL.UserControls
{
    partial class Slider
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
            this.Main_Split = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.Main_Split)).BeginInit();
            this.Main_Split.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_Split
            // 
            this.Main_Split.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Split.Location = new System.Drawing.Point(0, 0);
            this.Main_Split.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Split.Name = "Main_Split";
            // 
            // Main_Split.Panel1
            // 
            this.Main_Split.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Main_Split.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_Split_Panel1_MouseClick);
            this.Main_Split.Panel1MinSize = 0;
            // 
            // Main_Split.Panel2
            // 
            this.Main_Split.Panel2.BackColor = System.Drawing.Color.SpringGreen;
            this.Main_Split.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_Split_Panel2_MouseClick);
            this.Main_Split.Panel2MinSize = 0;
            this.Main_Split.Size = new System.Drawing.Size(747, 217);
            this.Main_Split.SplitterDistance = 300;
            this.Main_Split.TabIndex = 0;
           
            this.Main_Split.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_Split_MouseClick);
            // 
            // Slider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.Main_Split);
            this.Name = "Slider";
            this.Size = new System.Drawing.Size(747, 217);
            ((System.ComponentModel.ISupportInitialize)(this.Main_Split)).EndInit();
            this.Main_Split.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main_Split;
    }
}
