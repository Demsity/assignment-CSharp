using ConsoleApp.Models;

namespace ConsoleApp.Services;

internal class MenuService
{
    public static void Run ()
    {
        mainMenu();

    }

    private static void mainMenu () {
        Console.WriteLine("Välkommen till Adressboken");
        Console.WriteLine("1. Skapa en kontakt");
        Console.WriteLine("2. Visa alla kontakter");
        Console.WriteLine("3. Visa en specifik kontakt");
        Console.WriteLine("4. Ta bort en specifik kontakt");
        Console.Write("Välj ett av alternativen ovan: ");
        var options = Console.ReadLine();

        switch(options)
        {
            case "1": addContactPage(); break;
            case "2": showContactsPage(); break;
            case "3": showContactPage(); break;
            case "4": removeContactPage(); break;
            default:
                Console.WriteLine("Ogiltigt val!");
                break;
        }
    }

    private static void addContactPage()
    {
        IContact contact = new Contact();

        clearScreen();
        Console.WriteLine("Skapa en ny kontakt");
        Console.Write("Förnamn: ");
        contact.FirstName = Console.ReadLine();
        Console.Write("Efternamn: ");
        contact.LastName = Console.ReadLine();
        Console.Write("E-postadress: ");
        contact.Email = Console.ReadLine();
        Console.Write("Telefonnummer: ");
        contact.PhoneNumber = Console.ReadLine();
        Console.Write("PostNummer:  ");
        contact.PostalCode = Console.ReadLine();
        Console.Write("Stad: ");
        contact.City = Console.ReadLine();
        Console.Write("Adress: ");
        contact.StreetName = Console.ReadLine();


    }

    private static void showContactsPage()
    {
        throw new NotImplementedException();
    }

    private static void showContactPage()
    {
        throw new NotImplementedException();
    }

    private static void removeContactPage()
    {
        throw new NotImplementedException();
    }

    private static void clearScreen()
    {
        Console.Clear();
    }
}
