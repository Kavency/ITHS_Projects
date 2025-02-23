using System.Windows;

namespace _05_Färgblandare
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

        private void chooseBTN_Click(object sender, RoutedEventArgs e)
        {
            ColourPickerWindow colourPickerWindow = new();
            colourPickerWindow.Show();
        }
    }
}