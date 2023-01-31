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

public partial class EditContactViewModel : ObservableObject
{
	[ObservableProperty]
	private Contact oldContact;


	[RelayCommand]
	private void SaveContact()
	{
		ContactService.UpdateContactInList(OldContact);
		//Clear Form
		OldContact = new Contact();
	}

	[RelayCommand]
	private void CancelEditContact()
	{
        //Clear Form
        OldContact = new Contact();
    }

	public EditContactViewModel()
	{
		oldContact = ContactService.SelectedContact;
	}
}
