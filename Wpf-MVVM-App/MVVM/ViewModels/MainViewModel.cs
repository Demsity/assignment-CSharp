using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM_App.MVVM.Models;
using Wpf_MVVM_App.Services;

namespace Wpf_MVVM_App.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject currentViewModel;

        [ObservableProperty]
        private Contact selectedContact;

        [RelayCommand]
        private void ShowAddContactView()
        {
            CurrentViewModel= new AddContactViewModel();
        }

        [RelayCommand]
        private void ShowBookView()
        {
            CurrentViewModel = new BookViewModel();
        }

        [RelayCommand]
        private void ShowEditContactView()
        {
            CurrentViewModel = new EditContactViewModel();
        }

        [RelayCommand]
        private void RemoveContact()
        {
            SelectedContact = ContactService.SelectedContact;
            ContactService.RemoveContactFromList(SelectedContact);
        }

        /// <summary>
        /// MVVM Main Contstructor
        /// </summary>
        public MainViewModel()
        {
            CurrentViewModel = new BookViewModel();
        }

    }
}
