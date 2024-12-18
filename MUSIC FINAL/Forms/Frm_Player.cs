using Microsoft.Web.WebView2.Core;
using MUSIC_FINAL.Entities;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL.Forms
{
    public partial class Frm_Player : Base
    {

    
        public Frm_Player()
        {
            InitializeComponent();
            //selectFilesButton.Click += SelectFilePaths;
            Variaveis.CurrentSongChanged += Variaveis_CurrentSongChanged;
            Variaveis.SongPathsChanged += Variaveis_SongPathsChanged;
        }

        List<string> old;
        private void Variaveis_SongPathsChanged(List<string> obj)
        {
            if (old == null || !old.SequenceEqual(obj))
            {
               

                SL_Musicas.AddSongItems(obj.ToArray());
                old = new List<string>(obj);
            }
     

        }

        bool animating  = false;
        private void Variaveis_CurrentSongChanged(int obj)
        {
            Lbl_Nome.Text = Variaveis.CurrentSong.Nome;
            Lbl_Artista.Text = Variaveis.CurrentSong.Autor;
            Pic_Art.Image = Variaveis.
            CurrentSong.Image;
            if (animating == false)
            {
                Animate();

            }
            
       
        }

      

        private void Btn_Adicionar_OnClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Archivos MP3 (*.mp3)|*.mp3";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileNames.Length > 0)
                    {
         
                        string directoryPath = Path.GetDirectoryName(openFileDialog.FileNames[0]);
                        string directoryName = Path.GetFileName(directoryPath);

                        Frm_List list = new Frm_List(openFileDialog.FileNames, directoryName);
                        list.Show();
                        this.Hide();
                        Variaveis.CurrentIndex = 0;

                    }
                    else
                    {
                        MessageBox.Show("No se encontraron archivos MP3 en la carpeta especificada.");
                    }
                }
            }
        }
        private void Frm_Player_Load(object sender, EventArgs e)
        {
            InitializeWebBackground("http://localhost:5173/", sender, e);
            if (Variaveis.WebAudioPlayer.CoreWebView2 != null)
            {
                Variaveis.WebAudioPlayer.Source = new Uri("http://localhost:5173/", UriKind.Absolute);
                //Variaveis.WebAudioPlayer.WebMessageReceived += musica_WebMessageReceived;
            }
       
        }





    

        private void Btn_Controles_OnClick(object sender, EventArgs e)
        {

            Variaveis.frm_controls.Show();
            Variaveis.frm_controls.BringToFront();
        }

      

        private async void Btn_Sair_OnClick(object sender, EventArgs e)
        {
            Frm_Acesso acesso = new Frm_Acesso();
            await Variaveis.Navigate("/register");

            acesso.Show();
            Hide();
            acesso.Focus();
        }

        private void Btn_Biblioteca_OnClick(object sender, EventArgs e)
        {
           Frm_Musicas fr = new Frm_Musicas();
            fr.Show();
            this.Hide();
        }


        public  void AnimateWidth(Control control, int initialWidth, int targetWidth, double durationInSeconds)
        {
            if (control == null)
                throw new ArgumentNullException(nameof(control));

            control.Width = initialWidth; // Configurar el ancho inicial
            int totalWidthChange = targetWidth - initialWidth;
            int durationInMilliseconds = (int)(durationInSeconds * 1000);
            int interval = 10; // Intervalo del Timer en milisegundos
            int steps = durationInMilliseconds / interval;
            double widthIncrement = (double)totalWidthChange / steps;

            Timer timer = new Timer
            {
                Interval = interval
            };

            int currentStep = 0;

            timer.Tick += (sender, e) =>
            {
                if (currentStep < steps)
                {
                    control.Width = initialWidth + (int)(widthIncrement * currentStep);
                    currentStep++;
                }
                else
                {
                    control.Width = targetWidth; // Asegurar el valor final exacto
                    timer.Stop();
                    timer.Dispose();
                }
            };

            timer.Start();
        }

        public async Task<bool> AnimateHeightAsync(Control control, int initialHeight, int targetHeight, double durationInSeconds)
        {
            if (control == null)
                throw new ArgumentNullException(nameof(control));

            control.Height = initialHeight; // Configurar la altura inicial
            int totalHeightChange = targetHeight - initialHeight;
            int durationInMilliseconds = (int)(durationInSeconds * 1000);
            int interval = 10; // Intervalo del Timer en milisegundos
            int steps = durationInMilliseconds / interval;
            double heightIncrement = (double)totalHeightChange / steps;

            Timer timer = new Timer
            {
                Interval = interval
            };

            int currentStep = 0;
            var taskCompletionSource = new TaskCompletionSource<bool>();

            timer.Tick += (sender, e) =>
            {
                if (currentStep < steps)
                {
                    control.Height = initialHeight + (int)(heightIncrement * currentStep);
                    currentStep++;
                }
                else
                {
                    control.Height = targetHeight; // Asegurar el valor final exacto
                    timer.Stop();
                    timer.Dispose();
                    taskCompletionSource.SetResult(true); // La animación ha terminado
                }
            };

            timer.Start();

            // Esperar a que la animación termine
            await taskCompletionSource.Task;

            return true;
        }


        public async Task<bool> AnimateXPositionAsync(Control control, int initialX, int targetX, double durationInSeconds)
        {
            if (control == null)
                throw new ArgumentNullException(nameof(control));

            // Configurar la posición inicial
            var initialLocation = control.Location;
            control.Location = new Point(initialX, initialLocation.Y);

            int totalXChange = targetX - initialX;
            int durationInMilliseconds = (int)(durationInSeconds * 1000);
            int interval = 10; // Intervalo del Timer en milisegundos
            int steps = durationInMilliseconds / interval;
            double xIncrement = (double)totalXChange / steps;

            Timer timer = new Timer
            {
                Interval = interval
            };

            int currentStep = 0;
            var taskCompletionSource = new TaskCompletionSource<bool>();

            timer.Tick += (sender, e) =>
            {
                if (currentStep < steps)
                {
                    int newX = initialX + (int)(xIncrement * currentStep);
                    control.Location = new Point(newX, initialLocation.Y);
                    currentStep++;
                }
                else
                {
                    control.Location = new Point(targetX, initialLocation.Y); // Asegurar el valor final exacto
                    timer.Stop();
                    timer.Dispose();
                    taskCompletionSource.SetResult(true); // La animación ha terminado
                }
            };

            timer.Start();

            // Esperar a que la animación termine
            await taskCompletionSource.Task;

            return true;
        }




        private async void Animate()
        {


            if (coverVisible == false)
            {
                animating = true;


                double anim1 = 100;
                double anim2 = 50;
                double anim3 = 50;


                int picArtStartWidth = 0;
                int picArtEndWidth = 270;

                int lblNomeStartWidth = 0;
                int lblNomeEndWidth = 350;

                int lblArtistaStartWidth = 0;
                int lblArtistaEndWidth = 350;


                AnimateWidth(Pic_Art, picArtStartWidth, picArtEndWidth, anim1 / 1000);
                await Task.Delay((int)anim1);

                AnimateWidth(Lbl_Nome, lblNomeStartWidth, lblNomeEndWidth, anim2 / 1000);
                await Task.Delay((int)anim2);

                AnimateWidth(Lbl_Artista, lblArtistaStartWidth, lblArtistaEndWidth, anim3 / 1000);
                await Task.Delay((int)anim3);

                await Task.Delay(2500);

                // Animaciones de salida (reversa)
                AnimateWidth(Lbl_Nome, lblNomeEndWidth, lblNomeStartWidth, anim2 / 1000);
                await Task.Delay((int)anim2);

                AnimateWidth(Lbl_Artista, lblArtistaEndWidth, lblArtistaStartWidth, anim3 / 1000);
                await Task.Delay((int)anim3);

                AnimateWidth(Pic_Art, picArtEndWidth, picArtStartWidth, anim1 / 1000);
                await Task.Delay((int)anim1);

                animating = false;
            }
            
        }

        bool openMenu = false;
        private async void Animated_OnClick(object sender, EventArgs e)


        {

            if (openMenu == false)
            {
                await AnimateHeightAsync(tableLayoutPanel1, 0, 191, 0.05);

                tableLayoutPanel1.Visible = false;
                await Task.Delay(10);
                tableLayoutPanel1.Visible = true;
                openMenu= true;
                Btn_Menu.Text = "-";
           
                Btn_Menu.Background = UserControls.Base.BackColorOption.Button;
                Btn_Menu.TextColor = UserControls.Base.ColorOption.ButtonText;
            }
            else
            {

                await AnimateHeightAsync(tableLayoutPanel1, 191, 0, 0.05);

                tableLayoutPanel1.Visible = false;
                await Task.Delay(10);
                tableLayoutPanel1.Visible = true;

                Btn_Menu.Text = "+";
                Btn_Menu.Background = UserControls.Base.BackColorOption.Disabled;
                Btn_Menu.TextColor = UserControls.Base.ColorOption.TextSecondary;

                openMenu = false;
            }
        
           
        
            
        }

        bool coverVisible = false;
        private async void Btn_Capa_OnClick(object sender, EventArgs e)
        {
            double anim1 = 100;
            double anim2 = 50;
            double anim3 = 50;


            int picArtStartWidth = 0;
            int picArtEndWidth = 270;

            int lblNomeStartWidth = 0;
            int lblNomeEndWidth = 350;

            int lblArtistaStartWidth = 0;
            int lblArtistaEndWidth = 350;

            if (coverVisible==false) 
            {
                animating = true;


               


                AnimateWidth(Pic_Art, picArtStartWidth, picArtEndWidth, anim1 / 1000);
                await Task.Delay((int)anim1);

                AnimateWidth(Lbl_Nome, lblNomeStartWidth, lblNomeEndWidth, anim2 / 1000);
                await Task.Delay((int)anim2);

                AnimateWidth(Lbl_Artista, lblArtistaStartWidth, lblArtistaEndWidth, anim3 / 1000);
                await Task.Delay((int)anim3);


                animating = false;
                coverVisible = true ;
            }
            else
            {
                animating = true;

                // Animaciones de salida (reversa)
                AnimateWidth(Lbl_Nome, lblNomeEndWidth, lblNomeStartWidth, anim2 / 1000);
                await Task.Delay((int)anim2);

                AnimateWidth(Lbl_Artista, lblArtistaEndWidth, lblArtistaStartWidth, anim3 / 1000);
                await Task.Delay((int)anim3);

                AnimateWidth(Pic_Art, picArtEndWidth, picArtStartWidth, anim1 / 1000);
                await Task.Delay((int)anim1);

                animating = false;
                coverVisible = false;
            }

           
           
        }

        bool isBlur = false;
        private async void Btn_Desfoque_OnClick(object sender, EventArgs e)
        {
            isBlur = !isBlur;
            await Variaveis.Blur(isBlur);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private async void button1_OnClick(object sender, EventArgs e)
        {
        
            panel4.Visible = !panel4.Visible;
            if (panel4.Visible)
            {

                Btn_Fila.Background = UserControls.Base.BackColorOption.Button;
                Btn_Fila.TextColor = UserControls.Base.ColorOption.ButtonText;
            }
            else
            {
                Btn_Fila.Background = UserControls.Base.BackColorOption.Disabled;
             
                Btn_Fila.TextColor = UserControls.Base.ColorOption.TextSecondary;
            }
        }

        private void Frm_Player_Paint(object sender, PaintEventArgs e)
        {
            if (Variaveis.WebAudioPlayer.CoreWebView2 != null) {
            
            Variaveis.WebAudioPlayer.Source = new Uri("http://localhost:5173/", UriKind.Absolute);
            }
        }

        private async void button3_OnClick(object sender, EventArgs e)
        {
            await Variaveis.NextPreset();
        }

        bool isHold = false;
        private  async void button2_OnClick(object sender, EventArgs e)
        {
            isHold= !isHold;
            if(isHold){

                button2.Background = UserControls.Base.BackColorOption.Button;
                button2.TextColor = UserControls.Base.ColorOption.ButtonText;
             
            }
            else
            {
                button2.Background = UserControls.Base.BackColorOption.Disabled;
                button2.TextColor = UserControls.Base.ColorOption.TextSecondary;
         
            }

            await Variaveis.HoldPreset();
        }

        private async void button1_OnClick_1(object sender, EventArgs e)
        {
            await Variaveis.PrevPreset();
        }
    }
}
