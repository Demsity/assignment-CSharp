using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM_App.Services;

namespace Wpf_MVVM_App.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject currentViewModel;


        [RelayCommand]
        private void showAddContactView()
        {
            CurrentViewModel= new AddContactViewModel();
        }

        [RelayCommand]
        private void showBookView()
        {
            CurrentViewModel = new BookViewModel();
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
