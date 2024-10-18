// 3.Lägg till Slider
// Uppdatera programmet i uppgift 2 så att det även finns 
// en slider som kan sättas från 0 till 9 (i hela steg, 
// alltså endast heltal). Om man flyttar slidern så kan 
// värdet på labeln ändras. Observera att knapparna fortfarande 
// ska finnas kvar, fungera som förut, och även uppdatera slidern.

using System.Windows;

namespace _03_Lägg_till_Slider
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
            if (count < Slider.Minimum)
                count = (int)Slider.Minimum;
            if (count >= Slider.Minimum)
                Slider.Value = count;
        }

        private void IncreaseBTN_Click(object sender, RoutedEventArgs e)
        {
            int count = Int32.Parse(CounterLBL.Content.ToString());
            CounterLBL.Content = ++count;
            if (count > Slider.Maximum)
                count = (int)Slider.Maximum;
            if(count <= Slider.Maximum)
                Slider.Value = count;
        }
    }
}