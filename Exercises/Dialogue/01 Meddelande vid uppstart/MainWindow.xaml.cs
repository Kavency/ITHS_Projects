// 1.Meddelande vid uppstart
// Använd MessageBox i fönstrets konstruktor för att visa 
// meddelandet "Application is about to start!". Visa 
// ytterligare en MessageBox när fönstrets "Loaded"-event 
// triggas där du skriver "Application started!".

using System.Windows;

namespace _01_Meddelande_vid_uppstart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("Loading");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("App started");
        }
    }
}