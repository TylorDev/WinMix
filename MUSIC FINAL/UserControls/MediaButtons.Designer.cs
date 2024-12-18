namespace MUSIC_FINAL.UserControls
{
    partial class MediaButtons
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
            this.Table_Cover = new System.Windows.Forms.TableLayoutPanel();
            this.Pic_Capa = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Prev = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Next = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Play = new MUSIC_FINAL.UserControls.Button();
            this.Table_Controls = new System.Windows.Forms.TableLayoutPanel();
            this.Table_Cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Capa)).BeginInit();
            this.panel1.SuspendLayout();
            this.Table_Controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_Cover
            // 
            this.Table_Cover.ColumnCount = 2;
            this.Table_Cover.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.17391F));
            this.Table_Cover.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.82609F));
            this.Table_Cover.Controls.Add(this.Table_Controls, 0, 0);
            this.Table_Cover.Controls.Add(this.Pic_Capa, 1, 0);
            this.Table_Cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Cover.Location = new System.Drawing.Point(0, 0);
            this.Table_Cover.Name = "Table_Cover";
            this.Table_Cover.RowCount = 1;
            this.Table_Cover.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_Cover.Size = new System.Drawing.Size(413, 199);
            this.Table_Cover.TabIndex = 16;
            // 
            // Pic_Capa
            // 
            this.Pic_Capa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic_Capa.Image = global::MUSIC_FINAL.Properties.Resources.chun_lo_astro_2__2_;
            this.Pic_Capa.Location = new System.Drawing.Point(218, 3);
            this.Pic_Capa.Name = "Pic_Capa";
            this.Pic_Capa.Size = new System.Drawing.Size(192, 193);
            this.Pic_Capa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Capa.TabIndex = 4;
            this.Pic_Capa.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Play);
            this.panel1.Controls.Add(this.Btn_Next);
            this.panel1.Controls.Add(this.Btn_Prev);
            this.panel1.Location = new System.Drawing.Point(25, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 70);
            this.panel1.TabIndex = 16;
            // 
            // Btn_Prev
            // 
            this.Btn_Prev.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Prev.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Btn_Prev.BordeSize = 0;
            this.Btn_Prev.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Prev.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Prev.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Prev.Icon = global::MUSIC_FINAL.Properties.Resources.previous;
            this.Btn_Prev.Location = new System.Drawing.Point(8, 22);
            this.Btn_Prev.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Prev.Name = "Btn_Prev";
            this.Btn_Prev.Size = new System.Drawing.Size(30, 30);
            this.Btn_Prev.TabIndex = 2;
            this.Btn_Prev.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Prev.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Prev.Texto = "";
            this.Btn_Prev.OnClick += new System.EventHandler(this.Btn_Prev_OnClick);
            // 
            // Btn_Next
            // 
            this.Btn_Next.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Next.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Btn_Next.BordeSize = 0;
            this.Btn_Next.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Next.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Next.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Next.Icon = global::MUSIC_FINAL.Properties.Resources.next;
            this.Btn_Next.Location = new System.Drawing.Point(115, 23);
            this.Btn_Next.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Next.Name = "Btn_Next";
            this.Btn_Next.Size = new System.Drawing.Size(30, 30);
            this.Btn_Next.TabIndex = 1;
            this.Btn_Next.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Next.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Next.Texto = "";
            this.Btn_Next.OnClick += new System.EventHandler(this.Btn_Next_OnClick);
            // 
            // Btn_Play
            // 
            this.Btn_Play.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Play.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Btn_Play.BordeSize = 0;
            this.Btn_Play.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Play.FontWeight = System.Drawing.FontStyle.Regular;
            this.Btn_Play.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Play.Icon = global::MUSIC_FINAL.Properties.Resources.pause;
            this.Btn_Play.Location = new System.Drawing.Point(48, 6);
            this.Btn_Play.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Play.Name = "Btn_Play";
            this.Btn_Play.Size = new System.Drawing.Size(60, 60);
            this.Btn_Play.TabIndex = 0;
            this.Btn_Play.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Play.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Play.Texto = "";
            this.Btn_Play.OnClick += new System.EventHandler(this.Btn_Play_OnClick);
            // 
            // Table_Controls
            // 
            this.Table_Controls.ColumnCount = 3;
            this.Table_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.06557F));
            this.Table_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_Controls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.93443F));
            this.Table_Controls.Controls.Add(this.panel1, 1, 1);
            this.Table_Controls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_Controls.Location = new System.Drawing.Point(3, 3);
            this.Table_Controls.Name = "Table_Controls";
            this.Table_Controls.RowCount = 3;
            this.Table_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_Controls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table_Controls.Size = new System.Drawing.Size(209, 193);
            this.Table_Controls.TabIndex = 17;
            // 
            // MediaButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Table_Cover);
            this.Name = "MediaButtons";
            this.Size = new System.Drawing.Size(413, 199);
            this.Table_Cover.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Capa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.Table_Controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table_Cover;
        public System.Windows.Forms.PictureBox Pic_Capa;
        private System.Windows.Forms.TableLayoutPanel Table_Controls;
        private System.Windows.Forms.Panel panel1;
        private Button Btn_Play;
        private Button Btn_Next;
        private Button Btn_Prev;
    }
}
