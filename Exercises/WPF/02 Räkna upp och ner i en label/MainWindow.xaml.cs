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

namespace _02_Räkna_upp_och_ner_i_en_label
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

        private void DecreaseBTN_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(CounterLBL.Content.ToString());
            CounterLBL.Content = --count;
        }

        private void IncreaseBTN_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(CounterLBL.Content.ToString());
            CounterLBL.Content = ++count;
        }
    }
}