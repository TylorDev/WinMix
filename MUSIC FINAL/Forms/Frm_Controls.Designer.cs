namespace MUSIC_FINAL.Forms
{
    partial class Frm_Controls
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progress1 = new MUSIC_FINAL.UserControls.Progress();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mediaButtons1 = new MUSIC_FINAL.UserControls.MediaButtons();
            musicData1 = new MUSIC_FINAL.UserControls.MusicData();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TittleBar_Main
            // 
            this.TittleBar_Main.resetButtons = true;
            this.TittleBar_Main.Size = new System.Drawing.Size(557, 30);
            this.TittleBar_Main.Title = "Github@Tylordev";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.progress1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 154);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // progress1
            // 
            this.progress1.BackColor = System.Drawing.Color.Transparent;
            this.progress1.Dock = System.Windows.Forms.DockStyle.Top;
            this.progress1.Location = new System.Drawing.Point(3, 3);
            this.progress1.Name = "progress1";
            this.progress1.Size = new System.Drawing.Size(551, 27);
            this.progress1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.mediaButtons1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(musicData1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(551, 115);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // mediaButtons1
            // 
            this.mediaButtons1.BackColor = System.Drawing.Color.Transparent;
            this.mediaButtons1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mediaButtons1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.mediaButtons1.Location = new System.Drawing.Point(0, 0);
            this.mediaButtons1.Margin = new System.Windows.Forms.Padding(0);
            this.mediaButtons1.Name = "mediaButtons1";
            this.mediaButtons1.Size = new System.Drawing.Size(320, 115);
            this.mediaButtons1.TabIndex = 0;
            // 
            // musicData1
            // 
            musicData1.BackColor = System.Drawing.Color.Transparent;
            musicData1.Location = new System.Drawing.Point(323, 3);
            musicData1.Name = "musicData1";
            musicData1.Size = new System.Drawing.Size(225, 109);
            musicData1.TabIndex = 2;
            // 
            // Frm_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(563, 190);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Frm_Controls";
            this.Text = "Frm_Controls";
            this.Tittle = "Controles";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Controls.SetChildIndex(this.TittleBar_Main, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
         public MUSIC_FINAL.UserControls.MusicData musicData1;
        public UserControls.Progress progress1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UserControls.MediaButtons mediaButtons1;
    }
}