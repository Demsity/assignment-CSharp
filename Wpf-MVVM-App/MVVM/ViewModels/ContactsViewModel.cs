using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM_App.MVVM.Models;
using Wpf_MVVM_App.Services;

namespace Wpf_MVVM_App.MVVM.ViewModels
{
    public partial class ContactsViewModel : ObservableObject
    {
        private readonly FileService fileService;

        [ObservableProperty]
        private string text = "test text";

        [ObservableProperty]
        private ObservableCollection<Contact> contacts;

        public ContactsViewModel()
        {
            fileService = new FileService();
            contacts = fileService.ContactsList;
        }



    }
}
