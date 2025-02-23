// 6.Formulär för studenter
// Utgå från XAML-uppgift 8 ("Formulär för studenter"), 
// men ta bort "OK"-knappen. Lägg till funktionalitet så 
// att när man väljer en student i listan så visas den 
// studentens förnamn, efternamn och email i formuläret 
// till höger i fönstret; och om man uppdaterar något i 
// formuläret så uppdateras den studenten i listan.
//
// OBS! Email visas inte i listan, men behöver ändå lagras 
// så det nya värdet finns kvar när man växlar mellan 
// studenterna via listan.

using System.Windows;

namespace _06_Formulär_för_studenter
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