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
    [DefaultEvent("Cliked")]
    public partial class Slider : UserControl
    {
        int maxValue;
        [Category(".Text Properties")]
        public int MaxValue
        {
            get => maxValue;
            set => maxValue = value;
        }



        double _value;
        [Category(".Text Properties")]
        public double Value
        {
            get => _value; 
            set
            {

                _value = value;
                double porcentaje = value/maxValue*100;
             
                int result = ConvertPercentageToPixels(porcentaje);
                Main_Split.SplitterDistance = result;


            }
        }


        public int SplitterDistance
        {
            get=>Main_Split.SplitterDistance;
        }



        public double ConvertPixelsToPercentage(int pxValue)
        {
    
            double percentage = ((double)pxValue / Width) * 100;
            double result = maxValue * (percentage / 100);


            return percentage;
        }

        public int ConvertPercentageToPixels(double percentage)
        {

            if (Width == 0)
                throw new InvalidOperationException("Width no puede ser 0.");

            int pixels = (int)((percentage / 100) * Width);

            return pixels;
        }


        public Slider()
        {
            InitializeComponent();
            Main_Split.SplitterMoved+= (sender, e) => OnSplitterMoved(sender,e);
            Main_Split.Panel1.MouseClick += (sender, e) => OnClicked(sender, e);
            Main_Split.Panel2.MouseClick += (sender, e) => OnClicked(sender, e);
            Main_Split.Panel2.BackColor = GlobalStyles.ButtonText;
            Main_Split.Panel1.BackColor = GlobalStyles.Button;
        }

        public event EventHandler SplitterMoved;
        public event EventHandler Clicked;
        protected virtual void OnClicked(object sender, MouseEventArgs e)

        {
            Clicked?.Invoke(sender, e);
        }

        protected virtual void OnSplitterMoved(object sender, SplitterEventArgs  e)

        {
        
            SplitterMoved?.Invoke(sender, e);
        }

   

        private void Main_Split_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                int relativeX = e.X;  
                int newSplitterDistance = relativeX - Main_Split.Panel1.Left;

              
                newSplitterDistance = Math.Max(0, Math.Min(newSplitterDistance, Main_Split.Width - Main_Split.SplitterWidth));

    
                Main_Split.SplitterDistance = newSplitterDistance;
            }
        
        }

        private void Main_Split_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
         
                Main_Split.SplitterDistance = e.X;
           
            }
        }

        private void Main_Split_Panel2_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {
         
                Main_Split.SplitterDistance += e.X;
          
               
            }
        }

     
    }
}
