// 2.Räkna upp och ner i en label.
// Gör ett program med en label som initialt visar 
// värdet 5. Det ska finna en knapp "Increase" och 
// en knapp "Decrease". Genom att klicka på knapparna 
// ska man kunna öka eller minska värdet som visas på 
// label, ett steg i taget. Värdet ska dock aldrig kunna 
// bli lägre än 0, eller högre än 9.

using System.Windows;

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