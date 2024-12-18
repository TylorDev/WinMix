using Google.Protobuf.WellKnownTypes;
using Microsoft.Web.WebView2.Core;
using MUSIC_FINAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL.UserControls
{
    public partial class Controls : UserControl
    {



        public string Duration
        {
            get => progress1.Lbl_Duration.Text;
            set => progress1.Lbl_Duration.Text = value;

        }
        public string Progress
        {
            get => progress1.Lbl_Progress.Text;
            set => progress1.Lbl_Progress.Text = value;

        }

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


        public Controls()
        {
            InitializeComponent();

        }

 

        
    }
}
