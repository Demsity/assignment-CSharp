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
    }
}
