namespace MUSIC_FINAL.Forms
{
    partial class Frm_Player
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
            this.Pic_Art = new System.Windows.Forms.PictureBox();
            this.PlayerDataTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lbl_Nome = new MUSIC_FINAL.UserControls.Label();
            this.Lbl_Artista = new MUSIC_FINAL.UserControls.Label();
            this.Btn_Menu = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Biblioteca = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Controles = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Adicionar = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Capa = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Desfoque = new MUSIC_FINAL.UserControls.Button();
            this.Btn_Sair = new MUSIC_FINAL.UserControls.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Btn_Fila = new MUSIC_FINAL.UserControls.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new MUSIC_FINAL.UserControls.Button();
            this.button2 = new MUSIC_FINAL.UserControls.Button();
            this.button1 = new MUSIC_FINAL.UserControls.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SL_Musicas = new MUSIC_FINAL.UserControls.SongList();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Art)).BeginInit();
            this.PlayerDataTable.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // TittleBar_Main
            // 
            this.TittleBar_Main.Size = new System.Drawing.Size(1294, 46);
            this.TittleBar_Main.TabIndex = 1;
            this.TittleBar_Main.Title = "WinMix -  Tylor";
            // 
            // Pic_Art
            // 
            this.Pic_Art.Image = global::MUSIC_FINAL.Properties.Resources.abrar_khan_neural_connection_2__2_;
            this.Pic_Art.Location = new System.Drawing.Point(3, 3);
            this.Pic_Art.Name = "Pic_Art";
            this.Pic_Art.Size = new System.Drawing.Size(0, 277);
            this.Pic_Art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Art.TabIndex = 11;
            this.Pic_Art.TabStop = false;
            // 
            // PlayerDataTable
            // 
            this.PlayerDataTable.ColumnCount = 2;
            this.PlayerDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PlayerDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.PlayerDataTable.Controls.Add(this.Pic_Art, 0, 0);
            this.PlayerDataTable.Controls.Add(this.panel2, 1, 0);
            this.PlayerDataTable.Location = new System.Drawing.Point(3, 356);
            this.PlayerDataTable.Name = "PlayerDataTable";
            this.PlayerDataTable.RowCount = 1;
            this.PlayerDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlayerDataTable.Size = new System.Drawing.Size(635, 283);
            this.PlayerDataTable.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lbl_Nome);
            this.panel2.Controls.Add(this.Lbl_Artista);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(9, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 277);
            this.panel2.TabIndex = 12;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Nome.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Button;
            this.Lbl_Nome.BordeSize = 0;
            this.Lbl_Nome.cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Nome.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Large;
            this.Lbl_Nome.FontWeight = System.Drawing.FontStyle.Bold;
            this.Lbl_Nome.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Nome.Location = new System.Drawing.Point(0, 118);
            this.Lbl_Nome.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(0, 91);
            this.Lbl_Nome.TabIndex = 17;
            this.Lbl_Nome.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Nome.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.Lbl_Nome.Texto = "Bust Your Knee Caps";
            // 
            // Lbl_Artista
            // 
            this.Lbl_Artista.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Artista.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.ButtonText;
            this.Lbl_Artista.BordeSize = 0;
            this.Lbl_Artista.cursor = System.Windows.Forms.Cursors.Default;
            this.Lbl_Artista.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.Lbl_Artista.FontWeight = System.Drawing.FontStyle.Italic;
            this.Lbl_Artista.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Lbl_Artista.Location = new System.Drawing.Point(0, 209);
            this.Lbl_Artista.Margin = new System.Windows.Forms.Padding(0);
            this.Lbl_Artista.Name = "Lbl_Artista";
            this.Lbl_Artista.Size = new System.Drawing.Size(0, 68);
            this.Lbl_Artista.TabIndex = 18;
            this.Lbl_Artista.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Artista.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.Disabled;
            this.Lbl_Artista.Texto = "Pomplamoose";
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Menu.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Disabled;
            this.Btn_Menu.BordeSize = 1;
            this.Btn_Menu.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.Btn_Menu.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Menu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Menu.Icon = null;
            this.Btn_Menu.Location = new System.Drawing.Point(0, 6);
            this.Btn_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(56, 45);
            this.Btn_Menu.TabIndex = 17;
            this.Btn_Menu.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Menu.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.Btn_Menu.Texto = "+";
            this.Btn_Menu.OnClick += new System.EventHandler(this.Animated_OnClick);
            // 
            // Btn_Biblioteca
            // 
            this.Btn_Biblioteca.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Biblioteca.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.ButtonText;
            this.Btn_Biblioteca.BordeSize = 2;
            this.Btn_Biblioteca.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Biblioteca.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Biblioteca.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Biblioteca.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Biblioteca.Icon = null;
            this.Btn_Biblioteca.Location = new System.Drawing.Point(0, 0);
            this.Btn_Biblioteca.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Biblioteca.Name = "Btn_Biblioteca";
            this.Btn_Biblioteca.Size = new System.Drawing.Size(235, 1);
            this.Btn_Biblioteca.TabIndex = 10;
            this.Btn_Biblioteca.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Biblioteca.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.Btn_Biblioteca.Texto = "Playlists";
            this.Btn_Biblioteca.OnClick += new System.EventHandler(this.Btn_Biblioteca_OnClick);
            // 
            // Btn_Controles
            // 
            this.Btn_Controles.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Controles.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Disabled;
            this.Btn_Controles.BordeSize = 1;
            this.Btn_Controles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Controles.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Controles.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Controles.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Controles.Icon = null;
            this.Btn_Controles.Location = new System.Drawing.Point(0, 0);
            this.Btn_Controles.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Controles.Name = "Btn_Controles";
            this.Btn_Controles.Size = new System.Drawing.Size(235, 1);
            this.Btn_Controles.TabIndex = 12;
            this.Btn_Controles.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Controles.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Controles.Texto = "Controles";
            this.Btn_Controles.OnClick += new System.EventHandler(this.Btn_Controles_OnClick);
            // 
            // Btn_Adicionar
            // 
            this.Btn_Adicionar.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Adicionar.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Disabled;
            this.Btn_Adicionar.BordeSize = 1;
            this.Btn_Adicionar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Adicionar.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Adicionar.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Adicionar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Adicionar.Icon = null;
            this.Btn_Adicionar.Location = new System.Drawing.Point(0, 0);
            this.Btn_Adicionar.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Adicionar.Name = "Btn_Adicionar";
            this.Btn_Adicionar.Size = new System.Drawing.Size(235, 1);
            this.Btn_Adicionar.TabIndex = 13;
            this.Btn_Adicionar.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Adicionar.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Adicionar.Texto = "Adicionar música.";
            this.Btn_Adicionar.OnClick += new System.EventHandler(this.Btn_Adicionar_OnClick);
            // 
            // Btn_Capa
            // 
            this.Btn_Capa.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Capa.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Disabled;
            this.Btn_Capa.BordeSize = 1;
            this.Btn_Capa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Capa.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Capa.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Capa.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Capa.Icon = null;
            this.Btn_Capa.Location = new System.Drawing.Point(0, 0);
            this.Btn_Capa.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Capa.Name = "Btn_Capa";
            this.Btn_Capa.Size = new System.Drawing.Size(235, 1);
            this.Btn_Capa.TabIndex = 14;
            this.Btn_Capa.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Capa.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Capa.Texto = "Mostrar capa";
            this.Btn_Capa.OnClick += new System.EventHandler(this.Btn_Capa_OnClick);
            // 
            // Btn_Desfoque
            // 
            this.Btn_Desfoque.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Desfoque.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Disabled;
            this.Btn_Desfoque.BordeSize = 1;
            this.Btn_Desfoque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Desfoque.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Desfoque.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Desfoque.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Desfoque.Icon = null;
            this.Btn_Desfoque.Location = new System.Drawing.Point(0, 0);
            this.Btn_Desfoque.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Desfoque.Name = "Btn_Desfoque";
            this.Btn_Desfoque.Size = new System.Drawing.Size(235, 1);
            this.Btn_Desfoque.TabIndex = 15;
            this.Btn_Desfoque.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Desfoque.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.Btn_Desfoque.Texto = "Habilitar/Desabilitar Desfoque";
            this.Btn_Desfoque.OnClick += new System.EventHandler(this.Btn_Desfoque_OnClick);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Sair.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Button;
            this.Btn_Sair.BordeSize = 0;
            this.Btn_Sair.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Sair.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Sair.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Sair.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Sair.Icon = null;
            this.Btn_Sair.Location = new System.Drawing.Point(0, 0);
            this.Btn_Sair.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(235, 1);
            this.Btn_Sair.TabIndex = 16;
            this.Btn_Sair.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Sair.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.ButtonText;
            this.Btn_Sair.Texto = "Sair";
            this.Btn_Sair.OnClick += new System.EventHandler(this.Btn_Sair_OnClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Sair, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Desfoque, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Capa, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Adicionar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Controles, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Biblioteca, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 0);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // Btn_Fila
            // 
            this.Btn_Fila.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Fila.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Disabled;
            this.Btn_Fila.BordeSize = 1;
            this.Btn_Fila.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Small;
            this.Btn_Fila.FontWeight = System.Drawing.FontStyle.Bold;
            this.Btn_Fila.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Btn_Fila.Icon = null;
            this.Btn_Fila.Location = new System.Drawing.Point(0, 55);
            this.Btn_Fila.Margin = new System.Windows.Forms.Padding(0);
            this.Btn_Fila.Name = "Btn_Fila";
            this.Btn_Fila.Size = new System.Drawing.Size(56, 45);
            this.Btn_Fila.TabIndex = 21;
            this.Btn_Fila.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Fila.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.Btn_Fila.Texto = "Fila";
            this.Btn_Fila.OnClick += new System.EventHandler(this.button1_OnClick);
            this.Btn_Fila.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Btn_Menu);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.Btn_Fila);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 274);
            this.panel1.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Disabled;
            this.button3.BordeSize = 1;
            this.button3.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.button3.FontWeight = System.Drawing.FontStyle.Bold;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Icon = null;
            this.button3.Location = new System.Drawing.Point(0, 202);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 45);
            this.button3.TabIndex = 24;
            this.button3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.button3.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.button3.Texto = ">>";
            this.button3.OnClick += new System.EventHandler(this.button3_OnClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Disabled;
            this.button2.BordeSize = 1;
            this.button2.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.button2.FontWeight = System.Drawing.FontStyle.Bold;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Icon = null;
            this.button2.Location = new System.Drawing.Point(0, 153);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 45);
            this.button2.TabIndex = 23;
            this.button2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.button2.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextSecondary;
            this.button2.Texto = "III";
            this.button2.OnClick += new System.EventHandler(this.button2_OnClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Background = MUSIC_FINAL.UserControls.Base.BackColorOption.Disabled;
            this.button1.BordeSize = 1;
            this.button1.FontSizeType = MUSIC_FINAL.UserControls.Base.FontSizeOption.Button;
            this.button1.FontWeight = System.Drawing.FontStyle.Bold;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(0, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 45);
            this.button1.TabIndex = 22;
            this.button1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.button1.TextColor = MUSIC_FINAL.UserControls.Base.ColorOption.TextPrimary;
            this.button1.Texto = "<<";
            this.button1.OnClick += new System.EventHandler(this.button1_OnClick_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.PlayerDataTable, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(641, 642);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // SL_Musicas
            // 
            this.SL_Musicas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.SL_Musicas.Dock = System.Windows.Forms.DockStyle.Left;
            this.SL_Musicas.Location = new System.Drawing.Point(0, 0);
            this.SL_Musicas.Margin = new System.Windows.Forms.Padding(0);
            this.SL_Musicas.MinimumSize = new System.Drawing.Size(438, 10);
            this.SL_Musicas.Name = "SL_Musicas";
            this.SL_Musicas.Size = new System.Drawing.Size(438, 642);
            this.SL_Musicas.TabIndex = 25;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 49);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1294, 648);
            this.tableLayoutPanel3.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(650, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 642);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.SL_Musicas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(236, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(405, 642);
            this.panel4.TabIndex = 26;
            this.panel4.Visible = false;
            // 
            // Frm_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Name = "Frm_Player";
            this.Text = "";
            this.Tittle = "WinMix -  Tylor";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Load += new System.EventHandler(this.Frm_Player_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_Player_Paint);
            this.Controls.SetChildIndex(this.TittleBar_Main, 0);
            this.Controls.SetChildIndex(this.tableLayoutPanel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Art)).EndInit();
            this.PlayerDataTable.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Pic_Art;
        private System.Windows.Forms.TableLayoutPanel PlayerDataTable;
        private System.Windows.Forms.Panel panel2;
        private UserControls.Label Lbl_Artista;
        private UserControls.Label Lbl_Nome;
        private UserControls.Button Btn_Menu;
        private UserControls.Button Btn_Biblioteca;
        private UserControls.Button Btn_Controles;
        private UserControls.Button Btn_Adicionar;
        private UserControls.Button Btn_Capa;
        private UserControls.Button Btn_Desfoque;
        private UserControls.Button Btn_Sair;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UserControls.Button Btn_Fila;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UserControls.SongList SL_Musicas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private UserControls.Button button3;
        private UserControls.Button button2;
        private UserControls.Button button1;
    }
}