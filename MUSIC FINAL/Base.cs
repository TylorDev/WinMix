using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using MUSIC_FINAL.Global;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL
{
    public partial class Base : Form
    {
        #region Props
        [Category(".Custom Properties")]
        public string Tittle
        {
            get => TittleBar_Main.Title;
            set
            {
                TittleBar_Main.Title = value;
            }
        }
        [Category(".Custom Properties")]
        public Color BarColor
        {
            get => TittleBar_Main.BackColor;
            set
            {
                TittleBar_Main.BackColor = value;
            }
        }
        #endregion

        private readonly Dictionary<Control, PointF> relativePositions = new Dictionary<Control, PointF>();
        public Base()
        {
            InitializeComponent();

            this.Load += Form_Load;
            this.Resize += Form_Resize;
            TittleBar_Main.BackColor = GlobalStyles.ButtonText;
        }

    
        private void Form_Load(object sender, EventArgs e)
        {

            foreach (Control ctrl in this.Controls)
            {
                float relativeX = (float)ctrl.Left / this.ClientSize.Width;
                float relativeY = (float)ctrl.Top / this.ClientSize.Height;

                relativePositions[ctrl] = new PointF(relativeX, relativeY);
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
       
            foreach (var kvp in relativePositions)
            {
                Control ctrl = kvp.Key;
                PointF relative = kvp.Value;

                ctrl.Left = (int)(relative.X * this.ClientSize.Width);
                ctrl.Top = (int)(relative.Y * this.ClientSize.Height);
            }
        }


        #region WebBackground 


     

        public  void InitializeWebBackground(string webViewUrl, object sender, EventArgs e)
        {

        
            Size initialClientSize = this.ClientSize;
            FormWindowState initialWindowState = this.WindowState;

        
           

            Variaveis.BackgroundForm.BackColor = Color.White;
            Variaveis.BackgroundForm.ClientSize = initialClientSize;
            Variaveis.BackgroundForm.Location = this.Location;
            Variaveis.BackgroundForm.StartPosition = FormStartPosition.Manual;
            Variaveis.BackgroundForm.Enabled = false;
            Variaveis.BackgroundForm.FormBorderStyle = FormBorderStyle.None;
            Variaveis.BackgroundForm.ShowInTaskbar = false;
            Variaveis.BackgroundForm.WindowState = initialWindowState;
            Variaveis.BackgroundForm.TopMost = false;

            Timer timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += (sr, es) =>
            {
                Variaveis.BackgroundForm.TopMost = true;
                timer.Stop();
            };
            timer.Start();


            if (Variaveis.WebAudioPlayer != null)
            {
                Variaveis.WebAudioPlayer.Dock = DockStyle.Fill;
                Variaveis.WebAudioPlayer.Source = new Uri(webViewUrl, UriKind.Absolute);
                Variaveis.WebAudioPlayer.DefaultBackgroundColor = Color.Black;


                Variaveis.BackgroundForm.Controls.Add(Variaveis.WebAudioPlayer);
            }
               

            



            Variaveis.BackgroundForm.Click += (s, eArgs) =>
            {
                this.BringToFront();
                this.Activate();
            };

           
            Variaveis.BackgroundForm.Activated += (s, eArgs) =>
            {
                this.BringToFront();
                this.Activate();
            };

            Variaveis.BackgroundForm.Show();


            this.FormClosed += Base_FormClosed;

            
            this.LocationChanged += SyncBackPositionAndSize;
            this.Paint += SyncBackPositionAndSize;
            this.SizeChanged += SyncBackPositionAndSize;
            this.Resize += SyncBackWindowState;

            Variaveis.WebAudioPlayer.WebMessageReceived += musica_WebMessageReceived;




        }

       

        private async void musica_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            try
            {
         
            

                var message = e.WebMessageAsJson;
                var json = JsonDocument.Parse(message);
                CultureInfo culture = new CultureInfo("pt-BR");

                if (json.RootElement.TryGetProperty("message", out JsonElement messageElement))
                {
                    string receivedMessage = messageElement.GetString();

                    if (double.TryParse(receivedMessage, NumberStyles.Any, culture, out double numeroDecimal))
                    {

                        int numeroEntero = (int)Math.Round(numeroDecimal);

                        TimeSpan duracion = Variaveis.CurrentSong.Duration;
                        int segundos = (int)duracion.TotalSeconds;

               


                 
                        Variaveis.frm_controls.progress1.Lbl_Duration.Text = FormatearTiempo(segundos);
                        Variaveis.frm_controls.Song = Variaveis.CurrentSong;
                        Variaveis.frm_controls.progress1.Sld_Progress.MaxValue = segundos;


                    
                        Variaveis.frm_controls.progress1.Lbl_Progress.Text = FormatearTiempo(numeroEntero) ;
                        Variaveis.frm_controls.progress1.Sld_Progress.Value = numeroEntero;
                        
                      
                      

                        await Variaveis.SetVolume(Variaveis.volume);

                        if (numeroEntero >= segundos)
                        {
                            await Variaveis.Next();
                        }
                    }
                    else
                    {
                        // Log invalid message format
                        Console.WriteLine($"Invalid message format: {receivedMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores detallado
                Console.WriteLine($"Error en musica_WebMessageReceived: {ex.Message}");
                Console.WriteLine($"Traza de pila: {ex.StackTrace}");
            }
        }

        public string FormatearTiempo(int segundos)
        {
            int minutos = segundos / 60;
            int segundosRestantes = segundos % 60;
            return $"{minutos:D2}:{segundosRestantes:D2}";
        }
        private void Base_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (Variaveis.BackgroundForm != null)
            //{
            //    Variaveis.BackgroundForm.Close();
            //}
        }

        private void SyncBackPositionAndSize(object sender, EventArgs e)
        {
            if (Variaveis.BackgroundForm != null)
            {
                Variaveis.BackgroundForm.Size = this.Size;
                Variaveis.BackgroundForm.Location = this.Location;
            }
        }

        private void SyncBackWindowState(object sender, EventArgs e)
        {
            if (Variaveis.BackgroundForm != null)
            {
                Variaveis.BackgroundForm.WindowState = this.WindowState;
            }
        }
        #endregion



        #region ResizeArea
   
        private const int WM_NCHITTEST = 0x84;
        private const int RESIZE_HANDLE_SIZE = 10;


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST)
            {
                Point cursor = PointToClient(new Point(message.LParam.ToInt32()));

                Rectangle topLeft = new Rectangle(0, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE);
                Rectangle topRight = new Rectangle(ClientSize.Width - RESIZE_HANDLE_SIZE, 0, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE);
                Rectangle bottomLeft = new Rectangle(0, ClientSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE);
                Rectangle bottomRight = new Rectangle(ClientSize.Width - RESIZE_HANDLE_SIZE, ClientSize.Height - RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE, RESIZE_HANDLE_SIZE);

                if (topLeft.Contains(cursor)) message.Result = (IntPtr)13;
                else if (topRight.Contains(cursor)) message.Result = (IntPtr)14;
                else if (bottomLeft.Contains(cursor)) message.Result = (IntPtr)16;
                else if (bottomRight.Contains(cursor)) message.Result = (IntPtr)17;
                else if (cursor.Y <= RESIZE_HANDLE_SIZE) message.Result = (IntPtr)12;
                else if (cursor.X <= RESIZE_HANDLE_SIZE) message.Result = (IntPtr)10;
                else if (cursor.Y >= ClientSize.Height - RESIZE_HANDLE_SIZE) message.Result = (IntPtr)15;
                else if (cursor.X >= ClientSize.Width - RESIZE_HANDLE_SIZE) message.Result = (IntPtr)11;
            }

           
        }






        #endregion

    }
}
