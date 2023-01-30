using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM_App.MVVM.Models;
using Wpf_MVVM_App.Services;

namespace Wpf_MVVM_App.MVVM.ViewModels;

public partial class AddContactViewModel : ObservableObject
{

	[ObservableProperty]
	private Contact newContact;

	public AddContactViewModel()
	{
		newContact= new Contact();
	}

	[RelayCommand]
	private void SaveNewContact()
	{

		ContactService.AddContactToList(NewContact);

		// Clear the Form
		NewContact = new Contact();

	}

	[RelayCommand]
	private void CancelAddContact()
	{
        // Clear the Form
        NewContact = new Contact();
    }

}
