// 4.Label med valbar position
// Skapa ett nytt program med en label som visar sin 
// egen x- och y-position (T.ex: "x = 43, y= 89").
// Skapa en slider för att ställa in x-positionen mellan
// 0-100, och en slider som gör det samma för y-positionen.
//
// När man drar i sliders så ska labelns position uppdateras. 
// D.v.s både texten som skrivs i labeln så den reflekterar 
// valda värden på x och y; och dessutom labelns faktiska 
// position i fönstret.
//
// Bonus: Lägg gärna till en label i anslutning till vardera 
// slider så att det tydligt framgår vad varje slider gör. 
// T.ex: "x-position:", respektive "y-position:"

using System.Windows;

namespace _04_Label_med_valbar_position
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

        private void xSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            positionLabel.Content = $"x: {xSlider.Value}, y: {ySlider.Value}"; // y.Slider har ännu inte skapats så det blir null exception om value sätts från start.
        }
        private void ySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            positionLabel.Content = $"x: {xSlider.Value}, y: {ySlider.Value}";
        }
    }
}