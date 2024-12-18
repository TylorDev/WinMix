namespace MUSIC_FINAL.UserControls
{
    partial class Textbox
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
            this.Lbl_Tittle = new MUSIC_FINAL.UserControls.Label();
            this.Btn_Icon = new MUSIC_FINAL.UserControls.Button();
            this.Txt_Main = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.81818F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.Controls.Add(this.Lbl_Tittle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Icon, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Txt_Main, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.28302F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.71698F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 53);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Lbl_Tittle
            // 
            this.Lbl_Tittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Lbl_Tittle.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.ButtonText;
            this.Lbl_Tittle.BordeSize = 0;
            this.Lbl_Tittle.cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Tittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Lbl_Tittle.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Medium;
            this.Lbl_Tittle.FontWeight = System.Drawing.FontStyle.Bold;
            this.Lbl_Tittle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Tittle.Location = new System.Drawing.Point(5, 5);
            this.Lbl_Tittle.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Tittle.Name = "Lbl_Tittle";
            this.Lbl_Tittle.Size = new System.Drawing.Size(225, 19);
            this.Lbl_Tittle.TabIndex = 0;
            this.Lbl_Tittle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Lbl_Tittle.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.White;
            this.Lbl_Tittle.Texto = "Password";
            // 
            // Btn_Icon
            // 
            this.Btn_Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Icon.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Btn_Icon.BordeSize = 0;
            this.Btn_Icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Icon.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Icon.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Icon.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Icon.Icon = global::MUSIC_FINAL.Properties.Resources._2;
            this.Btn_Icon.Location = new System.Drawing.Point(230, 24);
            this.Btn_Icon.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Icon.Name = "Btn_Icon";
            this.Btn_Icon.Size = new System.Drawing.Size(51, 24);
            this.Btn_Icon.TabIndex = 1;
            this.Btn_Icon.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Icon.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Icon.Texto = "";
            this.Btn_Icon.OnClick += new System.EventHandler(this.Btn_Icon_OnClick);
            // 
            // Txt_Main
            // 
            this.Txt_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txt_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Txt_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Main.ForeColor = System.Drawing.Color.White;
            this.Txt_Main.Location = new System.Drawing.Point(5, 24);
            this.Txt_Main.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_Main.Multiline = true;
            this.Txt_Main.Name = "Txt_Main";
            this.Txt_Main.Size = new System.Drawing.Size(225, 24);
            this.Txt_Main.TabIndex = 2;
            this.Txt_Main.Text = "TextoTxtTextoText";
            this.Txt_Main.Enter += new System.EventHandler(this.Txt_Main_Enter);
            this.Txt_Main.Leave += new System.EventHandler(this.Txt_Main_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(230, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(51, 19);
            this.panel1.TabIndex = 3;
            // 
            // Textbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Textbox";
            this.Size = new System.Drawing.Size(286, 53);
            this.Load += new System.EventHandler(this.Textbox_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Btn_Icon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Txt_Main;
        private System.Windows.Forms.Panel panel1;
        private Label Lbl_Tittle;
    }
}
