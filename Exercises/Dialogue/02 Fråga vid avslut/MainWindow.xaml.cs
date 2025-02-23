// 2.Fråga vid avslut
// Lyssna på fönstrets "Closing"-event och visa en MessageBox med frågan
// "Are you sure you want to quit?". Om användaren väljer "No", avbryt 
// stängning av fönstret genom att sätta Cancel = true på 
// CancelEventArgs-objektet som skickas med när eventet triggas.

using System.Windows;

namespace _02_Fråga_vid_avslut
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Titel?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
            
        }
    }
}