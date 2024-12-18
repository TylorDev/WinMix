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
    public partial class Progress : UserControl
    {
        public Progress()
        {
            InitializeComponent();
        }

        private async  void Sld_Progress_Clicked(object sender, EventArgs e)
        {
            if (Sld_Progress != null)
            {
                double porcentaje = (double)Sld_Progress.SplitterDistance / Sld_Progress.Width * 100; 
                int result = (int)(Sld_Progress.MaxValue * (porcentaje / 100));
                await Variaveis.SkipTo(result);

            }
            else
            {
                MessageBox.Show("NULL");
            }
        }
    }
}
