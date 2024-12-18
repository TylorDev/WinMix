namespace MUSIC_FINAL.Forms
{
    partial class ListOption
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Name = new MUSIC_FINAL.UserControls.Button();
            this.Lbl_data = new MUSIC_FINAL.UserControls.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Pic_1 = new System.Windows.Forms.PictureBox();
            this.Pic_2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.25514F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.74486F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(307, 243);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.Btn_Name, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Lbl_data, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 161);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 82);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // Btn_Name
            // 
            this.Btn_Name.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Name.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Button;
            this.Btn_Name.BordeSize = 0;
            this.Btn_Name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Name.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Large;
            this.Btn_Name.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Name.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Name.Icon = null;
            this.Btn_Name.Location = new System.Drawing.Point(0, 0);
            this.Btn_Name.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Name.Name = "Btn_Name";
            this.Btn_Name.Size = new System.Drawing.Size(307, 41);
            this.Btn_Name.TabIndex = 1;
            this.Btn_Name.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Name.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.Btn_Name.Texto = "Heavy Metal";
            // 
            // Lbl_data
            // 
            this.Lbl_data.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_data.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.ButtonText;
            this.Lbl_data.BordeSize = 0;
            this.Lbl_data.cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_data.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Lbl_data.FontWeight = System.Drawing.FontStyle.Italic;
            this.Lbl_data.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_data.Location = new System.Drawing.Point(0, 41);
            this.Lbl_data.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_data.Name = "Lbl_data";
            this.Lbl_data.Size = new System.Drawing.Size(307, 41);
            this.Lbl_data.TabIndex = 0;
            this.Lbl_data.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.Lbl_data.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.Disabled;
            this.Lbl_data.Texto = "Esta lista tiene 51 tracks y dura01:05:30";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.41936F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.58064F));
            this.tableLayoutPanel1.Controls.Add(this.Pic_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pic_2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 161);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // Pic_1
            // 
            this.Pic_1.BackColor = System.Drawing.Color.Transparent;
            this.Pic_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pic_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic_1.Image = global::MUSIC_FINAL.Properties.Resources.bowsette_by_kawacy_dcowgqt__2_;
            this.Pic_1.Location = new System.Drawing.Point(0, 0);
            this.Pic_1.Margin = new System.Windows.Forms.Padding(0);
            this.Pic_1.Name = "Pic_1";
            this.Pic_1.Size = new System.Drawing.Size(237, 161);
            this.Pic_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_1.TabIndex = 0;
            this.Pic_1.TabStop = false;
            // 
            // Pic_2
            // 
            this.Pic_2.BackColor = System.Drawing.Color.Black;
            this.Pic_2.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pic_2.Image = global::MUSIC_FINAL.Properties.Resources.s5;
            this.Pic_2.Location = new System.Drawing.Point(243, 0);
            this.Pic_2.Margin = new System.Windows.Forms.Padding(0);
            this.Pic_2.Name = "Pic_2";
            this.Pic_2.Size = new System.Drawing.Size(64, 161);
            this.Pic_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_2.TabIndex = 3;
            this.Pic_2.TabStop = false;
            // 
            // ListOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListOption";
            this.Size = new System.Drawing.Size(307, 243);
            this.Load += new System.EventHandler(this.ListOption_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UserControls.Button Btn_Name;
        private UserControls.Label Lbl_data;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox Pic_1;
        private System.Windows.Forms.PictureBox Pic_2;
    }
}
