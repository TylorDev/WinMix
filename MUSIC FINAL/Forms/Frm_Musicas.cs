using MUSIC_FINAL.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL.Forms
{
    public partial class Frm_Musicas : Base
    {
        public Frm_Musicas()
        {
            InitializeComponent();
            TittleBar_Main.disableClose = true;
            TittleBar_Main.Btn_Close.OnClick += Btn_Close_OnClick;
            TittleBar_Main.Btn_Max.Enabled = false;
        }

        private void Btn_Close_OnClick(object sender, EventArgs e)
        {
            this.Close();
            Variaveis.frm_Player.Show();
        }

        private async void Frm_Musicas_Load(object sender, EventArgs e)
        {
            InitializeWebBackground("http://localhost:5173/", sender, e);
            Variaveis.WebAudioPlayer.Source = new Uri("http://localhost:5173/", UriKind.Absolute);
            //Variaveis.WebAudioPlayer.WebMessageReceived += musica_WebMessageReceived;
            await Variaveis.Blur(true);
        }

        private void OpenMusicFolder(string folderName, object sender)
        {

                ListOption list0 = sender as ListOption;
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Music", folderName);

            if (Directory.Exists(folderPath))
            {
                string[] mp3Files = Directory.GetFiles(folderPath, "*.mp3");

                if (mp3Files.Length > 0)
                {
                    Frm_List list = new Frm_List(mp3Files, list0.Nome);
                    list.frm = this;
                    list.Show();
                    this.Hide();
                    Variaveis.CurrentIndex = 0;
                }
                else
                {
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("error.");
            }
        }


        private void listOption12_OnClick(object sender, EventArgs e)
        {
        
            OpenMusicFolder("1", sender);
        }
        private void listOption8_OnClick(object sender, EventArgs e)
        {
            OpenMusicFolder("2", sender);
        }
        private void listOption5_OnClick(object sender, EventArgs e)
        {
            OpenMusicFolder("3", sender);
        }
        private void listOption4_OnClick(object sender, EventArgs e)
        {

            OpenMusicFolder("4", sender);
        }
        private void listOption3_OnClick(object sender, EventArgs e)
        {
            OpenMusicFolder("5", sender);
        }
        private void listOption9_OnClick(object sender, EventArgs e)
        {
            OpenMusicFolder("6", sender);
        }

        private void listOption1_OnClick(object sender, EventArgs e)
        {
            OpenMusicFolder("7", sender);
        }

   
        private void listOption2_OnClick(object sender, EventArgs e)
        {
            OpenMusicFolder("8", sender);
        }
        private void listOption11_OnClick(object sender, EventArgs e)
        {
            OpenMusicFolder("9", sender);
        }
        private void listOption10_OnClick(object sender, EventArgs e)
        {
            OpenMusicFolder("10", sender);
        }

        private void listOption7_OnClick(object sender, EventArgs e)
        {
            OpenMusicFolder("11", sender);
        }
        private void listOption6_OnClick(object sender, EventArgs e)
        {
            OpenMusicFolder("12", sender);
        }

       
    }
}
