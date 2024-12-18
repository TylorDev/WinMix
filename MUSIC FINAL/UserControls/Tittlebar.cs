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
    public partial class Tittlebar : Base
    {
        private Form boss;

        [Category(".bar props")]
        public string Title
        {
            get { return Lbl_Tittle.Text; }
            set { Lbl_Tittle.Text = value; }
        }

        private bool _reset= false;

        [Category(".bar props")]
        public bool resetButtons
        {
            get=>_reset; set { _reset = value; }
        }
        public Tittlebar()
        {
            InitializeComponent();
            this.MouseDown += MovableUserControl_MouseDown;
            this.MouseMove += MovableUserControl_MouseMove;
            this.MouseUp += MovableUserControl_MouseUp;
            Lbl_Tittle.Btn_Main.MouseDown += MovableUserControl_MouseDown;
            Lbl_Tittle.Btn_Main.MouseMove += MovableUserControl_MouseMove;
            Lbl_Tittle.Btn_Main.MouseUp += MovableUserControl_MouseUp;


            Lbl_Tittle.ForeColor = GlobalStyles.TextPrimary;
            Btn_Close.ForeColor = GlobalStyles.TextPrimary;
            Btn_Min.ForeColor = GlobalStyles.TextPrimary;
            Btn_Max.ForeColor = GlobalStyles.TextPrimary;
            this.BackColor = Color.Red;

        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

   


        private void MovableUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.FindForm().Location;

        }

        private void MovableUserControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.FindForm().Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void MovableUserControl_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public bool disableClose;
        private void Btn_Close_Click(object sender, EventArgs e)
        {
           

            if (disableClose == false)
            {
                if (resetButtons == false)
                {
                    Application.Exit();
                }
            
            }
            
            
            
         
        }

      


        private void Btn_Max_Click(object sender, EventArgs e)
        {


            if (resetButtons == false)
            {
                if (this.FindForm().WindowState == FormWindowState.Maximized)
                {
                    this.FindForm().WindowState = FormWindowState.Normal;
                }
                else
                {
                    this.FindForm().WindowState = FormWindowState.Maximized;
                }
            }


           

        }

      

        private void Btn_Min_OnClick(object sender, EventArgs e)
        {
            if (resetButtons == false)
            {
                this.FindForm().WindowState = FormWindowState.Minimized;
            }
          
        }

    }
}
