using ConsoleApp.Models;
using Newtonsoft.Json;

namespace ConsoleApp.Services;

internal class MenuService
{
    private List<Contact> contacts = new List<Contact>();
    private FileService fileService = new();

    public string FilePath { get; set; } = null!;
    public void Run ()
    {
        PopulateContactsList();
        mainMenu();
    }

    private void mainMenu () {
        clearScreen();
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
            case "2": ShowContactsPage(); break;
            case "3": ShowContactPage(); break;
            case "4": RemoveContactPage(); break;
            default:
                clearScreen();
                Console.WriteLine("Ogiltigt val!");
                break;
        }
    }

    private void addContactPage()
    {
        Contact contact = new Contact();

        clearScreen();
        Console.WriteLine("Skapa en ny kontakt");
        Console.Write("Förnamn: ");
        contact.FirstName = Console.ReadLine() ?? null!;
        Console.Write("Efternamn: ");
        contact.LastName = Console.ReadLine() ?? null!;
        Console.Write("E-postadress: ");
        contact.Email = Console.ReadLine() ?? null!;
        Console.Write("Telefonnummer: ");
        contact.PhoneNumber = Console.ReadLine() ?? null!;
        Console.Write("PostNummer:  ");
        contact.PostalCode = Console.ReadLine() ?? null!;
        Console.Write("Stad: ");
        contact.City = Console.ReadLine() ?? null!;
        Console.Write("Adress: ");
        contact.StreetName = Console.ReadLine() ?? null!;

        contacts.Add(contact);
        fileService.storeContent(JsonConvert.SerializeObject(contacts), FilePath);
        clearScreen();
    }

    private void ShowContactsPage()
    {

        clearScreen();
        foreach(Contact contact in contacts)
        {
            Console.WriteLine(contact.FirstName);
            Console.WriteLine(contact.LastName);
            Console.WriteLine(contact.Email);
            Console.WriteLine(contact.PhoneNumber);
            Console.WriteLine(contact.StreetName);
            Console.WriteLine(contact.PostalCode);
            Console.WriteLine(contact.City);
            Console.WriteLine();
            
        }
        Console.WriteLine("Press any key to return to main menu...");
        Console.ReadKey();
        
    }

    private void ShowContactPage()
    {
        throw new NotImplementedException();
    }

    private void RemoveContactPage()
    {
        throw new NotImplementedException();
    }

    private void PopulateContactsList ()
    {

        var itemsFromFile= JsonConvert.DeserializeObject<List<Contact>>(fileService.readContent(FilePath));
        if (itemsFromFile != null) {
            contacts = itemsFromFile;
        }
    }

    private void clearScreen()
    {
        Console.Clear();
    }
}
