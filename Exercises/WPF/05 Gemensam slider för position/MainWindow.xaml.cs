// 5.Gemensam slider för position
// Gör en ny version av programmet i uppgift 4, där det nya
// programmet bara har en slider för att välja värdet. Både 
// x och y ska sättas till värdet man valt på slidern (0-100).
//
// Det ska också finnas två checkboxar. En "Lock x-value." och en 
// "Lock y-value". Dessa ska kunna låsa x- och y-värden från att
// uppdateras. D.v.s om man t.ex klickar i "Lock x-value" och sedan 
// ändrar värdet på slidern så ska knappens y-värde fortfarande uppdateras, 
// medan x-värdet uppdateras först när man klickar ur checkboxen igen.
//
// Förtydligande: Om man klickar i båda checkboxar så ska positionen 
// inte uppdateras alls när man ändrar värdet, förrän man klickar 
// ur checkboxarna: då "hoppar" labeln till sin nya position.

using System.Windows;
using System.Windows.Controls;

namespace _05_Gemensam_slider_för_position
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
            if(xLock.IsChecked == true && yLock.IsChecked == false)
            {
                Canvas.SetTop(positionLabel, valueSlider.Value);
            }

            if(xLock.IsChecked == false && yLock.IsChecked == true)
            {
                Canvas.SetLeft(positionLabel, valueSlider.Value);
            }

            if(xLock.IsChecked == false && yLock.IsChecked == false)
            {
                Canvas.SetLeft(positionLabel, valueSlider.Value);
                Canvas.SetTop(positionLabel, valueSlider.Value);
            }

            positionLabel.Content = $"x: {Canvas.GetLeft(positionLabel)}, y: {Canvas.GetTop(positionLabel)}";
        }


        private void xLock_Unchecked(object sender, RoutedEventArgs e)
        {
            Canvas.SetLeft(positionLabel, valueSlider.Value);
            positionLabel.Content = $"x: {Canvas.GetLeft(positionLabel)}, y: {Canvas.GetTop(positionLabel)}";
        }


        private void yLock_Unchecked(object sender, RoutedEventArgs e)
        {
            Canvas.SetTop(positionLabel, valueSlider.Value);
            positionLabel.Content = $"x: {Canvas.GetLeft(positionLabel)}, y: {Canvas.GetTop(positionLabel)}";
        }

    }
}