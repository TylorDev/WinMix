namespace MUSIC_FINAL.UserControls
{
    partial class Label
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Main = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Btn_Main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 134);
            this.panel1.TabIndex = 1;
            // 
            // Btn_Main
            // 
            this.Btn_Main.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Main.Cursor = System.Windows.Forms.Cursors.Default;
            this.Btn_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Main.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Btn_Main.FlatAppearance.BorderSize = 0;
            this.Btn_Main.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Main.Location = new System.Drawing.Point(0, 0);
            this.Btn_Main.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Main.Name = "Btn_Main";
            this.Btn_Main.Size = new System.Drawing.Size(824, 134);
            this.Btn_Main.TabIndex = 0;
            this.Btn_Main.Text = "Lorem Ipsum dolor sit amet epsum amarar setump";
            this.Btn_Main.UseVisualStyleBackColor = false;
            this.Btn_Main.MouseEnter += new System.EventHandler(this.Btn_Main_MouseEnter);
            this.Btn_Main.MouseLeave += new System.EventHandler(this.Btn_Main_MouseLeave);
            this.Btn_Main.MouseHover += new System.EventHandler(this.Btn_Main_MouseHover);
            // 
            // Label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Label";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button Btn_Main;
    }
}
