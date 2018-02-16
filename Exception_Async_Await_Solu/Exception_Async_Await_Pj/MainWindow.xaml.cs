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
            sc.SyncDownload("https://msdn.microsoft.com/en-us/");
        }

        private void Async_Download(object sender, RoutedEventArgs e)
        {
            Exceptions exs = new Exceptions();
            exs.ExceptionDivideZero();
        }
    }
}
