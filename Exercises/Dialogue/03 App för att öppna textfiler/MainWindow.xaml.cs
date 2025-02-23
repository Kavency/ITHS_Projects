// 3.App för att öppna och visa textfiler.
// Skapa en applikation där hela fönstret består av en 
// readonly TextBox. Programmet ska ha en meny med en 
// File->Open som visar en OpenFileDialog, och en 
// File->Exit som avslutar programmet.
//
// När användaren valt en fil i OpenFileDialog 
// så ska filen läsas in och visas i TextBoxen.

using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace _03_App_för_att_öppna_textfiler
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

        private void open_file_event(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new();
            dialog.ShowDialog();
            textFileTextBox.Text = File.ReadAllText(dialog.FileName);
        }

        private void exit_app_event(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Quit?", "Exit app", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                Environment.Exit(200);
            }
        }
    }
}