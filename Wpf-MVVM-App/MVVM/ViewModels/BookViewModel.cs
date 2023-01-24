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
        private FileService fileService;

        [ObservableProperty]
        private ObservableCollection<Contact> contactsList;

        [ObservableProperty]
        private Contact selectedContact;


        public BookViewModel()
        {
            fileService = new FileService();
            ContactsList = fileService.ContactsList;

            if (ContactsList.FirstOrDefault<Contact>() != null)
            {
                SelectedContact = (Contact)ContactsList.FirstOrDefault<Contact>();
            }
        }
    }
}
