using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM_App.MVVM.Models;

namespace Wpf_MVVM_App.Services;

public static partial class ContactService 
{
    private static FileService fileService = new FileService();

    public static ObservableCollection<Contact> ContactList;

    public static Contact SelectedContact = new Contact();

    static ContactService()
    {
        PopulateContactList();
    }

    public static void PopulateContactList()
    {
        try
        {
            ContactList = fileService.readContent();
        } catch
        {
            ContactList = new ObservableCollection<Contact>();
        }
    }

    public static void AddContactToList(Contact contact)
    {
        if(contact != null)
        {
            try
            {
                ContactList.Add(contact);
            }
            catch 
            {
                ContactList = new ObservableCollection<Contact>{ new Contact {
                FirstName= contact.FirstName,
                LastName= contact.LastName,
                Email= contact.Email,
                PhoneNumber= contact.PhoneNumber,
                StreetName= contact.StreetName,
                City= contact.City,
                PostalCode= contact.PostalCode,
                } };
            }
            
            fileService.storeContent(ContactList);
            PopulateContactList();
        }
    }

    public static Contact GetContactFromList(Contact contact)
    {
        return (Contact)ContactList.Where(x => x.Id == contact.Id);
    }


    public static void RemoveContactFromList(Contact contact)
    { 
        if(contact != null)
        {
            ContactList.Remove(contact);
            fileService.storeContent(ContactList);
            PopulateContactList();
        }
        
    }
}
