using System.Net;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Async_Await_Pj.Sync_Async
{
    internal class Sync_Class
    {
        // C:\Users\Mia\Desktop\AspNet_Practice\_NotesRecords\C#NextLevel
        public void SyncDownload(string url)
        {
            var webCli = new WebClient();
            var downloadHtml = webCli.DownloadString(url);
            using (var streamwritter = new StreamWriter(@"C:\Users\Mia\Desktop\AspNet_Practice\_NotesRecords\C#NextLevel\syncdownload.html"))
            {
                streamwritter.Write(downloadHtml);
            }
        }

        public string SyncDownloadString(string url)
        {
            var webCli = new WebClient();
            return webCli.DownloadString(url);
        }
    }
}
