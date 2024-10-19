// 4.Text editor
// Uppdatera appen från uppgift 3 så man även kan editera och spara filer.
// Lägg även till scrollbars på din TextBox, om du inte redan har det.
// Visa filens namn i fönstrets Title-property; om det finns osparade 
// ändringar visa en * efter filnamnet. Om det är en ny text (ej inladdad 
// från fil) visa "Untitled Document" istället för filnamnet.
//
// Lägg till följande i menyn:
// File->New
// Om man har osparade ändringar, visa en dialogruta som frågar om man vill spara först:
//
// YES: Spara filen om den redan har ett filnamn, annars visa en SaveFileDialog.
// Först när filen är sparad, töm textboxen.
// NO: Töm textboxen(och sätt Title= "Untitled Document").
// CANCEL: Avbryt, och låt användaren fortsätta editera den osparade texten.
// File->Save
// Om det är en "Untitled Document", gör samma som File->Save As; annars spara 
// filen med det filnamn den redan har.
//
// File->Save As Visa en SaveFileDialog där det förvalda filnamnet i dialogboxen 
// är det namn som filen redan har. (Om det är en "Untitled Document", 
// visa "Untitled Document.txt" som förvalt filnamn).
//
// Lyssna på fönstrets Closing-event.
// Om det finns osparade ändringar visa en MessageBox och hantera på liknande 
// sätt som när man gör nytt dokument, men avsluta istället programmet.
//
// Grattis, du har gjort en text editor!
//
// Extra-uppgift: Lägg till en "Edit" meny med alternativ för Cut/Copy/Paste och 
// implementera funktionalitet för dessa.
//
//Extra-uppgift: Lägg till en <StatusBar> längst ner i appen, som visar vilken 
//rad och kolumn textmarkören befinner sig på, samt totalt antal tecken i filen.

using System.Windows;

namespace _04_Text_editor
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