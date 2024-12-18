using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MUSIC_FINAL.Webserver
{
    internal class Server
    {
        private readonly HttpListener _listener;
        private readonly string filePath;
        private bool _running;

        public Server(string folder = "wwwroot", string url = "http://localhost:5173/")
        {
          
            filePath = Path.GetFullPath(folder);
            _listener = new HttpListener();
            _listener.Prefixes.Add(url);
        }

        public void Start()
        {
            if (_running) return;
            _running = true;
            _listener.Start();
            Task.Run(HandleRequests);
        }

        public void Stop()
        {
            _running = false;
            _listener.Stop();
        }

        private async Task HandleRequests()
        {
            while (_running)
            {
                try
                {
                    var context = await _listener.GetContextAsync();
                    ProcessRequest(context);
                }
                catch (HttpListenerException)
                {
                  break;
                }         
            }
        }

        private void ProcessRequest(HttpListenerContext context)
        {
            var response = context.Response;
            string requestedPath = context.Request.Url.LocalPath.TrimStart('/');
            if (string.IsNullOrEmpty(requestedPath))
            {
                requestedPath = "index.html";
            }
            string physicalPath = Path.Combine(filePath, requestedPath);
            response.ContentType = GetMimeType(physicalPath);
            using (var fileStream = File.OpenRead(physicalPath))
            {
                response.ContentLength64 = fileStream.Length;
                fileStream.CopyTo(response.OutputStream);
            }
            response.OutputStream.Close();
        }

        private string GetMimeType(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            switch (extension)
            {
                case ".html":
                    return "text/html";
                case ".js":
                    return "application/javascript";
                case ".css":
                    return "text/css";
                case ".json":
                    return "application/json";
                case ".png":
                    return "image/png";
                case ".jpg":
                case ".jpeg":
                    return "image/jpeg";
                case ".gif":
                    return "image/gif";
                case ".svg":
                    return "image/svg+xml";
                case ".ico":
                    return "image/x-icon";
                case ".txt":
                    return "text/plain";
                default:
                    return "application/octet-stream";
            }
        }
    }
}
