using System.Windows;
using System.Windows.Media;

namespace _05_Färgblandare
{
    /// <summary>
    /// Interaction logic for ColourPickerWindow.xaml
    /// </summary>
    public partial class ColourPickerWindow : Window
    {
        public SolidColorBrush CurrentColour { get { return CurrentColour; } set { CurrentColour = value; } }

        Color newColour = new();
        
        public ColourPickerWindow()
        {
            InitializeComponent();
        }

        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            newColour.R = (byte)RedSlider.Value;
            ColourRect.Fill = new SolidColorBrush(newColour);
        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            newColour.G = (byte)GreenSlider.Value;
            ColourRect.Fill = new SolidColorBrush(newColour);
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            newColour.B = (byte)BlueSlider.Value;
            ColourRect.Fill = new SolidColorBrush(newColour);
        }

        private void AlphaSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            newColour.A = (byte)AlphaSlider.Value;
            ColourRect.Fill = new SolidColorBrush(newColour);
        }
    }
}
