using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace WpfApp1
{
    using LibVLCSharp.Shared;
    using MediaPlayer = LibVLCSharp.Shared.MediaPlayer;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LibVLC libvlc;
        MediaPlayer _mediaplayer;

        public MainWindow()
        {
            InitializeComponent();

            Core.Initialize();

            libvlc = new LibVLC();
            _mediaplayer = new MediaPlayer(libvlc);

            MyVideo.MediaPlayer = _mediaplayer;
            
            string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),"FortuneBank_1280x210.wmv");
            MyVideo.MediaPlayer.Media = new Media(libvlc, new Uri(path));
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            MyVideo.MediaPlayer.Play();
        }
    }
}
