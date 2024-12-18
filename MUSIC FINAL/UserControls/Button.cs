using MUSIC_FINAL.Global;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL.UserControls
{
    [DefaultEvent("OnClick")]
    public partial class Button : Base
    {
     
        #region Props

        ColorOption textColor;
        [Category(".Text Properties")]
        public ColorOption TextColor
        {
            get => textColor;
            set
            {
                textColor = value;
                ApplyTextColor(Btn_Main, textColor);
            }
        }
        [Category(".Text Properties")]
        new public string Text
        {
            get => Btn_Main.Text;
            set => Btn_Main.Text = value;
        }
        [Category(".Text Properties")]
        public string Texto
        {
            get => Btn_Main.Text;
            set => Btn_Main.Text = value;
        }
        [Category(".Text Properties")]
        public FontStyle FontWeight
        {
            get => Btn_Main.Font.Style;
            set => Btn_Main.Font = new Font(Btn_Main.Font, value);
        }
        private FontSizeOption _fontSize;
        [Category(".Text Properties")]
        public FontSizeOption FontSizeType
        {
            get => _fontSize;
            set
            {
                _fontSize = value;
                ApplyFontSize(Btn_Main, _fontSize);
            }
        }

        [Category(".Text Properties")]
        public ContentAlignment TextAlignment
        {
            get => Btn_Main.TextAlign;
            set => Btn_Main.TextAlign = value;
        }

        private BackColorOption _backcolor;

        [Category(".Custom Properties")]
        public BackColorOption Background
        {
            get => _backcolor;
            set
            {
                _backcolor = value;
                ApplyBackColor(Btn_Main, _backcolor);
            }
        }
        [Category(".Custom Properties")]
        public int BordeSize
        {
            get => Btn_Main.FlatAppearance.BorderSize;
            set
            {
                Btn_Main.FlatAppearance.BorderSize = value;
            }
        }
        [Category(".Custom Properties")]
        public Image Icon
        {
            get => Btn_Main.BackgroundImage;
            set
            {
                Btn_Main.BackgroundImage = value;
            }
        }

        #endregion
        public Button()
        {
            InitializeComponent();
            Btn_Main.BackColor =  GlobalStyles.Button;
            Btn_Main.ForeColor =  GlobalStyles.ButtonText;
            
            Btn_Main.MouseDown += (sender, e) => MyMouseDown(e);
            Btn_Main.BackgroundImageLayout = ImageLayout.Zoom;
            Btn_Main.FlatAppearance.MouseDownBackColor =  GlobalStyles.TextPrimary;
            Btn_Main.Click += (sender, e) => OnMiBotonClick(e);

        }


        new public event EventHandler OnClick;
        new public event EventHandler OnMouseDown;


       
        protected virtual void OnMiBotonClick(EventArgs e)
        {
            OnClick?.Invoke(this, e);
            PlayHoverSound("./sfx/click.wav");

        }

        protected virtual void MyMouseDown(EventArgs e)
        {
            OnMouseDown?.Invoke(this, e);

        }
        

        private List<WaveOutEvent> activeOutputs = new List<WaveOutEvent>();

        private void PlayHoverSound(string soundPath)
        {
            try
            {
                var audioFile = new AudioFileReader(soundPath) 
                {
                
                    Volume =0.1f,
                };
                var outputDevice = new WaveOutEvent();
                outputDevice.Init(audioFile);
                outputDevice.Play();
                activeOutputs.Add(outputDevice);
                outputDevice.PlaybackStopped += (s, e) =>
                {
                    outputDevice.Dispose();
                    audioFile.Dispose();
                    activeOutputs.Remove(outputDevice);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reproduciendo sonido: {ex.Message}");
            }
        }


        private  void Btn_Main_MouseEnter(object sender, EventArgs e)
        {
            PlayHoverSound("./sfx/btn.wav");
        }

        private void Btn_Main_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
