using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_test
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

        private void BtnDrawLine_Click(object sender, RoutedEventArgs e)
        {
            Gridbuilder.DrawALine(myCanvas, 10, 10, 200, 200);
        }

        private void BtnDrawBox_Click(object sender, RoutedEventArgs e)
        {
            Gridbuilder.DrawABox(myCanvas, 50, 50, 150, 100);
        }

        private void BtnDrawGrid_Click(object sender, RoutedEventArgs e)
        {
            myCanvas.Children.Clear();
            Gridbuilder.DrawAGrid(myCanvas, 10, 10, 50, 50, (int)SlideHight.Value, (int)SlideWidth.Value);
        }
    }
}