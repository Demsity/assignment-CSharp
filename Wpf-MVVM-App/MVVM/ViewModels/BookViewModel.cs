using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using Wpf_MVVM_App.MVVM.Models;
using Wpf_MVVM_App.Services;

namespace Wpf_MVVM_App.MVVM.ViewModels
{
    public partial class BookViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Contact> contactsList = null!;

        [ObservableProperty]
        private Contact selectedContact = ContactService.SelectedContact;


        public BookViewModel()
        {
            ContactsList = ContactService.ContactList;


            if (ContactsList != null)
            {
                // Make the First Contact From The List The Selected Contact
                SelectedContact = ContactsList.FirstOrDefault()!;
                ContactService.SelectedContact = SelectedContact;
            }
        }
    }
}
