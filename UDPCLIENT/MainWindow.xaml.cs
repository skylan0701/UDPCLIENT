using System.Windows;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UDPCLIENT
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private UDPCLIRNT Recv = null;
        private Thread startrecv = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ThreadCompleteHandler result = ThreadRunOver;
            button1.IsEnabled = true;
            button.IsEnabled = false;
            Recv = new UDPCLIRNT();
            Recv.SetFileName("test.wav");
            startrecv = new Thread((ThreadStart)delegate
            {
                result(Recv.recv());//调用result委托

            });
            startrecv.IsBackground = true;
            startrecv.Start();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Recv.Close();
            Recv = null;
            if (startrecv != null)
                startrecv.Abort();
            startrecv = null;
            button.IsEnabled = true;
            button1.IsEnabled = false;
        }

        public delegate void ThreadCompleteHandler(int i);

        public void ThreadRunOver(int result)
        {
            if (result == 0)
            {
                Recv.Close();
                Recv = null;
                this.Dispatcher.Invoke(
                    new Action(
                    delegate
                    {

                        button.IsEnabled = true;
                        button1.IsEnabled = false;
                    }
                    )
                    );
            }
        }

    }

}
