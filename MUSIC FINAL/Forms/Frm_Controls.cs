using MUSIC_FINAL.Entities;
using MUSIC_FINAL.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL.Forms
{
    public partial class Frm_Controls :Base
    {
        public Song Song
        {
            get => Song;
            set
            {
                musicData1.Lbl_Nome.Text = value.Nome;
                musicData1.Lbl_Artista.Text = value.Autor;
                mediaButtons1.Pic_Capa.Image = value.Image;
            }
        }
        public Frm_Controls()
        {
            InitializeComponent();
            BackColor = GlobalStyles.BackgroundColor;
            TittleBar_Main.Btn_Max.Visible = false;
            TittleBar_Main.Btn_Min.Visible = false;
            TittleBar_Main.Btn_Close.OnClick += Btn_Close_OnClick;
        }

        private void Btn_Close_OnClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
