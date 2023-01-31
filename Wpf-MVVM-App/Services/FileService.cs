using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wpf_MVVM_App.MVVM.Models;

namespace Wpf_MVVM_App.Services
{
    public class FileService
    {
        private string filePath;

        public FileService()
        {
            filePath = @$"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\content.json";
        }

        // Overload for Testing
        public FileService(string path)
        {
            filePath = path;
        }

        public void storeContent(ObservableCollection<Contact> contactList)
        {

            try
            {
                using var sw = new StreamWriter(filePath);
                sw.WriteLine(JsonConvert.SerializeObject(contactList));
            }
            catch
            {
                throw new InvalidDataException("Failed to save data to json file");
            }


        }

        public ObservableCollection<Contact> readContent()
        {
            try
            {
                using var sr = new StreamReader(filePath);
                var item = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<ObservableCollection<Contact>>(item)!;
            }
            catch
            {
                throw new Exception("Failed to load data from json file");

            }

        }

    }
}
