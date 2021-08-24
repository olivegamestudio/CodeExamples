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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TestViewModel Model { get; set; } = new TestViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = Model;
        }

        private void OnTemplate1Pressed(object sender, RoutedEventArgs e)
        {
            Model.TemplateId = "SCROLLING_PANEL";
        }

        private void OnTemplate0Pressed(object sender, RoutedEventArgs e)
        {
            Model.TemplateId = "PROMO_PANEL";
        }
    }
}
