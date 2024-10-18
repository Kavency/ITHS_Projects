using System.Diagnostics.Metrics;
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

namespace _01_Klickräknare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int clickCounter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickerBTN_Click(object sender, RoutedEventArgs e)
        {
            ClickerBTN.Content = $"Clicked {++clickCounter} times!";
            ClickerBTN.Height = ClickerBTN.Height *= 1.05;
        }
    }
}