using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUSIC_FINAL.Entities
{
    public class Song
    {
        private int index;
        private string nome, autor;
        private TimeSpan duration;
        private Image image;
        private string filePath;

        public string Nome
        {
            get=>nome; 
            set { 
            
                nome = value;
            }
        }
        public string Autor
        {
            get => autor;
            set
            {

                autor = value;
            }
        }
        public TimeSpan Duration
        {
            get => duration;
            set
            {

                duration = value;
            }
        }

        public string FilePath
        {
            get=>filePath;
            set
            {
                filePath = value;
            }
        }
        public Image Image
        {
            get=>image;
            set
            {
                image = value;
            }
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }

     
        public Song(string nome, string autor, TimeSpan duration  ,Image image = null) {
            this.nome = nome;
            this.autor = autor;
            this.duration = duration;
            this.image = image;
        }   

    }

}
