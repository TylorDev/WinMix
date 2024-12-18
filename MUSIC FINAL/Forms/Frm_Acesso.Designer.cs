namespace MUSIC_FINAL.Forms
{
    partial class Frm_Acesso
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new MUSIC_FINAL.UserControls.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new MUSIC_FINAL.UserControls.Label();
            this.label1 = new MUSIC_FINAL.UserControls.Label();
            this.Brn_Entrar = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Cadastro = new MUSIC_FINAL.UserControls.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TittleBar_Main
            // 
            this.TittleBar_Main.Size = new System.Drawing.Size(1294, 46);
            this.TittleBar_Main.Title = "Acesso";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.06303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.93697F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.38596F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.61404F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1294, 694);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Brn_Entrar);
            this.panel1.Controls.Add(this.Btn_Cadastro);
            this.panel1.Location = new System.Drawing.Point(399, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 464);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.label3.BordeSize = 0;
            this.label3.cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Large;
            this.label3.FontWeight = System.Drawing.FontStyle.Bold;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(117, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 35);
            this.label3.TabIndex = 8;
            this.label3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.label3.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.White;
            this.label3.Texto = "WinMix";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MUSIC_FINAL.Properties.Resources.logic;
            this.pictureBox1.Location = new System.Drawing.Point(201, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.label2.BordeSize = 0;
            this.label2.cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Medium;
            this.label2.FontWeight = System.Drawing.FontStyle.Regular;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Location = new System.Drawing.Point(28, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 26);
            this.label2.TabIndex = 6;
            this.label2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.White;
            this.label2.Texto = "Ouça suas músicas com qualidade de som incomparável.";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.label1.BordeSize = 0;
            this.label1.cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Large;
            this.label1.FontWeight = System.Drawing.FontStyle.Bold;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(22, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 40);
            this.label1.TabIndex = 5;
            this.label1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.label1.Texto = "Typescript + C# + Milkdrop";
            // 
            // Brn_Entrar
            // 
            this.Brn_Entrar.BackColor = System.Drawing.Color.Black;
            this.Brn_Entrar.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Button;
            this.Brn_Entrar.BordeSize = 0;
            this.Brn_Entrar.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.Brn_Entrar.FontWeight = System.Drawing.FontStyle.Regular;
            this.Brn_Entrar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Brn_Entrar.Icon = null;
            this.Brn_Entrar.Location = new System.Drawing.Point(177, 223);
            this.Brn_Entrar.Margin = new System.Windows.Forms.Padding(0);
            this.Brn_Entrar.Name = "Brn_Entrar";
            this.Brn_Entrar.Size = new System.Drawing.Size(143, 58);
            this.Brn_Entrar.TabIndex = 3;
            this.Brn_Entrar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Brn_Entrar.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.Brn_Entrar.Texto = "Entrar";
            this.Brn_Entrar.OnClick += new System.EventHandler(this.Brn_Entrar_OnClick);
            // 
            // Btn_Cadastro
            // 
            this.Btn_Cadastro.BackColor = System.Drawing.Color.Black;
            this.Btn_Cadastro.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Button;
            this.Btn_Cadastro.BordeSize = 0;
            this.Btn_Cadastro.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.Btn_Cadastro.FontWeight = System.Drawing.FontStyle.Regular;
            this.Btn_Cadastro.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Cadastro.Icon = null;
            this.Btn_Cadastro.Location = new System.Drawing.Point(177, 293);
            this.Btn_Cadastro.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Cadastro.Name = "Btn_Cadastro";
            this.Btn_Cadastro.Size = new System.Drawing.Size(143, 64);
            this.Btn_Cadastro.TabIndex = 4;
            this.Btn_Cadastro.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Cadastro.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.Btn_Cadastro.Texto = "Cadastrar-se";
            this.Btn_Cadastro.OnClick += new System.EventHandler(this.Btn_Cadastro_OnClick);
            // 
            // Frm_Acesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Frm_Acesso";
            this.Text = "Frm_Acesso";
            this.Tittle = "Acesso";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Load += new System.EventHandler(this.Frm_Acesso_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_Acesso_Paint);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.TittleBar_Main, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private UserControls.Button Brn_Entrar;
        private UserControls.Button Btn_Cadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.Label label2;
        private UserControls.Label label1;
        private UserControls.Label label3;
    }
}