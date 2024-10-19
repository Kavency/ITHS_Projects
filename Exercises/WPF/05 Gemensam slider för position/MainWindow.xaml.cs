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
    }
}