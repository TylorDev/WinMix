namespace MUSIC_FINAL
{
    partial class Base
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            this.TittleBar_Main = new MUSIC_FINAL.UserControls.Tittlebar();
            this.SuspendLayout();
            // 
            // TittleBar_Main
            // 
            this.TittleBar_Main.BackColor = System.Drawing.Color.Maroon;
            this.TittleBar_Main.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.TittleBar_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.TittleBar_Main.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.TittleBar_Main.Location = new System.Drawing.Point(3, 3);
            this.TittleBar_Main.Margin = new System.Windows.Forms.Padding(0);
            this.TittleBar_Main.Name = "TittleBar_Main";
            this.TittleBar_Main.Size = new System.Drawing.Size(994, 46);
            this.TittleBar_Main.TabIndex = 0;
            this.TittleBar_Main.Tag = "";
            this.TittleBar_Main.Title = "Base";
            // 
            // Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.TittleBar_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Base";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public UserControls.Tittlebar TittleBar_Main;
    }
}

