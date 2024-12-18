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


namespace MUSIC_FINAL.UserControls
{
    [DefaultEvent("OnClick")]
    public partial class Label :  Base
    {

        [Category(".Text Properties")]
        public Cursor cursor
        {
            get=>Btn_Main.Cursor;
            set=>Btn_Main.Cursor = value;
        }
        ColorOption textColor;
        private Color internalColor ;
        [Category(".Text Properties")]
        public ColorOption TextColor
        {
            get => textColor;
            set
            {
               textColor = value;
               internalColor = ApplyTextColor(Btn_Main, textColor);

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
            set
            {

                if (value.HasFlag(FontStyle.Underline))
                {
                    value |= FontStyle.Bold; 
                }

                Btn_Main.Font = new Font(Btn_Main.Font, value);
            }
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


                switch (value)
                {
                    case BackColorOption.Button:
                       Btn_Main.FlatAppearance.MouseOverBackColor = GlobalStyles.Button;
                       Btn_Main.FlatAppearance.MouseDownBackColor = GlobalStyles.Button;
                        break;
                    case BackColorOption.ButtonText:
                        Btn_Main.FlatAppearance.MouseOverBackColor = GlobalStyles.ButtonText;
                        Btn_Main.FlatAppearance.MouseDownBackColor = GlobalStyles.ButtonText;
                        break;
                    case BackColorOption.Primary:
                        Btn_Main.FlatAppearance.MouseOverBackColor = GlobalStyles.PrimaryColor;
                        Btn_Main.FlatAppearance.MouseDownBackColor = GlobalStyles.PrimaryColor;
                        break;
                    case BackColorOption.Secondary:
                        Btn_Main.FlatAppearance.MouseOverBackColor = GlobalStyles.SecondaryColor;
                        Btn_Main.FlatAppearance.MouseDownBackColor = GlobalStyles.PrimaryColor;
                        break;
                
                       
                }
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
        new public Padding Padding
        {
            get => panel1.Padding;
            set
            {
                panel1.Padding = value;
            }
        }


     



        public Label()
        {
            InitializeComponent();
            Btn_Main.Click += (sender, e) => OnMiBotonClick(e);

         

        }


        new public event EventHandler OnClick;
  



        protected virtual void OnMiBotonClick(EventArgs e)
        {
            OnClick?.Invoke(this, e);
        }

        private void Btn_Main_MouseHover(object sender, EventArgs e)

        {
           
        
        }

        private void Btn_Main_MouseEnter(object sender, EventArgs e)
        {
          
            
            if(Btn_Main.Cursor == Cursors.Hand){
                Btn_Main.ForeColor = Color.Red;
            }
           
        
            
              
        }

        private void Btn_Main_MouseLeave(object sender, EventArgs e)
        {

            if (Btn_Main.Cursor == Cursors.Hand)
            {
                Color startColor = Color.Red;
                Color endColor = internalColor;
                int duration = 1000; // Duración de 5 segundos
                int stepCount = 60;  // Número de pasos para suavizar la animación
                int currentStep = 0;

                Timer timer = new Timer();
                timer.Interval = duration / stepCount;

                timer.Tick += (s, ev) =>
                {
                    currentStep++;
                    float ratio = (float)currentStep / stepCount;

                    int r = (int)(startColor.R + (endColor.R - startColor.R) * ratio);
                    int g = (int)(startColor.G + (endColor.G - startColor.G) * ratio);
                    int b = (int)(startColor.B + (endColor.B - startColor.B) * ratio);

                    Btn_Main.ForeColor = Color.FromArgb(r, g, b);

                    if (currentStep >= stepCount)
                    {
                        timer.Stop();
                        Btn_Main.ForeColor = endColor; // Asegura el color final
                    }
                };

                timer.Start();
            }


        }
    }
}
