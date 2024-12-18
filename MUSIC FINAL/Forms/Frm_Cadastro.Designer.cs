namespace MUSIC_FINAL.Forms
{
    partial class Frm_Cadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Txt_Nome = new MUSIC_FINAL.UserControls.Textbox();
            this.Txt_Senha = new MUSIC_FINAL.UserControls.Textbox();
            this.Lbl_Cadastro = new MUSIC_FINAL.UserControls.Label();
            this.Lbl_8 = new MUSIC_FINAL.UserControls.Label();
            this.Btn_Confirmar = new MUSIC_FINAL.UserControls.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new MUSIC_FINAL.UserControls.Button();
            this.Lbl_tem = new MUSIC_FINAL.UserControls.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TittleBar_Main
            // 
            this.TittleBar_Main.Size = new System.Drawing.Size(1294, 46);
            this.TittleBar_Main.Title = "Cadastro";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Txt_Nome);
            this.panel1.Controls.Add(this.Txt_Senha);
            this.panel1.Controls.Add(this.Lbl_Cadastro);
            this.panel1.Controls.Add(this.Lbl_8);
            this.panel1.Controls.Add(this.Btn_Confirmar);
            this.panel1.Location = new System.Drawing.Point(497, 196);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 302);
            this.panel1.TabIndex = 4;
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Nome.BorderColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.Txt_Nome.BorderThickness = 2;
            this.Txt_Nome.CornerRadius = 5;
            this.Txt_Nome.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Txt_Nome.FontWeight = System.Drawing.FontStyle.Bold;
            this.Txt_Nome.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Txt_Nome.Location = new System.Drawing.Point(7, 56);
            this.Txt_Nome.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.PlaceHolder = "Escreva seu nome aqui...";
            this.Txt_Nome.Size = new System.Drawing.Size(286, 65);
            this.Txt_Nome.TabIndex = 9;
            this.Txt_Nome.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Txt_Nome.Texto = "Escreva seu nome aqui...";
            this.Txt_Nome.Tittle = "Nome do perfil";
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
            // 
            // Txt_Senha
            // 
            this.Txt_Senha.BackColor = System.Drawing.Color.Transparent;
            this.Txt_Senha.BorderColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.Txt_Senha.BorderThickness = 2;
            this.Txt_Senha.CornerRadius = 5;
            this.Txt_Senha.Enabled = false;
            this.Txt_Senha.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Txt_Senha.FontWeight = System.Drawing.FontStyle.Bold;
            this.Txt_Senha.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Txt_Senha.Location = new System.Drawing.Point(7, 130);
            this.Txt_Senha.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PlaceHolder = "Sua senha aqui...";
            this.Txt_Senha.Size = new System.Drawing.Size(286, 65);
            this.Txt_Senha.TabIndex = 10;
            this.Txt_Senha.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Txt_Senha.Texto = "Sua senha aqui...";
            this.Txt_Senha.Tittle = "Senha de 8 caracteres";
            this.Txt_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Senha_KeyPress);
            // 
            // Lbl_Cadastro
            // 
            this.Lbl_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cadastro.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Cadastro.BordeSize = 0;
            this.Lbl_Cadastro.cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Cadastro.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Large;
            this.Lbl_Cadastro.FontWeight = System.Drawing.FontStyle.Bold;
            this.Lbl_Cadastro.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Cadastro.Location = new System.Drawing.Point(77, 10);
            this.Lbl_Cadastro.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Cadastro.Name = "Lbl_Cadastro";
            this.Lbl_Cadastro.Size = new System.Drawing.Size(155, 46);
            this.Lbl_Cadastro.TabIndex = 8;
            this.Lbl_Cadastro.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Cadastro.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_Cadastro.Texto = "Cadastro";
            // 
            // Lbl_8
            // 
            this.Lbl_8.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_8.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_8.BordeSize = 0;
            this.Lbl_8.cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_8.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Medium;
            this.Lbl_8.FontWeight = System.Drawing.FontStyle.Regular;
            this.Lbl_8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_8.Location = new System.Drawing.Point(7, 198);
            this.Lbl_8.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_8.Name = "Lbl_8";
            this.Lbl_8.Size = new System.Drawing.Size(135, 32);
            this.Lbl_8.TabIndex = 4;
            this.Lbl_8.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_8.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_8.Texto = "8 caracteres";
            // 
            // Btn_Confirmar
            // 
            this.Btn_Confirmar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Confirmar.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Button;
            this.Btn_Confirmar.BordeSize = 1;
            this.Btn_Confirmar.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Confirmar.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Confirmar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Confirmar.Icon = null;
            this.Btn_Confirmar.Location = new System.Drawing.Point(69, 230);
            this.Btn_Confirmar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Confirmar.Name = "Btn_Confirmar";
            this.Btn_Confirmar.Size = new System.Drawing.Size(163, 45);
            this.Btn_Confirmar.TabIndex = 3;
            this.Btn_Confirmar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Confirmar.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.Btn_Confirmar.Texto = "Confirmar";
            this.Btn_Confirmar.Visible = false;
            this.Btn_Confirmar.OnClick += new System.EventHandler(this.Btn_Confirmar_OnClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Lbl_tem, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1294, 694);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 187);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Button;
            this.button1.BordeSize = 0;
            this.button1.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.button1.FontWeight = System.Drawing.FontStyle.Bold;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(1, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 31);
            this.button1.TabIndex = 0;
            this.button1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.button1.Texto = "Back";
            this.button1.OnClick += new System.EventHandler(this.button1_OnClick_1);
            // 
            // Lbl_tem
            // 
            this.Lbl_tem.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_tem.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_tem.BordeSize = 0;
            this.Lbl_tem.cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_tem.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.Lbl_tem.FontWeight = ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
            this.Lbl_tem.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_tem.Location = new System.Drawing.Point(494, 501);
            this.Lbl_tem.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_tem.Name = "Lbl_tem";
            this.Lbl_tem.Size = new System.Drawing.Size(292, 43);
            this.Lbl_tem.TabIndex = 5;
            this.Lbl_tem.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_tem.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.Lbl_tem.Texto = "Ja tem cadastro?";
            this.Lbl_tem.OnClick += new System.EventHandler(this.label1_OnClick);
            // 
            // Frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.Name = "Frm_Cadastro";
            this.Text = "Frm_Cadastro";
            this.Tittle = "Cadastro";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Frm_Acesso_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.TittleBar_Main, 0);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls.Label Lbl_tem;
        private UserControls.Button Btn_Confirmar;
        private UserControls.Label Lbl_8;
        private UserControls.Label Lbl_Cadastro;
        private UserControls.Textbox Txt_Senha;
        private UserControls.Textbox Txt_Nome;
        private System.Windows.Forms.Panel panel2;
        private UserControls.Button button1;
    }
}