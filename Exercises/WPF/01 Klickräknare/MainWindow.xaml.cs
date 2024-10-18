// 1.Klickräknare
// Bygg ett program med en knapp som håller reda på hur
// många gånger man klickat på den. Det ska stå "Click: X" 
// på knappen, där X är antalet gånger man klickat på knappen.

using System.Windows;


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