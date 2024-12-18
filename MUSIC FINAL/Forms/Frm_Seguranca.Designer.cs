
namespace MUSIC_FINAL.Forms
{
    partial class Frm_Seguranca
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
            this.Txt_ConfirmarSenha = new MUSIC_FINAL.UserControls.Textbox();
            this.Txt_NovaSenha = new MUSIC_FINAL.UserControls.Textbox();
            this.Btn_Salvar = new MUSIC_FINAL.UserControls.Button();
            this.Txt_Nome = new MUSIC_FINAL.UserControls.Textbox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new MUSIC_FINAL.UserControls.Label();
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
            this.TittleBar_Main.Title = "Segurança";
            // 
            // Txt_ConfirmarSenha
            // 
            this.Txt_ConfirmarSenha.BackColor = System.Drawing.Color.Transparent;
            this.Txt_ConfirmarSenha.BorderColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.Txt_ConfirmarSenha.BorderThickness = 2;
            this.Txt_ConfirmarSenha.CornerRadius = 5;
            this.Txt_ConfirmarSenha.Enabled = false;
            this.Txt_ConfirmarSenha.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Txt_ConfirmarSenha.FontWeight = System.Drawing.FontStyle.Bold;
            this.Txt_ConfirmarSenha.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Txt_ConfirmarSenha.Location = new System.Drawing.Point(22, 217);
            this.Txt_ConfirmarSenha.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_ConfirmarSenha.Name = "Txt_ConfirmarSenha";
            this.Txt_ConfirmarSenha.PlaceHolder = "Digite a senha novamente...";
            this.Txt_ConfirmarSenha.Size = new System.Drawing.Size(286, 65);
            this.Txt_ConfirmarSenha.TabIndex = 2;
            this.Txt_ConfirmarSenha.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Txt_ConfirmarSenha.Texto = "Digite a senha novamente...";
            this.Txt_ConfirmarSenha.Tittle = "Confirmar Senha";
            this.Txt_ConfirmarSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ConfirmarSenha_KeyPress);
            // 
            // Txt_NovaSenha
            // 
            this.Txt_NovaSenha.BackColor = System.Drawing.Color.Transparent;
            this.Txt_NovaSenha.BorderColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.Txt_NovaSenha.BorderThickness = 2;
            this.Txt_NovaSenha.CornerRadius = 5;
            this.Txt_NovaSenha.Enabled = false;
            this.Txt_NovaSenha.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Txt_NovaSenha.FontWeight = System.Drawing.FontStyle.Bold;
            this.Txt_NovaSenha.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Txt_NovaSenha.Location = new System.Drawing.Point(22, 146);
            this.Txt_NovaSenha.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_NovaSenha.Name = "Txt_NovaSenha";
            this.Txt_NovaSenha.PlaceHolder = "Nova senha de 8 caracteres..";
            this.Txt_NovaSenha.Size = new System.Drawing.Size(286, 64);
            this.Txt_NovaSenha.TabIndex = 3;
            this.Txt_NovaSenha.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Txt_NovaSenha.Texto = "Nova senha de 8 caracteres..";
            this.Txt_NovaSenha.Tittle = "Nova senha";
            this.Txt_NovaSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_NovaSenha_KeyPress);
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Salvar.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Button;
            this.Btn_Salvar.BordeSize = 1;
            this.Btn_Salvar.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.Btn_Salvar.FontWeight = System.Drawing.FontStyle.Regular;
            this.Btn_Salvar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Salvar.Icon = null;
            this.Btn_Salvar.Location = new System.Drawing.Point(78, 289);
            this.Btn_Salvar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(191, 54);
            this.Btn_Salvar.TabIndex = 4;
            this.Btn_Salvar.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Salvar.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.Btn_Salvar.Texto = "Salvar";
            this.Btn_Salvar.Visible = false;
            this.Btn_Salvar.OnClick += new System.EventHandler(this.Btn_Salvar_OnClick);
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
            this.Txt_Nome.Location = new System.Drawing.Point(22, 72);
            this.Txt_Nome.Margin = new System.Windows.Forms.Padding(0);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.PlaceHolder = "Digite seu nome...";
            this.Txt_Nome.Size = new System.Drawing.Size(286, 65);
            this.Txt_Nome.TabIndex = 1;
            this.Txt_Nome.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Txt_Nome.Texto = "Digite seu nome...";
            this.Txt_Nome.Tittle = "Nome do perfil";
            this.Txt_Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nome_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1294, 648);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_Nome);
            this.panel1.Controls.Add(this.Txt_ConfirmarSenha);
            this.panel1.Controls.Add(this.Btn_Salvar);
            this.panel1.Controls.Add(this.Txt_NovaSenha);
            this.panel1.Location = new System.Drawing.Point(480, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 350);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.trasparent;
            this.label3.BordeSize = 0;
            this.label3.cursor = System.Windows.Forms.Cursors.Default;
            this.label3.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Large;
            this.label3.FontWeight = System.Drawing.FontStyle.Regular;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Location = new System.Drawing.Point(89, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 46);
            this.label3.TabIndex = 8;
            this.label3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.label3.Texto = "Segurança";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 140);
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
            this.button1.Location = new System.Drawing.Point(-3, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 25);
            this.button1.TabIndex = 0;
            this.button1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.button1.Texto = "Back";
            this.button1.OnClick += new System.EventHandler(this.button1_OnClick);
            // 
            // Frm_Seguranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Frm_Seguranca";
            this.Text = "";
            this.Tittle = "Segurança";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Load += new System.EventHandler(this.Frm_Seguranca_Load);
            this.Controls.SetChildIndex(this.TittleBar_Main, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private UserControls.Textbox Txt_ConfirmarSenha;
        private UserControls.Textbox Txt_NovaSenha;
        private UserControls.Button Btn_Salvar;
        private UserControls.Textbox Txt_Nome;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private UserControls.Label label3;
        private System.Windows.Forms.Panel panel2;
        private UserControls.Button button1;
    }
}