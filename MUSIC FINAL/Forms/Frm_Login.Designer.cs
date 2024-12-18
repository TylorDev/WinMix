
namespace MUSIC_FINAL.Forms
{
    partial class Frm_Login
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
            this.Txt_Senha = new MUSIC_FINAL.UserControls.Textbox();
            this.Txt_Nome = new MUSIC_FINAL.UserControls.Textbox();
            this.Lbl_Cadastro = new MUSIC_FINAL.UserControls.Label();
            this.Lbl_Esqueceu = new MUSIC_FINAL.UserControls.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Entrar = new MUSIC_FINAL.UserControls.Button();
            this.Lbl_Tittle = new MUSIC_FINAL.UserControls.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new MUSIC_FINAL.UserControls.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TittleBar_Main
            // 
            this.TittleBar_Main.Size = new System.Drawing.Size(1294, 46);
            this.TittleBar_Main.Title = "Login";
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
            this.Txt_Senha.Location = new System.Drawing.Point(17, 125);
            this.Txt_Senha.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_Senha.Name = "Txt_Senha";
            this.Txt_Senha.PlaceHolder = "Sua senha aqui...";
            this.Txt_Senha.Size = new System.Drawing.Size(286, 65);
            this.Txt_Senha.TabIndex = 4;
            this.Txt_Senha.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Txt_Senha.Texto = "Sua senha aqui...";
            this.Txt_Senha.Tittle = "Senha de 8 caracteres";
            this.Txt_Senha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Senha_KeyPress);
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
            this.Txt_Nome.Location = new System.Drawing.Point(17, 46);
            this.Txt_Nome.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.PlaceHolder = "Escreva seu nome aqui...";
            this.Txt_Nome.Size = new System.Drawing.Size(286, 65);
            this.Txt_Nome.TabIndex = 3;
            this.Txt_Nome.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Txt_Nome.Texto = "Escreva seu nome aqui...";
            this.Txt_Nome.Tittle = "Nome do perfil";
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
            // 
            // Lbl_Cadastro
            // 
            this.Lbl_Cadastro.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Cadastro.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Cadastro.BordeSize = 0;
            this.Lbl_Cadastro.cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Cadastro.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.Lbl_Cadastro.FontWeight = ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
            this.Lbl_Cadastro.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Cadastro.Location = new System.Drawing.Point(0, 297);
            this.Lbl_Cadastro.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Cadastro.Name = "Lbl_Cadastro";
            this.Lbl_Cadastro.Size = new System.Drawing.Size(332, 37);
            this.Lbl_Cadastro.TabIndex = 5;
            this.Lbl_Cadastro.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Cadastro.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.Lbl_Cadastro.Texto = "Não tem cadastro?";
            this.Lbl_Cadastro.OnClick += new System.EventHandler(this.label1_OnClick);
            // 
            // Lbl_Esqueceu
            // 
            this.Lbl_Esqueceu.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Esqueceu.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Esqueceu.BordeSize = 0;
            this.Lbl_Esqueceu.cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_Esqueceu.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.Lbl_Esqueceu.FontWeight = ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline)));
            this.Lbl_Esqueceu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Esqueceu.Location = new System.Drawing.Point(0, 269);
            this.Lbl_Esqueceu.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Esqueceu.Name = "Lbl_Esqueceu";
            this.Lbl_Esqueceu.Size = new System.Drawing.Size(332, 39);
            this.Lbl_Esqueceu.TabIndex = 6;
            this.Lbl_Esqueceu.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Esqueceu.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.Lbl_Esqueceu.Texto = "Esqueceu sua senha?";
            this.Lbl_Esqueceu.OnClick += new System.EventHandler(this.label2_OnClick);
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1294, 694);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Entrar);
            this.panel1.Controls.Add(this.Lbl_Tittle);
            this.panel1.Controls.Add(this.Txt_Nome);
            this.panel1.Controls.Add(this.Lbl_Esqueceu);
            this.panel1.Controls.Add(this.Txt_Senha);
            this.panel1.Controls.Add(this.Lbl_Cadastro);
            this.panel1.Location = new System.Drawing.Point(481, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 334);
            this.panel1.TabIndex = 5;
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Entrar.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Button;
            this.Btn_Entrar.BordeSize = 1;
            this.Btn_Entrar.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Entrar.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Entrar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Entrar.Icon = null;
            this.Btn_Entrar.Location = new System.Drawing.Point(80, 203);
            this.Btn_Entrar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(163, 45);
            this.Btn_Entrar.TabIndex = 8;
            this.Btn_Entrar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Entrar.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.Btn_Entrar.Texto = "Entrar";
            this.Btn_Entrar.Visible = false;
            this.Btn_Entrar.OnClick += new System.EventHandler(this.Btn_Entrar_OnClick);
            // 
            // Lbl_Tittle
            // 
            this.Lbl_Tittle.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Tittle.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.Lbl_Tittle.BordeSize = 0;
            this.Lbl_Tittle.cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Tittle.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Large;
            this.Lbl_Tittle.FontWeight = System.Drawing.FontStyle.Regular;
            this.Lbl_Tittle.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Tittle.Location = new System.Drawing.Point(119, 2);
            this.Lbl_Tittle.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Tittle.Name = "Lbl_Tittle";
            this.Lbl_Tittle.Size = new System.Drawing.Size(105, 44);
            this.Lbl_Tittle.TabIndex = 7;
            this.Lbl_Tittle.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Tittle.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Lbl_Tittle.Texto = "Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 171);
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
            this.button1.Location = new System.Drawing.Point(-3, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 0;
            this.button1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.button1.Texto = "Back";
            this.button1.OnClick += new System.EventHandler(this.button1_OnClick);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Frm_Login";
            this.Text = "Frm_Login";
            this.Tittle = "Login";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.TittleBar_Main, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.Textbox Txt_Senha;
        private UserControls.Textbox Txt_Nome;
        private UserControls.Label Lbl_Cadastro;
        private UserControls.Label Lbl_Esqueceu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private UserControls.Label Lbl_Tittle;
        private UserControls.Button Btn_Entrar;
        private System.Windows.Forms.Panel panel2;
        private UserControls.Button button1;
    }
}