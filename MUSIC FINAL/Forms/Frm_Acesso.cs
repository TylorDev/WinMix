using Google.Protobuf.WellKnownTypes;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL.Forms
{
    public partial class Frm_Acesso :Base
    {
        public  Frm_Acesso()
        {
    
            InitializeComponent();
            
         
        }





        private void Brn_Entrar_OnClick(object sender, EventArgs e)
        {
            Frm_Login frm = new Frm_Login(this);
            frm.Show();
            this.Hide();

        }

       

        private async void Frm_Acesso_Load(object sender, EventArgs e)
        {
            await Variaveis.InitializeWebViewAsync();

            await Task.Delay(2000);
            await Variaveis.Navigate("/register");

        }







        private void Btn_Cadastro_OnClick(object sender, EventArgs e)
        {
            Frm_Cadastro frm_Cadastro = new Frm_Cadastro(this);
            frm_Cadastro.Show();
            this.Hide();
       
        }

        private void selectFilesButton_Click(object sender, EventArgs e)
        {

            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Music", "Swing");

        





            if (Directory.Exists(folderPath))
            {
            
                string[] mp3Files = Directory.GetFiles(folderPath, "*.mp3");
            


                if (mp3Files.Length > 0)
                {
                    Frm_List list = new Frm_List(mp3Files, "Swing");
                    list.Show();
                    this.Hide();
                    Variaveis.CurrentIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron archivos MP3 en la carpeta especificada.");
                }
            }
            else
            {
                MessageBox.Show("La carpeta especificada no existe.");
            }


        }

        private void button1_OnClick(object sender, EventArgs e)
        {
            Variaveis.frm_controls.Show();
        }

    

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Music", "Singer");

            if (Directory.Exists(folderPath))
            {
              
                string[] mp3Files = Directory.GetFiles(folderPath, "*.mp3");

                if (mp3Files.Length > 0)
                {
                   // songList1.AddSongItems(mp3Files);    
                    Variaveis.CurrentIndex = 0;
                }
                else
                {
                    MessageBox.Show("No se encontraron archivos MP3 en la carpeta especificada.");
                }
            }
            else
            {
                MessageBox.Show("La carpeta especificada no existe.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
              using (OpenFileDialog openFileDialog = new OpenFileDialog())
  {
      openFileDialog.Multiselect = true;
      openFileDialog.Filter = "Archivos MP3 (*.mp3)|*.mp3";

      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
         // songList1.AddSongItems(openFileDialog.FileNames);
          Variaveis.CurrentIndex = 0;

      }
  }
        }

        private void Frm_Acesso_Paint(object sender, PaintEventArgs e)
        {
            InitializeWebBackground("http://localhost:5173/#register", sender, e);
      
        }
    }
}
