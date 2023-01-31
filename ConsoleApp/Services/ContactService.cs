using ConsoleApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services;

public class ContactService
{
    private readonly FileService fileService = new FileService();
    public List<Contact> ContactList = new();


    public List<Contact> PopulateContactsList(string filePath)
    {

        var itemsFromFile = JsonConvert.DeserializeObject<List<Contact>>(fileService.readContent(filePath));
        if (itemsFromFile != null)
        {
           return ContactList = itemsFromFile;
        } else
        {
            // if File dosent exsist, create it
            fileService.storeContent(JsonConvert.SerializeObject(ContactList), filePath);
            return null!;
        }
    }

    public void AddContactToList(Contact contact, string filePath)
    {
        ContactList.Add(contact);
        fileService.storeContent(JsonConvert.SerializeObject(ContactList), filePath);
        PopulateContactsList(filePath);
    }

    public void RemoveContactFromList(Contact contact, string filePath)
    {
        ContactList.Remove(contact);
        fileService.storeContent(JsonConvert.SerializeObject(ContactList), filePath);
        PopulateContactsList(filePath);
    }

}
