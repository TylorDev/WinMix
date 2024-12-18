using Mysqlx.Session;
using MySqlX.XDevAPI.Common;
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
    public partial class MusicData : UserControl
    {


        public MusicData()
        {
            InitializeComponent();
        }

        private async void Sld_Volume_Clicked(object sender, EventArgs e)
        {
            if (Sld_Volume != null)
            {
                double porcentaje = (double)Sld_Volume.SplitterDistance / Sld_Volume.Width * 100; 
                int result = (int)(Sld_Volume.MaxValue * (porcentaje / 100));
                Variaveis.volume=result;
                await Variaveis.SetVolume(result);

            }
            else
            {
                MessageBox.Show("NULL");
            }
        }

        private async void Sld_Volume_SplitterMoved(object sender, EventArgs e)
        {
            if (Sld_Volume != null)
            {
                double porcentaje = (double)Sld_Volume.SplitterDistance / Sld_Volume.Width * 100; 
                int result = (int)(Sld_Volume.MaxValue * (porcentaje / 100));
                Variaveis.volume = result;
                await Variaveis.SetVolume(result);

            }
            else
            {
                MessageBox.Show("NULL");
            }
        }

        bool isMute = false;
        private async void Btn_Mute_OnClick(object sender, EventArgs e)
        {
            if (isMute) {
                await Variaveis.SetVolume(100);
                isMute = false;
                Sld_Volume.Value = 100;
                Variaveis.volume = 100;
            }
            else
            {
                await Variaveis.SetVolume(0);
                isMute = true;
                Sld_Volume.Value = 0;
                Variaveis.volume = 0;
            }
        }
    }
}
