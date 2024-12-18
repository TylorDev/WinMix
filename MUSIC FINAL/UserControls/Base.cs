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
using static MUSIC_FINAL.Global.GlobalStyles;

namespace MUSIC_FINAL.UserControls
{
    public partial class Base : UserControl
    {
        public enum ColorOption
        {
            TextPrimary,
            TextSecondary,
            ButtonText,
            Disabled,
            Black,
            White
        }
      
        public enum BackColorOption
        {
            trasparent,
            Button,
            ButtonText,
            Disabled,
            Primary,
            Secondary,
        }
        public enum FontSizeOption
        {
            Small,
            Medium,
            Large,
            Button
        }

        public void ApplyBackColor(Control control, BackColorOption options)
        {
            switch (options)
            {
                case BackColorOption.Button:
                    control.BackColor = GlobalStyles.Button;
                  
                    break;
                case BackColorOption.Disabled:
                    control.BackColor = GlobalStyles.DisabledBack;

                    break;
                case BackColorOption.ButtonText:
                    control.BackColor = GlobalStyles.ButtonText;
                    break;
                case BackColorOption.Primary:
                    control.BackColor = GlobalStyles.PrimaryColor;
                    break;
                case BackColorOption.Secondary:
                    control.BackColor = GlobalStyles.SecondaryColor;
                    break;
                default:
                    control.BackColor = Color.Transparent; break;
            }
        }

        public void ApplyFontSize(Control control, FontSizeOption options)
        {
            switch (options)
            {
                case FontSizeOption.Small:
                    control.Font = new Font(control.Font.FontFamily, GlobalStyles.FontSmall);
                    break;
                case FontSizeOption.Medium:
                    control.Font = new Font(control.Font.FontFamily, GlobalStyles.FontMedium);
                    break;
                case FontSizeOption.Large:
                    control.Font = new Font(control.Font.FontFamily, GlobalStyles.FontLarge);
                    break;
                case FontSizeOption.Button:
                    control.Font = new Font(control.Font.FontFamily, GlobalStyles.FontButton);
                    break;
            }
        }


        public Color ApplyTextColor(Control control, ColorOption options)
        {
            switch (options)
            {
                case ColorOption.TextPrimary:
                    control.ForeColor = GlobalStyles.TextPrimary;
                    return GlobalStyles.TextPrimary;
    
                case ColorOption.TextSecondary:
                    control.ForeColor = GlobalStyles.TextSecondary;
                    return GlobalStyles.TextSecondary;
          
                case ColorOption.ButtonText:
                    control.ForeColor = GlobalStyles.ButtonText;
                    return GlobalStyles.ButtonText;
                 
                case ColorOption.Disabled:
                    control.ForeColor = GlobalStyles.DisabledText;
                    return GlobalStyles.DisabledText;
                   
                case ColorOption.Black:
                    control.ForeColor = Color.Black;
                    return Color.Black;
               
                case ColorOption.White:
                    control.ForeColor = Color.White;
                    return Color.White;
                default: return control.ForeColor;
       
            }
        }








        public Base()
        {
            InitializeComponent();
     
        }
    }
}
