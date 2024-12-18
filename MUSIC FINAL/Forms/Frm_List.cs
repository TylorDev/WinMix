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
    public partial class Frm_List : Base
    {
        private string[] list;
        public Frm_Musicas frm;
        public Frm_List(string[] list, string name)
        {
            InitializeComponent();
            this.list = list;
            var(totalSongs, totalDuration, randomImages) = SL_List.AddSongItems(list);


            
            Lbl_ListName.Text = name;
            Lbl_Tracks.Text = $"{totalSongs} tracks";
            Lbl_ListDuration.Text = $"{totalDuration.Hours:D2} horas y {totalDuration.Minutes:D2} minutos.";
            Pic_1.Image = randomImages[0];
            Pic_2.Image = randomImages[1];
            Pic_3.Image = randomImages[2];
            Pic_4.Image = randomImages[3];

            TittleBar_Main.disableClose= true;
            TittleBar_Main.Btn_Close.OnClick += Btn_Close_OnClick;

        }

        private async void Btn_Close_OnClick(object sender, EventArgs e)
        {
            this.Close();
     
            Variaveis.frm_Player.Show();
            await Variaveis.Blur(false);

        }

        private async void TittleBar_Main_Load(object sender, EventArgs e)
        {
            InitializeWebBackground("http://localhost:5173/", sender, e);
            if (Variaveis.WebAudioPlayer.CoreWebView2 != null)
            {
                Variaveis.WebAudioPlayer.Source = new Uri("http://localhost:5173/", UriKind.Absolute);
                //Variaveis.WebAudioPlayer.WebMessageReceived += musica_WebMessageReceived;

                await Variaveis.Blur(true);
            }
        }

        private async void Btn_Play_OnClick(object sender, EventArgs e)
        {
            if (list != null)
            Variaveis.SongPaths.Clear();
            Variaveis.SongPaths = new List<string>(list);
            Variaveis.CurrentSong = Variaveis.GetMetadata(list[0]);
           await Variaveis.PlaySong(list[0]);
        }

        private void button1_OnClick(object sender, EventArgs e)
        {
            if (frm != null)
            {
                frm.Show();
                this.Close();
            }
        
          
        }
    }
}
