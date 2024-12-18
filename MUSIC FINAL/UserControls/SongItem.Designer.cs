namespace MUSIC_FINAL.UserControls
{
    partial class SongItem
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
            this.Metadata = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Nome = new MUSIC_FINAL.UserControls.Label();
            this.Lbl_Autor = new MUSIC_FINAL.UserControls.Label();
            this.Pic_Cover = new System.Windows.Forms.PictureBox();
            this.Main = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Duration = new MUSIC_FINAL.UserControls.Label();
            this.Metadata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cover)).BeginInit();
            this.Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Metadata
            // 
            this.Metadata.BackColor = System.Drawing.Color.Transparent;
            this.Metadata.ColumnCount = 1;
            this.Metadata.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Metadata.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.Metadata.Controls.Add(this.Lbl_Nome, 0, 0);
            this.Metadata.Controls.Add(this.Lbl_Autor, 0, 1);
            this.Metadata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Metadata.Location = new System.Drawing.Point(66, 0);
            this.Metadata.Margin = new System.Windows.Forms.Padding(0);
            this.Metadata.Name = "Metadata";
            this.Metadata.RowCount = 2;
            this.Metadata.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.Metadata.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.Metadata.Size = new System.Drawing.Size(290, 67);
            this.Metadata.TabIndex = 0;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Nome.BordeSize = 0;
            this.Lbl_Nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Nome.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Medium;
            this.Lbl_Nome.FontWeight = System.Drawing.FontStyle.Regular;
            this.Lbl_Nome.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Nome.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Nome.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(290, 34);
            this.Lbl_Nome.TabIndex = 0;
            this.Lbl_Nome.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Nome.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_Nome.Texto = "KICK BACK LOREM IPSUM DOLOR";
            // 
            // Lbl_Autor
            // 
            this.Lbl_Autor.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Autor.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Autor.BordeSize = 0;
            this.Lbl_Autor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Autor.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Medium;
            this.Lbl_Autor.FontWeight = System.Drawing.FontStyle.Italic;
            this.Lbl_Autor.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Autor.Location = new System.Drawing.Point(0, 34);
            this.Lbl_Autor.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Autor.Name = "Lbl_Autor";
            this.Lbl_Autor.Size = new System.Drawing.Size(290, 33);
            this.Lbl_Autor.TabIndex = 1;
            this.Lbl_Autor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Autor.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_Autor.Texto = "Kenshi Yonezu ipsum atmet remix";
            // 
            // Pic_Cover
            // 
            this.Pic_Cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic_Cover.Image = global::MUSIC_FINAL.Properties.Resources.chun_lo_astro_2__2_;
            this.Pic_Cover.Location = new System.Drawing.Point(3, 3);
            this.Pic_Cover.Name = "Pic_Cover";
            this.Pic_Cover.Size = new System.Drawing.Size(60, 61);
            this.Pic_Cover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Cover.TabIndex = 2;
            this.Pic_Cover.TabStop = false;
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.Black;
            this.Main.BackgroundImage = global::MUSIC_FINAL.Properties.Resources.tra3;
            this.Main.ColumnCount = 3;
            this.Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Main.Controls.Add(this.Lbl_Duration, 2, 0);
            this.Main.Controls.Add(this.Pic_Cover, 0, 0);
            this.Main.Controls.Add(this.Metadata, 1, 0);
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.RowCount = 1;
            this.Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Main.Size = new System.Drawing.Size(408, 67);
            this.Main.TabIndex = 0;
          
            // 
            // Lbl_Duration
            // 
            this.Lbl_Duration.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Duration.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Duration.BordeSize = 0;
            this.Lbl_Duration.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Lbl_Duration.FontWeight = System.Drawing.FontStyle.Bold;
            this.Lbl_Duration.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Duration.Location = new System.Drawing.Point(356, 0);
            this.Lbl_Duration.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Duration.Name = "Lbl_Duration";
            this.Lbl_Duration.Size = new System.Drawing.Size(52, 67);
            this.Lbl_Duration.TabIndex = 3;
            this.Lbl_Duration.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Duration.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_Duration.Texto = "4:08";
            // 
            // SongItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Main);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SongItem";
            this.Size = new System.Drawing.Size(408, 67);
            this.Metadata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cover)).EndInit();
            this.Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Metadata;
        private Label Lbl_Nome;
        private Label Lbl_Autor;
        private Label Lbl_Duration;
        private System.Windows.Forms.PictureBox Pic_Cover;
        private System.Windows.Forms.TableLayoutPanel Main;
    }
}
