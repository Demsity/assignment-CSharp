using ConsoleApp.Services;

var menu = new MenuService();
menu.FilePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";


while(true)
{
    menu.Run();
}
