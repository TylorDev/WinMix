using MUSIC_FINAL.Forms;
using MUSIC_FINAL.Webserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUSIC_FINAL
{
    internal static class Program
    {
       
        private static Server _webServer;

        [STAThread]
        static  void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

       
            Task.Run(() =>
            {
                _webServer = new Server("www");
                _webServer.Start();      
            });

     
            Application.Run(new Frm_Acesso());

           
            _webServer?.Stop();
        }
    }
}
