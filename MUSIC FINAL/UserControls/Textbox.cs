using MUSIC_FINAL.Global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL.UserControls
{


    [DefaultEvent("KeyPress")]
    public partial class Textbox : Base
    {
        #region Props
        ColorOption textColor;
        private Color internalColor;
        [Category(".Text Properties")]
        public ColorOption TextColor
        {
            get => textColor;
            set
            {
                textColor = value;
                internalColor = ApplyTextColor(Txt_Main, textColor);


            }
        }

        [Category(".Text Properties")]
        public string PlaceHolder { 
            
            get=>placeholderText; 
            set 
            {

                placeholderText = value;
                Txt_Main.Text = placeholderText;
            }
                
      }

        [Category(".Text Properties")]
        new public string Text
        {
            get => Txt_Main.Text;
            set => Txt_Main.Text = value;
        }

        [Category(".Text Properties")]
        public string Tittle
        {
            get => Lbl_Tittle.Text;
            set
            {

                Lbl_Tittle.Text = value;


            }


        }
        [Category(".Text Properties")]
        public string Texto
        {
            get => Txt_Main.Text;
            set => Txt_Main.Text = value;
        }
        [Category(".Text Properties")]
        public FontStyle FontWeight
        {
            get => Txt_Main.Font.Style;
            set => Txt_Main.Font = new Font(Txt_Main.Font, value);
        }

        private FontSizeOption _fontSize;
        [Category(".Text Properties")]
        public FontSizeOption FontSizeType
        {
            get => _fontSize;
            set
            {
                _fontSize = value;
                ApplyFontSize(Txt_Main, _fontSize);
            }
        }







        private int borderThickness = 2;
        private Color borderColor = Color.Red;
        private int cornerRadius = 10;

        [Category(".Text Properties")]
        public int BorderThickness
        {
            get { return borderThickness; }
            set
            {
                borderThickness = value;
                this.Invalidate();
            }
        }

        ColorOption _border;
        [Category(".Text Properties")]
        public ColorOption BorderColor
        {
            get => _border;
            set
            {
                _border = value;

                switch (_border)
                {
                    case ColorOption.TextPrimary:
                        borderColor = GlobalStyles.TextPrimary;

                        break;
                    case ColorOption.TextSecondary:
                        borderColor = GlobalStyles.TextSecondary;
                        break;
                    case ColorOption.ButtonText:
                        borderColor = GlobalStyles.ButtonText;
                        break;

                    case ColorOption.Black:
                        borderColor = Color.Black;
                        break;
                }
                this.Invalidate();

            }
        }






        [Category(".Text Properties")]
        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                this.Invalidate(); 
            }
        }
        #endregion
        #region Border
        private void BorderedUserControl_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(borderColor, borderThickness))
            {
         
                Rectangle rect = new Rectangle(
                    borderThickness / 2,
                    borderThickness / 2,
                    this.Width - borderThickness,
                    this.Height - borderThickness);

    
                using (System.Drawing.Drawing2D.GraphicsPath path = CreateRoundedRectanglePath(rect, cornerRadius))
                {
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

      
        private System.Drawing.Drawing2D.GraphicsPath CreateRoundedRectanglePath(Rectangle rect, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int diameter = radius * 2;
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); 
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); 
            path.CloseFigure();
            return path;
        }

        #endregion


        private string placeholderText = "Escribe aquí...";  // Texto del placeholder
        private bool isPlaceholderVisible = true;


        public Textbox()
        {
            InitializeComponent();

    


            this.DoubleBuffered = true;
            this.Paint += BorderedUserControl_Paint;
            Btn_Icon.Icon = Properties.Resources._1;
            Color myback = GlobalStyles.ButtonText;
            Txt_Main.BackColor = myback;
            Btn_Icon.BackColor = myback;
            Lbl_Tittle.Background = BackColorOption.ButtonText;
            panel1.BackColor = myback;
            Txt_Main.KeyPress += (sender, e) =>LetKeyPress(e);

            Txt_Main.Enter += Txt_Main_Enter1;
            Txt_Main.Leave += Txt_Main_Leave1;
    
        }

        private void Txt_Main_Leave1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Main.Text))
            {
                SetPlaceholder();
            }
        }

        private void Txt_Main_Enter1(object sender, EventArgs e)
        {
            if (isPlaceholderVisible)
            {
                Txt_Main.Text = "";
                Txt_Main.ForeColor = internalColor; 
                isPlaceholderVisible = false;
            }
        }

        private void SetPlaceholder()
        {
            Txt_Main.Text = placeholderText;
            Txt_Main.ForeColor = Color.Gray;  // Color del placeholder
            isPlaceholderVisible = true;
        }

        new public event KeyPressEventHandler KeyPress;
        protected virtual void LetKeyPress(KeyPressEventArgs  e)
        {
            KeyPress?.Invoke(this, e);
        }

        private void Txt_Main_Enter(object sender, EventArgs e)
        {
            borderColor = GlobalStyles.Button;
            this.Invalidate();
        }

        private void Txt_Main_Leave(object sender, EventArgs e)
        {
            borderColor = GlobalStyles.TextSecondary;
            this.Invalidate();
        }

   


        bool hidden = false;
        private void Btn_Icon_OnClick(object sender, EventArgs e)
        {
            if (hidden)
            {
                Txt_Main.PasswordChar = '\0';
                Btn_Icon.Icon = Properties.Resources._1;
                hidden = false;
                Txt_Main.Focus();
            }
            else
            {
                Txt_Main.PasswordChar = '•';
                hidden = true;
                Btn_Icon.Icon = Properties.Resources._2;
                Txt_Main.Focus();

            }



        }


        new public bool Enabled
        {
            get => Txt_Main.Enabled;

            set
            {
                Txt_Main.Enabled = value;

                if (value == false)
                {
                    Txt_Main.BackColor = GlobalStyles.DisabledBack;
                    Btn_Icon.BackColor = GlobalStyles.DisabledBack;
                    Lbl_Tittle.Background = BackColorOption.Disabled;
                    Lbl_Tittle.TextColor = ColorOption.Disabled;
                    panel1.BackColor = GlobalStyles.DisabledBack;
                    borderColor = GlobalStyles.DisabledBorder;
                    Btn_Icon.Enabled = false;
                    Btn_Icon.Icon = Properties.Resources.disabledEye;
                    this.Invalidate();
                }
                else if (value == true)
                {

                    Color myback = GlobalStyles.ButtonText;
                    Txt_Main.BackColor = myback;
                    Lbl_Tittle.TextColor = ColorOption.White;
                    Btn_Icon.BackColor = myback;
                    Lbl_Tittle.Background = BackColorOption.ButtonText;
                    panel1.BackColor = myback;

                    borderColor = GlobalStyles.TextSecondary;
                    Btn_Icon.Enabled = true;
                    Btn_Icon.Icon = Properties.Resources._1;
                    this.Invalidate();
                }


            }


        }






        new public void Focus()
        {
            Txt_Main.Focus();   
        }
         public void Clear()
        {
            Txt_Main.Clear();
        }

        private void Textbox_Load(object sender, EventArgs e)
        {
            // Configura el TextBox
            SetPlaceholder();
        }
    }
}
