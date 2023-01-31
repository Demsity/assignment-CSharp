using Newtonsoft.Json;
using System.Collections.ObjectModel;
using Wpf_MVVM_App.MVVM.Models;
using Wpf_MVVM_App.Services;

namespace Wpf_MVVM_APP.Tests;

public class FileService_Test
{
    private string filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\WPFAPP_Tests.json";

    [Fact]
    public void Should_Create_a_Json_File_And_Delete_It()
    {
        FileService fileService = new FileService(filePath);
        ObservableCollection<Contact> content = new ObservableCollection<Contact>();
        content.Add(new Contact { FirstName = "Test", LastName = "Test" }); 

        fileService.storeContent(content);

        Assert.True(File.Exists(filePath));
        File.Delete(filePath);
    }
}