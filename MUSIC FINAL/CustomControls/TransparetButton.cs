using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL.Global
{
    internal class TransparentButton : Button
    {
        public TransparentButton()
        {

            this.SetStyle(ControlStyles.Opaque, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

 
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, Color.White);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, Color.White);
            this.BackColor = Color.Transparent;

      
            this.ForeColor = Color.White;
            this.Font = new Font(this.Font, FontStyle.Bold);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20; 
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
        
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.Invalidate();
        }
    }
}
