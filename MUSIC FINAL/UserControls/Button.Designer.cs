using MUSIC_FINAL.Global;

namespace MUSIC_FINAL.UserControls
{
    partial class Button
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
            this.Btn_Main = new MUSIC_FINAL.Global.TransparentButton();
            this.SuspendLayout();
            // 
            // Btn_Main
            // 
            this.Btn_Main.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.Btn_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Main.ForeColor = System.Drawing.Color.White;
            this.Btn_Main.Location = new System.Drawing.Point(0, 0);
            this.Btn_Main.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Main.Name = "Btn_Main";
            this.Btn_Main.Size = new System.Drawing.Size(270, 175);
            this.Btn_Main.TabIndex = 0;
            this.Btn_Main.Text = "button1";
            this.Btn_Main.UseVisualStyleBackColor = false;
            this.Btn_Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Btn_Main_Paint);
            this.Btn_Main.MouseEnter += new System.EventHandler(this.Btn_Main_MouseEnter);
            // 
            // Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Btn_Main);
            this.Name = "Button";
            this.Size = new System.Drawing.Size(270, 175);
            this.ResumeLayout(false);

        }

        #endregion
        private TransparentButton Btn_Main;
    }
}
