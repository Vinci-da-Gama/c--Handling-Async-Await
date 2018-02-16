using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace Exception_Async_Await_Pj.Sync_Async
{
    internal class Async_Class
    {
        // C:\Users\Mia\Desktop\AspNet_Practice\_NotesRecords\C#NextLevel
        public async Task DownloadHtmlAsync(string url)
        {
            WebClient wcli = new WebClient();
            var downloadHtml = await wcli.DownloadStringTaskAsync(url);
            using (var streamWritter = new StreamWriter(@"C:\Users\Mia\Desktop\AspNet_Practice\_NotesRecords\C#NextLevel\asyncdownload.html"))
            {
                await streamWritter.WriteAsync(downloadHtml);
            }
        }

        public async Task<string> DownloadStringAsync(string url)
        {
            var webCli = new WebClient();
            return await webCli.DownloadStringTaskAsync(url);
        }
    }
}
