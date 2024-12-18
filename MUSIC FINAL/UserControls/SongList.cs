using MUSIC_FINAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL.UserControls
{
    public partial class SongList : UserControl
    {
        public SongList()
        {
            InitializeComponent();

        }



        public (int totalSongs, TimeSpan totalDuration, Image[] randomImages) AddSongItems(string[] songPaths)
        {
            Flw_Queue.Controls.Clear();

            int index = 0;
            TimeSpan totalDuration = TimeSpan.Zero;
            List<Image> validImages = new List<Image>();

            foreach (string filePath in songPaths)
            {
                Song song = Variaveis.GetMetadata(filePath);
                song.Index = index++;

                totalDuration += song.Duration;

                if (song.Image != null)
                {
                    validImages.Add(song.Image); // Agrega la imagen válida a la lista
                }

                SongItem songItem = new SongItem(song, songPaths);
                songItem.Padding = new Padding(0, 5, 0, 0);
                Flw_Queue.Controls.Add(songItem);
            }

            // Seleccionar hasta 4 imágenes aleatorias
            Random rng = new Random();
            Image[] randomImages = validImages
                .OrderBy(x => rng.Next()) // Mezcla las imágenes
                .Take(4)                  // Toma hasta 4 imágenes
                .ToArray();               // Convierte a array

            int totalSongs = songPaths.Length;
            return (totalSongs, totalDuration, randomImages); // Devuelve la tupla
        }



    }
}
