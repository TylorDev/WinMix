namespace MUSIC_FINAL.UserControls
{
    partial class MusicData
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
            this.Table_name = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.table_3 = new System.Windows.Forms.TableLayoutPanel();
            this.Lbl_Nome = new MUSIC_FINAL.UserControls.Label();
            this.Sld_Volume = new MUSIC_FINAL.UserControls.Slider();
            this.Btn_Mute = new MUSIC_FINAL.UserControls.Button();
            this.Lbl_Artista = new MUSIC_FINAL.UserControls.Label();
            this.Table_name.SuspendLayout();
            this.panel1.SuspendLayout();
            this.table_3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table_name
            // 
            this.Table_name.BackColor = System.Drawing.Color.Transparent;
            this.Table_name.ColumnCount = 1;
            this.Table_name.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.Table_name.Controls.Add(this.Lbl_Nome, 0, 0);
            this.Table_name.Controls.Add(this.panel1, 0, 1);
            this.Table_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table_name.Location = new System.Drawing.Point(0, 0);
            this.Table_name.Name = "Table_name";
            this.Table_name.RowCount = 2;
            this.Table_name.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.Table_name.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Table_name.Size = new System.Drawing.Size(403, 114);
            this.Table_name.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.table_3);
            this.panel1.Controls.Add(this.Lbl_Artista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 78);
            this.panel1.TabIndex = 4;
            // 
            // table_3
            // 
            this.table_3.BackColor = System.Drawing.Color.Transparent;
            this.table_3.ColumnCount = 3;
            this.table_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.544933F));
            this.table_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.table_3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.45507F));
            this.table_3.Controls.Add(this.Sld_Volume, 1, 1);
            this.table_3.Controls.Add(this.Btn_Mute, 0, 1);
            this.table_3.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_3.Location = new System.Drawing.Point(0, 27);
            this.table_3.Name = "table_3";
            this.table_3.RowCount = 3;
            this.table_3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.table_3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.table_3.Size = new System.Drawing.Size(713, 53);
            this.table_3.TabIndex = 7;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Nome.BordeSize = 0;
            this.Lbl_Nome.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Nome.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Lbl_Nome.FontWeight = System.Drawing.FontStyle.Bold;
            this.Lbl_Nome.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Nome.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Nome.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(719, 30);
            this.Lbl_Nome.TabIndex = 3;
            this.Lbl_Nome.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Nome.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_Nome.Texto = "Resistance";
            // 
            // Sld_Volume
            // 
            this.Sld_Volume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Sld_Volume.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Sld_Volume.Location = new System.Drawing.Point(28, 17);
            this.Sld_Volume.Margin = new System.Windows.Forms.Padding(0);
            this.Sld_Volume.MaxValue = 100;
            this.Sld_Volume.Name = "Sld_Volume";
            this.Sld_Volume.Size = new System.Drawing.Size(190, 17);
            this.Sld_Volume.TabIndex = 10;
            this.Sld_Volume.Value = 80D;
            this.Sld_Volume.SplitterMoved += new System.EventHandler(this.Sld_Volume_SplitterMoved);
            this.Sld_Volume.Clicked += new System.EventHandler(this.Sld_Volume_Clicked);
            // 
            // Btn_Mute
            // 
            this.Btn_Mute.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Mute.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Btn_Mute.BordeSize = 0;
            this.Btn_Mute.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Mute.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Mute.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Mute.Icon = global::MUSIC_FINAL.Properties.Resources.volume;
            this.Btn_Mute.Location = new System.Drawing.Point(0, 17);
            this.Btn_Mute.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Mute.Name = "Btn_Mute";
            this.Btn_Mute.Size = new System.Drawing.Size(28, 17);
            this.Btn_Mute.TabIndex = 11;
            this.Btn_Mute.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Mute.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Mute.Texto = "";
            this.Btn_Mute.OnClick += new System.EventHandler(this.Btn_Mute_OnClick);
            // 
            // Lbl_Artista
            // 
            this.Lbl_Artista.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Artista.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Artista.BordeSize = 0;
            this.Lbl_Artista.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Artista.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Lbl_Artista.FontWeight = System.Drawing.FontStyle.Regular;
            this.Lbl_Artista.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Artista.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Artista.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Artista.Name = "Lbl_Artista";
            this.Lbl_Artista.Size = new System.Drawing.Size(713, 27);
            this.Lbl_Artista.TabIndex = 6;
            this.Lbl_Artista.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_Artista.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_Artista.Texto = "Lorem ipsum dolor sit";
            // 
            // MusicData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Table_name);
            this.Name = "MusicData";
            this.Size = new System.Drawing.Size(403, 114);
            this.Table_name.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.table_3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Table_name;
        public Label Lbl_Nome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel table_3;
        private Button Btn_Mute;
        public Label Lbl_Artista;
        public Slider Sld_Volume;
    }
}
