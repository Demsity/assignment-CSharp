using ConsoleApp.Models;
using Newtonsoft.Json;

namespace ConsoleApp.Services;

internal class MenuService
{
    private ContactService contactService = new ContactService();
    private List<Contact> contacts = new List<Contact>();

    public string FilePath { get; set; } = null!;
    public void Run ()
    {
        PopulateContactList();
        mainMenu();
    }

    private void mainMenu () {
        ClearScreen();
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
                ClearScreen();
                Console.WriteLine("Ogiltigt val!");
                ReturnToMainMenu();
                break;
        }
    }

    private void addContactPage()
    {
        Contact contact = new Contact();

        ClearScreen();
        Console.WriteLine("1. Skapa en ny kontakt:");
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

        contactService.AddContactToList(contact, FilePath);
        PopulateContactList();
        Console.WriteLine("Kontakten är Skapad!");
        ReturnToMainMenu();
        
    }

    private void ShowContactsPage()
    {

        ClearScreen();
        Console.WriteLine("2. Visa alla kontakter:");
        InsertLineBreak();
        foreach (Contact contact in contacts)
        {
            Console.WriteLine($"Förnamn: {contact.FirstName}");
            Console.WriteLine($"Efternamn: {contact.LastName}");
            Console.WriteLine($"E-postadrtess: {contact.Email}");
            Console.WriteLine($"Telefonummer: {contact.PhoneNumber}");
            Console.WriteLine($"Adress: {contact.FullAdress}");
            InsertLineBreak();
            
        }
        ReturnToMainMenu();
    }

    private void ShowContactPage()
    {
        ClearScreen();
        Console.WriteLine("3. Visa en specifik kontakt:");
        Console.Write("Sök efter en kontakt med namn (Skiftkänslig): ");
        var query = Console.ReadLine() ?? null!;
        InsertLineBreak();

        var contact = SearchForContact(query);
        if (contact != null)
        {
            Console.WriteLine($"Förnamn: {contact.FirstName}");
            Console.WriteLine($"Efternamn: {contact.LastName}");
            Console.WriteLine($"E-postadrtess: {contact.Email}");
            Console.WriteLine($"Telefonummer: {contact.PhoneNumber}");
            Console.WriteLine($"Adress: {contact.FullAdress}");
            ReturnToMainMenu();
        }


    }

    private void RemoveContactPage()
    {
        ClearScreen();
        Console.WriteLine("4. Ta bort en specifik kontakt");
        Console.Write("Sök efter en kontakt med namn (Skiftkänslig): ");
        var query = Console.ReadLine() ?? null!;
        InsertLineBreak();

        var contact = SearchForContact(query);
        if (contact != null)
        {
            Console.WriteLine($"Förnamn: {contact.FirstName}");
            Console.WriteLine($"Efternamn: {contact.LastName}");
            Console.WriteLine($"E-postadrtess: {contact.Email}");
            Console.WriteLine($"Telefonummer: {contact.PhoneNumber}");
            Console.WriteLine($"Adress: {contact.FullAdress}");
            InsertLineBreak();
            Console.Write("Vill du ta bort kontakten? ( y/n ): ");
            var answer = Console.ReadLine() ?? null!;
            
            switch(answer.ToLower()) {
                case "y":
                    InsertLineBreak();
                    contactService.RemoveContactFromList(contact, FilePath);
                    PopulateContactList();
                    Console.WriteLine("Kontakten har tagits bort!");
                    ReturnToMainMenu();
                    break;
                case "n":
                    InsertLineBreak();
                    Console.WriteLine("Kontakten har inte tagits bort");
                    ReturnToMainMenu();
                    break;
                default:
                    InsertLineBreak();
                    Console.WriteLine("Kontakten har inte tagits bort");
                    ReturnToMainMenu();
                    break;

            }
        }

    }



    private void PopulateContactList()
    {
        contacts = contactService.PopulateContactsList(FilePath);
    }


    private void ClearScreen()
    {
        Console.Clear();
    }

    private void ReturnToMainMenu ()
    {
        Console.WriteLine();
        Console.WriteLine("Tryck på valfri knapp för att återvända till menyn...");
        Console.ReadKey();
    }

    private void InsertLineBreak ()
    {
        Console.WriteLine();
    }

    private Contact SearchForContact (string query) 
    {
        Contact contact = new Contact();
        if (query != null)
        {
            contact = contacts.Find(x => x.FirstName == query || x.LastName == query)!;

            if (contact != null)
            {
                return contact;

            }
            else
            {
                ClearScreen();
                Console.WriteLine("Kontakten hittades inte");
                ReturnToMainMenu();
                return null!;

            }
        } else
        {
            return null!;
        }
    }
}
