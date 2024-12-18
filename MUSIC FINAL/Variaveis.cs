using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using MUSIC_FINAL.Entities;
using MUSIC_FINAL.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MUSIC_FINAL
{
    class Variaveis
    {


        public static WebView2 WebAudioPlayer { get; private set; }

        // Método estático asincrónico para inicializar
       public static async Task InitializeWebViewAsync()
{
    try 
    {
        var options = new CoreWebView2EnvironmentOptions("--autoplay-policy=no-user-gesture-required");
        var environment = await CoreWebView2Environment.CreateAsync(null, null, options);
        
        if (WebAudioPlayer == null)
        {
            WebAudioPlayer = new WebView2();
        }
        
        // Importante: verificar que la operación de inicialización no falle
        await WebAudioPlayer.EnsureCoreWebView2Async(environment);
    }
    catch (Exception ex)
    {
        // Manejo de errores detallado
        Console.WriteLine($"Error de inicialización: {ex.Message}");
        // Opcional: loguear el error completo
        Console.WriteLine($"Traza de pila: {ex.StackTrace}");
    }
}

        public static Frm_Controls frm_controls = new Frm_Controls();
        public static Frm_Player frm_Player = new Frm_Player();
        public static Form BackgroundForm = new Form();
        //public static Song CurrentSong;
        public static string nome, senha;
        public static int volume=80;
        public static int id;
        public static bool isPlaying = false;
        private static int _currentIndex;
        private static TimeSpan def = new TimeSpan(1, 0, 0);
        private static Song _currentSong = new Song("Default", "???", Variaveis.def );
        private static List<string> _songPaths = new List<string>();
        public static event Action<List<string>> SongPathsChanged;

        public static List<string> SongPaths
        {
            get => _songPaths;
            set
            {
               
                    _songPaths.Clear(); 
                    _songPaths.AddRange(value); 
                    SongPathsChanged?.Invoke(new List<string>(_songPaths));

            }
        }


        public static event Action<int> CurrentSongChanged;

        public static event Action<int> CurrentIndexChanged;

        public static Song CurrentSong
        {
            get { return _currentSong; }
            set
            {
         
               _currentSong = value;
                CurrentSongChanged?.Invoke(_currentIndex);


            }
        }

        public static int CurrentIndex
        {
            get => _currentIndex;
            set
            {
                if (_currentIndex != value)
                {
                    _currentIndex = value;
              
                    CurrentIndexChanged?.Invoke(_currentIndex);
                }
            }
        }
        public static Song GetMetadata(string filePath)
        {
            var file = TagLib.File.Create(filePath);
            Image cover = GetAlbumCover(filePath);
            string titulo = file.Tag.Title ?? "????";
            string artista = file.Tag.FirstPerformer ?? "????";
            TimeSpan duration = file.Properties.Duration;
            Song song = new Song(titulo, artista, duration, cover);
            song.FilePath = filePath;
           
            return song;
        }

        public static Image GetAlbumCover(string ruta)
        {
            var file = TagLib.File.Create(ruta);

            if (file.Tag.Pictures.Length > 0)
            {
                var pictureData = file.Tag.Pictures[0].Data.Data;

                if (pictureData != null && pictureData.Length > 0)
                {
                    try
                    {
                        using (var ms = new MemoryStream(pictureData))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                    catch
                    {
                       
                    }
                }
            }

            return null;  
        }


        public static  async Task btnPlay()
        {
            string script;

            if (isPlaying)
            {
                script = $"window.pauseAudio()";
                isPlaying = false;  
               
            }
            else
            {
                script = $"window.playAudio()";
                isPlaying = true;  

            }
            if (Variaveis.WebAudioPlayer != null)
            {
                await WebAudioPlayer.ExecuteScriptAsync(script);
            }
        }

        public static async Task Next()
        {
            if (SongPaths.Count == 0) return;  

            Variaveis.CurrentIndex = (Variaveis.CurrentIndex + 1) % SongPaths.Count; 
            Variaveis.CurrentSong = Variaveis.GetMetadata(SongPaths[Variaveis.CurrentIndex]);

            await PlaySong(SongPaths[Variaveis.CurrentIndex]);
        }
        public static async Task Prev()
        {
            if (Variaveis.SongPaths.Count == 0) return;

            Variaveis.CurrentIndex = (Variaveis.CurrentIndex - 1 + Variaveis.SongPaths.Count) % Variaveis.SongPaths.Count;
            Variaveis.CurrentSong = Variaveis.GetMetadata(Variaveis.SongPaths[Variaveis.CurrentIndex]);

            await Variaveis.PlaySong(Variaveis.SongPaths[Variaveis.CurrentIndex]);
        }

        public static async Task PlaySong(string filePath)
        {

            var fileContent = File.ReadAllBytes(filePath);
            var base64FileContent = Convert.ToBase64String(fileContent);
            string fileName = Uri.EscapeDataString(Path.GetFileName(filePath));
            string mimeType = MimeMapping.GetMimeMapping(filePath);
            string script = $"window.receiveFile('{base64FileContent}', '{fileName}', '{mimeType}');";
            if (Variaveis.WebAudioPlayer != null)
            {
                await Variaveis.WebAudioPlayer.ExecuteScriptAsync(script);
            }
               


        }

        public static async Task SkipTo(int seconds)
        {
            string script = $"window.setCurrentTime({seconds});";
            if (Variaveis.WebAudioPlayer != null)
            {
                await Variaveis.WebAudioPlayer.ExecuteScriptAsync(script);
            }
        
            Variaveis.isPlaying = true;

        }

        public static async Task Blur(bool value)
        {
            string script = $"window.ActivateBlur({value.ToString().ToLower()});";
            if (Variaveis.WebAudioPlayer != null)
            {
                await Variaveis.WebAudioPlayer.ExecuteScriptAsync(script);
            }

        }



        public static async Task NextPreset()
        {
            string script = $"window.goToNext();";
            if (Variaveis.WebAudioPlayer != null)
            {
                await Variaveis.WebAudioPlayer.ExecuteScriptAsync(script);
            }

        }

        public static async Task PrevPreset()
        {
            string script = $"window.goToPrevious();";
            if (Variaveis.WebAudioPlayer != null)
            {
                await Variaveis.WebAudioPlayer.ExecuteScriptAsync(script);
            }

        }

        public static async Task HoldPreset()
        {
            string script = $"window.togglePause();";
            if (Variaveis.WebAudioPlayer != null)
            {
                await Variaveis.WebAudioPlayer.ExecuteScriptAsync(script);
            }

        }

        public static async Task Navigate(string value)
        {
            string script = $"window.Navigate({value});";
            if (Variaveis.WebAudioPlayer != null)
            {
                await Variaveis.WebAudioPlayer.ExecuteScriptAsync(script);
            }
          
        }


        public static async Task SetVolume(int vol)
        {
         
            double volume = vol / 100.0;  
            string volumeString = volume.ToString(CultureInfo.InvariantCulture);  


            string script = $"window.setVolume({volumeString});";
            if (Variaveis.WebAudioPlayer != null)
            {
                await Variaveis.WebAudioPlayer.ExecuteScriptAsync(script);
            }
 

        }
    }
}
