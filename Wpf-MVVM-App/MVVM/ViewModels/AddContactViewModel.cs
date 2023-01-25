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
    private readonly FileService fileService;

	[ObservableProperty]
	private Contact newContact;

	[RelayCommand]
	private void saveNewContact()
	{
		NewContact.FirstName = "";
		NewContact.LastName = "";
		NewContact.Email = "";
		NewContact.PhoneNumber = "";
        NewContact.StreetName = "";
		NewContact.City = "";
		NewContact.PostalCode = "";

        if (true)
		{
			fileService.storeContent(NewContact);
		}
	}

	public AddContactViewModel()
	{
		fileService= new FileService();
	}

}
