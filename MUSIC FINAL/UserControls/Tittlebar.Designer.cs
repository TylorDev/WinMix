namespace MUSIC_FINAL.UserControls
{
    partial class Tittlebar
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
            this.Btn_Max = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Min = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Close = new MUSIC_FINAL.UserControls.Button();
            this.Lbl_Tittle = new MUSIC_FINAL.UserControls.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Max, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Min, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Close, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(359, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(140, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Btn_Max
            // 
            this.Btn_Max.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Max.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Btn_Max.BordeSize = 0;
            this.Btn_Max.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Max.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Max.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Max.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Max.Icon = null;
            this.Btn_Max.Location = new System.Drawing.Point(46, 0);
            this.Btn_Max.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Max.MinimumSize = new System.Drawing.Size(45, 45);
            this.Btn_Max.Name = "Btn_Max";
            this.Btn_Max.Size = new System.Drawing.Size(46, 52);
            this.Btn_Max.TabIndex = 2;
            this.Btn_Max.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Max.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Max.Texto = "[ ]";
            this.Btn_Max.OnClick += new System.EventHandler(this.Btn_Max_Click);
            // 
            // Btn_Min
            // 
            this.Btn_Min.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Min.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Btn_Min.BordeSize = 0;
            this.Btn_Min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Min.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Min.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Min.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Min.Icon = null;
            this.Btn_Min.Location = new System.Drawing.Point(0, 0);
            this.Btn_Min.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Min.MinimumSize = new System.Drawing.Size(45, 45);
            this.Btn_Min.Name = "Btn_Min";
            this.Btn_Min.Size = new System.Drawing.Size(46, 52);
            this.Btn_Min.TabIndex = 1;
            this.Btn_Min.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Min.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Min.Texto = "--";
            this.Btn_Min.OnClick += new System.EventHandler(this.Btn_Min_OnClick);
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Close.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Btn_Close.BordeSize = 0;
            this.Btn_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Close.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Close.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Close.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Close.Icon = null;
            this.Btn_Close.Location = new System.Drawing.Point(92, 0);
            this.Btn_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Close.MinimumSize = new System.Drawing.Size(45, 45);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(48, 52);
            this.Btn_Close.TabIndex = 0;
            this.Btn_Close.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Close.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Close.Texto = "X";
            this.Btn_Close.OnClick += new System.EventHandler(this.Btn_Close_Click);
            // 
            // Lbl_Tittle
            // 
            this.Lbl_Tittle.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Tittle.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Tittle.BordeSize = 0;
            this.Lbl_Tittle.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Medium;
            this.Lbl_Tittle.FontWeight = System.Drawing.FontStyle.Regular;
            this.Lbl_Tittle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Tittle.Location = new System.Drawing.Point(52, 0);
            this.Lbl_Tittle.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Tittle.Name = "Lbl_Tittle";
            this.Lbl_Tittle.Size = new System.Drawing.Size(304, 52);
            this.Lbl_Tittle.TabIndex = 1;
            this.Lbl_Tittle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Tittle.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_Tittle.Texto = "Lorem Ipsum dolor sit amet epsum amarar setump";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.71472F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.28529F));
            this.tableLayoutPanel2.Controls.Add(this.Lbl_Tittle, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(356, 52);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MUSIC_FINAL.Properties.Resources.logic;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Tittlebar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Tittlebar";
            this.Size = new System.Drawing.Size(499, 52);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Label Lbl_Tittle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Button Btn_Max;
        public Button Btn_Min;
        public Button Btn_Close;
    }
}
