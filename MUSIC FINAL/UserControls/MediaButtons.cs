using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL.UserControls
{
    public partial class MediaButtons : Base
    {
        public MediaButtons()
        {
            InitializeComponent();
        }

        private async void Btn_Prev_OnClick(object sender, EventArgs e)
        {
        
            await Variaveis.Prev();

        }

        private async void Btn_Play_OnClick(object sender, EventArgs e)
        {
            await Variaveis.btnPlay();
            if (Variaveis.isPlaying)
            {
                Btn_Play.Icon = Properties.Resources.pause;
            }
            else
            {
                Btn_Play.Icon = Properties.Resources.play;
            }
   
        }

        private async void Btn_Next_OnClick(object sender, EventArgs e)
        {
            await Variaveis.Next();
        }
    }
}
