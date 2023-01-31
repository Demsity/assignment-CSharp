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

    // A Static Global List Of Contacts
    public static ObservableCollection<Contact> ContactList;

    // A Static Global Variable For Assigning The Selected Contact
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
            // Needed to create file if it dosen´t exsists
            ContactList = new ObservableCollection<Contact>();
        }
    }

    public static void AddContactToList(Contact contact)
    {
        if(contact != null)
        {

            ContactList.Add(contact);
            fileService.storeContent(ContactList);
            PopulateContactList();
        }
    }

    public static void UpdateContactInList (Contact contact)
    {
        if(contact != null) 
        {
            Contact _contact = ContactList.FirstOrDefault(x => x.Id == contact.Id)!;
            if(_contact != null)
            {
                // Remove the old contact and add the updated one
                RemoveContactFromList(contact);
                AddContactToList(_contact);
            }
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
