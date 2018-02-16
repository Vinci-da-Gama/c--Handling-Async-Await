using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Exception_Async_Await_Pj.ExceptionClasses;
using Exception_Async_Await_Pj.Sync_Async;

namespace Exception_Async_Await_Pj
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string theUrl = "https://msdn.microsoft.com/en-us/";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Divide0Exception(object sender, RoutedEventArgs e)
        {
            Exceptions exs = new Exceptions();
            MessageBox.Show(exs.ExceptionDivideZero());
        }

        private void ExceptionWithFinal(object sender, RoutedEventArgs e)
        {
            Exceptions exs = new Exceptions();
            MessageBox.Show(exs.ExceptionWithFinal());
        }

        private void Exception_Using(object sender, RoutedEventArgs e)
        {
            Exceptions exs = new Exceptions();
            MessageBox.Show(exs.ExceptionUsingBlock());
        }

        private void Exception_Youtube(object sender, RoutedEventArgs e)
        {
            Exceptions exs = new Exceptions();
            MessageBox.Show(exs.ExceptionYoutube());
        }

        private void Sync_Download(object sender, RoutedEventArgs e)
        {
            Sync_Class sc = new Sync_Class();
            sc.SyncDownload(this.theUrl);

            string htmlStr = sc.SyncDownloadString(this.theUrl);
            MessageBox.Show(htmlStr.Substring(0, 10));
        }

        private async void Async_Download(object sender, RoutedEventArgs e)
        {
            Async_Class ac = new Async_Class();
            await ac.DownloadHtmlAsync("https://msdn.microsoft.com/en-us/");

            var htmlstr = await ac.DownloadStringAsync(theUrl);
            MessageBox.Show(htmlstr.Substring(0, 10));
        }
    }
}
