using ConsoleApp.Models;

namespace ConsoleApp.Services;

internal class FileService
{
    public void storeContent (object content, string filePath) { 
    
        try
        {
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(content);
        }
        catch
        {
            throw new InvalidDataException("Failed to save data to json file");
        }


    }

    public string readContent(string filePath)
    {
        try
        {
            using var sr = new StreamReader(filePath);
            return sr.ReadToEnd();
        }
        catch
        {
            throw new Exception("Failed to load data from json file");

        }

    }


}
