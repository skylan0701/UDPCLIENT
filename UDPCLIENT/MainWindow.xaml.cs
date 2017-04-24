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

namespace UDPCLIENT
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private UDPCLIRNT Recv = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            button1.IsEnabled = true;
            button.IsEnabled = false;
            //    Recv = new UDPCLIRNT();
            //    Recv.recv();
            //    Recv.SetFileName("test.wav");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Recv.Close();
            button.IsEnabled = true;
            button1.IsEnabled = false;
        }
    }
}
