using Google.Protobuf.WellKnownTypes;
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
    [DefaultEvent("OnClick")]
    public partial class ListOption : UserControl
    {



        [Category(".Props")]
        public Image Cover {  get=>Pic_1.Image; set 
            
            { 
                Pic_1.Image = value;
                BackgroundImage = value;
                BackgroundImageLayout = ImageLayout.Stretch;
                Btn_Name.OnClick += (sender, e) => OnOptionClick(e);
            } 
        
        }
        [Category(".Props")]
        public Image Sign { get => Pic_2.Image; set { Pic_2.Image = value; } }
        [Category(".Props")]
        public string Nome { get=>Btn_Name.Text; set { Btn_Name.Text = value; } }

        [Category(".Props")]
        public string Data { get=>Lbl_data.Text; set { Lbl_data.Text = value; } }
        public ListOption()
        {
            InitializeComponent();
        }
        new public event EventHandler OnClick;
        protected virtual void OnOptionClick(EventArgs e)
        {
            OnClick?.Invoke(this, e);
       
        }

        private void ListOption_Load(object sender, EventArgs e)
        {
            BackgroundImage = Cover;
            BackgroundImageLayout = ImageLayout.Stretch;
            Data = "??? WinMix ??? @Tylodev on github";
        }
    }
}
