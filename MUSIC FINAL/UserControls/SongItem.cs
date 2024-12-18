using Microsoft.Web.WebView2.WinForms;
using MUSIC_FINAL.Entities;
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
using TagLib.Riff;

namespace MUSIC_FINAL.UserControls
{
    [DefaultEvent("Click")]
    public partial class SongItem : UserControl
    {
        private Song song;
        private string[] mp3Files;
        
        public SongItem(Song song, string[] files)
        {
            InitializeComponent();
            mp3Files = files;
            this.song = song;
            Lbl_Nome.OnClick += (sender, e) => OnPlay(e);
            Lbl_Autor.OnClick += (sender, e) => OnPlay(e);
            Pic_Cover.Click += (sender, e) => OnPlay(e);

            Lbl_Nome.Text = song.Nome;

            Lbl_Autor.Text= song.Autor;
            Pic_Cover.Image = song.Image;
            Lbl_Duration.Text = song.Duration.ToString(@"m\:ss");


            Variaveis.WebAudioPlayer.WebMessageReceived += WebAudioPlayer_WebMessageReceived;

        }



        private void WebAudioPlayer_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {

            if (Variaveis.isPlaying)
            {
                if (song.Nome == Variaveis.CurrentSong.Nome)
                {

                    Metadata.BackColor = GlobalStyles.Button;
                    Lbl_Autor.TextColor = Base.ColorOption.ButtonText;
                    Lbl_Nome.TextColor = Base.ColorOption.ButtonText;


                }
                else
                {
                    Metadata.BackColor = Color.Transparent;
                    Lbl_Autor.TextColor = Base.ColorOption.TextPrimary;
                    Lbl_Nome.TextColor = Base.ColorOption.TextPrimary;
                }
            }
               
            
           
        }


        new public event EventHandler Click;

        protected async virtual void OnPlay(EventArgs e)
        {
            Click?.Invoke(this, e);
            Variaveis.isPlaying=true;
            Variaveis.SongPaths.Clear();
            Variaveis.SongPaths= new List<string> (mp3Files); 
            Variaveis.CurrentSong = song;
            Variaveis.CurrentIndex = song.Index;
            await Variaveis.PlaySong(song.FilePath);
          

        }

  

    }
}
