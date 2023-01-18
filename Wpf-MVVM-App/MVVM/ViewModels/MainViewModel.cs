using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_MVVM_App.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableObject currentViewModel;

        /// <summary>
        /// MVVM Main Contstructor
        /// </summary>
        public MainViewModel()
        {
            CurrentViewModel = new ContactsViewModel();
        }
    }
}
